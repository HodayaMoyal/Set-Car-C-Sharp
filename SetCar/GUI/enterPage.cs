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
    public partial class enterPage : Form
    {
        public enterPage()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        //כפתןור המעביר לדף תפריט אם נכנס כשתמש
        private void submit_Click(object sender, EventArgs e)
        {
            EmployeesTable employeesTable = new EmployeesTable();
            Employees employees = employeesTable.GetList().Find(a => a.Email.Trim() == txtUserEmail.Text && a.EmployeeId.Trim() == txtId.Text);
            if (employees != null)
            {
                Properties.Settings.Default.Id = employees.EmployeeId;
                Properties.Settings.Default.User = "employees";
                MenueGUI mangerMenueGUI = new MenueGUI();
                mangerMenueGUI.Show();
            }
            else
            {
                CustomersTable customersTable = new CustomersTable();
                Customers customers = customersTable.GetList().Find(a => a.Email.Trim() == txtUserEmail.Text && a.CustomerId.Trim() == txtId.Text);
                if (customers != null)
                {
                    Properties.Settings.Default.Id = customers.CustomerId;
                    Properties.Settings.Default.User = "customers";
                    MenueGUI mangerMenueGUI = new MenueGUI();
                    mangerMenueGUI.Show();
                }
                else
                {
                    MessageBox.Show("not exists");
                }
            }
        }

        //כפתןור המעביר לדף תפריט אם נכנס כמנהל
        private void button1_Click(object sender, EventArgs e)
        {
            ManagerTable managerTable = new ManagerTable();
            Manager manager = managerTable.GetList().Find(a => a.Email.Trim() == txtEmail.Text && a.ManagerPassword.Trim() == txtPassword.Text);
            if (manager != null)
            {
                Properties.Settings.Default.Id = manager.ManagerId;
                Properties.Settings.Default.User = "manager";
                MenueGUI mangerMenueGUI = new MenueGUI();
                mangerMenueGUI.Show();
            }
            else
            {
                MessageBox.Show("not exists");
            }
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        //יצירת טיימר בן 30 שניות
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==300)
            {
                timer1.Stop();
                i = 0;
                groupBox1.Visible = false;
            }
        }
        int i = 0;

        //מאפס את הטיימר בן ה-30 שניות עד להקשת מייל משתמש
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            i = 0;
        }

        //מאפס את הטיימר בן ה-30 שניות עד להקשת סיסמת מנהל
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            i = 0;
        }

        //מאפשר להיכנס כמשתמש
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            timer1.Start();
        }

        //מאפשר להיכנס כמנהל
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            timer1.Start();
        }

        //מאפס את הטיימר בן ה-30 שניות עד להקשת ת"ז מנהל
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            i = 0;
        }

        //מאפס את הטיימר בן ה-30 שניות עד להקשת מייל משתשמש
        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {
            i = 0;
        }

        private void enterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
