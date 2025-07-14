using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SetCar.BLL
{
    public class Tkinut
    {
        //בדיקת תעודת זהות
        public static bool LegalId(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int k = ((i % 2) + 1) * (Convert.ToInt32(s[i]) - '0');
                if (k > 9)
                    k -= 9;
                sum += k;
            }
            return sum % 10 == 0;
        }
        //בדיקת טלפון
        public static bool IsTelephone(string tel)
        {
            string pattern = @"\b0[ 2 4 7 8 3 77]-[2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }
        //בדיקת פלאפון
        //public static bool IsCellPhone(string tel)
        //{
        //    string pattern = @"\b05[0 2 4 6 7 8 3]-[2-9]\d{6}$";
        //    Regex reg = new Regex(pattern);
        //    return reg.IsMatch(tel);
        //}
        //בדיקת מייל
        public static bool CheackMail(string t)
        {
            if (t.Length == 0)
                return true;
            else
            if ((t.IndexOf("@") == -1) || (t.IndexOf(".") == -1))
                return false;
            else
                return true;
        }
    }
}
