using System;
using System.IO;

namespace ConsoleApp2_OO {
    class Program {
        static void Main(string[] args) {
            Person p = new Person();

            //p.Name = "aaa";
            Console.WriteLine(p.Name.Length);

            //Console.WriteLine(p.SayHi()); 

            Person p2 = new Person("Mario", "Super", false);

            //StreamWriter stream = null;
            //try {
            //    stream = new StreamWriter();
            //} finally {
            //    stream.Dispose();
            //}

            Console.WriteLine(p.Addresses[0].StreetName);

            Console.ReadLine();
        }

        static void Swap(ref int a, ref int b) => (b, a) = (a, b);
    }
}
