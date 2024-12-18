using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public class Robot : IWalkable
    {
        // This method is specific to the Robot class
        public void Walk()
        {
            Console.WriteLine("Robot is walking in a straight line.");
        }

        // Explicit interface implementation
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking with a robotic gait.");
        }

        // Additional method specific to Robot
        public void Charge()
        {
            Console.WriteLine("Robot is charging.");
        }
    }
}
