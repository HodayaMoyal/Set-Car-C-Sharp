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
    public partial class FeedbeckTableGui : Form
    {
        Feedbek feedbeck;
        FeedbekTable feedbekTable;
        Status status;
        string idCustomer = "";
        string idEmployee = "";
        List<Feedbek> rentsf;

        public FeedbeckTableGui()
        {
            InitializeComponent();
            status = new Status();
            feedbekTable = new FeedbekTable();
           // feedbeck = new Feedbek();
            rentsf = feedbekTable.GetList();
            refresh();
        }

        private void dgvFeedbeck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //ממלא את הטבלה
        public void refresh()
        {
            FeedbekTable feedbekTable = new FeedbekTable();
            rentsf = feedbekTable.GetList();
            dgvFeedbeck.DataSource = rentsf.Select(x => new { x.FeedbekId, x.NameCustomer, x.NameEmployee, x.Describe, x.Grading, x.RentCode }).ToList();
        }

        //בחירת שורה בטבלה
        private void chooseFeedbeck(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvFeedbeck.SelectedRows[0].Cells[0].Value);
            feedbeck = ((Feedbek)(feedbekTable.GetList().Find(x => x.FeedbekId == id)));
        }

        //מחיקה
        private void button1_Click(object sender, EventArgs e)
        {
            if (feedbeck == null)
                MessageBox.Show("בחר פידבק");
            else
            {

                DialogResult Result = MessageBox.Show("האם ברצונך למחוק פידבק זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    feedbekTable.Delete(feedbeck);
                    refresh();
                }
            }
        }

        //הוספה
        private void button1_Click_1(object sender, EventArgs e)
        { 
            FeedbeckGui feedbeck = new FeedbeckGui();
            feedbeck.Show();
            refresh();
        }

        //הצגת פרטים של הפידבק
        private void btn_details_Click(object sender, EventArgs e)
        {
            if (feedbeck == null)
            {
                MessageBox.Show("בחר שורה");
            }
            else
            {
                FeedbeckGui feedbeckGui = new FeedbeckGui(feedbeck, Status.details);
                feedbeckGui.ShowDialog();
                refresh();
            }
        }

        //בדיקה האם נכנס כמנהל או כלקוח או כעובד
        private void FeedbeckTableGui_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User == "employees")
            {
                btndelete.Visible = false;
                btn_add.Visible = false;
                idEmployee = Properties.Settings.Default.Id;
                rentsf = rentsf.FindAll(a => a.NameEmployee.Trim() == idEmployee.Trim());
            }
            if (Properties.Settings.Default.User == "customers")
            {
                btndelete.Visible = false;
                idCustomer = Properties.Settings.Default.Id;
                rentsf = rentsf.FindAll(a => a.NameCustomer.Trim() == idCustomer.Trim());
            }
            if (Properties.Settings.Default.User == "mananger")
            {
                btn_add.Visible = false;
            }
        }

        //חיפוש פידבק לפי ת"ז
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvFeedbeck.DataSource = feedbekTable.GetList().Where(a => a.FeedbekId.ToString().Contains(textBox1.Text)).Select(x => new { x.FeedbekId, x.NameCustomer, x.NameEmployee, x.Describe, x.Grading, x.RentCode }).ToList();
        }
    }
}
