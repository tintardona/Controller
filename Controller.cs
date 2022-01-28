using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    internal class Controller
    {

        /*Simple controller simulation
            Pretend this is connected to a motor
            functions are to turn on, off
            It has a speed sensor
            if the controller is on and speed is less than an expected speed,
            the controller turns off as a saftey feature*/

        private Boolean on;
        private int speed;

        public Controller(bool on, int speed)
        {
            this.on = on;
            this.speed = speed;
        }

        public void TurnOn()
        {
            this.on = true;
            this.speed = 50;
        }

        public void TurnOff()
        {
            this.on = false;
            this.speed = 0;
        }

        public int CheckSpeed()
        {
            return speed;
        }

        public void setSpeed(int speed)
        {
            this.speed = speed;
        }

        public bool SafetyFeature()
        {
            if(this.speed != 45)
            {
                //If speed is too slow or too fast, something is wrong, stop
                this.on = false;
                //Print full stop!!
                Console.Write("Full Stop!!");

            }
           else
            {
                Console.Write("Still Running.");
            }

            return on;
        }
            
    }
}
