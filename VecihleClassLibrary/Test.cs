using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecihleClassLibrary
{
    public class Test: BaseCar
    {
        public Test()
        {
            //BaseCar c = new();
            //c.
            base.IsEngineStarted = true;
            base.StopEngine();

        }
    }
}
