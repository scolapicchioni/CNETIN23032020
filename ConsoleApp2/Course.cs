using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2 {
    class Course {
        private static Course course = null;
        public static Course CreateCourse() {
            if (course == null) {
                course = new Course();
            }
            return course;
        }
        private Course() {

        }
    }
}
