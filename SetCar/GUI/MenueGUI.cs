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
    public enum Status { add, update, details }
    public partial class MenueGUI : Form
    {
        public MenueGUI()
        {
            InitializeComponent();
        }
        //כפתור המעביר לדף לקוחות
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerTableGUI c = new CustomerTableGUI();
            c.Show();
        }

        //כפתור המעביר לדף עובדים
        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeTableGUI ep = new EmployeeTableGUI();
            ep.Show();
        }

        //כפתור המעביר לדף רכבים
        private void button3_Click(object sender, EventArgs e)
        {
            CarTableGui car = new CarTableGui();
            car.Show();
        }

        //כפתור המעביר לדף פידבקים
        private void feedbeck_Click(object sender, EventArgs e)
        {
            FeedbeckTableGui ef = new FeedbeckTableGui();
            ef.Show();
        }

        //כפתור המעביר לדף השכרות
        private void rents_Click(object sender, EventArgs e)
        {
            RentsTableGui rentsTableGui = new RentsTableGui();
            rentsTableGui.Show();
        }

        //בדיקה האם הנכנס לאתר הוא עובד או לקוח ואז הפנייה לתחומים שברשותו
        private void MenueGUI_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User == "employees")
            {
                btnEmployee.Visible = false;
                btnMananger.Visible = false;
            }
            if (Properties.Settings.Default.User == "customers")
            {
                btnEmployee.Visible = false;
                btnMananger.Visible = false;
                btnFeedbeck.Visible = false;
                btnCustomer.Visible = false;
            }

        }

        private void btnMananger_Click(object sender, EventArgs e)
        {
            ManangerTableGui manangerTableGui = new ManangerTableGui();
            manangerTableGui.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
