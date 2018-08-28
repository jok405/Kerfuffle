using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner runner = new Runner();
            runner.Run();
        }
    }
    public class Runner
    {
        public void Run()
        {
            var time = GetTime();
        }
        public (int, int, int) GetTime()
        {
            return (1, 30, 40); // tuple literal
        }
    }
}
