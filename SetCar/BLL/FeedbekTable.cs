using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class FeedbekTable : GeneralTable
    {
        //פעולה בונה שלוחת לפעולה בונה של מחלקת הבסיס
        public FeedbekTable() : base("Feedbek", "FeedbekId")
        {
            //לולאה שמעבירה את הנתונים מהטבלה לתוך האוסף
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Feedbek(item));
            }
        }

        //פעולה שמחזירה את האוסף
        public List<Feedbek> GetList()
        {
            return base.list.Cast<Feedbek>().ToList();
        }
    }
}
