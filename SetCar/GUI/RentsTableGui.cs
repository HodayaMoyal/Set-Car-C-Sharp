using SetCar.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetCar.GUI
{
    public partial class RentsTableGui : Form
    {
        string idCustomer = "";
        string idEmployee = "";
        RentsTable rentsTable;
        Rents rents;
        Status status;
        List<Rents> rentsL;
        public RentsTableGui()
        {
            InitializeComponent();
           // rents = new Rents();
            rentsTable = new RentsTable();
        }

        //ממלא את הטבלה
        public void refresh()
        {
            rentsTable = new RentsTable();
            dgvRents.DataSource = rentsL.Select(x => new { x.RentCode, x.Carid, x.CheckIn, x.CheckOut, x.CustomerId, x.EmployeeId, x.NameEmployee, x.NameCustomer, x.RentSum, x.TotalDays }).ToList();
        }

        //בוחר את ההזמנה הרצויה
        private void chooseRents(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvRents.SelectedRows[0].Cells[0].Value);
            rents = rentsTable.GetList().Find(x => x.RentCode == id);
        }
        //הוספה
        private void addRents_Click(object sender, EventArgs e)
        {
            RentsGUI rentsGui = new RentsGUI();
            rentsGui.Show();
            refresh();
        }

        //הצגת פרטי הזמנה
        private void detailsRents_Click(object sender, EventArgs e)
        {
            if (rents == null)
                MessageBox.Show(" בחר הזמנה");
            else
            {
                RentsGUI rentsGUI = new RentsGUI(rents, Status.details);
                rentsGUI.ShowDialog();
                refresh();
            }
        }

        private void dgvRents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //בדיקה האם נכנס כמנהל או כלקוח
        private void RentsTableGui_Load_1(object sender, EventArgs e)
        {
            rentsL = new List<Rents>();
            if (Properties.Settings.Default.User == "customers")
            {
                addRents.Visible = false;
                idCustomer= Properties.Settings.Default.Id;
                DataTable dt = rentsTable.GetDisplayTable("select * from rents where customerid=" + Properties.Settings.Default.Id);
                foreach (DataRow item in dt.Rows)
                {
                    rentsL.Add(new Rents(item));
                }
            }
         else   if (Properties.Settings.Default.User == "mananger")
            {
                addRents.Visible = false;
                idEmployee = Properties.Settings.Default.Id;
                rentsL = rentsL.FindAll(a => a.EmployeeId.Trim() == idEmployee.Trim());
            }
            else
            {
                rentsL = rentsTable.GetList();
            }
            refresh();
        }

        //חיפוש הזמנה לפי מספר הזמנה 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvRents.DataSource = rentsL.Where(a => a.RentCode.ToString().Contains(textBox1.Text)).Select(x => new { x.RentCode, x.Carid, x.CheckIn, x.CheckOut, x.CustomerId, x.EmployeeId, x.NameEmployee, x.NameCustomer, x.RentSum, x.TotalDays }).ToList();
        }

        private void dgvRents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

