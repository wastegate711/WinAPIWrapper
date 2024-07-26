using System.Runtime.InteropServices;
using System.Text;
using WinApi.Kernel32;
using WinApi.Kernel32.Enums;

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

        }
    }
}