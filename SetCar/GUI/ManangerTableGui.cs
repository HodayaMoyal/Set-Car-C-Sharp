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
    public partial class ManangerTableGui : Form
    {
        Status status;
        ManagerTable managerTable;
        Manager manager;

        public ManangerTableGui()
        {
            InitializeComponent();
            status = new Status();
            managerTable = new ManagerTable();
            refresh();
        }

        //הצגת טבלה
        public void refresh()
        {
            managerTable = new ManagerTable();
            dgvTableMananger.DataSource = managerTable.GetList().Select(x => new { x.ManagerId, x.Email, x.FeedbekCode, x.ManagerPassword, x.Phone }).ToList();
        }

        //הוספה
        private void addMananger_Click(object sender, EventArgs e)
        {
            ManangerGui manangerGui = new ManangerGui();
            manangerGui.Show();
            status = Status.add;
            refresh();
        }

        private void dgvTableMananger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //בחירת שורה בטבלה
        private void chooseMananger(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dgvTableMananger.SelectedRows[0].Cells[0].Value.ToString();
            manager = managerTable.GetList().Find(x => x.ManagerId.Trim() == id);
        }

        //מחיקה
        private void deleteMananger_Click(object sender, EventArgs e)
        {
            if (manager == null)
                MessageBox.Show("בחר לקוח");
            else
            {

                DialogResult Result = MessageBox.Show("האם ברצונך למחוק לקוח זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    managerTable.Delete(manager);
                    refresh();
                }
            }
        }


        //עדכון לקוח קיים
        private void updateMananger_Click(object sender, EventArgs e)
        {

            if (manager == null)
                MessageBox.Show("בחר לקוח");
            else
            {

                ManangerGui manangerGui = new ManangerGui(manager, Status.update);
                manangerGui.ShowDialog();
                refresh();
            }
        }

        //הצגת פרטים של המנהל
        private void detailsMananger_Click(object sender, EventArgs e)
        {

            if (manager == null)
                MessageBox.Show("בחר לקוח");
            else
            {

                ManangerGui manangerGui = new ManangerGui(manager, Status.details);
                manangerGui.ShowDialog();
                refresh();
            }
        }

        //בדיקה האם נכנס כעובד או כלקוח
        private void ManangerTableGui_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User == "employees")
            {
                detailsMananger.Visible = false;
                deleteMananger.Visible = false;
                addMananger.Visible = false;
                updateMananger.Visible = false;
            }
            if (Properties.Settings.Default.User == "customers")
            {
                detailsMananger.Visible = false;
                deleteMananger.Visible = false;
                addMananger.Visible = false;
                updateMananger.Visible = false;
            }
        }

        //חיפוש מנהל לפי ת"ז
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvTableMananger.DataSource = managerTable.GetList().Where(a => a.ManagerId.Trim().Contains(textBox1.Text)).Select(x => new { x.ManagerId, x.Email, x.FeedbekCode, x.ManagerPassword, x.Phone }).ToList();

        }

        private void ManangerTableGui_Load_1(object sender, EventArgs e)
        {

        }
    }
}
