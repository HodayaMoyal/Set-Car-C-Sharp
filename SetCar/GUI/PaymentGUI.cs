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
    public partial class PaymentGUI : Form
    {
        Cars cars; 
        Rents rents;
        RentsTable rentsTable;
        public PaymentGUI(Cars cars,Rents rents)
        {
            InitializeComponent();
            this.rents = rents;
            this.cars = cars;
            rentsTable = new RentsTable();
            sumOfRent();
            fillTextBox();
            fillEnabled();
        }

        //פונקציה המחשבת סכום רכב
        public int sumOfRent()
        {
            int sum = 0;
            sum = rents.TotalDays * cars.PayForDay;
            rents.RentSum = sum;
            return sum;
        }

        private void PaymentGUI_Load(object sender, EventArgs e)
        {
        }

        //הוספת הזמנה
        private void button1_Click(object sender, EventArgs e)
        {
            rentsTable.Add(rents);
            MessageBox.Show("הזמנה נוספה בהצלחה");
            Close();
        }

        //ממלא את הפקדים
        public void fillTextBox()
        {
            txtCarName.Text = cars.CarName;
            txtCheckIn.Text = rents.CheckIn.ToString();
            txtCheckOut.Text = rents.CheckOut.ToString();
            txtNameEmployee.Text = rents.NameEmployee;
            txtRentSum.Text = rents.RentSum.ToString();
            txtTotalDays.Value = rents.TotalDays;
            txtSeats.Value = cars.NumOfSeats;
            txtNameEmployee.Text = rents.NameEmployee;

        }

        //משנה את הפקדים להצגה בלבד
        public void fillEnabled()
        {
            txtCarName.Enabled = false;
            txtCheckIn.Enabled = false;
            txtCheckOut.Enabled = false;
            txtNameEmployee.Enabled = false;
            txtRentSum.Enabled = false;
            txtSeats.Enabled = false;
            txtTotalDays.Enabled = false;
        }

        private void txtRentSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
