using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void shoot()
        {
            arrow.Left += 100;
            if (arrow.Left > 600)
            {
                player.Image=
                player.Image = Properties.Resources.idle;
                arrow.Image = Properties.Resources.arrow;
                arrow.Top = player.Top + 15;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                arrow.Left = player.Left;
                player.Image = Properties.Resources.shoot;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (player.Top > 50) { player.Top -= 20; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (player.Top < 230) { player.Top += 10; }
            }
        }
    }
}
