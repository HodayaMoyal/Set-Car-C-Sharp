using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class RentsTable : GeneralTable
    {
        //פעולה בונה שלוחת לפעולה בונה של מחלקת הבסיס
        public RentsTable() : base("Rents", "RentCode")
        {
            //לולאה שמעבירה את הנתונים מהטבלה לתוך האוסף
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Rents(item));
            }
        }

        //פעולה שמחזירה את האוסף
        public List<Rents> GetList()
        {
            return base.list.Cast<Rents>().ToList();
        }
    }
}
