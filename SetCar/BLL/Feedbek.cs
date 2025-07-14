using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class Feedbek : GeneralRow
    {
        #region מאפיינים
        private int feedbekId;

        public int FeedbekId
        {
            get { return feedbekId; }
            set
            {
                feedbekId = value;
            }
        }
        private string describe;

        public string Describe
        {
            get { return describe; }
            set
            {
                if (value == "")
                    throw new Exception("פידבק שגוי");
                describe = value;
            }
        }
        private int grading;

        public int Grading
        {
            get { return grading; }
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("ניקוד שגוי");
                grading = value;
            }
        }
        private int rentCode;

        public int RentCode
        {
            get { return rentCode; }
            set
            {
                rentCode = value;
            }
        }



        public string NameCustomer { get; set; }
        public string NameEmployee { get; set; }
        #endregion

        public Rents GetRent()
        {
          return  new Rents(rentCode);
            
        }
        public Customers GetCustomers()
        {
            return new Customers(GetRent().CustomerId);
        }

        public Employees GetEmployee()
        {
            return new Employees(GetRent().EmployeeId);

        }

        //פעולה המעבירה את נתוני הרשומה לתכונות המופע משמשת לשליפה
        public override void FillFields()
        {
            this.feedbekId = Convert.ToInt32(drow["feedbekId"]);
            this.describe = Convert.ToString(drow["describe"]);
            this.grading = Convert.ToInt32(drow["grading"]);
            this.rentCode = Convert.ToInt32(drow["rentCode"]);
           
            this.NameCustomer = GetCustomers().NameCustomer;
            this.NameEmployee = GetEmployee().EmployeeName;
        }

        //פעולה המעבירה את תכונות המופע לנתוני הרשומה משמשת לעדכון
        public override void FillDataRow()
        {
            drow["feedbekId"] = this.feedbekId;
            drow["describe"] = this.describe;
            drow["grading"] = this.grading;
            drow["rentCode"] = this.rentCode;
        }

        #region פעולות בונות
        //פעולה בונה להוספת חדש
        public Feedbek()
        {
        }

        //פעולה בונה המקבלת רשומה וממירה את נתוני הרשומה למופע המחלקה משמשת לניווט
        public Feedbek(DataRow dr)
        {
            drow = dr;
            FillFields();
        }

        //פעולה בונה המקבלת מפתח ראשי של טבלה וממירה את נתוני הרשומה למופע המחלקה
        public Feedbek(string id)
        {
            FeedbekTable feedbek = new FeedbekTable();
            drow = feedbek.Find(id);
            FillFields();
        }
        #endregion
    }
}
