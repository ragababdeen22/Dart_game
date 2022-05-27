using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Shoot()
        {
            Arrow.Left += 100;
            if (Arrow.Left > 600)
            {
                player.Image = Properties.Resources.idle;
                Arrow.Image = Properties.Resources.arrow;
                Arrow.Top = player.Top + 35;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Arrow.Left = player.Left;
                player.Image = Properties.Resources.shoot;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (player.Top > 50)
                {
                    player.Top -= 10;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (player.Top < 230)
                {
                    player.Top += 10;
                }
            }

        }

        void Balloon()
        {
            Random rnd = new Random();
            int x, y, z;
            if (b_1.Top < 20)
            {
                b_1.Top = 300;
                x = rnd.Next(200, 600);
                b_1.Location = new Point(x, 500);
            }
            if (b_2.Top < 20)
            {
                b_2.Top = 300;
                y = rnd.Next(200, 600);
                b_2.Location = new Point(y, 500);
            }
            if (b_3.Top < 20)
            {
                b_3.Top = 300;
                z = rnd.Next(200, 600);
                b_3.Location = new Point(z, 500);
            }
            else
            {
                b_1.Top -= 5;
                b_2.Top -= 8;
                b_3.Top -= 10;
            }
        }

        int score;
        void Game()
        {
            if (Arrow.Bounds.IntersectsWith(b_1.Bounds))
            {
                b_1.Top = 400;
                score += 1;
                lbl_score.Text = "Score :" + score;
                Arrow.Image = Properties.Resources.Explosion;
            }
            if (Arrow.Bounds.IntersectsWith(b_2.Bounds))
            {
                b_2.Top = 400;
                score += 1;
                lbl_score.Text = "Score :" + score;
                Arrow.Image = Properties.Resources.Explosion;
            }
            if (Arrow.Bounds.IntersectsWith(b_3.Bounds))
            {
                b_3.Top = 400;
                score += 1;
                lbl_score.Text = "Score :" + score;
                Arrow.Image = Properties.Resources.Explosion;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Shoot();
            Balloon();
            Game();


        }
    }
}






















