using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List of different systems and their corresponding intergalactic economies
//Also the distances between every system
//Include large amounts of information on every planet system
//Such as climate, species, weather, suggestions as to what might be cheap here etc
namespace SpaceTradingGame 
    
{
    class TravelMenu
    {
        public static void Planets()
        {
            List<string[]> Planet = new List<string[]>();
            string[] PlanetsArray =
            {
                "1. Earth",
                "2. Reach",
                "3. Pandora",
                "4. Alpha Centauri",
                "5. Krypton",
            };

            Console.WriteLine("Please choose the number of the planet you would like to travel to: ");
            int planet = int.Parse(Console.ReadLine());
            double age = 20;
            double percent;

             switch (planet)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You have now arrived at Earth");
                    double d = WarpEarth();
                    Console.WriteLine($"You have traveled for {d} days.");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You have now arrived at Reach");
                    double e = WarpReach();
                    Console.WriteLine($"You have traveled for {d} days.");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("You have now arrived at Pandora");
                    double f = WarpPandora();
                    Console.WriteLine($"You have traveled for {d} days.");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("You have now arrived at Alpha Centauri");
                    double g = WarpAlphaCentauri();
                    Console.WriteLine($"You have traveled for {d} days.");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("You have now arrived at Krypton");
                    double h = WarpKrypton();
                    Console.WriteLine($"You have traveled for {d} days.");
                    percent = d / 365 + age;
                    Console.WriteLine($"You are {percent} years old.");
                    break;
                default:
                    {
                        Console.WriteLine("Sorry, that is not a system that we are able to reach!");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    double WarpKrypton()
                    {
                        double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
                        d = Convert.ToInt32((240 / v) * (365));
                        return d;
                    }

                    double WarpAlphaCentauri()
                    {
                        double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
                        d = Convert.ToInt32((120 / v) * (365));
                        return d;
                    }

                    double WarpPandora()
                    {
                        double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
                        d = Convert.ToInt32((60 / v) * (365));
                        return d;
                    }

                    double WarpReach()
                    {
                        double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
                        d = Convert.ToInt32((30 / v) * (365));
                        return d;
                    }

                    double WarpEarth()
                    {
                        double v = (Math.Pow(3, (10.0 / 3))) + Math.Pow((10 - 3), ((-11.0 / 3)));
                         d = Convert.ToInt32((15 / v) * (365));
                        return d;
                    }

            }

}


