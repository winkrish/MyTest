using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("hi");
                int i = 0;
                int j = 0;
                int k = i / j;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+ ex.InnerException);
            }
        }
    }
}
