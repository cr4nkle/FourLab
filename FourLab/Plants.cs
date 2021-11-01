using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLab
{ 
    public class Plants
    {
        public int height=9;
        public virtual string GetInfo()
        {
            return "Я растение";
        }
    }

    public enum FlowerType { garden, forest, wild }
    public class Flowers : Plants
    {
        public int PetalCount=0;
        public string colour="blue";
        public FlowerType type= FlowerType.wild;

        public override string GetInfo()
        {
            var str = "Цветок";
            str += String.Format("\tСпелость{0}", this.height);
            return str;
        }
    }

    public class Bush : Plants
    {
        public bool WithFlower=true;
        public int BranchCount=0;

        public override string GetInfo()
        {
            var str = "Кустарник";
            str += String.Format("\tСпелость{0}", this.height);
            return str;
        }
    }

    public enum TreeType { coniferous, leafy }
    public class Tree : Plants
    {
        public int radius=0;
        public TreeType type= TreeType.leafy;

        public override string GetInfo()
        {
            var str = "Дерево";
            str += String.Format("\tСпелость{0}", this.height);
            return str;
        }
    }
}