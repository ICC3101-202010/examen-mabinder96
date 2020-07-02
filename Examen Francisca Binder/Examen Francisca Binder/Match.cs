using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public static class Match
    {
        
        private static Team team_1;
        private static Team team_2;
        private static int minutes;
        private static string results;
        private static bool type; // true== nacional; false== liga

        private static Team Team_1 { get => team_1; set => team_1 = value; }
        private static Team Team_2 { get => team_2; set => team_2 = value; }
        private static int Minutes { get => minutes; set => minutes = value; }
        private static string Results { get => results; set => results = value; }
        private static bool Type { get => type; set => type = value; }

        private static void OnInjure(object source, InjureEventsArgs v)
        {
            Console.WriteLine($"Se ha lesionado el jugador {v.P.Name}");
            v.C.Change_Player(v.P, v.T);
        }


    }
}
