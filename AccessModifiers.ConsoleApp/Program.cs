using System;
using VecihleClassLibrary;

namespace AccessModifiers.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Description

            /*
              
                public
                internal
                private
                

                protected internal
                private protected * -> After C# 7.2

             */

            #endregion


            BaseCar c = new MercedesBenz();
            
            BaseVehicle v = new BaseVehicle();
            
        }
    }
}
