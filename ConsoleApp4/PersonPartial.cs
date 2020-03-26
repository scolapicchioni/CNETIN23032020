using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4 {
    public partial class Person {
        public string Name { get; set; } //<Name>Mario</Name>

        partial void DoStuff();

        public void ActualMethod() {
            DoStuff();
        }
    }
}
