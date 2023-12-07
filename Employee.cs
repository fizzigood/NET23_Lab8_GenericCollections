using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET23_Lab8_AmieM
{
    //Klass med de egenskaper som uppgiften efterfrågar:
    internal class Employee 
    {
        public int Id { get; }
        public string Name { get; }
        public string Gender { get; }
        public int Salary { get; }

        public Employee(int id, string name, string gender, int salary) //Constructor som tvingar alla instanser av Employee att ha samma egenskaper/properties.
        {
            Id = id;                                                   //Berättar för datorn att constructorns publika egenskaper/properties är samma som klassens privata.
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
