using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3 {
    public interface IInterface01 {
        void Method01();
        int Method02(string a, int b);
        int MyProperty { get; set; }

        public void ActualInterfaceMethod() {
            Console.WriteLine($"This is the method implemented in the interface {IInterface01.x}");
        }
        private static int x;
        public static void SetX(int newValue) {
            x = newValue;
        }

        protected void protectedMethod() {
            Console.WriteLine("stuff");
        }
    }

    public interface IInterface2 : IInterface01 {
        public void IInterface2Method() {
            this.protectedMethod();
        }
    }
}
