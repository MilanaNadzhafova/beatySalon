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
        string NamePhoto = null;
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

        public void AddImage()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {

                    picService.Image = new Bitmap(file.FileName);
                    NamePhoto = file.SafeFileName;
                    
                }
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            AddImage();
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
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                if (decimal.TryParse(txtPrice.Text, out Cost) && Cost>0)
                {
                    if (!db.Service.Any(p => p.Title == Title))
                    {
                        string path = "";
                        if (picService.Image != null)
                        {
                            Random rand = new Random();
                            NamePhoto = rand.Next(10000).ToString() + NamePhoto;
                            path = Path.Combine(Application.StartupPath, "Услуги салона красоты", NamePhoto);
                            picService.Image.Save(path);

                        }
                        Service service = new Service
                        {
                            Title = Title,
                            Cost = Cost,
                            DurationInSeconds = Convert.ToInt32(Duration)*60,
                            Description = Desc,
                            Discount = Convert.ToDouble(Discount)/100,
                            MainImagePath = $"Услуги салона красоты\\{NamePhoto}"
                        };
                        db.Service.Add(service);
                        db.SaveChanges();
                        MessageBox.Show("Услуга успешно добавлена!");
                        this.Close();
                        ClientForm.listOfServices.UpdateTable();
                    }
                    else MessageBox.Show("Такая услуга уже существует");
                }
                else
                {
                    MessageBox.Show("Введите корректное значение стоимости!");
                }
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля!");
            }
        }
    }
}
