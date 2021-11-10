using System;
using System.Collections.Generic;
using System.Drawing;
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

        public virtual Image GetPicture()
        {
            return Properties.Resources.plant;
        }
    }

    public enum FlowerType { Садовые, Лесные, Полевые }
    public enum FlowerColour { Синий, Розовый, Красный, Оранжевый, Белый }
    public class Flowers : Plants
    {
        public int petalCount=0;
        public FlowerColour colour=FlowerColour.Синий;
        public FlowerType type= FlowerType.Полевые;

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
                height = 1 + rnd.Next() % 5,
                petalCount = 1 + rnd.Next() % 30,
                colour = (FlowerColour)rnd.Next(5),
                type = (FlowerType)rnd.Next(2) 
            };
        }
        public override Image GetPicture()
        {
            Image str = null;
            if (colour == FlowerColour.Синий)
            {
                str = Properties.Resources.flowerB;
            }
            else if (colour == FlowerColour.Розовый)
            {
                str = Properties.Resources.flowerP;
            }
            else if (colour == FlowerColour.Красный)
            {
                str = Properties.Resources.flowerR;
            }
            else if(colour == FlowerColour.Оранжевый)
            {
                str = Properties.Resources.flowerO;
            }
            else if(colour == FlowerColour.Белый)
            {
                str = Properties.Resources.flowerW;
            }
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
        public override Image GetPicture()
        {
            return Properties.Resources.bush;
        }
    }

    public enum TreeType { Хвойное, Листовые }
    public class Tree : Plants
    {
        public int radius=0;
        public TreeType type= TreeType.Листовые;

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
        public override Image GetPicture()
        {
            Image str = null;
            if (type == TreeType.Хвойное)
            {
                str = Properties.Resources.treeC;
            }
            else if (type == TreeType.Листовые)
            {
                str = Properties.Resources.treeL ;
            }
            
            return str;
        }
    }
}