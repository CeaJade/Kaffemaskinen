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
            while (true)
            {
                do
                {
                    Console.WriteLine("BREWING MACHINE\n");
                    Console.Write("1. Fill Reservoir \n2. Insert filter \n3. Add coffee \n4. Brew Coffee \n5. Brew Tea \nInput: ");
                    if (!int.TryParse(Console.ReadLine(), out input) || input > 5 || input <= 0)
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
                        FillWaterReservoir(brewingMachine);
                        break;
                    case 2:
                        Console.WriteLine("Filter has been inserted");
                        brewingMachine.FilterBasket.GetFilter();
                        break;
                    case 3:
                        FillCoffeePowder(brewingMachine);
                        break;
                    case 4:
                        Console.WriteLine(brewingMachine.BrewCoffee());
                        break;
                    case 5:
                        Console.WriteLine(brewingMachine.BrewTea());
                        break;
                }
                Console.ReadKey();
                Console.Clear();
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
            Console.WriteLine("There's " + brewingMachine.GetWaterreservoirVolume() + " dl of water in the reservoir");
        }

        public static void FillCoffeePowder(BrewingMachine brewingMachine)
        {
            bool valid;
            int fillAmount;
            do
            {
                Console.WriteLine("How many spoons of powder? Basket capacity is " + brewingMachine.GetFilterBasketCapacity() + " spoons");
                if (!int.TryParse(Console.ReadLine(), out fillAmount))
                {
                    Console.WriteLine("Invalid input");
                    valid = false;
                }
                else
                    valid = true;

            } while (!valid);

            brewingMachine.FilterBasket.FillContainer(fillAmount);
            Console.WriteLine("There's " + brewingMachine.GetFilterBasketVolume() + " spoons of coffee powder in the filter basket.");
        }
    }
}
