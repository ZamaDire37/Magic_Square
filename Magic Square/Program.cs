using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Square
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ProblemALG004r magicSq = new ProblemALG004r(5);
            magicSq.PrintMGS();
            Console.ReadLine();
        }
    }
}
