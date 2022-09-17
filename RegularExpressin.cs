using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using System.Text.RegularExpressions;
using System.Globalization;
namespace PenaltiesAccounting
{
    static public class RegularExpressin
    {
        public static  string? UserPattern;
        public static string? AgencyPattern;
        public static string? PasswordPatern;
        public static string? EmailPattern;
        public static string? CarNumber;
        static RegularExpressin()
        {
            UserPattern = @"[0-9]{10}";
            AgencyPattern= @"[А-Я]{2}-[0-9]{6}";
            PasswordPatern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$";
            EmailPattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$"; ;
            CarNumber = @"[А-Я]{2}-[0-9]{6}[А-Я]-{2}$";
        }
    }
}
