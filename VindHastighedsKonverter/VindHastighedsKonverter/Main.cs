using System;

namespace VindHastighedsKonverter
{
    public class Prog
    {
        static void Main(string[] args)
        {
            Methods m = new Method();
            Console.WriteLine("Press 1 for m/sec to km/h converter\nPress 2 for mps to knot converter");
            string keyChoice = Console.ReadLine();
            switch (keyChoice)
            {
                
                case "1":   
                m.Ms_Km;
                break;

                case "2":
                m.Mps_K
                break;
            }

         
        }
    }
}