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
    public partial class EmployeeGui : Form
    {
        Employees employees;
        EmployeesTable employeesTable;
        Status status;
        public EmployeeGui()
        {
            InitializeComponent();
            employees = new Employees();
            employeesTable = new EmployeesTable();
            status = new Status();
        }

        public EmployeeGui(Employees employees1, Status status1)
        {
            InitializeComponent();
            employees = new Employees();
            employeesTable = new EmployeesTable();
            status = status1;
            employees = employees1;
            //אם הגיע במצב של פרטים השדות נהפכים לחסומים למילוי            fillTextBox();
            fillTextBox();
            if (status == Status.details)
            {
                fillEnabled();
            }
            else
                txtId.Enabled = false;

        }

        //בודק אם כל הפקדים מולאו כראוי
        public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                employees.EmployeeId = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                employees.EmployeeName = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            try
            {
                if (txtPhone.Text.StartsWith("050") || txtPhone.Text.StartsWith("052") ||
                    txtPhone.Text.StartsWith("055") || txtPhone.Text.StartsWith("054") ||
                    txtPhone.Text.StartsWith("053") || txtPhone.Text.StartsWith("058"))
                    employees.Phone = txtPhone.Text;
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone, ex.Message);
                ok = false;
            }
            try
            {
                employees.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtEmail, ex.Message);
                ok = false;
            }
            return ok;
        }

        //משנה את הפקדים להצגה בלבד
        public void fillEnabled()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
        }

        //ממלא את הפקדים
        public void fillTextBox()
        {
            txtId.Text = employees.EmployeeId;
            txtName.Text = employees.EmployeeName;
            txtPhone.Text = employees.Phone;
            txtEmail.Text = employees.Email;
        }

        private void EmployeeGui_Load(object sender, EventArgs e)
        {

        }

        private void mananger_CheckedChanged(object sender, EventArgs e)
        {

        }

        //שומר את העובד ומעדכן בטבלה
        private void send_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                if (status == Status.add)//צריך הוספתי עכשיו מקודם לא היה?
                {
                    try
                    {
                        employeesTable.Add(employees);
                        MessageBox.Show("עובד נוסף בהצלחה");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("עובד כבר קיים");
                    }
                }
                else if (status == Status.update)
                {
                    employeesTable.Update(employees);
                    MessageBox.Show("עובד  עודכן בהצלחה");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}