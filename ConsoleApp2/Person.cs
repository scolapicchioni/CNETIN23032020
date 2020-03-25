using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2 {
    public abstract class Person {
        //public Person() {
        //    Console.WriteLine("default person");
        //}

        public Person(int id, string name) {
            this.id = id;
            Name = name;
        }

        protected int id;
        public int Id { get { return id; } }
        public string Name { get; set; }
        //public virtual string SayHi() => $"Hi I'm a Person and my name is {Name}";

        public abstract string SayHi(); // => $"Hi I'm a Person and my name is {Name}";

        public void DoSomething() {
            Console.WriteLine("doing stuff");
        }
    }
}
