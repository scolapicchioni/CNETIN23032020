using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2 {
    class Employee : Person {
        public Employee() : base(0,""){
            Console.WriteLine("default employee");
        }

        public Employee(int id, string name, decimal salary) : base(id, name) {
            
            Salary = salary;
        }
        public decimal Salary { get; set; }
        public void Work() {
            Console.WriteLine("Employee working");
        }

        public override string SayHi() => $"Hi I'm a Employee and my name is {Name} and my salary is {Salary}";
    }
}
