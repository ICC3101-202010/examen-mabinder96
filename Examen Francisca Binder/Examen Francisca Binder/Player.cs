using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public class Player:Person,IPlay
    {
        private int attack_points;
        private int defense_points;
        private int shirt_number;
        private bool goalkeeper;

        public Player(int attack_points, int defense_points, int shirt_number, bool goalkeeper, string name, string lastname, int age, string nation, int salary)
        {
            this.Attack_points = attack_points;
            this.Defense_points = defense_points;
            this.Shirt_number = shirt_number;
            this.Goalkeeper = goalkeeper;
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Nation = nation;
            this.Salary = salary;
        }
        public Player()
        {

        }

        public int Attack_points { get => attack_points; set => attack_points = value; }
        public int Defense_points { get => defense_points; set => defense_points = value; }
        public int Shirt_number { get => shirt_number; set => shirt_number = value; }
        public bool Goalkeeper { get => goalkeeper; set => goalkeeper = value; }

        //Creo el evento Injure
        public delegate void InjureHandler(object source, InjureEventsArgs args);
        public event InjureHandler Injure;
        protected virtual void OnInjure(Player player, Coach coach, Team team)
        {
            // Verifica si hay alguien suscrito al evento
            if (Injure != null)
            {
                // Engatilla el evento
                Injure(this, new InjureEventsArgs() {P= player, C=coach, T=team});
            }
        }

        public void InjureStarter(Coach mycoach, Team myTeam)
        {
            OnInjure(this, mycoach, myTeam);
        }

        public void Attack(int points)
        {
            this.attack_points -= points;
        }

        public void Defense(int points)
        {
            this.defense_points-= points;
        }
    }
}
