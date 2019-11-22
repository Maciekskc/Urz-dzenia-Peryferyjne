using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;


namespace Bial_Lis_UP
{
    class Program
    {
        static void Main(string[] args)
        {

            // SharpDX.DirectInput.DirectInput directInput = new SharpDX.DirectInput.DirectInput();
            Zadania zadania = new Zadania();
            Joystick device = zadania.checkDevices();
            device.Acquire();

            zadania.checkState(device);
            zadania.mouseUsage(device);
            // Windos zadanie2 = new Windos(device);
            //  zadanie2.Show();

            zadania.paint();

            Console.WriteLine("wcisnij ENTER zeby zakaczyc");
            Console.ReadLine();
        }
    }
}
