using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;


namespace ConsoleApp4 {
     [XmlRoot("person")]
     public partial class Person { //<person id="5">
        [XmlAttribute("id")]
        [Range(1,1000)]
        public int Id { get; set; } 
        partial void DoStuff() {
            Console.WriteLine("Doing stuff");
        }
    }// </person>
}
