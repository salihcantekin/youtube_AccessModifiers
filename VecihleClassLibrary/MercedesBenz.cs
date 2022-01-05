using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecihleClassLibrary
{
    public class MercedesBenz: BaseCar
    {
        public MercedesBenz()
        {
            base.StopEngine();
            base.IsEngineStarted = true;
        }
    }
}
