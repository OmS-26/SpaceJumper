using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SpaceJumper
{
    public partial class Form1 : Form
    {
        //global variables 
        int Gravity = 5;
        Random oRandom = new Random();
        PictureBox[] Asteroids;
        PictureBox[] UFO;
        int Score;
        

        public Form1()
        {
            InitializeComponent();
            lblScore.Text = "Score: " + Score;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //start game if enter clicked
            if (e.KeyCode == Keys.Enter)
            {
                StartGame();

                
            }
            //restart game
            if (e.KeyCode == Keys.R)
            {
                StartGame();
            }
            //Quit game
            if (e.KeyCode == Keys.Back)
            {
                Application.Exit();
            }
            //Character moving up 
            if (e.KeyCode == Keys.Space)
            {
                
                Gravity = -12;
            }
            //Pause game
            if (e.KeyCode == Keys.Escape)
            {
                tmrGame.Stop();
                lblPause.Visible = true;
                lblEscPause.Text = "Press P to resume";
                
            }
            //resume game 
            if (e.KeyCode == Keys.P)
            {
                lblPause.Visible = false;
                tmrGame.Start();
                lblEscPause.Text = "Press esc to pause";

            }
            //view rules
            if (e.KeyCode == Keys.D1)
            {
                lblRules.Visible = true;
                lblRuleBox.Text = "Press 2 to go back";
                picAstronaut.Visible = false;
                lblStart.Visible = false;
            }
            //back to main menu 
            if (e.KeyCode == Keys.D2)
            {
                lblRules.Visible = false;
                picAstronaut.Visible = true;
                lblStart.Visible = true ;
                lblRuleBox.Text = "Press 1 for rules";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Come back down after floating up 
            if (e.KeyCode == Keys.Space)
            {
                Gravity = 5;
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            //Create random positions for obstacles 

            int Asteroid1Height = oRandom.Next(10, this.ClientSize.Height - 50);
            int Asteroid1Width = oRandom.Next(this.ClientSize.Width + 40, this.ClientSize.Width + 1000);
            int Asteroid2Height = oRandom.Next(10, this.ClientSize.Height - 50);
            int Asteroid2Width = oRandom.Next(this.ClientSize.Width + 40, this.ClientSize.Width + 1000);
            int Asteroid3Height = oRandom.Next(10, this.ClientSize.Height - 50);
            int Asteroid3Width = oRandom.Next(this.ClientSize.Width + 40, this.ClientSize.Width + 1000);

            int UFO1Height = oRandom.Next(10, this.ClientSize.Height - 50);
            int UFO1Width = oRandom.Next(this.ClientSize.Width + 40, this.ClientSize.Width + 1000);
            int UFO2Height = oRandom.Next(10, this.ClientSize.Height - 50);
            int UFO2Width = oRandom.Next(this.ClientSize.Width + 40, this.ClientSize.Width + 1000);
            int UFO3Height = oRandom.Next(10, this.ClientSize.Height - 50);
            int UFO3Width = oRandom.Next(this.ClientSize.Width + 40, this.ClientSize.Width + 1000);

            //Stopping obstacles from overlapping 
            if (picAsteroid1.Bounds.IntersectsWith(picAsteroid2.Bounds))
            {
                picAsteroid1.Top += 10;
            }
            if (picAsteroid2.Bounds.IntersectsWith(picAsteroid3.Bounds))
            {
                picAsteroid2.Top += 10;
            }
            if (picAsteroid3.Bounds.IntersectsWith(picAsteroid1.Bounds))
            {
                picAsteroid3.Top += 10;
            }


            //make astronaut movements equal to variable 
            picAstronaut.Top += Gravity;
            //stop astronaut from going off screen
            if (picAstronaut.Bottom >= this.ClientSize.Height)
            {
                Gravity = 0;
            }


            //move the asteroids 
            for (int i = 0; i < Asteroids.Length; i++)
            {

                Asteroids[0].Left -= oRandom.Next(5, 9);
                Asteroids[1].Left -= oRandom.Next(5, 9);
                Asteroids[2].Left -= oRandom.Next(5, 9);

                //reposition the asteroids when they go off the screen 
                if (Asteroids[0].Left < -70)
                {
                    Asteroids[0].Left = Asteroid1Width;
                    Asteroids[0].Top = Asteroid1Height;
                    Score++;
                }
                if (Asteroids[1].Left < -70)
                {
                    Asteroids[1].Left = Asteroid2Width;
                    Asteroids[1].Top = Asteroid2Height;
                }
                if (Asteroids[2].Left < -70)
                {
                    Asteroids[2].Left = Asteroid3Width;
                    Asteroids[2].Top = Asteroid3Height;

                }
                lblScore.Text = "Score: " + Score;

            }
            //Send UFOs at random speed
            for (int i = 0; i < UFO.Length; i++)
            {

                UFO[0].Left -= oRandom.Next(7, 12);
                UFO[1].Left -= oRandom.Next(7, 12);
                UFO[2].Left -= oRandom.Next(7, 12);


                //reposition the asteroids when they go off the screen 
                if (UFO[0].Left < -70)
                {
                    UFO[0].Left = UFO1Width;
                    UFO[0].Top = UFO1Height;
                }
                if (UFO[1].Left < -70)
                {
                    UFO[1].Left = UFO2Width;
                    UFO[1].Top = UFO2Height;
                }
                if (UFO[2].Left < -70)
                {
                    UFO[2].Left = UFO3Width;
                    UFO[2].Top = UFO3Height;
                }

            }

            //end game 
            for (int i = 0; i < Asteroids.Length; i++)
            {
                if (Asteroids[i].Bounds.IntersectsWith(picAstronaut.Bounds))
                {
                    EndGame();

                }
                if (UFO[i].Bounds.IntersectsWith(picAstronaut.Bounds))
                {
                    EndGame();


                }

                if (picAstronaut.Top <= -60)

                {
                    EndGame();

                }

            }
        }
        //initialize game 
        private void StartGame()
        {
            Score = 0; 
            picAstronaut.Visible = true; 
            lblStart.Visible = false;
            lblRuleBox.Visible = false; 
            lblTitle.Visible = false;
            lblRestart.Visible = false;
            lblEscPause.Visible = true;
            picAsteroid1.Visible = true;
            picAsteroid2.Visible = true;
            picAsteroid3.Visible = true;
            picUFO1.Visible = true;
            picUFO2.Visible = true;
            lblScore.Visible = true;



            picUFO3.Visible = true;

            Asteroids = new PictureBox[3];
            Asteroids[0] = picAsteroid1;
            Asteroids[1] = picAsteroid2;
            Asteroids[2] = picAsteroid3;

            UFO = new PictureBox[3];
            UFO[0] = picUFO1;
            UFO[1] = picUFO2;
            UFO[2] = picUFO3;

            tmrGame.Enabled = true;
        }

        //End game function
        private void EndGame()
        {
            tmrGame.Stop();
            picAstronaut.Visible = false;
            picAsteroid1.Visible = false;
            picAsteroid2.Visible = false;
            picAsteroid3.Visible = false;
            lblEscPause.Visible = false; 
            picUFO1.Visible = false;
            picUFO2.Visible = false;
            picUFO3.Visible = false;
            lblRestart.Visible = true;

            picAstronaut.Location = new Point(66, 264);
            picAsteroid1.Location = new Point(1226, 47);
            picAsteroid2.Location = new Point(1226, 607);
            picAsteroid3.Location = new Point(1226, 354);
            picUFO1.Location = new Point(1146, 47);
            picUFO2.Location = new Point(1153, 355);
            picUFO3.Location = new Point(1153, 623);
        }

        
    }
    }

