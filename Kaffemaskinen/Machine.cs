using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskinen
{
    //Represents a machine that can turn on and off
    abstract class Machine
    {
        private bool isOn;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }

        public Machine()
        {
            IsOn = false;
        }

        public void TurnOnOff()
        {
            if (IsOn)
            {
                Console.WriteLine("I am off");
                IsOn = false;
            }

            else
            {
                Console.WriteLine("I am on");
                IsOn = true;
            }
                
        }
    }
}
