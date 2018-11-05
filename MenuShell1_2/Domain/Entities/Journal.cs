using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell1_2.Domain.Entities
{
    class Journal
    {
        public int Id { get; set; }
        public Owner Owner { get; set; }
        public Animal Animal { get; set; }
        public string Ailment { get; set; }

        public Journal()
        {

        }

        public Journal(Owner owner, Animal animal, string ailment)
        {
            Owner = owner;
            Animal = animal;
            Ailment = ailment;
        }
        public override string ToString()
        {
            return $"{Owner.FirstName} {Owner.LastName} {Animal.Name} {Ailment}";
        }
    }
}
