using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
    public class Cube
    {
        public Cubie[][] cube;
        private string[] corners = { "URF", "UFL", "ULB", "UBR", "DFR", "DLF", "DBL", "DRB" };
        private string[] edges = { "UR", "UF", "UL", "UB", "DR", "DF", "DL", "DB", "FR", "FL", "BL", "BR" };
        private Colour[] colours = { Colour.W, Colour.G, Colour.O, Colour.B, Colour.R, Colour.Y, Colour.U };
        public Cube()
        {
            cube = new Cubie[2][];
            Initialise();
        }
        public void Rotate(char face, int num)
        {
            try
            {
                switch (num)
                {
                    case 1:
                        FunctionAssigner(face, num);
                        break;
                    case 2:
                        for (int i = 0; i < 2; i++)
                            FunctionAssigner(face, num);
                        break;
                    case 3:
                        for (int i = 0; i < 3; i++)
                            FunctionAssigner(face, num);
                        break;
                    case -1:
                        for (int i = 0; i < 3; i++)
                            FunctionAssigner(face, num);
                        break;
                    default:
                        throw new Exception("Invalid entry for direction or face.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid face/rotation number.");
            }
        }
        public void Print()
        {
            // do with loop later
            Cubie[] corners = cube[0];
            Cubie[] edges = cube[1];
            Console.WriteLine("White Face: ");
            Console.WriteLine($"|{corners[2].colour1}||{edges[3].colour1}||{corners[3].colour1}|");
            Console.WriteLine($"|{edges[2].colour1}||W||{edges[0].colour1}|");
            Console.WriteLine($"|{corners[1].colour1}||{edges[1].colour1}||{corners[0].colour1}|");
            Console.WriteLine();
            Console.WriteLine("Green Face: ");
            Console.WriteLine($"|{corners[1].colour2}||{edges[1].colour2}||{corners[0].colour2}|");
            Console.WriteLine($"|{edges[9].colour1}||G||{edges[8].colour1}|");
            Console.WriteLine($"|{corners[5].colour2}||{edges[5].colour2}||{corners[4].colour2}|");
            Console.WriteLine();
            Console.WriteLine("Orange Face: ");
            Console.WriteLine($"|{corners[2].colour3}||{edges[2].colour2}||{corners[1].colour3}|");
            Console.WriteLine($"|{edges[10].colour2}||O||{edges[9].colour2}|");
            Console.WriteLine($"|{corners[5].colour3}||{edges[6].colour2}||{corners[6].colour3}|");
            Console.WriteLine();
            Console.WriteLine("Blue Face: ");
            Console.WriteLine($"|{corners[3].colour2}||{edges[3].colour2}||{corners[2].colour2}|");
            Console.WriteLine($"|{edges[11].colour1}||B||{edges[10].colour1}|");
            Console.WriteLine($"|{corners[7].colour2}||{edges[7].colour2}||{corners[6].colour2}|");
            Console.WriteLine();
            Console.WriteLine("Red Face: ");
            Console.WriteLine($"|{corners[0].colour3}||{edges[0].colour2}||{corners[3].colour3}|");
            Console.WriteLine($"|{edges[8].colour2}||R||{edges[11].colour2}|");
            Console.WriteLine($"|{corners[4].colour3}||{edges[4].colour2}||{corners[7].colour3}|");
            Console.WriteLine();
            Console.WriteLine("Yellow Face: ");
            Console.WriteLine($"|{corners[5].colour1}||{edges[5].colour1}||{corners[4].colour1}|");
            Console.WriteLine($"|{edges[6].colour1}||Y||{edges[4].colour1}|");
            Console.WriteLine($"|{corners[6].colour1}||{edges[7].colour1}||{corners[7].colour1}|");
        }
        private void U(int times)
        {
            // corners
            Cubie[] corners = cube[0];

            //edges
            Cubie[] edges = cube[1];
        }
        private void D(int times)
        {
            // corners
            Cubie[] corners = cube[0];

            //edges
            Cubie[] edges = cube[1];
        }
        private void F(int times)
        {
            // corners
            Cubie[] corners = cube[0];

            //edges
            Cubie[] edges = cube[1];

        }
        private void B(int times)
        {
            // corners
            Cubie[] corners = cube[0];

            //edges
            Cubie[] edges = cube[1];
        }
        private void L(int times)
        {
            // corners
            Cubie[] corners = cube[0];

            //edges
            Cubie[] edges = cube[1];
        }
        private void R(int times)
        {
            // corners
            Cubie[] corners = cube[0];

            //edges
            Cubie[] edges = cube[1];
        }
        private void Initialise()
        {
            for (int i = 0; i < 2; i++)
            {
                Cubie[] temp = new Cubie[8 + (4 * i)];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (i == 0)
                    {
                        temp[j] = new Cubie(0, corners[j], corners[j]);
                    }
                    else
                    {
                        temp[j] = new Cubie(0, edges[j], edges[j]);
                    }
                }
                cube[i] = temp;
            }
            for (int i = 0; i < 2; i++) // using priority of colour orientation we can assign colours with loops
            {
                Cubie[] temp = cube[i];
                if (i == 0)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (temp[j].location.Contains('U'))
                        {
                            temp[j].colour1 = Colour.W;
                        }
                        if (temp[j].location.Contains('D'))
                        {
                            temp[j].colour1 = Colour.Y;
                        }
                        if (temp[j].location.Contains('F'))
                        {
                            temp[j].colour2 = Colour.G;
                        }
                        if (temp[j].location.Contains('B'))
                        {
                            temp[j].colour2 = Colour.B;
                        }
                        if (temp[j].location.Contains('L'))
                        {
                            temp[j].colour3 = Colour.O;
                        }
                        if (temp[j].location.Contains('R'))
                        {
                            temp[j].colour3 = Colour.R;
                        }
                    }
                }
                else if (i == 1)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        int check = 0;
                        temp[j].colour3 = Colour.U; // unknown colour 3 defines an edge piece
                        if (temp[j].location.Contains('U'))
                        {
                            temp[j].colour1 = Colour.W;
                            check++;
                        }
                        if (temp[j].location.Contains('D'))
                        {
                            temp[j].colour1 = Colour.Y;
                            check++;
                        }
                        if (temp[j].location.Contains('F'))
                        {
                            if (check > 0) temp[j].colour2 = Colour.G;
                            else if (check == 0) temp[j].colour1 = Colour.G;
                        }
                        if (temp[j].location.Contains('B'))
                        {
                            if (check > 0) temp[j].colour2 = Colour.B;
                            else if (check == 0) temp[j].colour1 = Colour.B;
                        }
                        if (temp[j].location.Contains('L')) temp[j].colour2 = Colour.O;
                        if (temp[j].location.Contains('R')) temp[j].colour2 = Colour.R;
                    }
                }
                else throw new Exception("Face does not exist.");
                cube[i] = temp;
            }
        }
        private void FunctionAssigner(char face, int num)
        {
            Dictionary<char, Action<int>> faceActions = new Dictionary<char, Action<int>>
            {
                {'U', U},
                {'D', D},
                {'F', F},
                {'B', B},
                {'L', L},
                {'R', R}
            };
            if (faceActions.ContainsKey(face))
            {
                Action<int> action = faceActions[face];
                action(num);
            }
            else
            {
                throw new Exception("Invalid face character.");
            }
        }
    }
}
