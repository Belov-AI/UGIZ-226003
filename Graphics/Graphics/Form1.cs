using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();

            //SetStyle(ControlStyles.ResizeRedraw, true);

            
        }

        private void линияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var pen = new Pen(Color.Red, 10))
            {
                g.DrawLine(pen, 80, 40, 200, 200);
            }
        }
    }
}
