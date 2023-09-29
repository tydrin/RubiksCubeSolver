using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
    // not sure that the cube is initialising properly
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube();
            cube.Rotate('U', 1);
            cube.Print();
            Console.ReadKey();
        }
    }
}
