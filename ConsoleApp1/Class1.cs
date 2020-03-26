using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    class Class1 : IInterface1 {
        public void Bla(string s) {
            Console.WriteLine("Bla from Class1");
        }
        public void InterfaceMethod01() {
            Console.WriteLine("InterfaceMethod01 of the class");
        }
        
    }
}
