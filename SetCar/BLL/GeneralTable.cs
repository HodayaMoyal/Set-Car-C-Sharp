using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public abstract class GeneralTable
    {
        //DAL בניית משתנה מסוג
        protected static DAL.DAL dal = new DAL.DAL();
        //הגדרת משתנה מסוג טבלה
        protected DataTable table;
        protected string tableName;
        protected string key;

        protected List<GeneralRow> list;

        //הוספת טבלה
        public GeneralTable(string tableName, string key)
        {
            DAL.DAL.AddTable(tableName, key);

            this.table = DAL.DAL.GetTable(tableName);
            this.tableName = tableName;
            this.key = key;
            list = new List<GeneralRow>();

        }

        //מחזירה את הטבלה
        public DataTable GetDataTable()
        {
            return this.table;
        }

        //מחזירה את המפתח הראשי
        public string GetPrimaryKey()
        {
            return this.key;
        }

        //בודקת אם הטבלה ריקה
        public bool IsEmpty()
        {
            if (table.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        //מוצאת את האוביקט בטבלה לפי השדה שמתקבל
        public DataRow Find(string fieldname, object value)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[fieldname].Equals(value))
                {
                    return row;
                }

            }
            return null;
        }

        //מוצאת את האוביקט בטבלה לפי המפתח
        public DataRow Find(object value)
        {
            return Find(this.key, value);
        }

        //שומרת את השינויים
        public void Save()
        {
            try
            {
                DAL.DAL.Update(table.TableName);
            }

            catch (Exception e)
            {
                throw;
            }
        }

        //מחזירה את השורה הבאה
        public DataRow GetNewRow()
        {
            return table.NewRow();
        }

        //מוסיפה את הרשומה לטבלה
        public void AddRow(DataRow dr)
        {
            table.Rows.Add(dr);
            Save();
        }

        //מחזירה את מספר המפתח הבא
        public int GetNewKey()
        {
            if (table.Rows.Count == 0)
                return 1;
            return Convert.ToInt32(table.Rows[table.Rows.Count - 1][key]) + 1;
        }

        //מוסיפה את הרשומה
        public void Add(GeneralRow item)
        {
            list.Add(item);
            item.Drow = table.NewRow();
            item.FillDataRow();
            table.Rows.Add(item.Drow);
            Save();
        }
        //מעדכנת את הרשומה
        public void Update(GeneralRow item)
        {
            item.FillDataRow();
            Save();
        }
        public  DataTable GetDisplayTable(string sqlstring)
        {
           
            return DAL.DAL.GetDisplayTable(sqlstring);
        }

        //מוחקת את הרשומה
        public void Delete(GeneralRow item)
        {
            list.Remove(item);
            item.Drow.Delete();
            Save();
        }
    }
}
