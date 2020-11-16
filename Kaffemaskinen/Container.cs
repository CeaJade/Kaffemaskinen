using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    class Container
    {
        private int volume;
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Volume
        {
            get { return volume; }
            set  
            { 
                if (value <= capacity)
                {
                    volume += value;
                }
                else if (value < 0)
                {
                    volume = 0;
                }
                else 
                {
                    volume = capacity;
                }
            }
        }

        public Container(int capacity)
        {
            Capacity = capacity;
            Volume = 0;
        }

        public void FillContainer(int amount)
        {
            Volume += amount;
        }
    }
}
