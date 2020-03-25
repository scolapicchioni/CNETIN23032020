using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2 {
    class Student : Person {
        public Student() : base(0,"") {

        }

        public override string SayHi() {
            return "Student!!";
        }
    }
}
