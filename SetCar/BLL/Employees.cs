using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class Employees : GeneralRow
    {
        #region מאפיינים
        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (Tkinut.LegalId(value) == false)
                    throw new Exception("מספר הזהות שגוי");
                employeeId = value;
            }
        }
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                if (value == "")
                    throw new Exception("שדה חובה");
                employeeName = value;
            }
        }
        private string position;

        public string Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (Tkinut.CheackMail(value) == false)
                    throw new Exception("כתובת המייל אינה תקינה");
                email = value;
            }
        }
        #endregion

        //פעולה המעבירה את נתוני הרשומה לתכונות המופע משמשת לשליפה
        public override void FillFields()
        {
            this.employeeId = drow["employeeId"].ToString();
            this.employeeName = drow["employeeName"].ToString();
            this.position = drow["position"].ToString();
            this.phone = drow["phone"].ToString();
            this.email = Convert.ToString(drow["email"]);
        }

        //פעולה המעבירה את תכונות המופע לנתוני הרשומה משמשת לעדכון
        public override void FillDataRow()
        {
            drow["employeeId"] = this.employeeId;
            drow["employeeName"] = this.employeeName;
            drow["position"] = this.position;
            drow["phone"] = this.phone;
            drow["email"] = this.email;
        }

        #region פעולות בונות
        //פעולה בונה להוספת חדש
        public Employees()
        {
        }

        //פעולה בונה המקבלת רשומה וממירה את נתוני הרשומה למופע המחלקה משמשת לניווט
        public Employees(DataRow dr)
        {
            drow = dr;
            FillFields();
        }

        //פעולה בונה המקבלת מפתח ראשי של טבלה וממירה את נתוני הרשומה למופע המחלקה
        public Employees(string id)
        {
            EmployeesTable employees = new EmployeesTable();
            drow = employees.Find(id);
            FillFields();
        }
        #endregion
    }
}
