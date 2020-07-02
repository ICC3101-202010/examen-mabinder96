using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public class Team
    {
        private string name; //Si es nacional el nombre será la nación
        private bool type; // true== nacional; false== liga
        private List<Player> players = new List<Player>();
        private Coach coach;
        private Doctor doctor;
        private List<Player> playing = new List<Player>();

        public Team(string name, bool type, List<Player> players, Coach coach, Doctor doctor)
        {
            this.Name = name;
            this.Type = type;
            this.Players = players;
            this.Coach = coach;
            this.Doctor = doctor;
        }

        public string Name { get => name; set => name = value; }
        public bool Type { get => type; set => type = value; }
        public List<Player> Players { get => players; set => players = value; }
        public List<Player> Playing { get => playing; set => playing = value; }
        public Coach Coach { get => coach; set => coach = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }

        public bool CheckNationality(Team currentTeam)
        {
            if (currentTeam.type == true)
            {
                int count = 0;
                foreach (Player p in currentTeam.players)
                {
                    if (p.Nation != name)
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
            
        }
        public string GetInformation (Team currentTeam)
        {
            string tt;
            if (type == false)
            {
                tt = "Liga";
            }
            else
            {
                tt = "Nacional";
            }
            return $"Team name: {name}\nTeam type: {tt}\nTeam coach: {coach.Name} {coach.Lastname}\nTeam doctor: {doctor.Name} {doctor.Lastname}";
        }

        public void AddPlayer(Player player)
        {
            if (type == true)
            {
                if (player.Nation == name)
                {
                    players.Add(player);
                }
                else
                {
                    Console.WriteLine("No se ha podido agregar a su jugador, ya que no es de la nación del equipo.");
                }
            }
            else
            {
                players.Add(player);
            }
        }
    }
}
