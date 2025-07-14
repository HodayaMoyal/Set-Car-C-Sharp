using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class Manager : GeneralRow
    {
        #region מאפיינים
        private string managerId;

        public string ManagerId
        {
            get { return managerId; }
            set
            {
                if (Tkinut.LegalId(value) == false)
                    throw new Exception("מספר הזהות שגוי");
                managerId = value;
            }
        }

        private string feedbekCode;

        public string FeedbekCode
        {
            get { return feedbekCode; }
            set
            {
                feedbekCode = value;
            }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                //if (Tkinut.Tkinut.IsCellPhone(value) == false)
                //    throw new Exception("מספר הפלאפון לא תקין");
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
        private string managerPassword;

        public string ManagerPassword
        {
            get { return managerPassword; }
            set
            {
                if (value == "")
                    throw new Exception("סיסמה שגויה");
                managerPassword = value;
            }
        }
        #endregion

        //פעולה המעבירה את נתוני הרשומה לתכונות המופע משמשת לשליפה
        public override void FillFields()
        {
            this.managerId = Convert.ToString(drow["managerId"]);
            this.feedbekCode = Convert.ToString(drow["feedbekCode"]);
            this.phone = Convert.ToString(drow["phone"]);
            this.email = Convert.ToString(drow["email"]);
            this.managerPassword = Convert.ToString(drow["managerPassword"]);
        }

        //פעולה המעבירה את תכונות המופע לנתוני הרשומה משמשת לעדכון
        public override void FillDataRow()
        {
            drow["managerId"] = this.managerId;
            drow["feedbekCode"] = this.feedbekCode;
            drow["phone"] = this.phone;
            drow["email"] = this.email;
            drow["managerPassword"] = this.managerPassword;
        }

        #region פעולות בונות
        //פעולה בונה להוספת חדש
        public Manager()
        {
        }

        //פעולה בונה המקבלת רשומה וממירה את נתוני הרשומה למופע המחלקה משמשת לניווט
        public Manager(DataRow dr)
        {
            drow = dr;
            FillFields();
        }

        //פעולה בונה המקבלת מפתח ראשי של טבלה וממירה את נתוני הרשומה למופע המחלקה
        public Manager(string id)
        {
            ManagerTable manager = new ManagerTable();
            drow = manager.Find(id);
            FillFields();
        }
        #endregion
    }
}

