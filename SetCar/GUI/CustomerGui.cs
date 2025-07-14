using SetCar.BLL;
using SetCar.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetCar
{
    public partial class CustomerGui : Form
    {
        Customers customers;
        CustomersTable customersTable;
        Status status;

        public CustomerGui()
        {
            InitializeComponent();
            customers = new Customers();
            customersTable = new CustomersTable();
            status = new Status();
        }


        public CustomerGui(Customers customers1, Status status1)
        {
            InitializeComponent();
            customers = new Customers();
            customersTable = new CustomersTable();
            status = status1;
            customers = customers1;
            //אם הגיע במצב של פרטים השדות נהפכים לחסומים למילוי            fillTextBox();
            fillTextBox();
            if (status == Status.details)
            {
                fillEnabled();
            }
            else
                txtId.Enabled = false;

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
            txtId.Text = customers.CustomerId.Trim();
            txtName.Text = customers.NameCustomer;
            txtPhone.Text = customers.Phone;
            txtEmail.Text = customers.Email;
        }

        //בודק אם כל הפקדים מולאו כראוי
        public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                customers.CustomerId = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                customers.NameCustomer = txtName.Text;
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
                    customers.Phone = txtPhone.Text;
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
                customers.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtEmail, ex.Message);
                ok = false;
            }
            return ok;
        }

        //שומר את הלקוח ומעדכן בטבלה
        private void send_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                if (status == Status.add)
                {
                    try
                    {
                        customersTable.Add(customers);
                        MessageBox.Show("לקוח נוסף בהצלחה");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("לקוח כבר קיים");
                    }
                }
                else if (status == Status.update)
                {
                    customersTable.Update(customers);
                    MessageBox.Show("לקוח  עודכן בהצלחה");
                }
            }
        }
        private void CustomerGui_Load(object sender, EventArgs e)
        {

        }
    }
}
