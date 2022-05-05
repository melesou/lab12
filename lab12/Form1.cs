using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.BackColor = Color.Black; 
            g = panel1.CreateGraphics();
        }

        Color color = Color.Black; 
        bool isPressed = false; 
        Point CurrentPoint; 
        Point PrevPoint; 
        Graphics g; 
        ColorDialog colorDialog = new ColorDialog();

        private void label2_Click(object sender, EventArgs e)
        {
            colorDialog.Color = label2.BackColor;
            color = colorDialog.Color;
        }

        private void my_Pen()
        {
            Pen pen = new Pen(color, (float)numericUpDown1.Value);
            g.DrawLine(pen, CurrentPoint, PrevPoint);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void down(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
        }

        private void up(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void move(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                my_Pen();
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Refresh();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            colorDialog.Color = label7.BackColor;
            color = colorDialog.Color;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            colorDialog.Color = label4.BackColor;
            color = colorDialog.Color;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            colorDialog.Color = label5.BackColor;
            color = colorDialog.Color;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            colorDialog.Color = label17.BackColor;
            color = colorDialog.Color;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            colorDialog.Color = label18.BackColor;
            color = colorDialog.Color;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            colorDialog.Color = label19.BackColor;
            color = colorDialog.Color;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            colorDialog.Color = label20.BackColor;
            color = colorDialog.Color;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                label21.BackColor = colorDialog.Color;
            }
        }
    }
}
