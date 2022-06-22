using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Calculator **");


            int n = ReadNaturalFromConsole();


            Random rnd = new Random();
            int[] v = new int[n];
            for(int i = 0; i < v.Length; i++)   
                v[i] = rnd.Next(-100,101);      //Limite superiore escluso dalla generazione

            PrintMenu();
            string scelta = "";
            do
            {
                Console.WriteLine("Scegli un'opzione");
                scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "S":
                    case "s":
                        int sum = 0;
                        //for (int i = 0; i < v.Length; i++)
                        //    sum += v[i];
                        foreach (int num in v)
                            sum += num;
                        //int sum1 = v.Sum();
                        Console.WriteLine("Somma: " + sum);
                        break;
                    case "m":
                        int min = v[0];
                        for (int i = 0; i < v.Length; i++)
                        {
                            if (v[i] < min)
                                min = v[i];
                        }
                        Console.WriteLine("Minimo: " + min);
                        break;

                    case "M":
                        int max = v[0];
                        for (int i = 0; i < v.Length; i++)
                        {
                            if (v[i] > max)
                                max = v[i];
                        }
                        Console.WriteLine("Massimo: " + max);
                        break;

                    case "P":
                    case "p":
                        Console.WriteLine("Stampa i numeri:");
                        foreach (int num in v)
                        {
                            Console.Write(num);
                            Console.Write("  ");
                        }
                        Console.WriteLine();
                        break;

                    case "A":
                        float sum1 = 0;
                        foreach (int num in v)
                            sum1 += num;
                        float avg = sum1 / n;
                        //Console.WriteLine("La media di {0} numeri è {1}",n,avg);
                        Console.WriteLine($"La media di {n} numeri è {avg}");

                        break;
                  
                    case "Q":
                        Console.WriteLine("Exit ..........");
                        break;


                    default:
                        Console.WriteLine(string.Format("Scelta non valida {0}. Riprovare", scelta));
                        break;

                        //if(scelta == "S")
                        //{

                        //} else if (scelta == "m")
                        //{

                        //} else
                        //{

                        //}

                }
            }
            while (scelta != "Q");
            

        }

        static void PrintMenu()
        {
            Console.WriteLine("S - Somma");
            Console.WriteLine("m - minimo");
            Console.WriteLine("M - Massimo");
            Console.WriteLine("A - Avg (media)");
            Console.WriteLine("P - Stampa");
            Console.WriteLine("Q - Esci");
        }

        static int ReadNaturalFromConsole()
        {
            string s = "";
            int n = 0;
            bool parseResult = false;
            do
            {
                Console.WriteLine("Inserire n > 0:");
                s = Console.ReadLine();
                parseResult = int.TryParse(s, out n);
            } while (parseResult == false || n <= 0);
            return n;
        }
    }
}
