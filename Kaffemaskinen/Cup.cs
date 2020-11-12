using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    //This class repesents a cup with an average volume of 2 dl
    class Cup
    {
        private int volume;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Cup()
        {
            this.Volume = 2;
        }

    }
}
