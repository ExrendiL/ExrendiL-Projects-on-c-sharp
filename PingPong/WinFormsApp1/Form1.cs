using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 4;
        private int speed_horizontal = 4;

        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;
            gplatform.Top = bg.Bottom - (bg.Bottom / 10);
            looslab.Visible = false;
            looslab.Left = (bg.Width/2)-(looslab.Width/2);
            looslab.Top = (bg.Height / 2) - (looslab.Height / 2);
        }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.R)
            {
                gboll.Top = 50;
                gboll.Left = 70;
                speed_horizontal = 3;
                speed_vertical = 3;
                score = 0;
                looslab.Visible = false;
                timer1.Enabled = true;
                res.Text = "Score: 0";
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gplatform.Left = Cursor.Position.X - (gplatform.Width / 2);
            gboll.Left += speed_horizontal;
            gboll.Top += speed_vertical;

            if (gboll.Left <= bg.Left)
                speed_horizontal *= -1;
            if (gboll.Right >= bg.Right)
                speed_horizontal *= -1;
            if (gboll.Top <= bg.Top)
                speed_vertical *= -1;
            if (gboll.Bottom >= bg.Bottom)
            {
                timer1.Enabled = false;
                looslab.Visible = true;
            }
                
            if (gboll.Bottom >= gplatform.Top && gboll.Bottom <= gplatform.Bottom &&
                gboll.Left >= gplatform.Left && gboll.Right <= gplatform.Right)
            {
                speed_horizontal += 3;
                speed_vertical += 3;
                speed_vertical *= -1;
                score +=1;
                res.Text = "Score: " + score.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
