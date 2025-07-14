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
    public partial class CarGui : Form
    {
        Cars cars;
        CarsTable carsTable;
        Status status;

        public CarGui()
        {
            InitializeComponent();
            cars = new Cars();
            carsTable = new CarsTable();
            status = new Status();
        }

        public CarGui(Cars cars1, Status status1)
        {
            InitializeComponent();
            cars = new Cars();
            carsTable = new CarsTable();
            status = status1;
            cars = cars1;
            fillTextBox();
            //אם הגיע במצב של פרטים השדות נהפכים לחסומים למילוי            
            if (status == Status.details)
            {
                fillEnabled();
            }
            //עדכון חוץ מת"ז
            //else
            //    txtId.Enabled = false;
        }

        private void CarGui_Load(object sender, EventArgs e)
        {

        }

        //בודק אם כל הפקדים מולאו כראוי
        public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();
           
            try
            {
                cars.CarName = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            try
            {
                cars.Kind = txtKind.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKind, ex.Message);
                ok = false;
            }
            return ok;
        }

        //משנה את הפקדים להצגה בלבד
        public void fillEnabled()
        {
            //txtId.Enabled = false;
            txtName.Enabled = false;
            txtKind.Enabled = false;
            txtSeats.Enabled = false;
            txtFree.Enabled = false;
        }

        //ממלא את הפקדים
        public void fillTextBox()
        {
            //txtId.Text = cars.CarId;
            txtName.Text = cars.CarName;
            txtKind.Text = cars.Kind;
            txtSeats.Text = cars.NumOfSeats.ToString();
        }

        //שומר את הרכב ומעדכן בטבלה
        private void send_Click(object sender, EventArgs e)
        {
            {
                if (Check() == true)
                {
                    if (status == Status.add)
                    {
                        try
                        {
                            carsTable.Add(cars);
                            MessageBox.Show("רכב נוסף בהצלחה");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("רכב כבר קיים");
                        }
                    }
                    else if(status == Status.update)
                    {
                        carsTable.Update(cars);
                        MessageBox.Show("רכב  עודכן בהצלחה");
                    }
                }

            }

        }

        private void txtFree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



