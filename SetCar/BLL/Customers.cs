using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class Customers : GeneralRow,IComparable
    {
        #region מאפיינים
        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set
            {
                if (Tkinut.LegalId(value) == false)
                    throw new Exception("מספר הזהות שגוי");
                customerId = value;
            }
        }
        private string customerName;

        public string NameCustomer
        {
            get { return customerName; }
            set
            {
                if (value == "")
                    throw new Exception("שדה חובה");
                customerName = value;
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

        private bool vip;

        public bool Vip
        {
            get { return vip; }
            set { vip = value; }
        }
        #endregion

        //פעולה המעבירה את נתוני הרשומה לתכונות המופע משמשת לשליפה
        public override void FillFields()
        {
            this.customerId = drow["customerId"].ToString();
            this.customerName = drow["customerName"].ToString();
            this.phone = drow["phone"].ToString();
            this.email = drow["email"].ToString();
            this.vip = Convert.ToBoolean(drow["vip"]);
        }

        //פעולה המעבירה את תכונות המופע לנתוני הרשומה משמשת לעדכון
        public override void FillDataRow()
        {
            drow["customerId"] = this.customerId;
            drow["customerName"] = this.customerName;
            drow["phone"] = this.phone;
            drow["email"] = this.email;
            drow["vip"] = this.vip;
        }

        public int CompareTo(object obj)
        {
            if (this.customerName.CompareTo(((Customers)obj).customerName) < 1)
                return -1;
            if (this.customerName.CompareTo(((Customers)obj).customerName) > 1)
                return 1;
            return 1;
        }

        #region פעולות בונות
        //פעולה בונה להוספת חדש
        public Customers()
        {
        }

        //פעולה בונה המקבלת רשומה וממירה את נתוני הרשומה למופע המחלקה משמשת לניווט
        public Customers(DataRow dr)
        {
            drow = dr;
            FillFields();
        }

        //פעולה בונה המקבלת מפתח ראשי של טבלה וממירה את נתוני הרשומה למופע המחלקה
        public Customers(string id)
        {
            CustomersTable customers = new CustomersTable();
            drow = customers.Find(id);
            FillFields();
        }
        #endregion
    }
}
