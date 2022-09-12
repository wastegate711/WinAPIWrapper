using System.Text;
using WinApi.Kernel32;
using WinApi.Kernel32.Enums;

namespace TestWinApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            uint result;
            const uint MAX_DEEP_PATH = 32767;
            Console.WriteLine("Hello, World!");
            

            try
            {
                result = Kernel32_lib.GetCurrentDirectory(MAX_DEEP_PATH, out sb);
                Console.WriteLine($"result={result}\n sb={sb}");
                Console.WriteLine(Environment.CurrentDirectory);
            }
            catch (AccessViolationException e)
            {
                Console.WriteLine(e);
            }



        }
    }
}