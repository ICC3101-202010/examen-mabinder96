using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public class Doctor: Person
    {
        private int experience_points;

        public Doctor(int experience_points, string name, string lastname, int age, string nation, int salary)
        {
            this.Experience_points = experience_points;
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Nation = nation;
            this.Salary = salary;
        }

        public int Experience_points { get => experience_points; set => experience_points = value; }

        public void Evaluate(Player p)
        {
            Console.WriteLine($"Evaluando al jugador {p.Name} {p.Lastname}");
        }
        public void Cure(Player p)
        {
            Console.WriteLine($"Curando al jugador {p.Name} {p.Lastname}");
        }
    }
}
