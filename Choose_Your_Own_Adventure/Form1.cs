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
        int scene = 0, choice, gotgas = 0;
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
            if (e.KeyCode == Keys.B)//The Blue answer
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 3) { scene = 9; }
                else if (scene == 4) { choice = randGen.Next(1, 4); if (choice == 1 | choice == 2) { scene = 8; } else { scene = 6; } }
                else if (scene == 5) { scene = 17; }
                else if (scene == 6) { scene = 17; }
                else if (scene == 8) { scene = 17; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 10) { scene = 0; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 17; }
                else if (scene == 17) { scene = 20; }
                else if (scene == 20) { scene = 23; }//23 is combined with scene 24//
                else if (scene == 69) { scene = 69; }
            }
            if (e.KeyCode == Keys.M)//The red answer
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 15; }
                else if (scene == 3) { scene = 10; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 19; }
                else if (scene == 8) { scene = 19; }
                else if (scene == 10) { scene = 41; }
                else if (scene == 11) { scene = 14; }
                else if (scene == 13) { scene = 40; }
                else if (scene == 14) { scene = 40; }
                else if (scene == 15) { scene = 19; }
                else if (scene == 17) { scene = 25; }
                else if (scene == 20) { scene = 22; }//not scene 22 is combinded with 24//
                else if (scene == 69) { scene = 69; }
                else if (scene == 69) { scene = 69; }
                else if (scene == 69) { scene = 69; }
            }

            switch (scene)
            {
                case 0: //starting scene
                    startPictureBox.Visible = true;
                    gameLabel.Visible = false;
                    questionLabel.Visible = false;
                    gamePictureBox.BackgroundImage = (Properties.Resources.title_Choose_your_own_adventure);
                    startLabel.Visible = true;
                    startLabel.Visible = true;
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    gotgas = 0;
                    //typing.Play();
                    break;
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
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene5);
                    Refresh();
                    Thread.Sleep(3000);

                    gameLabel.Text = "James will pick you up tomorrow at 8 AM!.  He pulls up out in front of your dorm";
                    leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                    middlePictureBox.BackgroundImage = (Properties.Resources.no);
                    questionLabel.Text = "James asks you to play something on the radio.  What do you play?";
                    break;
                case 6:
                    gameLabel.Text = "Guess James fell asleep, you should do the same, after getting your bag packed with whatever semi clean clothes you have.'ll be good.";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene6);
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    Refresh();
                    Thread.Sleep(4000);

                    gameLabel.Text = "You wake up early next  morning and wait downstairs for James to pick you  up, ";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene7);
                    Refresh();
                    Thread.Sleep(4000);

                    gameLabel.Text = "He pulls up out in front of your dorm";
                    questionLabel.Text = "James asks you to play something.  What do you play? ";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene17_19);
                    leftPictureBox.BackgroundImage = (Properties.Resources.yes);//bneed to change to podcast
                    middlePictureBox.BackgroundImage = (Properties.Resources.no);
                    Refresh();

                    break;
                case 7:
                    ///hdhfahdf I messed this up thanks self!
                    break;
                case 8:
                    gameLabel.Text = "He replies fast, and tells you to pack warm clothes, a flash light, and bug repellent, the mosquitoes are still terrible.";
                    questionLabel.Visible = false;
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene8);
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;

                    Refresh();
                    Thread.Sleep(4000);
                    gameLabel.Text = "James will pick you up at 8AM tomorrow... He pulls up out in front of your dorm";
                    questionLabel.Text = "James asks you to play something on the radio";
                    questionLabel.Visible = true;
                    gamePictureBox.BackgroundImage = (Properties.Resources.Scene16);
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    leftPictureBox.BackgroundImage = (Properties.Resources.podcast);//need to change to podcast
                    middlePictureBox.BackgroundImage = (Properties.Resources.playlist);
                    Refresh();
                    break;
                case 9:
                    gameLabel.Text = "Oh wait you just took all of your midterms before this and have virtually no studying to do.";
                    questionLabel.Text = "Do you want to text James and ask if you  can still go to his cottage?";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene9);
                    leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                    middlePictureBox.BackgroundImage = (Properties.Resources.no);
                    rightPictureBox.Visible = false;
                    break;
                case 10:
                    gameLabel.Text = "You get in a good eight hour session of Counter strike and fall asleep." +
                        "After you sleep off your Red Bull/ Monster hangover you realize its Monday morning.";
                    questionLabel.Visible = false;
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene10);
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    rightPictureBox.Visible = false;

                    Refresh();
                    Thread.Sleep(3000);

                    gameLabel.Text = "Looks like you've had an interesting weekend.";
                    questionLabel.Text = "Would you like to try again, and start from the beginning?";
                    questionLabel.Visible = true;
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene40);
                    leftPictureBox.Visible = true; leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                    middlePictureBox.Visible = true; middlePictureBox.BackgroundImage = (Properties.Resources.no);
                    rightPictureBox.Visible = false;
                    break;
                case 11:
                    gameLabel.Text = "You go to the closest pizza place on campus 'EL Pizza DeJourno' which is always subpar.";
                    questionLabel.Text = "What type of pizza do you order?";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene11);
                    leftPictureBox.BackgroundImage = (Properties.Resources.cheese);
                    middlePictureBox.BackgroundImage = (Properties.Resources.pepper);
                    rightPictureBox.Visible = false;
                    break;
                case 12:
                    //dfasfgsdf
                    break;
                case 13:
                    gameLabel.Text = "You forgot you were lactose intolerant.  The next five days are terrible";
                    questionLabel.Visible = false;
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene13_14);
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    rightPictureBox.Visible = false;

                    Refresh();
                    Thread.Sleep(5000);

                    gameLabel.Text = "Looks like you've had an interesting weekend.";
                    questionLabel.Text = "Would you like to try again, and start from the beginning?";
                    questionLabel.Visible = true;
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene40); leftPictureBox.Visible = true; leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                    middlePictureBox.Visible = true; middlePictureBox.BackgroundImage = (Properties.Resources.no);
                    rightPictureBox.Visible = false;
                    break;
                case 14:
                    gameLabel.Text = "Something is wrong with that pizza, you're stuck with a flu migraine sickness for the next week.";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene13_14);
                    leftPictureBox.Visible = false; 
                    middlePictureBox.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);

                    gameLabel.Text = "Looks like you've had an interesting weekend.";
                    questionLabel.Text = "Would you like to try again, and start from the beginning?";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene40);
                    leftPictureBox.Visible = true; leftPictureBox.BackgroundImage = (Properties.Resources.yes);
                    middlePictureBox.Visible = true; middlePictureBox.BackgroundImage = (Properties.Resources.no);
                    rightPictureBox.Visible = false;
                    break;
                case 15:
                    gameLabel.Text = "More time to sleep and get rested for the long drive tomorrow." +
                        "You wake up to your alarm but you don't have anything packed yet, you throw" +
                        "some Pop tart's and your tooth brush into your backpack. James is waiting outside in his car ready to go.";
                    questionLabel.Text = "you get in James' car play something on the radio.";
                    gamePictureBox.BackgroundImage = (Properties.Resources.Scene16);
                    leftPictureBox.BackgroundImage = (Properties.Resources.podcast);//need to change to podcast
                    middlePictureBox.BackgroundImage = (Properties.Resources.playlist);
                    break;
                case 16:
                    //gameLabel.Text = "James will pick you up tomorrow at 8 AM.  He pulls up out in front of your dorm.";
                    //questionLabel.Text = "James asks you to play something on Aux.  What do you play?";
                    //gamePictureBox.BackgroundImage = (Properties.Resources.Scene16);
                    // musicChoice = randGen.Next(1, 4); podcastChoice = randGen.Next(1, 4);
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
                    gameLabel.Text = "It's a normal episode of the podcast but the guest can't speak English, and Joe Rogan keeps spilling drinks on the audio equipment.";
                    questionLabel.Visible = false;
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene17_19);
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    rightPictureBox.Visible = false;

                    Refresh();
                    Thread.Sleep(5000);

                    gamePictureBox.BackgroundImage = (Properties.Resources.scene18);
                    gameLabel.Text = "You guys are half way there and it's time for lunch.";
                    questionLabel.Text = "Stop for food or wait till you guys get there?";
                    questionLabel.Visible = true;
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    leftPictureBox.BackgroundImage = (Properties.Resources.stop);
                    middlePictureBox.BackgroundImage = (Properties.Resources.dontstop);
                    break;
                case 18:
                    ////hgifeghifgqrg93hrg8oqeruhogfuck
                    break;
                case 19:
                    gameLabel.Text = "James likes most of the  music but the every other song being" +
                        "from your cousin's Christian Rock/Rap band 'White Sabbath the Religious Awakening' +gets annoying.";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene17_19);
                    questionLabel.Visible = false;
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    rightPictureBox.Visible = false;

                    Refresh();
                    Thread.Sleep(3000);

                    gamePictureBox.BackgroundImage = (Properties.Resources.scene18);
                    gameLabel.Text = "You guys are half way there and it's time for lunch.";
                    questionLabel.Text = "Stop for food or wait till you guys get there?";
                    questionLabel.Visible = true;
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    leftPictureBox.BackgroundImage = (Properties.Resources.stop);
                    middlePictureBox.BackgroundImage = (Properties.Resources.dontstop);
                    break;
                case 20:
                    gameLabel.Text = "you guys were hungry!  James also remembers to fill the car up with gas," +
                        "it was almost empty. The rush hour traffic is almost past and you make it to the cottage in 2 hours. ";
                    questionLabel.Visible = false;
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene20);
                    questionLabel.Visible = false;
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    gotgas = 1;
                    Refresh();
                    Thread.Sleep(5000);
                    gameLabel.Text = "You see the sun going down and decide to have a fire.";
                    questionLabel.Text = "You decide to have a camp fire how do you want to help set up? chop some wood or set up the Muskoka chairs.";
                    gamePictureBox.BackgroundImage = (Properties.Resources.scene21);
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    leftPictureBox.BackgroundImage= (Properties.Resources.setchairs);
                    middlePictureBox.BackgroundImage = (Properties.Resources.chopwood);
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
                    questionLabel.Visible = false;
                    break;
            }

        }
    }
}

