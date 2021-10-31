using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLab
{ 
    public class Plants
    {
        public int height=10;
        public string GetInfo()
        {
            return height.ToString();
        }
        public override string ToString()
        {
            return height.ToString();
        }
    }

    public enum FlowerType { garden, forest,wild }
    public class Flowers : Plants
    {
        public int PetalCount=0;
        public string colour="blue";
        public FlowerType type= FlowerType.wild;

    }

    public class Bush : Plants
    {
        public bool WithFlower=true;
        public int BranchCount=0;
    }

    public enum TreeType { coniferous, leafy }
    public class Tree : Plants
    {
        public int radius=0;
        public TreeType type= TreeType.leafy;
    }
}