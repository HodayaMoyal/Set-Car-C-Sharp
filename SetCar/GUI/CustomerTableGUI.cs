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
    public partial class CustomerTableGUI : Form
    {
        Status status;
        CustomersTable customersTable;
        Customers customers;
        List<Customers> lc = new List<Customers>();

        public CustomerTableGUI()
        {
            InitializeComponent();
            customersTable = new CustomersTable();
            status = new Status();
        }
        //ממלא את הטבלה
        public void refresh()
        {
            customersTable = new CustomersTable();
            lc.Sort();
            dvgCustomer.DataSource = lc.Select(x => new { x.CustomerId, x.NameCustomer, x.Phone, x.Email }).ToList();
            changeHeader();
        }

        public void changeHeader()
        {

        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //הוספה
        private void addCustomer_Click(object sender, EventArgs e)
        {
            CustomerGui customerGui = new CustomerGui();
            customerGui.Show();
            status = Status.add;
            refresh();
        }

        //בחירת שורה בטבלה
        private void chooseCustomer(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dvgCustomer.SelectedRows[0].Cells[0].Value.ToString();
            customers = customersTable.GetList().Find(x => x.CustomerId == id);
        }

        //מחיקה
        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (customers == null)
                MessageBox.Show("בחר לקוח");
            else
            {
                DialogResult Result = MessageBox.Show("האם ברצונך למחוק לקוח זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    customersTable.Delete(customers);
                    refresh();
                }
            }
        }

        //עדכון לקוח קיים
        private void updateCustomer_Click(object sender, EventArgs e)
        {
            if (customers == null)
                MessageBox.Show("בחר לקוח");
            else
            {
                CustomerGui customerGui = new CustomerGui(customers, Status.update);
                customerGui.ShowDialog();
                refresh();
            }

        }

        //הצגת פרטים של הרכב
        private void details_Click(object sender, EventArgs e)
        {
            if (customers == null)
                MessageBox.Show("בחר לקוח");
            else
            {
                CustomerGui customerGui = new CustomerGui(customers, Status.details);
                customerGui.ShowDialog();
                refresh();
            }
        }

        private void CustomerTableGui_Load(object sender, EventArgs e)
        {
           
        }

        //בדיקה האם נכנס כמנהל או כלקוח
        private void CustomerTableGUI_Load_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User == "manager")
            {
                deleteCustomer.Visible = false;
                addCustomer.Visible = false;
                updateCustomer.Visible = false;
                lc = customersTable.GetList();
            }
            if (Properties.Settings.Default.User == "customers")
            {
                deleteCustomer.Visible = false;
                addCustomer.Visible = false;
                details.Visible = false;
                updateCustomer.Visible = false;
            }
            if(Properties.Settings.Default.User== "employees")
            {
             DataTable dt=customersTable.GetDisplayTable("select * from customers where customerid in(select customerid from rents where employeeid=" + Properties.Settings.Default.Id+")");
                foreach (DataRow item in dt.Rows)
                {
                    lc.Add(new Customers(item));
                }
            }
            refresh();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //חיפוש עובד לפי ת"ז
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dvgCustomer.DataSource = lc.Where(a => a.CustomerId.Trim().Contains(textBox1.Text)).Select(x => new { x.CustomerId, x.NameCustomer, x.Phone, x.Email }).ToList();

        }
    }
}
