using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace FIRST_ASSIGNMENT_RR
{
    public partial class Form1 : Form
    {
        AK_47 GUN = new AK_47();
        private object pictureBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            //coding for buttons
            GUN.Load();
            btn_load.Enabled = false;
            btn_spin.Enabled = true;
            btn_shoot_away.Enabled = false;
            btn_shoot.Enabled = false;

            //this code is for load Gif in picture box
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("FIRST_ASSIGNMENT_RR.Resources.load.gif");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(FIRST_ASSIGNMENT_RR.Properties.Resources.load);
            pic_box_main.Image = bmp;

            //This code is for load sound.
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(FIRST_ASSIGNMENT_RR.Properties.Resources.Gun_Reload);
            snd.Play();
        }

        private void Btn_spin_Click(object sender, EventArgs e)
        {
            GUN.Spin();

            //This code is for spin sound.
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(FIRST_ASSIGNMENT_RR.Properties.Resources.spinning);
            snd.Play();
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot_away.Enabled = true;
            btn_shoot.Enabled = true;

            //This code is for spin Gif in picture box.
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("FIRST_ASSIGNMENT_RR.Resources.spin.gif");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(FIRST_ASSIGNMENT_RR.Properties.Resources.load);
            pic_box_main.Image = bmp;
        }

        private void Btn_shoot_away_Click(object sender, EventArgs e)
        {
            GUN.ShootAWAY();

            //This code is for Shoot Away sound.
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(FIRST_ASSIGNMENT_RR.Properties.Resources.shoot);
            snd.Play();
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shoot_away.Enabled = true;

            //This code is for Shoot Away Gif shown in picture box.
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("FIRST_ASSIGNMENT_RR.Resources.shootaway.gif");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(FIRST_ASSIGNMENT_RR.Properties.Resources.load);
            pic_box_main.Image = bmp;
        }

        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            //This is for shoot sound.
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(FIRST_ASSIGNMENT_RR.Properties.Resources.shoot);
            snd.Play();

            //This coding is for shoot Gif in picture box.
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("FIRST_ASSIGNMENT_RR.Resources.shoot.gif");
            Bitmap bmp = new Bitmap(mystream);

            //var bmp = new Bitmap(FIRST_ASSIGNMENT_RR.Properties.Resources.load);
            pic_box_main.Image = bmp;

            if (GUN.GetAvailableBullets() > 0)
            {
                // Shoot Logic
                GUN.Shoot(false);
                btn_load.Enabled = false;
                btn_spin.Enabled = false;
                if (GUN.GetAvailableChances() > 0)
                {
                    btn_shoot_away.Enabled = true;
                    btn_shoot.Enabled = true;

                    if (GUN.GetPlayerWon())
                    {
                        victoryIndicatorLabel.Text = "You Won!";
                        btn_shoot_away.Enabled = false;
                        btn_shoot.Enabled = false;
                    }
                }
                else
                {
                    btn_shoot_away.Enabled = false;
                    btn_shoot.Enabled = false;

                    if (GUN.GetPlayerWon())
                    {
                        victoryIndicatorLabel.Text = "You Won!";
                    }
                    else
                    {
                        victoryIndicatorLabel.Text = "You Lost!";
                    }
                }
            }

            Console.WriteLine(GUN.GetPlayerWon());
            Console.ReadLine();
        }

        private void Btn_play_again_Click(object sender, EventArgs e)

        //This code is to clear everything to play game again.
        { 
            this.Controls.Clear();
            this.InitializeComponent();
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shoot_away.Enabled = false;
            btn_shoot.Enabled = false;
        }

        private void Btn_exit(object sender, EventArgs e)

            //This code is to exit the game.
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Reset Form
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shoot_away.Enabled = false;
            btn_shoot.Enabled = false;
           
        }
    }
}