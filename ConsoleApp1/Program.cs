using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1 {
    class Program {

        static int a;

        void M08() {
            //int a;
            //Program.a
        }

        static int MyMethod09(string input) => input.Length * 2;

        static void Main(string[] args) {

            int[] numbers = new int[] {1,6,3,7,0,3,2,5,2,5 };
            int[] numbers2 = new int[10] ;
            numbers[4] = 44;

            int[,] matrix = new int[10, 5];
            matrix[4, 3] = 55;

            int[,] m2 = new int[3,3] {
                { 2,6,4 },
                { 9,2,5 },
                { 3,5,9 }
            };

            int[,,] cube = new int[10, 5, 4];

            Person[] people = new Person[10]; //null, null, null....
            people[0] = new Person(1,"aa","rfr");

            //matrix.GetLength(0)

            numbers2 = numbers;

            Array.Sort(numbers);
            Array.Sort(people);

            int length = int.Parse(Console.ReadLine());

            numbers = new int[length];

            int sum = 0;
            foreach (var item in numbers) {
                sum += item;
            }

            //numbers[1..4]

            //List<int> list = new List<int>();
            //list.
        }

        static string[] MethodWithArray01(int[] nums) {
            string[] result = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++) {
                result[i] = nums[i].ToString();
            }
            return result;
        }


        private static void NewMethod07() {
            int length = MyMethod09("sdfsdfsd");
            M01(4);
            M01();
            M01(x: "sddd", p1: 44);
            M01(x: "fhedhfsw");

            M02(34, 6, 9, 3, 2);

            int a = 5;
            M03(ref a);

            M04(out a);

            SayHi("5");

            //SayHi(city: "aa", times: 3);
            Console.WriteLine(a);

            int r1 = M05();

            int b;
            (a, _) = M06();
            //_ = M05();
            (a, _, _) = M07();
            var res = M07();
        }

        static void SayHi() { }
        static void SayHi(string who) {

            void MyFunction(int x, int y) {

            }

            MyFunction(5, 4);

        }
        //static void SayHi(string city) { }
        static void SayHi(int times) { }

        static void SayHi(string city, int times) { }
        static void SayHi(int times, string city) { }

        static int M05() {
            return 5;
        }

        static (int, int) M06() {
            return (5,6);
        }

        static (int first, string second, int third) M07() { //tuple
            return (5, "6",7);
        }

        static void M03(ref int x) {
            x++;
        }

        static void M04(out int x) {
            x=5;
        }

        static void M02(params int[] numbers) {

        }

        static void M01(int p1 = 5 , string x = "") { 
        
        }

        private static void Ex02() {
            int a = 5;

            switch (a) {
                case 1:
                    Console.WriteLine("a is 1!");
                    Console.WriteLine("a is 1!");
                    Console.WriteLine("a is 1!");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("a is 2 or 3");
                    break;
                default:
                    Console.WriteLine("other that 1 2 or 3");
                    break;
            }

            string result = a switch
            {
                1 => "a is 1!",
                2 => "a is 2!",
                _ => "a is neither 1 nor 2"
            };

            do {

            } while (a < 5);

            while (a < 5) {


            }

            //for (int i = 0; i < length; i++) {

            //}

            foreach (char letter in "abcde") {
                Console.WriteLine(letter);
            }

            string x = "";

            //for (int i = 0; i < length; i++) {
            //    for (int bla = 0; bla < 10; bla++) {
            //        break;
            //    }
            //    //here
            //    goto MyExitPoint;
            //}

            //MyExitPoint:

            try {
                DoYourThing(22);
            } catch (SqlException ex) {
                Console.WriteLine($"sorry, we had a problem....{ex.Message}");
            } catch (Exception) {

            } finally {

            }
            Console.WriteLine("we're here!");
        }

        static void DoYourThing(int parameter) {
            if (parameter < 1 || parameter > 10) {
                throw new ArgumentException("The parameter is not ok!");
            }

            try {
                //open the file
            } catch (IOException ex ) when (ex.HResult == -3) { 
                //log the exception
                Console.WriteLine(ex.Message);
                throw;
            } catch (IOException ex) when (ex.HResult == -8) { 
                //log the exception
                Console.WriteLine(ex.Message);
                throw;
            }

    Console.WriteLine("I like parameter!");
        }

        private static void M01() {
            //type name;
            //name = expression;

            //type name = expression;

            //value types ==> struct, enum
            //reference types ==> class, arrays, delegates

            int? a = 5; //inline memory

            //a = null;

            string s1 = null;

            //Nullable<int> a2 = 5;


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
