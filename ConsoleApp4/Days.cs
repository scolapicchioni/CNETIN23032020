using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4 {
    public class Days {
        private string[] days = new string[] {"Lunedi", "Martedi", "Mercoledi" };

        

        public string this[int index] {
            //string day1 = days[0];
            get {
                return days[index];
            }
            //days[3] = "Giovedi";
            //set {
            //    days[index] = value;
            //}
        }

        public string this[string key] {
            //string day1 = days[0];
            get {
                return days.FirstOrDefault(x => x == key);
            }
            //days[3] = "Giovedi";
            //set {
            //    days[index] = value;
            //}
        }

    }
}
