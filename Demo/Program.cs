using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwilioWithThinq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            TwilioWrapper wrapper = new TwilioWrapper("ACa5a21802beff96f147d40bf98c957038", "7852c807435af28d468344ca57a49d2a", "11001", "0c82a54f22f775a3ed8b97b2dea74036");
            Console.WriteLine("Call sid: " + wrapper.call("19193365890", "19192334784"));
            Console.ReadLine();
        }
    }
}
