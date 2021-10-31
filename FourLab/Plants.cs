using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLab
{ 
    public class Plants
    {
        public int height;
    }

    public class Flowers : Plants
    {
        public int PetalCount;
        public string colour;
        public string type;
    }

    public class Bush : Plants
    {
        public bool WithFlower;
        public int BranchCount;
    }

    public enum TreeType { coniferous, leafy }
    public class Tree : Plants
    {
        public int radius;
        public TreeType type;
    }
}