using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using WinApi.Kernel32;
using WinApi.Kernel32.Enums;
using WinApi.User32;

namespace TestWinApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool res = Kernel32_lib.CreateDirectoryA("d:\\3", IntPtr.Zero);
            //Console.WriteLine(res);
            //bool result = Kernel32_lib.RemoveDirectoryW("d:\\3");


            //if(result)
            //    Console.WriteLine("Операция успешна.");
            //else
            //{
            //    Console.WriteLine("Ошибка");
            //    var code = Kernel32_lib.GetLastError();
            //    Console.WriteLine($"Код ошибки {code}");
            //}

            Console.WriteLine(sizeof(bool));
            var t = new Thread(test);
            t.Start();
        }

        static void test()
        {
            Point point = new Point();

            while (true)
            {
                User32.GetCursorPos(out point);
                Console.WriteLine("X={0} Y={1}" ,point.X, point.Y);
                Thread.Sleep(10);
            }
        }
    }
}