using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VecihleClassLibrary
{
    public class BaseCar: BaseVehicle
    {
        protected void StartEngine()
        {
            IsEngineStarted = true;
        }

        private protected void StopEngine()
        {
            IsEngineStarted = false;
        }

        private protected bool IsEngineStarted { get; set; }
    }
}
