using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    //This is a class responsible of containing water
    class WaterReservoir : Container, IEmpiableContainer
    {
        public WaterReservoir(int capacity) : base(capacity)
        {
        }

        public void EmptyContainer()
        {
            Volume = 0;
        }
    }
}
