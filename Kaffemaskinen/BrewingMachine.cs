using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
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

        public string Brew()
        {
            return "I am brewing";
        }

        public int GetWaterReservoirCapacity()
        {
            return waterReservoir.Capacity;
        }

        public int GetFilterBasketCapacity()
        {
            return filterBasket.Capacity;
        }
    }
}
