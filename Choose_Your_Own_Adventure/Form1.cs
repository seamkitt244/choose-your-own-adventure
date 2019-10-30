using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Threading;

namespace Choose_Your_Own_Adventure
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        SoundPlayer doorCreek = new SoundPlayer(Properties.Resources.doorCreek);
        SoundPlayer typing = new SoundPlayer(Properties.Resources.typing);
        SoundPlayer clothes = new SoundPlayer(Properties.Resources.clothesDryer);
        int scene = 0, choice, musicChoice,podcastChoice;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)//Third option
            {
                if (scene == 0) { scene = 1; startPictureBox.Visible = false; backdrop.BackColor = Color.Black; }
                else if (scene == 3) { scene = 11; }
            }
            if (e.KeyCode == Keys.B)//The yes answer
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 9; }
                else if (scene == 4)
                {
                    choice = randGen.Next(1, 3); if (choice == 1) { scene = 8; }
                    if (choice == 2) { scene = 6; } //One of the random encounters
                }
                else if (scene == 11) { scene = 13; }
            }
            if (e.KeyCode == Keys.M)//The No answer
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 3) { scene = 10; }
                else if (scene == 11) { scene = 14; }
            }

            switch (scene)
            {
              //case 0: //starting scene
                            //startPictureBox.Visible = false; titlePictureBox.Visible = false;
                            //backdrop.BackColor = Color.Black;
                            //gameLabel.AutoSize = false; gameLabel.Width = 882;
                            //startLabel.Visible = true;
                            //gamePictureBox.Visible = true;
                            //leftPictureBox.Visible = true;
                            // middlePictureBox.Visible = true;
                            //typing.Play();
              //  break;
              case 1:
                 gameLabel.Visible = true;
                 questionLabel.Visible = true;
                 startLabel.Visible = false;
                 gameLabel.Text = "After your Chemistry 101 Midterm you and your buddy James get out as fast as you can, its the start for reading week and you don't have a clue what you're going to do besides study.  James suggests that you and him go up to his family's cottage on crystal lake.";
                 questionLabel.Text = "Would you like to go?";
                 gamePictureBox.BackgroundImage = (Properties.Resources.scene1);
                 typing.Play();
                 leftPictureBox.Visible = true;
                 middlePictureBox.Visible = true;
                 break;
              case 2:
                gameLabel.Text = "Its all planned out, you and James are going to the lake house for reading week.";
                questionLabel.Text = "Start packing for the week, or just wait till last minute?";
                gamePictureBox.BackgroundImage = (Properties.Resources.scene2);
                leftPictureBox.BackgroundImage = (Properties.Resources.startBlue);
                middlePictureBox.BackgroundImage = (Properties.Resources.don_tStart);
                middlePictureBox.Visible = true;
                clothes.Play();
                break;
              case 3:
                gameLabel.Text = "Well James is off to his cottage, and the rest of your friends are going home for reading week.  You've got a long time to study, eat pizza, and play video games.";
                gamePictureBox.BackgroundImage = (Properties.Resources.scene3);
                questionLabel.Text = "What do you want to do  first after getting home?";
                leftPictureBox.BackgroundImage = (Properties.Resources.study);
                middlePictureBox.BackgroundImage = (Properties.Resources.videoGames);
                rightPictureBox.BackgroundImage = (Properties.Resources.pizza);
                rightPictureBox.Visible = true;
                break;
              case 4:
                gameLabel.Text = "Good idea, leaving it to the last minute makes it almost impossible to remember everything you need.";
                questionLabel.Text = "Do you want to text James and ask him what to bring?";
                gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                middlePictureBox.BackgroundImage = (Properties.Resources.no);
                typing.Play();
                break;
              case 5:
                gameLabel.Text = "Surely it's just a normal cottage, pack a swim suit and a towel and you'll be good.";
                questionLabel.Text = "Do you want to text James and ask him what to bring?";
                gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                middlePictureBox.BackgroundImage = (Properties.Resources.no);
                break;
              case 6:
                gameLabel.Text = "Guess James fell asleep, you should do the same, after getting your bag packed with whatever semi clean clothes you have.'ll be good.";
                gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                middlePictureBox.BackgroundImage = (Properties.Resources.no);
                Thread.Sleep(2000);
                scene = 7;
                break;
              case 7:
                gameLabel.Text = "fucking nihasdbfasbd";
                break;
              case 8:
                    gameLabel.Text = "He replies fast, and tells you to pack warm clothes, a flash light, and bug repellent, the mosquitoes are still terrible.";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    Thread.Sleep(10000);
                    scene = 16;
                    break;
              case 9:
                break;
              case 10:
                    gameLabel.Text = "You get in a good eight hour session of Counter strike and fall asleep.";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    Thread.Sleep(10000);
                    scene = 16;
                    break;
              case 11:
                gameLabel.Text = "You go to the closest pizza place on campus 'EL Pizza DeJourno' which is always subpar.";
                questionLabel.Text = "What type of pizza do you order?  Ghost pepperoni, or cheese";
                gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                leftPictureBox.BackgroundImage = (Properties.Resources.cheese);
                middlePictureBox.BackgroundImage = (Properties.Resources.pepper);
                rightPictureBox.Visible = false;
                break;
              case 12:
                    gameLabel.Text = "You go to the closest pizza place on campus 'EL Pizza DeJourno' which is always subpar.";
                    questionLabel.Text = "What type of pizza do you order?  Ghost pepperoni, or cheese";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                    break;
              case 13:
                    gameLabel.Text = "You forgot you were lactose intolerant.  The next five days are terrible";
                    Thread.Sleep(4000);
                    scene = 40;
                break;
              case 14:
                gameLabel.Text = "Something is wrong with that pizza, you're stuck with a flu migraine sickness for the next week.";
                    Thread.Sleep(4000);
                    scene = 40;
                    break;
              case 15:
                gameLabel.Text = "James will pick you up tomorrow at 8 AM!.He pulls up out in front of your dorm.";

                break;
              case 16:
                gameLabel.Text = "James will pick you up tomorrow at 8 AM.  He pulls up out in front of your dorm.";
                questionLabel.Text = "James asks you to play something on Aux.  What do you play?";
                gamePictureBox.BackgroundImage = (Properties.Resources.Scene16);
                musicChoice = randGen.Next(1, 4); podcastChoice = randGen.Next(1, 4);
                   // if (musicChoice == 1) { leftPictureBox.BackgroundImage = (Properties.Resources.cruddyPlaylist);}
                   // else if (musicChoice ==2) {leftPictureBox.BackgroundImage = (Properties.REsources.goodPlaylist);}
                   //else if {(musicChoice ==3) {leftPictureBox.BackgroundImage = (Properties.Rsources.cousinsPlaylist);}

                    //if (podcastChoice ==1) {middlePictureBox.BackgroundImage = (Propertie.Resources.weirdJoeRogan);}
                    //else if (podcastChoice ==2) {middlePictureBox.BackgroundImage = (Properties.Resources.goodJoeRogan);}
                    //elseif (podcastChoice ==3) {middlePictureBox.BackgroundImage = (Properties.Resources.NPR);}

                      //leftPictureBox.BackgroundImage = (Properties.Resources.);
                      //middlePictureBox.BackgroundImage = (Properties.Resources. );
                        break;
              case 17:
                    gameLabel.Text = "You go to the closest pizza place on campus 'EL Pizza DeJourno' which is always subpar.";
                    questionLabel.Text = "What type of pizza do you order?  Ghost pepperoni, or cheese";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                    break;
              case 18:
                    gameLabel.Text = "You go to the closest pizza place on campus 'EL Pizza DeJourno' which is always subpar.";
                    questionLabel.Text = "What type of pizza do you order?  Ghost pepperoni, or cheese";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                    break;
              case 19:
                    gameLabel.Text = "You go to the closest pizza place on campus 'EL Pizza DeJourno' which is always subpar.";
                    questionLabel.Text = "What type of pizza do you order?  Ghost pepperoni, or cheese";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                    break;
              case 20:
                    gameLabel.Text = "You go to the closest pizza place on campus 'EL Pizza DeJourno' which is always subpar.";
                    questionLabel.Text = "What type of pizza do you order?  Ghost pepperoni, or cheese";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene4);
                    break;
              
                
                
                
                case 40:
                    gameLabel.Text = "Looks like you've had an interesting weekend.";
                    questionLabel.Text = "Would you like to play again?";
                    leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                    middlePictureBox.BackgroundImage = (Properties.Resources.no);
                break;
              case 41:
                    gameLabel.Text = "Thanks for sticking around.... credits";//still needs work you cuck?fasf
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    rightPictureBox.Visible = false;
                break;
            }

            }
        }
    }

