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
    public partial class FeedbeckGui : Form
    {
        Feedbek feedbek;
        FeedbekTable feedbekTable;
        RentsTable rentsTable;
        Status status;
        Customers customers = new Customers();
        Rents rents = new Rents();
        //פעולה בונה ריקה
        public FeedbeckGui()
        {
            InitializeComponent();
            rentsTable = new RentsTable();
            status = Status.add;
            feedbekTable = new FeedbekTable();
            // feedbek = new Feedbek();
            feedbek = new Feedbek();
            txtName.Enabled = false;
            txtNameEmloyee.Enabled = false;
            refresh();
        }

        public FeedbeckGui(Feedbek feedbek1, Status status1)
        {
            InitializeComponent();
            feedbek = new Feedbek();
            feedbekTable = new FeedbekTable();
            rentsTable = new RentsTable();
            status = status1;
            feedbek = feedbek1;
            fillTextBox();
            fillEnabled();
            dgvFeedbeck.Visible = false;

        }

        //משנה את הפקדים להצגה בלבד
        public void fillEnabled()
        {
            // txtId.Enabled = false;
            txtName.Enabled = false;
            txtNameEmloyee.Enabled = false;
            txtDescribe.Enabled = false;
            txtGrading.Enabled = false;
        }

        //ממלא את הפקדים
        public void fillTextBox()
        {
            txtName.Text = feedbek.NameCustomer;
            txtDescribe.Text = feedbek.Describe;
            txtGrading.Text = feedbek.Grading.ToString();
            txtNameEmloyee.Text = feedbek.NameEmployee;
        }

        //הצגת טבלה
        public void refresh()
        {
            rentsTable = new RentsTable();
            dgvFeedbeck.DataSource = rentsTable.GetList().Select(x => new { x.RentCode, x.Carid, x.CheckIn, x.CheckOut, x.CustomerId, x.EmployeeId, x.NameEmployee, x.NameCustomer, x.RentSum, x.TotalDays }).ToList();
        }

       
        private void FeedbeckGui_Load(object sender, EventArgs e)
        {

        }

        private void dgvFeedbeck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        //בודק אם כל הפקדים מולאו כראוי
        public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();
       
            try
            {
                feedbek.NameCustomer = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            try
            {
                feedbek.Describe = txtDescribe.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDescribe, ex.Message);
                ok = false;
            }
            try
            {
                feedbek.Grading =Convert.ToInt32( txtGrading.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtGrading, ex.Message);
                ok = false;
            }
            return ok;
        }

        //מחיקה
        private void btn_details_Click(object sender, EventArgs e)
        {
            FeedbeckGui feedbeckGui = new FeedbeckGui(feedbek, Status.details);
            feedbeckGui.ShowDialog();
            refresh();
        }

        //שומר את הפידבק ומעדכן בטבלה
        private void sendClick_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                feedbek.RentCode = rents.RentCode;

                try
                {
                        feedbekTable.Add(feedbek);
                        MessageBox.Show("פידבק נוסף בהצלחה");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("פידבק כבר קיים");
                    }
                

            }
        }
        //בחירת שורה בטבלה
        private void choose(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvFeedbeck.SelectedRows[0].Cells[0].Value);
            rents = rentsTable.GetList().FirstOrDefault(x => x.RentCode ==id);
            txtName.Text = rents.NameCustomer;
            txtNameEmloyee.Text = rents.NameEmployee;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
