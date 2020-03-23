using System;
using System.Drawing;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            //type name;
            //name = expression;

            //type name = expression;

            //value types ==> struct, enum
            //reference types ==> class, arrays, delegates

            int a =5; //inline memory

            long l = long.MaxValue;

            a = (int)l;

            //bool b = (bool)a;

            //bool b = 1;


            a = 3;

            a = 5;
            int b = 10;

            b = a++;

            b = ++a;

            b = a > 5 ? 10 : 20;

            char c1 = 'a';
            //c1 = "c";


            //string s1 = 'asdg';
            
            string s1 = "asdg"; //

            s1 = s1 + "aa"; //asdgaa

            StringBuilder builder = new StringBuilder();

            builder.Append("aa");
            builder.Append("aa");
            builder.Append("aa");

            string s2 = builder.ToString();

            s2.Trim();

            s1 = a.ToString();

            s1 = "5";

            if (int.TryParse(s1, out a)) { 
                
            }
            
            //enum

            Method02();

            Point p = new Point(3, 4);

            Console.BackgroundColor = ConsoleColor.Yellow;

            ItalianDays day = ItalianDays.Lunedi;

            ItalianDays day2 = day;

            day = ItalianDays.Martedi;


            int d = (int)day;

            Console.WriteLine(day);

            Person simo;
            simo.Id = 5;
            simo.Name = "Simona";
            simo.Surname = "Colapicchioni";
            simo.FavoriteDay = ItalianDays.Mercoledi;

            simo.DoSomething();

            Console.WriteLine("What's the id?");

            simo.Id = int.Parse(Console.ReadLine());


        }

        static void Method02() {
            int a = 5; 
        }
    }

    
}
