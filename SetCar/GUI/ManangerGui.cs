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
    public partial class ManangerGui : Form
    {
        Manager manager;
        ManagerTable managerTable;
        Status status;
        public ManangerGui()
        {
            InitializeComponent();
            manager = new Manager();
            managerTable = new ManagerTable();
            status = new Status();
        }

        public ManangerGui(Manager manager1, Status status1)
        {
            InitializeComponent();
            manager = new Manager();
            managerTable = new ManagerTable();
            status = status1;
            manager = manager1;
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
                manager.ManagerId = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                manager.ManagerPassword = password.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(password, ex.Message);
                ok = false;
            }
            try
            {
                if (txtPhone.Text.StartsWith("050") || txtPhone.Text.StartsWith("052") ||
                    txtPhone.Text.StartsWith("055") || txtPhone.Text.StartsWith("054") ||
                    txtPhone.Text.StartsWith("053") || txtPhone.Text.StartsWith("058"))
                    manager.Phone = txtPhone.Text;
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
                manager.Email = txtEmail.Text;
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
            txtId.Text = manager.ManagerId;
            password.Text = manager.ManagerPassword;
            txtPhone.Text = manager.Phone;
            txtEmail.Text = manager.Email;
        }

        //שומר את המנהל ומעדכן בטבלה
        private void send_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                if (status == Status.add)
                {
                    try
                    {
                        managerTable.Add(manager);
                        MessageBox.Show("מנהל נוסף בהצלחה");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("מנהל כבר קיים");
                    }
                }
                else if (status == Status.update)
                {
                    managerTable.Update(manager);
                    MessageBox.Show("מנהל  עודכן בהצלחה");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}



