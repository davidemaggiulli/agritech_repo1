using System;
using System.IO;
using System.Text;

namespace SolarSystem
{
    internal class Program
    {
        private static Planet[] planets;

        static void Main(string[] args)
        {
            Console.WriteLine("*** Solar System ***");

            Planet terra = new Planet("Terra", 5.972E24f, 6371f, 149600000f);
            Planet mercurio = new Planet("Mercurio", 3.285E23f, 2439.7f, 57910000f);
            Planet plutone = new Planet("Plutone", 1.293E22f, 1188.3f, 4.488E9f);
            Planet saturno = new Planet("Saturno", 5.683E26f, 58232f, 1.434E9f);

            Console.WriteLine($"Primo pianeta {terra}");
            Console.WriteLine($"Secondo pianeta {mercurio}");

            double gravityTM = terra.GetGravity(mercurio);
            double gravityMP = mercurio.GetGravity(plutone);
            double gravityMP1 = Planet.GetGravity(mercurio, plutone);

            //Planet[] planets = new Planet[3];
            //planets[0] = terra;
            //planets[1] = mercurio;
            //planets[2] = plutone;

            planets = new Planet[] { terra, mercurio, plutone, saturno };

            //GetPlanetDetails();

            planets = ReadPlanetsFromFile("data\\planets.txt");
            WritePlanetsOnFile();

            Console.WriteLine("Inserire primo pianeta");
            string pName1 = Console.ReadLine();
            Console.WriteLine("Inserire secondo pianeta");
            string pName2 = Console.ReadLine();

            Planet p1 = FindPlanetByName(pName1);
            Planet p2 = FindPlanetByName(pName2);
            if(p1 == null)
            {
                Console.WriteLine($"Pianeta {pName1} non trovato");
            } else if(p2 == null)
            {
                Console.WriteLine($"Pianeta {pName2} non trovato");
            } else
            {
                double gr = p1.GetGravity(p2);
                Console.WriteLine($"Gravità: {gr}");
            }
            string.Format("{0,1}{1,10}", 1, 2, 3, 4, 5, 6, 7, 8, 9);

            Planet pp = terra + mercurio;

            Console.ReadLine();
      
        }

        static void GetPlanetDetails()
        {
            Console.WriteLine("Quale pianeta vuoi?");
            string name = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < planets.Length; i++)
            {
                Planet planet = planets[i];
                if (planet.Name == name)
                {
                    Console.WriteLine(planet);
                    found = true;
                    break;
                }
            }

            if (!found)  //found == false
                Console.WriteLine($"Pianeta {name} non trovato");

        }


        static void Method(int a, string b, params int[] value)
        {

        }
        static Planet FindPlanetByName (string planetName)
        {
            foreach(Planet planet in planets)
            {
                if (planet != null && planet.Name.Equals(planetName, StringComparison.InvariantCultureIgnoreCase))
                    return planet;
            }
            //for(int i = 0; i < planets.Length; i++)
            //{
            //    if (planets[i].Name == planetName)
            //        return planets[i];
            //}

            //Pianeta non trovato
            return null;
        }

        static void GetPlanetDetails1()
        {
            Console.WriteLine("Quale pianeta vuoi?");
            string name = Console.ReadLine();
            for (int i = 0; i < planets.Length; i++)
            {
                Planet planet = planets[i];
                if (planet.Name == name)
                {
                    Console.WriteLine(planet);
                    return;
                }
            }
            Console.WriteLine($"Pianeta {name} non trovato");
        }

        static Planet[] ReadPlanetsFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            
            Planet[] planets = new Planet[lines.Length];
            for(int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] lineParts = line.Split("|");
                if (lineParts.Length == 4)
                {
                    try
                    {
                        String name = lineParts[0].Trim();
                        string massString = lineParts[1].Trim();
                        float mass = float.Parse(massString);

                        string radiusString = lineParts[2].Trim();
                        float radius = float.Parse(radiusString);

                        string distanceString = lineParts[3].Trim();
                        float distance = float.Parse(distanceString);
                        planets[i] = new Planet(name, mass, radius, distance);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    

                }
                
            }

            return planets;
        }

        static void WritePlanetsOnFile()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var p in planets)
            {
                sb.AppendLine($"{p.Name} | {p.Mass} | {p.Radius} | {p.DistanceFromSun}");
            }
            string result = sb.ToString();
            File.WriteAllText("output.txt", result);
        }
    }
}
