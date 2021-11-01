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
            var str = "";
            str += String.Format("\nВысота: {0}", this.height);
            str += "\n";
            return str;
        }
        public static Random rnd = new Random();
    }

    public enum FlowerType { garden, forest, wild }
    public enum FlowerColour { blue, pink, red, orange, white }
    public class Flowers : Plants
    {
        public int petalCount=0;
        public FlowerColour colour=FlowerColour.blue;
        public FlowerType type= FlowerType.wild;

        public override string GetInfo()
        {
            var str = "Цветок";
            
            str += String.Format("\nКоличество лепестков: {0}", this.petalCount);
            str += String.Format("\nЦвет: {0}", this.colour);
            str += String.Format("\nТип цветка: {0}", this.type);
            str += base.GetInfo();
            return str;
        }

        public static Flowers Generate()
        {
            return new Flowers
            {
                height = 1 + rnd.Next() % 100,
                colour = (FlowerColour)rnd.Next(5),
                type = (FlowerType)rnd.Next(2) 
            };
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
            str += base.GetInfo();
            return str;
        }

        public static Bush Generate()
        {
            return new Bush
            {
                height = 1 + rnd.Next() % 10,
                withFlower = rnd.Next() % 2 ==0,
                branchCount = 1 + rnd.Next() % 10
            };
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
            str += base.GetInfo();
            return str;
        }

        public static Tree Generate()
        {
            return new Tree
            {
                height = 1 + rnd.Next() % 100,
                radius = 10 + rnd.Next() % 40,
                type = (TreeType)rnd.Next(2)
            };
        }
    }
}