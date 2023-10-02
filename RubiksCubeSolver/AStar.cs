using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
    public class AStarNode
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int G { get; set; }
        public int H { get; set; }
        public AStarNode Parent { get; set; }
        public AStarNode(int x, int y)
        {
            X = x;
            Y = y;
            G = 0;
            H = 0;
            Parent = null;
        }
        public int F => G + H;
    }
    public class AStar
    {
        private int Heuristic(Cube state, byte i)
        {
            int h = 0;
            Kociemba phase = new Kociemba(state);
            double[] coordinates = new double[3];
            if (i == 1)
            {
                foreach (double d in coordinates)
                {
                    h += int.Parse(d.ToString());
                }
            }
            else if (i == 2)
            {
                foreach (double d in coordinates)
                {
                    h += int.Parse(d.ToString());
                }
            }
            else throw new Exception("'i' can only be 1 or 2");
            return h;
        }
    }
}
