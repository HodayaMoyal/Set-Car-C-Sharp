using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class EmployeesTable : GeneralTable
    {
        //פעולה בונה שלוחת לפעולה בונה של מחלקת הבסיס
        public EmployeesTable() : base("Employees", "EmployeeId")
        {
            //לולאה שמעבירה את הנתונים מהטבלה לתוך האוסף
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Employees(item));
            }
        }

        //פעולה שמחזירה את האוסף
        public List<Employees> GetList()
        {
            return base.list.Cast<Employees>().ToList();
        }
    }
}
