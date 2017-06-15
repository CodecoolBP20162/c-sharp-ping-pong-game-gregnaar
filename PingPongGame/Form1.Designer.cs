namespace PingPongGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.pressStartToPlay = new System.Windows.Forms.Label();
            this.Pirate = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pirate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 20;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(251, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player1 Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(440, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player2 Score:";
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.player1Score.Location = new System.Drawing.Point(266, 29);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(0, 20);
            this.player1Score.TabIndex = 5;
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.player2Score.Location = new System.Drawing.Point(451, 29);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(0, 20);
            this.player2Score.TabIndex = 6;
            // 
            // pressStartToPlay
            // 
            this.pressStartToPlay.AutoSize = true;
            this.pressStartToPlay.BackColor = System.Drawing.Color.Transparent;
            this.pressStartToPlay.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pressStartToPlay.Location = new System.Drawing.Point(264, 265);
            this.pressStartToPlay.Name = "pressStartToPlay";
            this.pressStartToPlay.Size = new System.Drawing.Size(258, 32);
            this.pressStartToPlay.TabIndex = 7;
            this.pressStartToPlay.Text = "Press stHARRt to play";
            // 
            // Pirate
            // 
            this.Pirate.Image = global::PingPongGame.Properties.Resources.HAR;
            this.Pirate.Location = new System.Drawing.Point(312, 108);
            this.Pirate.Name = "Pirate";
            this.Pirate.Size = new System.Drawing.Size(153, 134);
            this.Pirate.TabIndex = 8;
            this.Pirate.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::PingPongGame.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(390, 227);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            this.ball.Visible = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::PingPongGame.Properties.Resources.pirateShip2;
            this.player1.Location = new System.Drawing.Point(-24, 158);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(65, 105);
            this.player1.TabIndex = 2;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Black;
            this.player2.Image = global::PingPongGame.Properties.Resources.pirateShip;
            this.player2.Location = new System.Drawing.Point(706, 158);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(65, 105);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.BackgroundImage = global::PingPongGame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(759, 413);
            this.Controls.Add(this.Pirate);
            this.Controls.Add(this.pressStartToPlay);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HARR-pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Player_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Player_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Pirate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label pressStartToPlay;
        private System.Windows.Forms.PictureBox Pirate;
    }
}

