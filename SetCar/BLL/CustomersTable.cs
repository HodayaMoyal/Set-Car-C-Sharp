using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class CustomersTable : GeneralTable
    {
        //פעולה בונה שלוחת לפעולה בונה של מחלקת הבסיס
        public CustomersTable() : base("Customers", "customerId")
        {
            //לולאה שמעבירה את הנתונים מהטבלה לתוך האוסף
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Customers(item));
            }
        }

        //פעולה שמחזירה את האוסף
        public List<Customers> GetList()
        {
            return base.list.Cast<Customers>().ToList();
        }
    }
}
