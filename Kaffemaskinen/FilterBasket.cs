using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    class FilterBasket : Container, IEmpiableContainer
    {
        private bool hasFilter;

        public bool HasFilter
        {
            get { return hasFilter; }
            set { hasFilter = value; }
        }

        public FilterBasket(int capacity) : base(capacity)
        {
        }

        public void GetFilter()
        {
            if (!hasFilter)
            {
                Console.WriteLine("I HAZ FILTER");
                hasFilter = true;
            }
        }

        public void EmptyContainer()
        {
            Console.WriteLine("I HAZ NO FILTER");
            Volume = 0;
            hasFilter = false;
        }
    }
}
