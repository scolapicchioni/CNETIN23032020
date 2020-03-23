using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    enum ItalianDays {
        Lunedi, Martedi, Mercoledi
    }

    class Person {
        public int Id;
        public string Name;
        public string Surname;
        public ItalianDays FavoriteDay;

        //Id = id;
        //Name = name;
        //Surname = surname;

        public Person(int id, string name, string surname) => (Id, Name, Surname) = (id, name, surname);


        //string result = "hi, my name is " + Name + " and my surname is " + Surname;

        //result = string.Format("hi, my name is {0} and my surname is {1}",Name,Surname) ;

        //result = $"hi, my name is {Name} and my surname is {Surname}";

        //Console.WriteLine("hi, my name is {0} and my surname is {1}", Name, Surname);


        public void DoSomething() => Console.WriteLine($"hi, my name is {Name} and my surname is {Surname}");
    }
}
