using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class Cars : GeneralRow
    {
        #region מאפיינים
        private int carId;

        public int CarId
        {
            get { return carId; }
            set
            {
      
                carId = value;
            }
        }
        private string carName;

        public string CarName
        {
            get { return carName; }
            set
            {
                if (value == "")
                    throw new Exception("שדה חובה");
                carName = value;
            }
        }
        private int numOfSeats;

        public int NumOfSeats
        {
            get { return numOfSeats; }
            set
            {
                numOfSeats = value;
            }
        }
        private string yearOfManufacture;

        public string YearOfManufacture
        {
            get { return yearOfManufacture; }
            set
            {
                yearOfManufacture = value;
            }
        }
        private string kind;

        public string Kind
        {
            get { return kind; }
            set
            {
                kind = value;
            }
        }
        private int payForDay;

        public int PayForDay
        {
            get { return payForDay; }
            set
            {
                payForDay = value;
            }
        }
        #endregion

        //פעולה המעבירה את נתוני הרשומה לתכונות המופע משמשת לשליפה
        //משורה לאוביקט
        public override void FillFields()
        {
            this.carId = Convert.ToInt32(drow["carId"]);
            this.carName = Convert.ToString(drow["carName"]);
            this.numOfSeats = Convert.ToInt32(drow["numOfSeats"]);
            this.yearOfManufacture = Convert.ToString(drow["yearOfManufacture"]);
            this.kind = Convert.ToString(drow["kind"]);
            this.payForDay = Convert.ToInt32(drow["payForDay"]);
        }

        //פעולה המעבירה את תכונות המופע לנתוני הרשומה משמשת לעדכון
        //מאוביקט לשורה
        public override void FillDataRow()
        {
            drow["carId"] = this.carId;
            drow["carName"] = this.carName;
            drow["numOfSeats"] = this.numOfSeats;
            drow["yearOfManufacture"] = this.yearOfManufacture;
            drow["kind"] = this.kind;
            drow["payForDay"] = this.payForDay;
        }

        //פעולה בונה להוספת חדש
        #region פעולות בונות
        public Cars()
        {
        }

        //פעולה בונה המקבלת רשומה וממירה את נתוני הרשומה למופע המחלקה משמשת לניווט
        public Cars(DataRow dr)
        {
            drow = dr;
            FillFields();
        }

        //פעולה בונה המקבלת מפתח ראשי של טבלה וממירה את נתוני הרשומה למופע המחלקה
        public Cars(int  id)
        {
            CarsTable cars = new CarsTable();
            drow = cars.Find(id);
            FillFields();
        }
        #endregion;
    }
}
