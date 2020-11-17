using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    //This class is respolsible of brewing
    class BrewingMachine : Machine
    {
        private WaterReservoir waterReservoir;
        private FilterBasket filterBasket;
        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

        public FilterBasket FilterBasket
        {
            get { return filterBasket; }
            set { filterBasket = value; }
        }

        public WaterReservoir WaterReservoir
        {
            get { return waterReservoir; }
            set { waterReservoir = value; }
        }

        public BrewingMachine(WaterReservoir reservoir, FilterBasket filterBasket)
        {
            FilterBasket = filterBasket;
            WaterReservoir = reservoir;
            IsRunning = false;
        }

        //Brews coffee
        public string BrewCoffee()
        {
            string returnString;
            decimal fVolume = filterBasket.Volume;
            decimal wVolume = waterReservoir.Volume;
            decimal coffeeStrength = fVolume / (wVolume / 2);
            coffeeStrength = Math.Round(coffeeStrength, 2);
            if (filterBasket.Volume == 0 && waterReservoir.Volume == 0)
            {
                returnString = "There is no water or coffee";
            }
            else if (filterBasket.Volume == 0)
            {
                returnString = waterReservoir.Volume / 2 + " cups of water";
            }
            else if (waterReservoir.Volume == 0)
            {
                returnString = "These are 0 cups of very dry coffee";
            }
            else if (filterBasket.HasFilter == false)
            {
                returnString = waterReservoir.Volume / 2 + " cups of grainy coffee with a strength of "
                    + coffeeStrength + " have been brewed.";
            }
            else
            {
                returnString = waterReservoir.Volume / 2 + " cups of coffee with a strength of "
                    + coffeeStrength + " have been brewed.";
            }

            waterReservoir.EmptyContainer();
            filterBasket.EmptyContainer();
            return returnString;
        }

        //Brews tea
        public string BrewTea()
        {
            string returnString;
            if (waterReservoir.Volume == 0)
            {
                returnString = "There is no water";
            }
            else
            {
                returnString = waterReservoir.Volume / 2 + " cups of hot water has been made ready for tea";
            }

            return returnString;
        }

        public int GetWaterReservoirCapacity()
        {
            return waterReservoir.Capacity;
        }

        public int GetWaterreservoirVolume()
        {
            return waterReservoir.Volume;
        }

        public int GetFilterBasketCapacity()
        {
            return filterBasket.Capacity;
        }

        public int GetFilterBasketVolume()
        {
            return filterBasket.Volume;
        }
    }
}
