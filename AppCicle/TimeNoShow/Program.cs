using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeNoShow
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine($"Hora Atual: {DateTime.Now.ToString("HH:mm:ss.fff")}");
                Thread.Sleep(10);
            }
        }
    }
}
