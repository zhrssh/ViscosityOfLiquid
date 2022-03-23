// Application: Finding Viscosity of Liquid Console-based Application
// Programmed by: Zherish Galvin Mayordo
//
// This console-based application finds the viscosity of liquid at varying temperatures.

using System;

namespace LiquidViscosity
{
    public class Program
    {
        float c1, c2, c3, c4, c5;
        float maxTemperature = 373.15f;
        float result;

        private static Program _instance = null;
        public static Program instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Program();

                return _instance;
            }
        }

        public static void Main(string[] args)
        {
            Program.instance.ProgramStart();
        }

        public void ProgramStart()
        {
            Console.WriteLine("This application finds the viscosity of liquid.");
            Console.WriteLine("Enter the values: ");
            Console.Write("\nC1: ");
            c1 = float.Parse(Console.ReadLine());
            Console.Write("\nC2: ");
            c2 = float.Parse(Console.ReadLine());
            Console.Write("\nC3: ");
            c3 = float.Parse(Console.ReadLine());
            Console.Write("\nC4: ");
            c4 = float.Parse(Console.ReadLine());
            Console.Write("\nC5: ");
            c5 = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\nValues inputted: ");
            Console.Write("\nC1: " + c1 + "\nC2: " + c2 + "\nC3: " + c3 + "\nC4: " + c4 + "\nC5: " + c5);

            for (float temperature = 273.15f; temperature <= maxTemperature; temperature = temperature + 10)
            {
                result = ComputeViscosity(c1, c2, c3, c4, c5, temperature);
                Console.WriteLine("\nTemperature: " + temperature + " Result: " + result);
            }
        }

        public float ComputeViscosity(float c1, float c2, float c3, float c4, float c5, float temperature)
        {
            float v = (float)Math.Exp(c1 + (c2 / temperature) + (c3 * (float)Math.Log(temperature)) + (c4 * (float)Math.Pow(temperature, c5)));
            return v;
        }
    }
}