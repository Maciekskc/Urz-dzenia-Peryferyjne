using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DirectInput;

namespace Bial_Lis_UP
{
    class Zadania
    {
        public Joystick checkDevices()
        {
            SharpDX.DirectInput.DirectInput directInput = new SharpDX.DirectInput.DirectInput();

            var devices = directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AttachedOnly);

            Console.WriteLine("Wykryłem następujące urządzenia:");
            foreach (DeviceInstance instance in devices) Console.WriteLine(instance.InstanceName);

            Joystick joystick = new Joystick(directInput, devices[0].InstanceGuid);
            return  joystick;
        }


        public void checkState(Joystick joystick)
        {
            int x = 0;
            int y = 0;
            int z = 0;

            if (joystick != null)
            {
                do
                {
                    if (joystick.GetCurrentState().X != x || joystick.GetCurrentState().Y != y)
                    {
                        x = joystick.GetCurrentState().X;
                        y = joystick.GetCurrentState().Y;
                        Console.WriteLine("Pozycja:[" +x+","+y+"]\t");
                    }

                    if (z != joystick.GetCurrentState().Z)
                    {
                        z = joystick.GetCurrentState().Z;
                        Console.WriteLine("pozycja z:[" +z+"]");
                    }

                    if(joystick.GetCurrentState().Buttons[0]) Console.WriteLine("Kliknieto LPM");
                    if (joystick.GetCurrentState().Buttons[1]) Console.WriteLine("Kliknieto PPM");


                } while (!joystick.GetCurrentState().Buttons[10]);
            }
        }

        public void mouseUsage(Joystick joystick)
        {
            bool rightPressed = false;
            bool leftPressed = false;
            //wyjscie z procesu poprzez przycisk 10
            do
            {
                int X = joystick.GetCurrentState().X;
                int Y = joystick.GetCurrentState().Y;

                //int mouseX = X / 30;
                //int mouseY = Y / 52;

                uint flag = (0x00008000 | 0x00000001);

                bool ppm = joystick.GetCurrentState().Buttons[1];
                bool lpm = joystick.GetCurrentState().Buttons[0];


                if (joystick.GetCurrentState().Buttons[1])
                {
                    if (!rightPressed)
                    {
                        rightPressed = true;
                        flag = 0x00000008;

                    }else
                    {
                        rightPressed = false;
                        flag = 0x00000010;
                    }
                }

                if (joystick.GetCurrentState().Buttons[0])
                {
                    if (!leftPressed)
                    {
                        leftPressed = true;
                        flag = 0x00000002;
                    }
                    else
                    {
                        leftPressed = false;
                        flag = 0x00000004;
                    }
                }
                //SetCursorPos(mouseX, mouseY);
                mouse_event(flag, X, Y, 0, 0);

            } while (!joystick.GetCurrentState().Buttons[9]);
        }
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);


        public void paint()
        {
            Window window = new Window();
            //otwieranie okna powoduje błąd, nie jesteśmy w stanie nic na nim wyświetlić,
            //ąd zgłoszony prowadzącemu

        } 

    }
}
