using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gameOn = false;
        int speedX = -30;
        int speedY = -6;
        int player1Speed = 5;
        int player2Speed = 5;
        bool player1Up, player2Up, player1Down, player2Down = false;

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            stillRunning();
            if (gameOn)
            {
                moveBall();
                if (player1Up && !Collision_Top(player2))
                {
                    player2.Top -= player1Speed;
                }
                if (player1Down && !Collision_Bottom(player2))
                {
                    player2.Top += player1Speed;
                }
                if (player2Up && !Collision_Top(player1))
                {
                    player1.Top -= player2Speed;
                }
                if (player2Down && !Collision_Bottom(player1))
                {
                    player1.Top += player2Speed;
                }
            }
        }

        private void stillRunning()
        {
            if (player1Score.Text == "xxxxx" || player2Score.Text == "xxxxx")
            {
                gameOn = false;
                pressStartToPlay.Text = (player1Score.Text == "xxxxx") ? "Winner: Player1" : "Winner: Player2";
                pressStartToPlay.Visible = true;
                ball.Visible = false;
            }
        }

        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.O:
                    player1Down = false;
                    player1Up = true;
                    break;
                case Keys.L:
                    player1Up = false;
                    player1Down = true;
                    break;
                case Keys.W:
                    player2Up = true;
                    player2Down = false;
                    break;
                case Keys.S:
                    player2Up = false;
                    player2Down = true;
                    break;
                case Keys.Space:
                    gameOn = true;
                    pressStartToPlay.Visible = false;
                    Pirate.Visible = false;
                    ball.Visible = true;
                    break;
                case Keys.Escape:
                    gameOn = false;
                    pressStartToPlay.Text = "Paused";
                    pressStartToPlay.Visible = true;
                    break;
            }
        }

        private void Player_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.O:
                    player1Up = false;
                    break;
                case Keys.W:
                    player2Up = false;
                    break;
                case Keys.L:
                    player1Down = false;
                    break;
                case Keys.S:
                    player2Down = false;
                    break;
            }
        }

        public void moveBall()
        {
            
            if (Collision_Right(ball))
            {
                speedX *= -1;
                speedY *= 1;
                
            }
                
            if (Collision_Left(ball))
            {
                speedX *= -1;
                speedY *= 1;
                
            }
                
            if (Collision_Top(ball))
            {
                speedX *= 1;
                speedY *= -1;
            }
                
            if (Collision_Bottom(ball))
            {
                speedX *= 1;
                speedY *= -1;
            }
            if (Collision_Player1(ball))
            {
                speedX *= -1;
                speedY *= 1;
                player2Score.Text += "x";
                ball.Location = new Point(player1.Top -40, 227);
            }
            if (Collision_Player2(ball))
            {
                speedX *= -1;
                speedY *= 1;
                player1Score.Text += "x";
                ball.Location = new Point(player2.Top - 40, 227);
            }

            int ballx = ball.Location.X;
            int bally = ball.Location.Y;
            ball.Location = new Point(ballx + speedX, bally + speedY);
        }

        public Boolean Collision_Left(PictureBox obj)
        {
            if (obj.Location.X <= 0)
                return true;
            return false;
        }

        public Boolean Collision_Right(PictureBox obj)
        {
            if (obj.Location.X >= 755)
                return true;
            return false;
        }

        public Boolean Collision_Top(PictureBox obj)
        {
            if (obj.Location.Y <= 0)
                return true;
            return false;
        }

        public Boolean Collision_Bottom(PictureBox obj)
        {
            if (obj.Location.Y + obj.Height >= 410)
                return true;
            return false;
        }

        public bool Collision_Player1(PictureBox ball)
        {
            if (player1.Bounds.IntersectsWith(ball.Bounds))
            {
                Collision_Right(ball);
                return true;
            }
            return false;
        }
        public bool Collision_Player2(PictureBox ball)
        {
            if (player2.Bounds.IntersectsWith(ball.Bounds))
            {
                Collision_Left(ball);
                return true;
            }
            return false;
        }
    }
}
