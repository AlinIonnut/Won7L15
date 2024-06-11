using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Won7L15
{
    internal class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Specialization Specialization { get; set; }

        public Student(Guid id, string name, string firstName, int age, Specialization specialization)
        {
            Id = Guid.NewGuid();
            Name = name;
            FirstName = firstName;
            Age = age;
            Specialization = specialization;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nFirstName: {FirstName}\nAge: {Age}\nSpecialization: {Specialization}\n";
        }
    }
}
