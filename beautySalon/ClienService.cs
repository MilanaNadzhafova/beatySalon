using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beautySalon
{
    public partial class ClienService : Form
    {
        int IdService;
        DateTime date;
        Service service = new Service();
        beatySalonEntities db = new beatySalonEntities();
        public ClienService(int SerId)
        {
            InitializeComponent();
            IdService = SerId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadClients()
        {
            tableClient.DataSource = db.Client.ToList();
            tableClient.Columns["Birthday"].Visible = false;
            tableClient.Columns["RegistrationDate"].Visible = false;
            tableClient.Columns["Email"].Visible = false;
            tableClient.Columns["Phone"].Visible = false;
            tableClient.Columns["GenderCode"].Visible = false;
            tableClient.Columns["PhotoPath"].Visible = false;
            tableClient.Columns["Gender"].Visible = false;
            tableClient.Columns["ClientService"].Visible = false;
            tableClient.Columns["Tag"].Visible = false;
            tableClient.Columns["LastName"].HeaderText = "Фамилия";
            tableClient.Columns["FirstName"].HeaderText = "Имя";
            tableClient.Columns["Patronymic"].HeaderText = "Отчество";
        }

        private void ClienService_Load(object sender, EventArgs e)
        {
            service = db.Service.Where(p => p.ID == IdService).FirstOrDefault();
            LoadClients();
            lblServiceName.Text = service.Title;
            lblServiceDuration.Text = (service.DurationInSeconds / 60).ToString() + " мин.";
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddClientService_Click(object sender, EventArgs e)
        {
            if (!ValidateTime())
            {
                MessageBox.Show("Введите корректное время!");
                return;
            }
            if (!string.IsNullOrEmpty(txtTimeEnd.Text))
            {
                int ClientId = Convert.ToInt32(tableClient.SelectedRows[0].Cells["ID"].Value);
                var client = db.Client.Where(p => p.ID == ClientId).FirstOrDefault();
                ClientService clienService = new ClientService
                {
                    ClientID = ClientId,
                    ServiceID = service.ID,
                    StartTime = date,
                };
                db.ClientService.Add(clienService);
                db.SaveChanges();
                MessageBox.Show("Запись добавлена!");
                this.Close();
                
            }
            else
                MessageBox.Show("Введите время начала оказания услуги!");

        }

        private void txtTimeStart_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public bool ValidateTime()
        {
            Regex regex = new Regex(@"^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$");
            if (regex.IsMatch(txtTimeStart.Text))
            {
                return true;
            }
            else return false;
        }

        private void txtTimeStart_TextChanged(object sender, EventArgs e)
        {


            //var ArrStr = txtTimeStart.Text.Split(':');
            //if (!(Convert.ToInt32(ArrStr[0]) <= 23) && !(Convert.ToInt32(ArrStr[1]) <= 59))
            //{
            //    MessageBox.Show("Введите корректное время!");
            //}
        }

        private void txtTimeStart_Leave(object sender, EventArgs e)
        {
            if (!ValidateTime()) MessageBox.Show("Введите корректную дату и время начала!");
            else
            {
                var ArrStr = txtTimeStart.Text.Split(':');
                date = new DateTime(dateService.Value.Year, dateService.Value.Month, dateService.Value.Day, Convert.ToInt32(ArrStr[0]), Convert.ToInt32(ArrStr[1]), 0);
                if (date < DateTime.Now)
                {
                    MessageBox.Show("Введите корректную дату и время начала!");
                    return;
                }
                var d = date.AddMinutes(service.DurationInSeconds / 60);
                if (d.Hour < 10)
                {
                    if (d.Minute < 10)
                        txtTimeEnd.Text = "0" + d.Hour + ":" + "0" + d.Minute;
                    else
                        txtTimeEnd.Text = "0" + d.Hour + ":" + d.Minute;
                }
                else
                {
                    if (d.Minute < 10)
                        txtTimeEnd.Text = d.Hour + ":" + "0" + d.Minute;
                    else
                        txtTimeEnd.Text = d.Hour + ":" + d.Minute;
                }

            }
        }
    }
}

