using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class Rents : GeneralRow
    {
        #region מאפיינים
        private int rentCode;

        public int RentCode
        {
            get { return rentCode; }
            set
            {
                rentCode = value;
            }
        }
        private int totalDays;

        public int TotalDays
        {
            get { return totalDays; }
            set
            {
                if (value <= 0)
                    throw new Exception("מספר ימים שגוי");
                totalDays = value;
            }
        }
        private int rentSum;

        public int RentSum
        {
            get { return rentSum; }
            set
            {
                rentSum = value;
            }
        }
        private DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set
            {
                if (value < DateTime.Now.Date)
                    throw new Exception("תאריך לא תקין");
                else
                    checkIn = value;
            }
        }

        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set
            {
                if (value.Date < DateTime.Now.Date || value.Date < CheckIn.Date)
                    throw new Exception("תאריך לא תקין");
                else
                    checkOut = value;
            }
        }

        private int carid;

        public int Carid
        {
            get { return carid; }
            set
            {
                carid = value;
            }
        }

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

        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set
            {
                
                customerId = value;
            }
        }
        public string NameCustomer { get; set; }
        public string NameEmployee { get; set; }
        public string NameCar { get; set; }

        #endregion

        //פעולה המעבירה את נתוני הרשומה לתכונות המופע משמשת לשליפה
        public override void FillFields()
        {
            this.customerId = Convert.ToString(drow["customerId"]);
            this.rentCode = Convert.ToInt32(drow["rentCode"]);
            this.totalDays = Convert.ToInt32(drow["totalDays"]);
            this.rentSum = Convert.ToInt32(drow["rentSum"]);
            this.checkIn = Convert.ToDateTime(drow["checkIn"]);
            this.checkOut = Convert.ToDateTime(drow["checkOut"]);
            this.carid = Convert.ToInt32(drow["carid"].ToString());
            this.employeeId = Convert.ToString(drow["employeeId"]);
            this.NameCustomer = GetCustomers().NameCustomer;
            this.NameEmployee = GetEmployee().EmployeeName;
            this.NameCar = GetCar().CarName;
        }

        //פעולה המעבירה את תכונות המופע לנתוני הרשומה משמשת לעדכון
        public override void FillDataRow()
        {
            drow["rentCode"] = this.rentCode;
            drow["totalDays"] = this.totalDays;
            drow["rentSum"] = this.rentSum;
            drow["checkIn"] = this.checkIn;
            drow["checkOut"] = this.checkOut;
            drow["carid"] = this.carid;
            drow["employeeId"] = this.employeeId;
            drow["customerId"] = this.customerId;
        }

        #region פעולות בונות

        public Customers GetCustomers()
        {
            CustomersTable customersTable = new CustomersTable();
          
            Customers c= customersTable.GetList().Find(x => x.CustomerId.Trim() == this.customerId);
            if (c == null)
                return new Customers();
            return c;
        }

        public Employees GetEmployee()
        {
            EmployeesTable employeesTable = new EmployeesTable();
            Employees e= employeesTable.GetList().Find(x => x.EmployeeId.Trim() == this.employeeId);
         if(e==null)
            {
                return new Employees();
            }
            return e;
        }

        public Cars GetCar()
        {
            CarsTable carsTable = new CarsTable();
            Cars cars = carsTable.GetList().Find(x => x.CarId == this.carid);
            return cars;
        }
        //פעולה בונה להוספת חדש
        public Rents()
        {
        }

        //פעולה בונה המקבלת רשומה וממירה את נתוני הרשומה למופע המחלקה משמשת לניווט
        public Rents(DataRow dr)
        {
            drow = dr;
            FillFields();
        }

        //פעולה בונה המקבלת מפתח ראשי של טבלה וממירה את נתוני הרשומה למופע המחלקה
        public Rents(int id)
        {
            RentsTable rents = new RentsTable();
            drow = rents.Find(id);
            FillFields();
        }
        #endregion
    }
}
