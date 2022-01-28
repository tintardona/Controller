using NUnit.Framework;
using System;

namespace Controller
{
    public class Tests
    {
       
       /*   Test condition when speed is too slow due to a possible malfunction or obstruction.
            Expected result is the saftey feature will turn the machine off.
       */
        [Test]
        public void Speed_Too_slow()
        {
            //Log Message
            Console.Write("Running Test: Speed Too Slow. ");

            Controller controller = new Controller(false, 0);

            //turn on 
            controller.TurnOn();
            //set speed < 45
            controller.setSpeed(34);
            //assert safty feature runs
            Assert.False(controller.SafetyFeature());

        }

        /*   Test condition when speed is too fast due to a possible malfunction.
            Expected result is the saftey feature will turn the machine off.
       */
        [Test]
        public void Speed_Too_Fast()
        {
            //Log Message
            Console.Write("Running Test: Speed Too Fast. ");
            
            Controller controller = new Controller(false, 0);

            //turn on 
            controller.TurnOn();
            //set speed > 45
            controller.setSpeed(60);
            //assert safty feature runs
            Assert.False(controller.SafetyFeature());


        }


        /*   Test condition when speed is witin safe range.
            Expected result is the saftey feature will not trigger.
       */
        [Test]
        public void Speed_In_Safe_Range()
        {
            //Log Message
            Console.Write("Running Test: Speed In Safe Range. ");

            Controller controller = new Controller(false, 0);

            //turn on 
            controller.TurnOn();
            //set speed = 45
            controller.setSpeed(45);
            //assert safty feature runs
            Assert.True(controller.SafetyFeature());

        }
    }
}