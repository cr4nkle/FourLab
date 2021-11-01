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
            var str = "Я растение";
            str += String.Format("\tВысота: {0}", this.height);
            return str;
        }
    }

    public enum FlowerType { garden, forest, wild }
    public class Flowers : Plants
    {
        public int petalCount=0;
        public string colour="blue";
        public FlowerType type= FlowerType.wild;

        public override string GetInfo()
        {
            var str = "Цветок";
            str += base.GetInfo();
            str += String.Format("\nКоличество лепестков: {0}", this.petalCount);
            str += String.Format("\nЦвет: {0}", this.colour);
            str += String.Format("\nТип цветка: {0}", this.type);
            return str;
        }
    }

    public class Bush : Plants
    {
        public bool withFlower=true;
        public int branchCount=0;

        public override string GetInfo()
        {
            var str = "Кустарник";
            str += String.Format("\nНаличие цветков: {0}", this.withFlower);
            str += String.Format("\nКоличество веток: {0}", this.branchCount);
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
            str += String.Format("\nРадиус: {0}", this.radius);
            str += String.Format("\nТип дерева: {0}", this.type);
            return str;
        }
    }
}