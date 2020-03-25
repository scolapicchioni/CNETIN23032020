using SchoolSystem;
using System;

namespace ConsoleApp_School {
    class Program {
        static void Main(string[] args) {
            Course c;
            //c = new Course();

            School school = new School();
            c = school.CreateCourse("bla");

            //Clean Code - Rober Martin
            //S.O.L.I.D. ARCHITECTURE
        }
    }
}
