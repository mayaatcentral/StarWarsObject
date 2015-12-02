///made by Maya Stuart
///on December 2nd, 2015
///moves and scales an exhaust port to put into a program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ExhaustPort(245, 62, 20, 205);
        }

        /// <summary>
        /// Moves and scales an exhaust port to put into a program
        /// </summary>
        /// <param name="x">the x-coordinate of the exhaust port</param>
        /// <param name="y">the y-coordinate of the exhaust port</param>
        /// <param name="width">the width of the exhaust port</param>
        /// <param name="height">the height of the exhaust port</param>
        public void ExhaustPort (float x, float y, float width, float height)
        {
            float scaleWidth = width / 80;
            float scaleHeight = height / 120;
            Pen drawPen = new Pen(Color.White);
            Pen drawPen2 = new Pen(Color.Red);

            g.DrawRectangle(drawPen, x, y, width, height);

            //Draw two outside lines
            g.DrawLine(drawPen, (30 * scaleWidth + x), (20 * scaleHeight + y), (30 * scaleWidth + x), (100 * scaleHeight + y));
            g.DrawLine(drawPen, (50 * scaleWidth + x), (20 * scaleHeight + y), (50 * scaleWidth + x), (100 * scaleHeight + y));

            //Draw 2 triangles
            g.DrawLine(drawPen, (30 * scaleWidth + x), (20 * scaleHeight + y), (15 * scaleWidth + x), (20 * scaleHeight + y));
            g.DrawLine(drawPen, (50 * scaleWidth + x), (20 * scaleHeight + y), (65 * scaleWidth + x), (20 * scaleHeight + y));
            g.DrawLine(drawPen, (15 * scaleWidth + x), (20 * scaleHeight + y), (35 * scaleWidth + x), (0 * scaleHeight + y));
            g.DrawLine(drawPen, (65 * scaleWidth + x), (20 * scaleHeight + y), (45 * scaleWidth + x), (0 * scaleHeight + y));

            //Draw 2 inside, red lines
            g.DrawLine(drawPen2, (35 * scaleWidth + x), (0 * scaleHeight + y), (35 * scaleWidth + x), (100 * scaleHeight + y));
            g.DrawLine(drawPen2, (45 * scaleWidth + x), (0 * scaleHeight + y), (45 * scaleWidth + x), (100 * scaleHeight + y));

            //Draw 2 connecting squares
            g.DrawLine(drawPen, (30 * scaleWidth + x), (100 * scaleHeight + y), (0 * scaleWidth + x), (100 * scaleHeight + y));
            g.DrawLine(drawPen, (50 * scaleWidth + x), (100 * scaleHeight + y), (80 * scaleWidth + x), (100 * scaleHeight + y));
            g.DrawLine(drawPen, (0 * scaleWidth + x), (100 * scaleHeight + y), (0 * scaleWidth + x), (120 * scaleHeight + y));
            g.DrawLine(drawPen, (80 * scaleWidth + x), (100 * scaleHeight + y), (80 * scaleWidth + x), (120 * scaleHeight + y));

            g.DrawArc(drawPen2, (30 * scaleWidth + x), (100 * scaleHeight + y), 20 * scaleWidth, 20 * scaleHeight, 300, 300);

        }
    }

}
