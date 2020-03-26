using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    public interface IInterface1 {
        private static string staticVariable = "private static interface variable";
        void Bla(string s);
        private void somePrivateMethod() {
            Console.WriteLine("private interface method");
        }
        public void InterfaceMethod01() {
            somePrivateMethod();
            Console.WriteLine("InterfaceMethod01 of the interface");
        }
        //private int x; no can do

        //this needs to be implemented by the class
        //public int MyProperty { get; set; }

        protected void ProtectedInterfaceMethod() {
            Console.WriteLine("Critical Command Sent via Interface");
        }

        public virtual void VirtualInterfaceMethod() {
            Console.WriteLine("Command Sent via Interface");
        }
    }

    public interface IInterface2 : IInterface1 {
        public void Stuff() {
            this.ProtectedInterfaceMethod();
        }
    }
}
