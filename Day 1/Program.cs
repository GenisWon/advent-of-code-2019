using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prgrm = new Program();
            System.IO.StreamReader file = new System.IO.StreamReader("mass.txt");
            string strLine;
            int intCounter = 0;
            int intMass;
            int intFuel = 0;

            while ((strLine = file.ReadLine()) != null)
            {
                intMass = int.Parse(strLine);
                while(prgrm.calcFuel(intMass) > 0)
                {
                    intMass = prgrm.calcFuel(intMass);
                    intFuel += intMass;
                }
                intCounter++;
            }

            Console.WriteLine("Fuel needed: ");
            Console.Write(intFuel);
        }

        private int calcFuel(int intMass)
        {
            return (intMass / 3) - 2;
        }
    }
}
