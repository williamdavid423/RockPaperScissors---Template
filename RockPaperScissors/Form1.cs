using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

/// <summary>
/// A rock, paper, scissors game that utilizes basic methods
/// for repetitive tasks.
/// </summary>

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        string playerChoice, cpuChoice;
        int wins = 0;
        int losses = 0;
        int ties = 0;

        Random randGen = new Random();

        SoundPlayer jabPlayer = new SoundPlayer(Properties.Resources.jabSound);
        SoundPlayer gongPlayer = new SoundPlayer(Properties.Resources.gong);

        Image rockImage = Properties.Resources.rock168x280;
        Image paperImage = Properties.Resources.paper168x280;
        Image scissorImage = Properties.Resources.scissors168x280;
        Image winImage = Properties.Resources.winTrans;
        Image loseImage = Properties.Resources.loseTrans;
        Image tieImage = Properties.Resources.tieTrans;

        Point playerLocation = new Point(168, 70);
        Point cpuLocation = new Point(360, 70);

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            /// TODO Set the playerchoice value, draw the appropriate image,
            /// play a sound, wait for a second; repeat for the computer turn 
        }

        private void paperButton_Click(object sender, EventArgs e)
        {

        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {

        }
    }
}