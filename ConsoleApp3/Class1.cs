using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3 {
    class Class1 : IInterface01, IInterfaceWithMethod01 {
        public int MyProperty { get ; set; }
        int IInterface01.MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void Method01() {
        //    Console.WriteLine("Metho01 of Class1");
        //}

        //public int Method02(string a, int b) {
        //    return 5;
        //}

        public void ActualInterfaceMethod() {
            Console.WriteLine("This is th method implemented in the class");
        }

        public void MyMethod() { 
            
        }

        void IInterface01.ActualInterfaceMethod() {
            throw new NotImplementedException();
        }

        void IInterface01.Method01() {
            throw new NotImplementedException();
        }

        void IInterfaceWithMethod01.Method01() {
            throw new NotImplementedException();
        }

        int IInterface01.Method02(string a, int b) {
            throw new NotImplementedException();
        }
    }
}
