using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 5;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeDown.Left < -50)
            {
                pipeDown.Left = 600;
                score++;
            }
            if(pipeTop.Left < -50)
            {
                pipeTop.Left = 700;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeDown.Bounds) ||
            flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
            flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
