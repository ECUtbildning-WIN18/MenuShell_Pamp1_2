using System;

namespace MenuShell1_2.Domain.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string TypeOfAnimal { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public Owner Owner { get; set; }

        public Animal()
        {

        }

        public Animal(string typeOfAnimal, string name, DateTime dob, Owner owner)
        {
            TypeOfAnimal = typeOfAnimal;
            Name = name;
            Dob = dob;
            Owner = owner;
        }
    }
}