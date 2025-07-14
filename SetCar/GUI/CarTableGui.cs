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
    public partial class CarTableGui : Form
    {
        Status status;
        CarsTable carsTable;
        Cars cars;

        //פעולה בונה ריקה
        public CarTableGui()
        {
            InitializeComponent();
            status = new Status();
            carsTable = new CarsTable();
            refresh();
        }
        //הצגת טבלה
        public void refresh()
        {
            carsTable = new CarsTable();
            dgvCar.DataSource = carsTable.GetList().Select(x => new { x.CarId, x.CarName, x.Kind, x.NumOfSeats, x.PayForDay, x.YearOfManufacture }).ToList();
        }

        private void dgvCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //בחירת שורה בטבלה
        private void chooseCar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id =int.Parse( dgvCar.SelectedRows[0].Cells[0].Value.ToString());
            cars = carsTable.GetList().Find(x => x.CarId == id);
        }

        //מחיקה
        private void delete_Click(object sender, EventArgs e)
        {
            if (cars == null)
                MessageBox.Show("בחר לקוח");
            else
            {

                DialogResult Result = MessageBox.Show("האם ברצונך למחוק לקוח זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    carsTable.Delete(cars);
                    refresh();
                }
            }
        }

        //הוספה
        private void addCar_Click(object sender, EventArgs e)
        {
            CarGui carGui = new CarGui();
            carGui.Show();
            status = Status.add;
            refresh();
        }

        //עדכון לקוח קיים
        private void updateCar_Click(object sender, EventArgs e)
        {
            if (cars == null)
                MessageBox.Show("בחר לקוח");
            else
            {
                CarGui carGui = new CarGui(cars, Status.update);
                carGui.ShowDialog();
                refresh();
            }

        }

        //הצגת פרטים של הרכב
        private void detailsCarClick_Click(object sender, EventArgs e)
        {
            if (cars == null)
                MessageBox.Show("בחר שורה");
            else
            {
                CarGui carGui = new CarGui(cars, Status.details);
                carGui.ShowDialog();
                refresh();
            }
        }

        //בדיקה האם נכנס כלקוח או כעובד
        private void CarTableGui_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User == "employees")
            {
                addCar.Visible = false;
                deletear.Visible = false;
            }
            if (Properties.Settings.Default.User == "customers")
            {
                addCar.Visible = false;
                deletear.Visible = false;
                updateCar.Visible = false;
            }
        }

        //חיפוש רכב לפי שם רכב
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCar.DataSource = carsTable.GetList().Where(a => a.CarName.Contains(textBox1.Text)).Select(x => new { x.CarName, x.CarId, x.Kind, x.NumOfSeats, x.PayForDay, x.YearOfManufacture }).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
