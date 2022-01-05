using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecihleClassLibrary
{
    public class BaseVehicle
    {
        private string testVariable;

        public void Go()
        {
            Log("Car is going");
            testVariable = "";
        }

        public void Stop()
        {
            Log("Car is stopping");
        }

        private void Log(string logStr)
        {
            Console.WriteLine(logStr);
        }
    }
}
