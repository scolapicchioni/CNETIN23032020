using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            //Person p1 = new Person() { Name = "Mario"};
            //p1.Id = 2;

            //p1.SayHi();

            //Person p1 = new Person(1, "aa");
            //Employee ee = new Employee()
            Employee e1 = new Employee(3, "aa",123);
            //e1.Id = 3;

            //e1.Salary = 123M;

            //e1.SayHi();

            Student s = new Student();
            s.SayHi();

            //Printperson(p1);

           // Printperson(e1);


            //Person p = new Employee();

        }

        static void Printperson(Person p) {

            p.SayHi();


            Console.WriteLine(p.Name + " " + p.Id );

            //Employee employee = (Employee)p;

            if (p is Employee) {
                Employee employee = (Employee)p;
                Console.WriteLine(employee.Salary); 
            }

            Employee employee1 = p as Employee;
            if (employee1 != null) {
                Console.WriteLine(employee1.Salary);
            }

            Console.WriteLine(employee1?.Salary);

            string x = employee1?.Name ?? "No employee";
        }
    }
}
