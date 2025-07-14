using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class ManagerTable : GeneralTable
    {
        //פעולה בונה שלוחת לפעולה בונה של מחלקת הבסיס
        public ManagerTable() : base("Manager", "managerId")
        {
            //לולאה שמעבירה את הנתונים מהטבלה לתוך האוסף
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Manager(item));
            }
        }

        //פעולה שמחזירה את האוסף
        public List<Manager> GetList()
        {
            return base.list.Cast<Manager>().ToList();
        }
    }
}
