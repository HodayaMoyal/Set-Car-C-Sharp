using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetCar.DAL
{
    public class DAL
    {
        private static SqlConnection con;
        private static DataSet ds;

        //פעולה בונה
        public DAL()
        {
            string path = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SETCAR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
           // string path = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=SetCar;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(path);
            ds = new DataSet();
        }

        //פעולה שמוסיפה את הטבלה מתוך הפרויקט   SQLב     
        public static void AddTable(string tableName, string Keyname)
        {
            if (!ds.Tables.Contains(tableName))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from " + tableName + " order by " + Keyname, con);
                adapter.Fill(ds, tableName);
            }
        }

        //אם רוצים טבלה מסוימת לתוך הפרויקט
        public static DataTable GetTable(string tableName)
        {
            if (ds.Tables.Contains(tableName))
                return ds.Tables[tableName];
            else
                return null;
        }

        //פעולה שמביאה לנו רק חלק מהטבלה שאנחנו רוצים
        public static DataTable GetDisplayTable(string sqlstring)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlstring, con);
            adapter.Fill(dt);
            return dt;
        }

        //פעולה שמעדכנת את הטבלה הרצויה שעשינו בה שינויים בתוך הדטבייס
        public static void Update(string tableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from " + tableName, con);
           SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(ds, tableName);
        }
    }
}
