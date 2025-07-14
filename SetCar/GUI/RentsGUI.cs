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
    public partial class RentsGUI : Form
    {
        CarsTable carsTable;
        RentsTable rentsTable;
        Rents rents;
        Cars cars;
        int placeOrd = 0;
        List<Cars> opCar = new List<Cars>();
        Status status;
        public RentsGUI()
        {
            InitializeComponent();
            carsTable = new CarsTable();
            rentsTable = new RentsTable();
            rents = new Rents();
            cars = new Cars();
            txtCarName.Visible = false;
            calcTotal();
            txtTotalDays.Enabled = false;
            txtNameEmployee.Enabled = false;
            txtNameEmployee.Text = new Employees(Properties.Settings.Default.Id).EmployeeName;
        }
        bool flag = true;
        public RentsGUI(Rents rents1, Status status1)
        {
            InitializeComponent();
            rents = new Rents();
            rentsTable = new RentsTable();
            status = status1;
            rents = rents1;
            calcTotal();
            flag = false;
            fillTextBox();
            fillEnabled();
            flag = true;
        }

        //משנה את הפקדים להצגה בלבד
        public void fillEnabled()
        {
            txtSeats.Enabled = false;
            txtCheckIn.Enabled = false;
            txtCheckOut.Enabled = false;
            txtTotalDays.Enabled = false;
            txtNameEmployee.Enabled = false;
            txtCarName.Enabled = false;
        }

        //ממלא את הפקדים
        public void fillTextBox()
        {
            txtCarName.Text = rents.NameCar;
            txtNameEmployee.Text = rents.NameEmployee;
            txtCheckIn.Value = rents.CheckIn;
            txtCheckOut.Value = rents.CheckOut;
            txtTotalDays.Text = rents.TotalDays.ToString();
            txtSeats.Visible = false;
            labelSeats.Visible = false;
        }

        //בדיקה אם הפקדים מולאו כראוי
        public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                rents.TotalDays = Convert.ToInt32(txtTotalDays.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTotalDays, ex.Message);
                ok = false;
            }

            try
            {
                rents.CheckIn = txtCheckIn.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCheckIn, ex.Message);
                ok = false;
            }
            try
            {
                rents.CheckOut = txtCheckOut.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCheckOut, ex.Message);
                ok = false;
            }
            return ok;
        }

        //כפתור שיוצר רשימה של הרכבים הפנוים בתאריכים המבוקשים
        private void Click_FreeCar(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).Name);
            Cars c = new Cars(id);
            rents.Carid = id;
            Close();
            PaymentGUI paymentGUI = new PaymentGUI(c, rents);
            paymentGUI.Show();

        }

        //כפתור המציג את הרכבים הפנויים בתאריכים המבוקשים
        private void showCars()
        {
            Color color = Color.LightBlue;
            int x = 40;
            int y = 40;
            foreach (Cars item in opCar)
            {
                Button b = new Button();

                b.Size = new Size(150, 150);
                b.BackColor = color;
                b.Location = new Point(x, y);
                y = x >= 490 ? y + 150 : y;
                x = x >= 490 ? 40 : x + 150;
                b.Text = "the car is:" + item.CarName + "\n" + "pay for day:" + item.PayForDay + "\n" + "num of seats:" + item.NumOfSeats;
                b.Name = item.CarId.ToString();
                b.Click += new System.EventHandler(this.Click_FreeCar);
                Controls.Add(b);
            }
        }

        //כפתור שיוצר רשימה של הרכבים הפנוים בתאריכים המבוקשים
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                try
                {
                    rents.CustomerId = txtidcustomer.Text;
                    placeOrd = Convert.ToInt32(txtSeats.Value);
                    //מכניסה להשכרה וגם מספר מושבים
                    opCar = carsTable.GetList().FindAll(a => a.NumOfSeats >= placeOrd);
                    //לפי מספר מושבים
                    List<Rents> AllRents = rentsTable.GetList().FindAll(a => a.CheckOut >= DateTime.Now);
                    foreach (Rents item in AllRents)
                    {
                        if (item.CheckIn.Date >= rents.CheckIn.Date && item.CheckIn.Date <= rents.CheckOut.Date ||
                            item.CheckOut.Date>= rents.CheckIn.Date && item.CheckOut.Date <= rents.CheckOut.Date)
                            opCar.Remove(opCar.Find(a=>a.CarId==item.Carid));
                    }
                    groupBox1.Visible = false;
                    showCars();
                }
                catch (Exception)
                {

                }
            }           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //כפתור שקורא לפונקצית חישוב הסכום לפי מספר הימים
        private void txtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        //כפתור שקורא לפונקצית חישוב הסכום לפי מספר הימים
        private void txtCheckOut_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();

        }

        //כפתור שמחשב את מספר הימים
        public void calcTotal()
        {
            if(flag)
                txtTotalDays.Value =txtCheckIn.Value.Date==txtCheckOut.Value.Date?1:((int)(txtCheckOut.Value - txtCheckIn.Value).TotalDays);
        }

        private void txtTotalDays_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RentsGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
