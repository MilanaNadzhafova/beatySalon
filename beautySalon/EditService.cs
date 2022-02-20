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
    public partial class EditService : Form
    {
        beatySalonEntities db = new beatySalonEntities();
        int IDServ;
        Service service = new Service();
        bool CheckPic;
        string NamePhoto;
        Random rand = new Random();
        List<TemporaryData> PictureList = new List<TemporaryData>();
        List<ServicePhoto> OldData;
        public EditService(int ID)
        {
            InitializeComponent();
            IDServ = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDataInList()
        {
            OldData = db.ServicePhoto.Where(p => p.ServiceID == IDServ).ToList();
            foreach (var item in OldData)
            {
                string str = item.PhotoPath;
                if (str.Contains("Услуги салона красоты"))
                {
                    var index = str.IndexOf("\\") + 1;
                    str = str.Substring(index);
                }
                string path = Path.Combine(Application.StartupPath, item.PhotoPath);
                Image image;
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    image = Image.FromStream(stream);
                    stream.Dispose();
                };
                image = new Bitmap(image, new Size(100, 100));
                PictureList.Add(
                    new TemporaryData
                    {
                        NamePicture = str,
                        Picture = image
                    });
            }
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            service = db.Service.Where(p => p.ID == IDServ).FirstOrDefault();
            if (!string.IsNullOrEmpty(service.Description)) txtDescription.Text = service.Description;
            else txtDescription.Text = "";
            txtDiscount.Value = Convert.ToDecimal(service.Discount) * 100;
            txtDuration.Value = Convert.ToDecimal(service.DurationInSeconds) / 60;
            txtName.Text = service.Title;
            txtPrice.Text = service.Cost.ToString();
            if (!string.IsNullOrEmpty(service.MainImagePath))
            {
                var path = Path.Combine(Application.StartupPath, service.MainImagePath.Trim());
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    picService.Image = Image.FromStream(stream);
                    stream.Dispose();
                }

            }
            LoadDataInList();
            UpdateTable();
        }

      

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
        }

        private void btnChangeService_Click(object sender, EventArgs e)
        {
            string Title = txtName.Text, Desc = txtDescription.Text;
            decimal Duration = txtDuration.Value, Discount = txtDiscount.Value;
            decimal Cost;
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                if (decimal.TryParse(txtPrice.Text, out Cost) && Cost > 0)
                {

                    service.Title = Title;
                    service.Cost = Cost;
                    service.DurationInSeconds = Convert.ToInt32(Duration) * 60;
                    service.Description = Desc;
                    service.Discount = Convert.ToDouble(Discount) / 100;
                    if (CheckPic && !string.IsNullOrEmpty(NamePhoto))
                    {
                        service.MainImagePath = $"Услуги салона красоты\\{NamePhoto}";
                    }
                    foreach (var item in OldData)
                    {
                        string path = Path.Combine(Application.StartupPath, item.PhotoPath);
                        FileInfo fileInfo = new FileInfo(path);
                        if (PictureList.Count > 0)
                        {
                            if (fileInfo.Exists) fileInfo.Delete();
                            db.ServicePhoto.Remove(item);
                        }
                        else
                        {
                            if (service.MainImagePath == item.PhotoPath) continue;
                            if (fileInfo.Exists) fileInfo.Delete();
                            db.ServicePhoto.Remove(item);
                        }
                    }

                    foreach (TemporaryData item in PictureList)
                    {
                        ServicePhoto servicePhoto = new ServicePhoto
                        {
                            ServiceID = service.ID,
                            PhotoPath = "Услуги салона красоты\\" + item.NamePicture
                        };
                        string path = Path.Combine(Application.StartupPath, servicePhoto.PhotoPath);
                        FileInfo fi = new FileInfo(path);
                        if (!fi.Exists)
                            item.Picture.Save(path);
                        db.ServicePhoto.Add(servicePhoto);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Информация об услуге успешно обновлена!");
                    ClientForm.listOfServices.Close();
                    new ListOfServices(true).Show();
                    this.Close();
                }
                else MessageBox.Show("Введите корректное значение стоимости! \n В формате 123,34 или 123");


            }
            else MessageBox.Show("Заполните все поля!");
        }
        public TemporaryData GetDataTemporary()
        {
            var StrName = tablePicture.SelectedRows[0].Cells["NamePicture"].Value.ToString();
            var item = PictureList.Find(p => p.NamePicture == StrName);
            return item;
        }
        public void AddTimeImg()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    Size size = new Size(100, 100);
                    Image img;
                    using (FileStream stream = new FileStream(file.FileName, FileMode.Open))
                    {
                        img = Image.FromStream(stream);
                        stream.Dispose();
                    }
                    img = new Bitmap(img, size);

                    TemporaryData temporaryData = new TemporaryData
                    {
                        NamePicture = rand.Next(10000) + file.SafeFileName,
                        Picture = img
                    };
                    foreach (var item in PictureList)
                    {
                        if (item.NamePicture == temporaryData.NamePicture)
                        {
                            MessageBox.Show("Картинка с таким именем уже существует!");
                            return;
                        }
                    }
                    PictureList.Add(temporaryData);
                }
            }
        }
        private void btnAddMorePhoto_Click(object sender, EventArgs e)
        {
            
            AddTimeImg();
            UpdateTable();
        }
        public void UpdateTable()
        {
            tablePicture.DataSource = PictureList.ToList();
            tablePicture.Columns["NamePicture"].Visible = false;
            tablePicture.Columns["Picture"].HeaderText = "Картинка";
        }
        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            if (tablePicture.SelectedRows.Count > 0)
            {
                PictureList.Remove(GetDataTemporary());
                UpdateTable();
            }
            else MessageBox.Show("Фотография не выбрана!");
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            if (tablePicture.SelectedRows.Count > 0)
            {
                var item = GetDataTemporary();
                picService.Image = item.Picture;
                NamePhoto = item.NamePicture;
                CheckPic = true;
            }
            else MessageBox.Show("Фотография не выбрана!");
        }
    }
}
