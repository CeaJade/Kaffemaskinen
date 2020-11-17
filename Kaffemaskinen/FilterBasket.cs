using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    //This class is responsible for containing a filter
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
                hasFilter = true;
            }
        }

        public void EmptyContainer()
        {
            Volume = 0;
            hasFilter = false;
        }
    }
}
