using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesEOperacoesComDateTime {
    class Program {
        static void Main(string[] args) {

            /*
             * Propriedades
             * 
                • Date (DateTime)
                • Day (int)
                • DayOfWeek (DayOfWeek)
                • DayOfYear (int)
                • Hour (int)
                • Kind (DateTimeKind)
                • Millisecond (int)
                • Minute (int)
                • Month (int)
                • Second (int)
                • Ticks (long)
                • TimeOfDay (TimeSpan)
                • Year (int)
            */

            //Demo
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine("-----------------------Propriedades--------------------------");
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("--------------------------------------------------------------");



            //Formatação(DateTime-> string)
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine("-----------------------Formatação-----------------------------");
            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();
            string s5 = d1.ToString();
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine("--------------------------------------------------------------");

            /*Operações com Datetime
            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime y = x.Add(timeSpan);
            DateTime y1 = x.AddDays(double);
            DateTime y2 = x.AddHours(double);
            DateTime y3 = x.AddMilliseconds(double);
            DateTime y4 = x.AddMinutes(double);
            DateTime y5 = x.AddMonths(int);
            DateTime y6 = x.AddSeconds(double);
            DateTime y7 = x.AddTicks(long);
            DateTime y8 = x.AddYears(int);
            DateTime y9 = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);,
            */

        }
    }
}
