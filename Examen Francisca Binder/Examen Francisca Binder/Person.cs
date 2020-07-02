using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public abstract class Person
    {
        protected string name;
        protected string lastname;
        protected int age;
        protected string nation;
        protected int salary;

        public string Nation { get => nation; set => nation = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
    }
}
