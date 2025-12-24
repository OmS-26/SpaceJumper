
namespace SpaceJumper
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            this.picUFO1 = new System.Windows.Forms.PictureBox();
            this.picAsteroid3 = new System.Windows.Forms.PictureBox();
            this.picAsteroid2 = new System.Windows.Forms.PictureBox();
            this.picAsteroid1 = new System.Windows.Forms.PictureBox();
            this.picAstronaut = new System.Windows.Forms.PictureBox();
            this.picUFO2 = new System.Windows.Forms.PictureBox();
            this.picUFO3 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRuleBox = new System.Windows.Forms.Label();
            this.lblEscPause = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsteroid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsteroid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsteroid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAstronaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(255, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(661, 108);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Space Jumper";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStart.Location = new System.Drawing.Point(564, 154);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(296, 37);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Press Enter to Start";
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(245, 297);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(566, 108);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over ";
            this.lblGameOver.Visible = false;
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.ForeColor = System.Drawing.Color.Red;
            this.lblRestart.Location = new System.Drawing.Point(201, 405);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(679, 37);
            this.lblRestart.TabIndex = 6;
            this.lblRestart.Text = "Press R to Restart or Backspace to Quit Game";
            this.lblRestart.Visible = false;
            // 
            // picUFO1
            // 
            this.picUFO1.Image = global::SpaceJumper.Properties.Resources.UFO_image;
            this.picUFO1.Location = new System.Drawing.Point(1146, 47);
            this.picUFO1.Margin = new System.Windows.Forms.Padding(2);
            this.picUFO1.Name = "picUFO1";
            this.picUFO1.Size = new System.Drawing.Size(49, 44);
            this.picUFO1.TabIndex = 8;
            this.picUFO1.TabStop = false;
            this.picUFO1.Visible = false;
            // 
            // picAsteroid3
            // 
            this.picAsteroid3.Image = global::SpaceJumper.Properties.Resources.Asteroid_game;
            this.picAsteroid3.Location = new System.Drawing.Point(1226, 354);
            this.picAsteroid3.Name = "picAsteroid3";
            this.picAsteroid3.Size = new System.Drawing.Size(65, 60);
            this.picAsteroid3.TabIndex = 7;
            this.picAsteroid3.TabStop = false;
            this.picAsteroid3.Visible = false;
            // 
            // picAsteroid2
            // 
            this.picAsteroid2.Image = global::SpaceJumper.Properties.Resources.Asteroid_game;
            this.picAsteroid2.Location = new System.Drawing.Point(1226, 607);
            this.picAsteroid2.Name = "picAsteroid2";
            this.picAsteroid2.Size = new System.Drawing.Size(65, 60);
            this.picAsteroid2.TabIndex = 4;
            this.picAsteroid2.TabStop = false;
            this.picAsteroid2.Visible = false;
            // 
            // picAsteroid1
            // 
            this.picAsteroid1.Image = global::SpaceJumper.Properties.Resources.Asteroid_game;
            this.picAsteroid1.Location = new System.Drawing.Point(1226, 47);
            this.picAsteroid1.Name = "picAsteroid1";
            this.picAsteroid1.Size = new System.Drawing.Size(56, 51);
            this.picAsteroid1.TabIndex = 3;
            this.picAsteroid1.TabStop = false;
            this.picAsteroid1.Visible = false;
            // 
            // picAstronaut
            // 
            this.picAstronaut.BackColor = System.Drawing.Color.Transparent;
            this.picAstronaut.Image = global::SpaceJumper.Properties.Resources.astronaut_gamne_final;
            this.picAstronaut.Location = new System.Drawing.Point(66, 264);
            this.picAstronaut.Margin = new System.Windows.Forms.Padding(2);
            this.picAstronaut.Name = "picAstronaut";
            this.picAstronaut.Size = new System.Drawing.Size(68, 98);
            this.picAstronaut.TabIndex = 2;
            this.picAstronaut.TabStop = false;
            // 
            // picUFO2
            // 
            this.picUFO2.Image = global::SpaceJumper.Properties.Resources.UFO_image;
            this.picUFO2.Location = new System.Drawing.Point(1153, 623);
            this.picUFO2.Margin = new System.Windows.Forms.Padding(2);
            this.picUFO2.Name = "picUFO2";
            this.picUFO2.Size = new System.Drawing.Size(49, 44);
            this.picUFO2.TabIndex = 9;
            this.picUFO2.TabStop = false;
            this.picUFO2.Visible = false;
            // 
            // picUFO3
            // 
            this.picUFO3.Image = global::SpaceJumper.Properties.Resources.UFO_image;
            this.picUFO3.Location = new System.Drawing.Point(1153, 355);
            this.picUFO3.Margin = new System.Windows.Forms.Padding(2);
            this.picUFO3.Name = "picUFO3";
            this.picUFO3.Size = new System.Drawing.Size(49, 44);
            this.picUFO3.TabIndex = 10;
            this.picUFO3.TabStop = false;
            this.picUFO3.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScore.Location = new System.Drawing.Point(472, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 33);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score: ";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblScore.Visible = false;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.Cyan;
            this.lblPause.Location = new System.Drawing.Point(466, 264);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(113, 33);
            this.lblPause.TabIndex = 12;
            this.lblPause.Text = "Paused";
            this.lblPause.Visible = false;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(103, 309);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(876, 279);
            this.lblRules.TabIndex = 15;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            this.lblRules.Visible = false;
            // 
            // lblRuleBox
            // 
            this.lblRuleBox.AutoSize = true;
            this.lblRuleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleBox.Location = new System.Drawing.Point(257, 156);
            this.lblRuleBox.Name = "lblRuleBox";
            this.lblRuleBox.Size = new System.Drawing.Size(249, 33);
            this.lblRuleBox.TabIndex = 16;
            this.lblRuleBox.Text = "Press 1 For Rules";
            // 
            // lblEscPause
            // 
            this.lblEscPause.AutoSize = true;
            this.lblEscPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscPause.Location = new System.Drawing.Point(3, 16);
            this.lblEscPause.Name = "lblEscPause";
            this.lblEscPause.Size = new System.Drawing.Size(196, 25);
            this.lblEscPause.TabIndex = 17;
            this.lblEscPause.Text = "Press esc to pause";
            this.lblEscPause.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1028, 686);
            this.Controls.Add(this.lblEscPause);
            this.Controls.Add(this.lblRuleBox);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.picAstronaut);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picUFO3);
            this.Controls.Add(this.picUFO2);
            this.Controls.Add(this.picUFO1);
            this.Controls.Add(this.picAsteroid3);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picAsteroid2);
            this.Controls.Add(this.picAsteroid1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Space Jumper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picUFO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsteroid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsteroid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAsteroid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAstronaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUFO3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox picAstronaut;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox picAsteroid1;
        private System.Windows.Forms.PictureBox picAsteroid2;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.PictureBox picAsteroid3;
        private System.Windows.Forms.PictureBox picUFO1;
        private System.Windows.Forms.PictureBox picUFO2;
        private System.Windows.Forms.PictureBox picUFO3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblRuleBox;
        private System.Windows.Forms.Label lblEscPause;
    }
}

