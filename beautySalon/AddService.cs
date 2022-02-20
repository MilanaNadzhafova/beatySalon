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
    public partial class AddService : Form
    {
        beatySalonEntities db = new beatySalonEntities();
        Random rand = new Random();
        string NamePhoto = null;
        DataGridViewImageColumn imgColumn = new DataGridViewImageColumn { Name = "img" };
        List<TemporaryData> PictureList = new List<TemporaryData>();
        public AddService()
        {
            InitializeComponent();
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string AddImage()
        {
            NamePhoto = null;
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {

                    picService.Image = new Bitmap(file.FileName);
                    NamePhoto = file.SafeFileName;

                }
            }
            return NamePhoto;
        }

        public void AddTimeImg()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    picService.Image = new Bitmap(file.FileName);
                    NamePhoto = file.SafeFileName;

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

        //public void AddImgInDb()
        //{
        //    TimeNamePhoto = rand.Next(10000) + TimeNamePhoto;
        //    string path = Path.Combine(Application.StartupPath, "Услуги салона красоты", TimeNamePhoto);
        //    TimeImage.Save(path);
        //    path = "Услуги салона красоты\\" + TimeNamePhoto;

        //}


        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            if (tablePicture.SelectedRows.Count > 0)
            {
                var item = GetDataTemporary();
                picService.Image = item.Picture;

                NamePhoto = item.NamePicture;
            }
            else MessageBox.Show("Фотография не выбрана!");
        }
        public string getFileExtension(string fileName) // Получение типа фотографии
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            string Title = txtName.Text, Desc = txtDescription.Text;
            decimal Duration = txtDuration.Value, Discount = txtDiscount.Value;
            decimal Cost;
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(NamePhoto))
            {
                if (decimal.TryParse(txtPrice.Text, out Cost) && Cost > 0)
                {
                    if (!db.Service.Any(p => p.Title == Title))
                    {
                        Service service = new Service
                        {
                            Title = Title,
                            Cost = Cost,
                            DurationInSeconds = Convert.ToInt32(Duration) * 60,
                            Description = Desc,
                            Discount = Convert.ToDouble(Discount) / 100,
                            MainImagePath = $"Услуги салона красоты\\{NamePhoto}"
                        };
                        db.Service.Add(service);
                        foreach (TemporaryData item in PictureList)
                        {
                            ServicePhoto servicePhoto = new ServicePhoto
                            {
                                ServiceID = service.ID,
                                PhotoPath = "Услуги салона красоты\\" + item.NamePicture
                            };
                            string path = Path.Combine(Application.StartupPath, servicePhoto.PhotoPath);
                            item.Picture.Save(path);
                            db.ServicePhoto.Add(servicePhoto);
                        }
                        db.SaveChanges();
                        MessageBox.Show("Услуга успешно создана!");
                        this.Close();
                        ClientForm.listOfServices.UpdateTable();
                    }
                    else MessageBox.Show("Услуга с таким наименованием уже существует!");
                }
                else MessageBox.Show("Введите корректное значение стоимости! \n В формате 123,34 или 123");


            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void btnAddMorePhoto_Click(object sender, EventArgs e)
        {
            AddTimeImg();
            UpdateTable();
        }

        private void AddService_Load(object sender, EventArgs e)
        {
        }



        public void UpdateTable()
        {
            tablePicture.DataSource = PictureList.ToList();
            tablePicture.Columns["NamePicture"].Visible = false;
            tablePicture.Columns["Picture"].HeaderText = "Картинка";
        }
        //получение элементов листа из строка датагрид
        public TemporaryData GetDataTemporary()
        {
            var StrName = tablePicture.SelectedRows[0].Cells["NamePicture"].Value.ToString();
            var item = PictureList.Find(p => p.NamePicture == StrName);
            return item;
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
    }
}
