using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    //This is a class responsible of containing water
    class Reservoir
    {
        //Volume is measured in dl
        private int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }


        public Reservoir(int volume)
        {
            this.Volume = volume;
        }

        public void GetWater(int dlOfWater)
        {
            if (dlOfWater > volume)
                dlOfWater = volume;
            else
                dlOfWater = dlOfWater;
        }
    }
}
