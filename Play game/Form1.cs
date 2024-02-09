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
using System.Media;


namespace Play_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startbutton.BackColor = Color.Black;
            gametimer.BackColor = Color.Black;
            gametime.BackColor = Color.Black;

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.starting_pistol_Stephan_Schutze_613594351);
                
            gametime.BackColor = Color.Green;
            gametime.ForeColor = Color.Green;
            background.BackColor = Color.Green;
            gametimer.BackColor = Color.Green;
            startbutton.Visible = false;
            gametimer.ForeColor = Color.White;

            gametimer.Text = "Ready in Three!!!";
            Refresh();
            Thread.Sleep(1000);
            gametimer.Text = "Ready in Two!!!";
            Refresh();
            Thread.Sleep(1000);
            gametimer.Text = "Ready in One!!!";
            Refresh();
            Thread.Sleep(1000);

            player.Play();
            
            gametime.ForeColor = Color.Black;
            gametime.BackColor = Color.Red;
            background.BackColor = Color.Red;
            gametimer.BackColor = Color.Red;
            gametimer.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            Application.Restart();
        }

      
    }
}