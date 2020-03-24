using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2_OO {
    class Person {
        //default
        public Person() : this(string.Empty, string.Empty, false)
        {
            
            //name = string.Empty;
            //Surname = string.Empty;
        }

        public Person(string name, string surname, bool children) {
            this.name = name;
            Surname = surname;
            Children = children;
            //HomeAddress = new Address();
            //WorkAddress = new Address();
            this.Addresses[0] = new Address();
            this.Addresses[1] = new Address();
        }

        ~Person() { 
            
        }

        //fields
        //int id;

        public int Id { get; private set; }

        //getter
        public string getName() {
            return name;
        }

        //setter
        public void setName(string bla) {
            //if()
            name = bla;
        }

        //backing field
        string name;
        //property
        public string Name 
        {
            get 
            {
                return name;
            }
            set 
            {
                //if()
                name = value;
            }
        }

        public string Surname { get; set; }

        private bool children;

        public bool Children {
            get { return children; }
            set { children = value; }
        }

        private string SayHi() {
            return $"Hi my name is {this.Name} and my surname is {Surname}";
        }

        public void Bla() {
            SayHi();
        }

        //public Address HomeAddress { get; set; } = new Address();
        //public Address WorkAddress { get; set; }
        public List<Address> Addresses = new List<Address>();
    }
}
