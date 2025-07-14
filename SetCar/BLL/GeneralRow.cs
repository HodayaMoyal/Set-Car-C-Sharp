using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public abstract class GeneralRow
    {
        #region מאפיינים
        //שורה בטבלה
        protected DataRow drow;
        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        #endregion

        //פעולה המעבירה את נתוני הרשומה לתכונות המופע משמשת לשליפה
        public abstract void FillFields();

        //פעולה המעבירה את תכונות המופע לנתוני הרשומה משמשת לעדכון
        public abstract void FillDataRow();
    }
}
