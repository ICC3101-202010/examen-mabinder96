using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Francisca_Binder
{
    public class Coach:Person 
    {
        private int tactic_points;

        public int Tactic_points { get => tactic_points; set => tactic_points = value; }

        public Coach(int tactic_points, string name, string lastname, int age, string nation, int salary)
        {
            this.Tactic_points = tactic_points;
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
            this.Nation = nation;
            this.Salary = salary;
        }

        public void Change_Player(Player out_player, Team currentTeam)
        {
            try
            {
                currentTeam.Playing.Remove(out_player);
                Console.WriteLine("Ingrese el número de jugador que va a entrar");
                int count = 0;
                while (count == 0)
                {
                    int count2 = 0;
                    int count3 = 0;
                    int number = -1;
                    while (number == -1)
                    {
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            if (number < 0)
                            {
                                Console.WriteLine("Ingrese una número válido");
                                number = -1;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Formato invalido");
                        }
                    }

                    foreach (Player p in currentTeam.Playing)
                    {
                        if (p.Shirt_number == number)
                        {
                            count2++;
                        }
                    }
                    foreach (Player p in currentTeam.Players)
                    {
                        if (p.Shirt_number == number)
                        {
                            count3++;
                        }
                    }

                    if (count2 != 0)
                    {
                        Console.WriteLine("El jugador ya está en la cancha.Seleccione otro");
                    }
                    else if (count3 == 0)
                    {
                        Console.WriteLine("El jugador no existe.Seleccione otro");
                    }
                    else if (number == out_player.Shirt_number)
                    {
                        Console.WriteLine("El jugador se encuentra lesionado. Seleccione otro");
                    }
                    else
                    {
                        foreach (Player p in currentTeam.Players)
                        {
                            if (p.Shirt_number == number)
                            {
                                currentTeam.Playing.Add(p);
                            }
                        }
                        count = 1;
                    }

                }              
            }
            catch
            {
                Console.WriteLine("El jugador lesionado no está jugando.");
            }
        }
    }
}
