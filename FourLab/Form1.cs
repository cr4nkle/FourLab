using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourLab
{
    public partial class Form1 : Form
    {
        List<Plants> plantList = new List<Plants>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.plantList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0: 
                        this.plantList.Add(new Flowers());
                        break;
                    case 1: 
                        this.plantList.Add(new Bush());
                        break;
                    case 2: 
                        this.plantList.Add(new Tree());
                        break;
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            int flowersCount = 0;
            int bushCount = 0;
            int treeCount = 0;

            foreach (var plant in this.plantList)
            {
                if (plant is Flowers) 
                {
                    flowersCount++;
                }
                else if (plant is Bush)
                {
                    bushCount++;
                }
                else if (plant is Tree)
                {
                    treeCount++;
                }
            }
            richTextBox2.Text = "Цветок\tКуст\tДерево";
            richTextBox2.Text += "\n";
            richTextBox2.Text += String.Format("{0}\t{1}\t{2}", flowersCount, bushCount, treeCount);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
