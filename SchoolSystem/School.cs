using System;
using System.Collections.Generic;

namespace SchoolSystem {
    public class School {
        public Dictionary<string, Course> Courses { get; } = new Dictionary<string, Course>();
        public Course CreateCourse(string name) {
            //same logic as your lab
            return new Course();
        }
    }
}
