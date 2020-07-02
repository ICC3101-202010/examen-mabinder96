using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public class Match
    {
        
        private string team_1;
        private string team_2;
        private int minutes;
        private string results;
        private bool type; // true== nacional; false== liga

        public Match()
        {
        }

        public string Team_1 { get => team_1; set => team_1 = value; }
        public string Team_2 { get => team_2; set => team_2 = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public string Results { get => results; set => results = value; }
        public bool Type { get => type; set => type = value; }

        public void OnInjure(object source, InjureEventsArgs v)
        {
            Console.WriteLine($"Se ha lesionado el jugador {v.P.Name}");
            v.C.Change_Player(v.P,v.T);
        }


    }
}
