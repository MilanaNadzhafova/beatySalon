using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beautySalon
{
    public partial class ListOfServices : Form
    {
        int TotalPages;
        bool CheckAdmin;
        int CurrentRowCount;
        DataGridViewImageColumn ImgColumn = new DataGridViewImageColumn { Name = "img" };
        beatySalonEntities db = new beatySalonEntities();
        public ListOfServices(bool admin)
        {
            InitializeComponent();
            ClientForm.listOfServices = this;
            CheckAdmin = admin;
        }

        //печатаем сколько записей выведено
        public string PrintPages()
        {
            return CurrentRowCount.ToString() + " из " + TotalPages.ToString() + " записей";
        }

        //преобразуем поля длительность и скидка
        public List<Service> ConfigureList(List<Service> list)
        {
            List<Service> new_list = new List<Service>();
            foreach (Service item in list)
            {
                Service el = new Service
                {
                    ID = item.ID,
                    Title = item.Title,
                    Cost = item.Cost,
                    DurationInSeconds = item.DurationInSeconds / 60,
                    Discount = item.Discount * 100,
                    Description = item.Description,
                    MainImagePath = item.MainImagePath,
                };
                new_list.Add(el);
            }
            return new_list;
        }

        private void ListOfServices_Load(object sender, EventArgs e)
        {
            if (!CheckAdmin)
            {
                panelButton.Visible = false;
            }
            tableService.Columns.Add(ImgColumn);
            try
            {
                UpdateTable();
            }
            catch { }

        }
        // вывод картинок в датагрид
        public void AddImg(List<Bitmap> list)
        {
            try
            {
                int i = 0;
                foreach (DataGridViewRow item in tableService.Rows)
                {
                   // await Task.Run(() =>
                   //tableService.Invoke((MethodInvoker)(() =>
                   //{

                       ImgColumn.Image = list[i];
                       item.Cells["img"].Value = ImgColumn.Image;
                       i++;
                   //}))
                   //);
                }

            }
            catch { }

        }

        //закарашиваем уветом записи со скидкой
        public void ColorizeTable()
        {
            foreach (DataGridViewRow item in tableService.Rows)
            {
                if (Convert.ToInt32(item.Cells["Discount"].Value) > 0)
                    item.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        //считаем новую цену со скидкой и записываем
        public List<Service> WriteDiscountCell(List<Service> list)
        {
            List<Service> new_list = new List<Service>();
            foreach (Service item in list)
            {
                double Dicsount = Convert.ToDouble(item.Discount) / 100.0;
                if (Dicsount > 0)
                {
                    var OldPrice = Convert.ToDouble(item.Cost);
                    item.NewPrice = OldPrice - (OldPrice * Dicsount);
                }
                new_list.Add(item);
            }
            return new_list;
        }

        //получаем путь ко всем картинкам
        public List<string> AddImgPath()
        {
            List<string> arr = new List<string>();
            foreach (var item in db.Service.ToList())
            {
                string path = Path.Combine(Application.StartupPath, item.MainImagePath.Trim());
                arr.Add(path);
            }
            return arr;
        }

        //заполнение личта картинками с помощью  пути из предыдущего метода
        public List<Bitmap> AddImgToList(List<string> ArrPath)
        {
            List<Bitmap> list = new List<Bitmap>();
            int i = 0;
            foreach (DataGridViewRow item in tableService.Rows)
            {
                Image img;
                using (FileStream file = new FileStream(ArrPath[i], FileMode.Open))
                {
                    img = Image.FromStream(file);
                    file.Dispose();
                }
                Size size = new Size(40, 40);
                list.Add(new Bitmap(img, size));
                i++;
            }
            return list;
        }

        //объявляем порядок вывода колонок
        public void DisplayCells()
        {
            tableService.Columns["ID"].Visible = false;
            tableService.Columns["MainImagePath"].Visible = false;
            tableService.Columns["ClientService"].Visible = false;
            tableService.Columns["ServicePhoto"].Visible = false;
            tableService.Columns["Description"].Visible = false;
            tableService.Columns["Title"].HeaderText = "Наименование";
            tableService.Columns["Cost"].HeaderText = "Цена";
            tableService.Columns["NewPrice"].HeaderText = "Новая цена";
            tableService.Columns["DurationInSeconds"].HeaderText = "Длительность мин.";
            tableService.Columns["Discount"].HeaderText = "Скидка, %";
            tableService.Columns["img"].HeaderText = "Картинка";
            tableService.Columns["Title"].DisplayIndex = 0;
            tableService.Columns["Cost"].DisplayIndex = 1;
            tableService.Columns["NewPrice"].DisplayIndex = 2;
            tableService.Columns["DurationInSeconds"].DisplayIndex = 3;
            tableService.Columns["Discount"].DisplayIndex = 4;
            tableService.Columns["img"].DisplayIndex = 5;
        }


        //Фильтрация
        public List<Service> FilterList(List<Service> list)
        {
            List<Service> new_list = new List<Service>();
            if (cmbDiscountFiltr.SelectedIndex == 1)
            {
                new_list = list.Where(p => p.Discount >= 0 && p.Discount < 0.05).ToList();
            }
            else if (cmbDiscountFiltr.SelectedIndex == 2)
            {
                new_list = list.Where(p => p.Discount >= 0.5 && p.Discount < 0.15).ToList();
            }
            else if (cmbDiscountFiltr.SelectedIndex == 3)
            {
                new_list = list.Where(p => p.Discount >= 0.15 && p.Discount < 0.3).ToList();
            }
            else if (cmbDiscountFiltr.SelectedIndex == 4)
            {
                new_list = list.Where(p => p.Discount >= 0.3 && p.Discount < 0.7).ToList();
            }
            else if (cmbDiscountFiltr.SelectedIndex == 5)
            {
                new_list = list.Where(p => p.Discount >= 0.7 && p.Discount < 1).ToList();
            }
            else return list;

            return new_list;
        }

        //Поиск
        public List<Service> SearchList(List<Service> list, string SearchStr)
        {
            List<Service> new_list = new List<Service>();

            foreach(Service item in list)
            {
                try
                {
                    bool check = false;
                    if(!string.IsNullOrEmpty(item.Title))
                    {
                        if (item.Title.Contains(SearchStr))
                            check = true;
                    }
                    if (!string.IsNullOrEmpty(item.Description))
                    {
                        if (item.Description.Contains(SearchStr))
                            check = true;
                    }
                    if (check) new_list.Add(item);
                }
                catch { }
                
            }
            return new_list;
        }


        public void UpdateTable()
        {
            //cmbPriceSort.SelectedIndex = cmbPriceSort.SelectedIndex == -1 ? 0 : cmbPriceSort.SelectedIndex;
            var list = db.Service.ToList();
            TotalPages = list.Count();
            list = SearchList(list, txtSearch.Text);
            list = FilterList(list);
            if (cmbPriceSort.SelectedIndex == 1)
            {
                list = list.OrderBy(p => p.Cost).ToList();
            }
            else if (cmbPriceSort.SelectedIndex == 2)
            {
                list = list.OrderByDescending(p => p.Cost).ToList();
            }
            var ListService = ConfigureList(list);
            ListService = WriteDiscountCell(ListService);
            tableService.DataSource = ListService;
            
            var ListImg = AddImgToList(AddImgPath());
            CurrentRowCount = tableService.RowCount;
            lblPages.Text = PrintPages();
            DisplayCells();
            ColorizeTable();
            AddImg(ListImg);
        }
        private void panelButton_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void cmbPriceSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateTable();
            }
            catch { }
        }

        private void cmbDiscountFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateTable();
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateTable();
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddService().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new EditService(Convert.ToInt32(tableService.SelectedRows[0].Cells["ID"].Value)).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить услугу?", "Удаление", MessageBoxButtons.YesNo);
            int IdService = Convert.ToInt32(tableService.SelectedRows[0].Cells["ID"].Value);
            if(!db.ClientService.Any(p => p.ServiceID == IdService))
            {
                var service = db.Service.Where(p => p.ID == IdService).FirstOrDefault();
                foreach (ServicePhoto item in db.ServicePhoto.Where(p => p.ServiceID == IdService).ToList())
                    db.ServicePhoto.Remove(item);
                db.Service.Remove(service);
                db.SaveChanges();
                ClientForm.listOfServices.UpdateTable();
                MessageBox.Show("Запись удалена!");
            }
            else
            {
                MessageBox.Show("Невохмможно выполнить удаление! На эту услушу есть запись!");

            }
        }

        private void btnRecordClient_Click(object sender, EventArgs e)
        {
            new ClienService(Convert.ToInt32(tableService.SelectedRows[0].Cells["ID"].Value)).ShowDialog();
        }

        private void btnComingRecorf_Click(object sender, EventArgs e)
        {
            new RecordShow().ShowDialog();
        }
    }
}
