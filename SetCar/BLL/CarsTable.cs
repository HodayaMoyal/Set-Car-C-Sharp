using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class CarsTable : GeneralTable
    {
        //פעולה בונה שלוחת לפעולה בונה של מחלקת הבסיס
        public CarsTable() : base("Cars", "carId")
        {
            //לולאה שמעבירה את הנתונים מהטבלה לתוך האוסף
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Cars(item));
            }
        }

        //פעולה שמחזירה את האוסף
        public List<Cars> GetList()
        {
            return base.list.Cast<Cars>().ToList();
        }
    }
}

