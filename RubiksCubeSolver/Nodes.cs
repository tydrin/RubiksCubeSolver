using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
    public class Cubie
    {
        public int orientation { get; set; }
        public string location { get; set; }
        public string originalLocation { get; set; }
        public Colour colour1 { get; set; }
        public Colour colour2 { get; set; }
        public Colour colour3 { get; set; }
        public Cubie(int orientation, string location, string originalLocation)
        {
            this.orientation = orientation;
            this.location = location;
            this.originalLocation = originalLocation;
        }
    }
    public class Node
    {
        public Cube state { get; set; }
        public string move { get; set; }
        public Node(Cube state, string move)
        {
            this.state = state;
            this.move = move;
        }
    }
    public enum Colour
    {
        W, G, O, B, R, Y, U
    }
}
