using System;

namespace FactoryExercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"My name is {Name} and my ID is {Id}.";
        }
    }

    public class PersonFactory
    {
        private int PeopleCreated;
        public PersonFactory()
        {
            this.PeopleCreated = 0;
        }

        public Person CreatePerson(string personName)
        {
            var person =  new Person { Id = this.PeopleCreated, Name = personName };
            this.PeopleCreated++;
            return person;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var pf = new PersonFactory();
            var jack = pf.CreatePerson("Jack");
            var jill = pf.CreatePerson("Jill");
            Console.WriteLine(jack);
            Console.WriteLine(jill);
        }
    }
}
