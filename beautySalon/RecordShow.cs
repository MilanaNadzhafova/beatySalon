using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beautySalon
{
    public partial class RecordShow : Form
    {
        beatySalonEntities db = new beatySalonEntities();
        public RecordShow()
        {
            InitializeComponent();
        }
        public void UpdateTable()
        {
            tableRecord.Rows.Clear();
            var list = from cls in db.ClientService
                       join cl in db.Client on cls.ClientID equals cl.ID
                       join ser in db.Service on cls.ServiceID equals ser.ID
                       where cls.StartTime >= DateTime.Now && cls.StartTime <= DbFunctions.AddDays(DateTime.Now, 1)
                       orderby cls.StartTime
                       select new
                       {
                           id = cls.ID,
                           servname = ser.Title,
                           firstname = cl.FirstName,
                           lastname = cl.LastName,
                           middlename = cl.Patronymic,
                           date = cls.StartTime,
                           stay = "",
                           email = cl.Email,
                           phone = cl.Phone,
                       };
           
            WriteTable(list);
            ColorizeTable(list);

        }

        //перебор анонимного листа с помощью динамического типа данных IQueryable<dynamic>
        public void ColorizeTable(IQueryable<dynamic> list)
        {
            foreach (var item in list)
            {
                TimeSpan time = item.date - DateTime.Now;
                if (time.Hours < 1)
                {
                    foreach (DataGridViewRow row in tableRecord.Rows)
                    {
                        if (item.id == Convert.ToInt32(row.Cells["id"].Value))
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 128, 114);
                    }
                }
            }
        }
        public void WriteTable(IQueryable<dynamic> list)
        {
            foreach (var item in list)
            {
                var date = item.date;
                TimeSpan TimeRemaining = date - DateTime.Now;
                var stay = TimeRemaining.Hours + " ч. " + TimeRemaining.Minutes + " мин.";
                tableRecord.Rows.Add(item.id, item.servname, item.firstname, item.lastname, item.middlename, item.date, stay, item.email, item.phone);
            }
        }
        private void RecordShow_Load(object sender, EventArgs e)
        {
           
            Timer.Enabled = true;
            Timer.Start();
            tableRecord.Columns.Add("id", "ID");
            tableRecord.Columns.Add("servname", "Наименование");
            tableRecord.Columns.Add("firstname", "Имя");
            tableRecord.Columns.Add("lastname", "Фамилия");
            tableRecord.Columns.Add("middlename", "Отчество");
            tableRecord.Columns.Add("date", "Дата");
            tableRecord.Columns.Add("stay", "Осталось");
            tableRecord.Columns.Add("email", "Email");
            tableRecord.Columns.Add("phone", "Телефон");
            tableRecord.Columns["id"].Visible = false;
            UpdateTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
