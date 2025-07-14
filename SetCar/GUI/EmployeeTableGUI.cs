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
    public partial class EmployeeTableGUI : Form
    {
        Status status;
        EmployeesTable employeeTable;
        Employees employees;
        public EmployeeTableGUI()
        {
            InitializeComponent();
            employeeTable = new EmployeesTable();
            status = new Status();
            refresh();
        }

        //הצגת טבלה
        public void refresh()
        {
            employeeTable = new EmployeesTable();
            dvgEmployee.DataSource = employeeTable.GetList().Select(x => new { x.EmployeeId, x.EmployeeName, x.Phone, x.Email,x.Position }).ToList();
        }

        //הוספה
        private void addEmployee_Click(object sender, EventArgs e)
        {
            EmployeeGui employeeGui = new EmployeeGui();
            employeeGui.Show();
            status = Status.add;
            refresh();
        }

        //בחירת שורה בטבלה
        private void chooseEmployee(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dvgEmployee.SelectedRows[0].Cells[0].Value.ToString();
            employees = employeeTable.GetList().Find(x => x.EmployeeId == id);
        }

        //מחיקה
        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            {
                if (employees == null)
                    MessageBox.Show("בחר לקוח");
                else
                {

                    DialogResult Result = MessageBox.Show("האם ברצונך למחוק לקוח זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {
                        employeeTable.Delete(employees);
                        refresh();
                    }
                }
            }
        }

        private void dvgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //עדכון לקוח קיים
        private void updateEmployee_Click(object sender, EventArgs e)
        {
            if (employees == null)
                MessageBox.Show("בחר לקוח");
            else
            {
                EmployeeGui employeeGui = new EmployeeGui(employees, Status.update);
                employeeGui.ShowDialog();
                refresh();
            }
        }

        //הצגת פרטים של הרכב
        private void details_Click(object sender, EventArgs e)
        {
            if (employees == null)
                MessageBox.Show("בחר לקוח");
            else
            {
                EmployeeGui employeeGui = new EmployeeGui(employees, Status.details);
                employeeGui.ShowDialog();
                refresh();
            }
        }

        //בדיקה האם נכנס כמנהל או כלקוח
        private void EmployeeTableGui_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User == "employees")
            {
                deleteEmployee.Visible = false;
                addEmployee.Visible = false;
                updateEmployee.Visible = false;
                details.Visible = false;
            }
            if (Properties.Settings.Default.User == "customers")
            {
                details.Visible = false;
                deleteEmployee.Visible = false;
                addEmployee.Visible = false;
                updateEmployee.Visible = false;
            }
        }

        //חיפוש עובד לפי ת"ז
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dvgEmployee.DataSource = employeeTable.GetList().Where(a => a.EmployeeId.Trim().Contains(textBox1.Text)).Select(x => new { x.EmployeeId, x.EmployeeName, x.Phone, x.Email, x.Position }).ToList();

        }

        private void EmployeeTableGUI_Load_1(object sender, EventArgs e)
        {

        }
    }
}
