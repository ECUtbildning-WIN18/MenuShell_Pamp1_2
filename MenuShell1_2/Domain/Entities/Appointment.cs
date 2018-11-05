using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell1_2.Domain.Entities
{
    class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Owner Owner { get; set; }
        public Animal Animal { get; set; }
        public string Problem { get; set; }


        public Appointment()
        {

        }
        public Appointment(DateTime appointmentDate, Owner owner, Animal animal, string problem)
        {
            AppointmentDate = appointmentDate;
            Owner = owner;
            Animal = animal;
            Problem = problem;
        }
    }
}
