using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VecihleClassLibrary;

namespace AccessModifiers.ConsoleApp
{
    public class TestCar: BaseCar
    {
        public TestCar()
        {
            //base.StopEngine();
            base.StartEngine();
        }
    }
}
