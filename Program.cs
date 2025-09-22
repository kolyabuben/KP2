using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            string w = "\nмій рядок 1";
            string o= "\tмій рядок 2";
            string v = "\aмій рядок 3";

            Console.WriteLine(w);
            Console.WriteLine(o);
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}