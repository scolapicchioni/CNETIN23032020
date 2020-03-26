using System;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {
            Class1 c1 = new Class1();
            IInterface01 c2 = new Class1();
            c2.ActualInterfaceMethod();

            ((IInterface01)c1).ActualInterfaceMethod();
            ((IInterface01)c1).Method01();
            ((IInterfaceWithMethod01)c1).Method01();
            c1.ActualInterfaceMethod();

            M01(c1);
            M01(c2);
            Console.ReadLine();
        }

        static void M01(IInterface01 param1) {
            param1.Method01();
            int x = param1.Method02("a", 5);
            param1.ActualInterfaceMethod();
            param1.Method01();
        }


    }
}
