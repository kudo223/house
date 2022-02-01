using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace house
{
    public partial class Form1 : Form
    {
        List<House> houses;
        public Form1()
        {
            InitializeComponent();
            houses = new List<House>();
        }

        private void pbUp_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pbUp.BackColor;
            colorDialog1.ShowDialog();
            pbUp.BackColor = colorDialog1.Color;
        }

        private void pbDown_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pbDown.BackColor;
            colorDialog1.ShowDialog();
            pbDown.BackColor = colorDialog1.Color;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            House house = new House(pbUp.ForeColor,pbDown.BackColor,Convert.ToInt32(numVertical.Value),Convert.ToInt32(numHorizontal.Value),Convert.ToInt32(numHeight.Value));
            house.Location = new Point(random.Next(0, pbCanvas.Width), random.Next(0,pbCanvas.Height));
            houses.Add(house);
            pbCanvas.Refresh();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach(var house in houses)
            {
                house.Draw(e.Graphics);
            }
        }
    }
}
