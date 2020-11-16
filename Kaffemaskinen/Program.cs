using System;

namespace Kaffemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            BrewingMachine brewingMachine = new BrewingMachine(new WaterReservoir(20), new FilterBasket(10));

            bool valid;
            int input;
            do
            {
                Console.WriteLine("BREWING MACHINE\n");
                Console.Write("1. Refill Reservoir \nInput: ");
                if (!int.TryParse(Console.ReadLine(), out input) || input > 1 || input <= 0)
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                    Console.Clear();
                    valid = false;
                }
                else
                    valid = true;
            } while (!valid);

            switch (input)
            {
                case 1:
                    
                    break;
            }
        }

        public static void FillWaterReservoir(BrewingMachine brewingMachine)
        {
            bool valid;
            int fillAmount;
            do
            {
                Console.WriteLine("How many dl of water? Reservoir capacity is " + brewingMachine.GetWaterReservoirCapacity() + " dl");
                if (!int.TryParse(Console.ReadLine(), out fillAmount))
                {
                    Console.WriteLine("Invalid input");
                    valid = false;
                }
                else
                    valid = true;

            } while (!valid);

            brewingMachine.WaterReservoir.FillContainer(fillAmount);
        }
    }
}
