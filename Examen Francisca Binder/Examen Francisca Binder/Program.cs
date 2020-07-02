using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;

namespace Examen_Francisca_Binder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            
            /*Solo por si se quiere usar el evento
            Match match = new Match();
            Player player = new Player();
            player.Injure += match.OnInjure;*/

            string switcher = "0";
            string stopper = "3";

            while (switcher != stopper)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a Fifa! \nPorfavor seleccione lo que desee hacer");
                Console.WriteLine("Si desea:\n\t(1)Crear equipo\n\t(2)Ver la información de los equipos\n\t(3)Salir del programa\n");
                switcher = Console.ReadLine();
                Console.Clear();
                switch (switcher)
                {
                    case "1": //Crear equipo
                        Console.WriteLine("Primero ingrese los datos del equipo");
                        Console.WriteLine("Ingrese: \n\t(1)Equipo es de la selección nacional\n\t(Otro)Equipo de la liga");
                        string optionteamtype = Console.ReadLine();
                        bool team_type;
                        string team_name="";
                        List<Player> players = new List<Player>();
                        if (optionteamtype == "1")
                        {
                            team_type = true;
                            Console.WriteLine("Ingrese la nación de su equipo: ");
                            int cn = 0;
                            while (cn == 0)
                            {
                                int cnn = 0;
                                team_name = Console.ReadLine();
                                foreach (Team t in teams)
                                {
                                    if (t.Name == team_name)
                                    {
                                        cnn++;
                                    }
                                }
                                if (cnn != 0)
                                {
                                    Console.WriteLine("Esa nación ya existe. Por favor seleccione otra.");
                                }
                                else
                                {
                                    cn = 1;
                                }

                            }
                        }
                        else
                        {
                            team_type = false;
                            Console.WriteLine("Ingrese el nombre de su equipo: ");
                            int cn = 0;
                            while (cn == 0)
                            {
                                int cnn = 0;
                                team_name = Console.ReadLine();
                                foreach(Team t in teams)
                                {
                                    if (t.Name == team_name)
                                    {
                                        cnn++;
                                    }
                                }
                                if (cnn != 0)
                                {
                                    Console.WriteLine("Ese nombre ya existe. Por favor seleccione otro.");
                                }
                                else
                                {
                                    cn = 1;
                                }

                            }
                            
                        }
                        Console.Clear();
                        Console.WriteLine("Ahora ingrese los datos del DT");
                        Console.WriteLine("\tIngrese su nombre: ");
                        string dtname = Console.ReadLine();
                        Console.WriteLine("\tIngrese su apellido: ");
                        string dtlastName = Console.ReadLine();
                        Console.WriteLine("\tIngrese su edad: ");
                        int dtage = -1;
                        while (dtage == -1)
                        {
                            try
                            {
                                dtage = int.Parse(Console.ReadLine());
                                if (dtage < 1)
                                {
                                    Console.WriteLine("Ingrese una edad válida");
                                    dtage = -1;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato invalido\nIngrese un numero como edad");
                            }
                        }
                        Console.WriteLine("\tIngrese su sueldo: ");
                        int dtsalary = -1;
                        while (dtsalary == -1)
                        {
                            try
                            {
                                dtsalary = int.Parse(Console.ReadLine());
                                if (dtsalary < 1)
                                {
                                    Console.WriteLine("Ingrese un sueldo válido");
                                    dtsalary = -1;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato invalido\nIngrese un numero como sueldo");
                            }
                        }
                        Console.WriteLine("\tIngrese sus puntos de táctica: ");
                        int dtpoints = -1;
                        while (dtpoints == -1)
                        {
                            try
                            {
                                dtpoints = int.Parse(Console.ReadLine());
                                if (dtpoints < 1)
                                {
                                    Console.WriteLine("Ingrese una número válido");
                                    dtpoints = -1;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato invalido\nIngrese un número.");
                            }
                        }
                        Console.WriteLine("\tIngrese su nacionalidad");
                        string dtnation = Console.ReadLine();

                        Coach coach = new Coach(dtpoints, dtname, dtlastName, dtage, dtnation, dtsalary);

                        Console.Clear();
                        Console.WriteLine("Ahora ingrese los datos del doctor");
                        Console.WriteLine("\tIngrese su nombre: ");
                        string dname = Console.ReadLine();
                        Console.WriteLine("\tIngrese su apellido: ");
                        string dlastName = Console.ReadLine();
                        Console.WriteLine("\tIngrese su edad: ");
                        int dage = -1;
                        while (dage == -1)
                        {
                            try
                            {
                                dage = int.Parse(Console.ReadLine());
                                if (dage < 1)
                                {
                                    Console.WriteLine("Ingrese una edad válida");
                                    dage = -1;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato invalido\nIngrese un numero como edad");
                            }
                        }
                        Console.WriteLine("\tIngrese su sueldo: ");
                        int dsalary = -1;
                        while (dsalary == -1)
                        {
                            try
                            {
                                dsalary = int.Parse(Console.ReadLine());
                                if (dsalary < 1)
                                {
                                    Console.WriteLine("Ingrese un sueldo válido");
                                    dsalary = -1;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato invalido\nIngrese un numero como sueldo");
                            }
                        }
                        Console.WriteLine("\tIngrese sus puntos de experiencia: ");
                        int dpoints = -1;
                        while (dpoints == -1)
                        {
                            try
                            {
                                dpoints = int.Parse(Console.ReadLine());
                                if (dpoints < 1)
                                {
                                    Console.WriteLine("Ingrese una número válido");
                                    dpoints = -1;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Formato invalido\nIngrese un número.");
                            }
                        }
                        Console.WriteLine("\tIngrese su nacionalidad");
                        string dnation = Console.ReadLine();

                        Doctor doctor = new Doctor(dpoints, dname, dlastName, dage, dnation, dsalary);

                        Team team = new Team(team_name, team_type, players, coach, doctor);

                        Console.Clear();
                        Console.WriteLine("Ahora continuamos con los jugadores");
                        Console.WriteLine("NO HARÉ UN CICLO WHILE HASTA QUE SE COMPLETEN LOS 15 JUGADORES PARA FACILITAR LA CORRECCIÓN");
                        int count_p = 0;
                        while (count_p == 0)
                        {
                            Console.WriteLine("\tIngrese su nombre: ");
                            string pname = Console.ReadLine();
                            Console.WriteLine("\tIngrese su apellido: ");
                            string plastName = Console.ReadLine();
                            Console.WriteLine("\tIngrese su edad: ");
                            int page = -1;
                            while (page == -1)
                            {
                                try
                                {
                                    page = int.Parse(Console.ReadLine());
                                    if (page < 1)
                                    {
                                        Console.WriteLine("Ingrese una edad válida");
                                        page = -1;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Formato invalido\nIngrese un numero como edad");
                                }
                            }
                            Console.WriteLine("\tIngrese su sueldo: ");
                            int psalary = -1;
                            while (psalary == -1)
                            {
                                try
                                {
                                    psalary = int.Parse(Console.ReadLine());
                                    if (psalary < 1)
                                    {
                                        Console.WriteLine("Ingrese un sueldo válido");
                                        psalary = -1;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Formato invalido\nIngrese un numero como sueldo");
                                }
                            }
                            Console.WriteLine("\tIngrese sus puntos de ataque: ");
                            int papoints = -1;
                            while (papoints == -1)
                            {
                                try
                                {
                                    papoints = int.Parse(Console.ReadLine());
                                    if (papoints < 1)
                                    {
                                        Console.WriteLine("Ingrese una número válido");
                                        papoints = -1;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Formato invalido\nIngrese un número.");
                                }
                            }
                            Console.WriteLine("\tIngrese sus puntos de defensa: ");
                            int pdpoints = -1;
                            while (pdpoints == -1)
                            {
                                try
                                {
                                    pdpoints = int.Parse(Console.ReadLine());
                                    if (pdpoints < 1)
                                    {
                                        Console.WriteLine("Ingrese una número válido");
                                        pdpoints = -1;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Formato invalido\nIngrese un número.");
                                }
                            }
                            Console.WriteLine("\tIngrese sus número de polera: ");
                            int nn = 0;
                            int pnumber = -1;
                            while (nn == 0)
                            {
                                pnumber = -1;
                                while (pnumber == -1)
                                {
                                    try
                                    {
                                        pnumber = int.Parse(Console.ReadLine());
                                        if (pnumber < 1)
                                        {
                                            Console.WriteLine("Ingrese una número válido");
                                            pnumber = -1;
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Formato invalido\nIngrese un número.");
                                    }
                                }

                                int cc = 0;
                                foreach (Player p in team.Players)
                                {
                                    if (p.Shirt_number == pnumber)
                                    {
                                        cc++;
                                    }
                                }
                                if (cc != 0)
                                {
                                    Console.WriteLine("Ese número está ocupado. Seleccione otro");

                                }
                                else
                                {
                                    nn = 1;
                                }
                            }
                            
                            Console.WriteLine("\tIngrese su nacionalidad");
                            string pnation = Console.ReadLine();

                            Console.WriteLine("\tSeleccione: \n\t\t(1)Si su jugador es arquero\n\t\t(Otro)Si no es arquero");
                            string pgoal = Console.ReadLine();
                            bool pgoalkeeper;
                            if (pgoal == "1")
                            {
                                pgoalkeeper = true;
                            }
                            else
                            {
                                pgoalkeeper = false;
                            }
                            Player player2 = new Player(papoints, pdpoints, pnumber, pgoalkeeper, pname, plastName, page, pnation, psalary);                         
                            team.AddPlayer(player2);

                            Console.WriteLine("¿Desea agregar otro jugador?\n\t(1)Sí\n\t(Otro)No");
                            string ans = Console.ReadLine();
                            if (ans != "1")
                            {
                                teams.Add(team);
                                count_p = 1;
                                Console.Clear();
                            }
                            Console.Clear();

                        }
                        break;
                    case "2":
                        if (teams.Count() == 0)
                        {
                            Console.WriteLine("No se han creado equipos.");
                            Console.ReadKey();

                        }
                        else
                        {
                            foreach (Team t in teams)
                            {
                                Console.Clear();
                                Console.WriteLine(t.GetTeamInformation());
                                Console.WriteLine("¿Desea ver la información de los jugadores del equipo?\n\t(1)Sí\n\t(Otro)No");
                                string ans2 = Console.ReadLine();
                                if (ans2 == "1")
                                {
                                    t.GetPlayersInformation();
                                    Console.ReadKey();


                                }

                            }
                        }
                        
                        break;
                    case "3":
                        switcher = "3";
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción valida\n");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
                
            }
        }
    }
}
