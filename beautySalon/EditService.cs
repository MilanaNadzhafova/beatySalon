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
        public EditService(int ID)
        {
            InitializeComponent();
            IDServ = ID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                picService.Image = new Bitmap(Path.Combine(Application.StartupPath, service.MainImagePath.Trim()));

            }
        }

        public void AddImg()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "File JPG|*.jpg|File png|*.png|All file |*.*";
                if (file.ShowDialog() == DialogResult.OK)
                {

                    picService.Image = new Bitmap(file.FileName);
                    CheckPic = true;
                    NamePhoto = file.SafeFileName;

                }
            }

        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            AddImg();
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

                    string path = "";
                    if (picService.Image != null && CheckPic)
                    {
                        Random rand = new Random();
                        NamePhoto = rand.Next(10000).ToString() + NamePhoto;
                        path = Path.Combine(Application.StartupPath, "Услуги салона красоты", NamePhoto);
                        picService.Image.Save(path);

                    }
                    service.Title = Title;
                    service.Cost = Cost;
                    service.DurationInSeconds = Convert.ToInt32(Duration) * 60;
                    service.Description = Desc;
                    service.Discount = Convert.ToDouble(Discount) / 100;
                    if (CheckPic && !string.IsNullOrEmpty(NamePhoto))
                    {
                        service.MainImagePath = $"Услуги салона красоты\\{NamePhoto}";
                    }
                    db.SaveChanges();
                    MessageBox.Show("Информация успешно изменена!");
                    ClientForm.listOfServices.Close();
                    new ListOfServices(true).Show();
                    this.Close();


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
