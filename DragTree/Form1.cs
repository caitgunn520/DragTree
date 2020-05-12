using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace DragTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tracks which row of lights is currently lit up
        int lightRow = 1;

        Stopwatch reactionTime = new Stopwatch();

        private void startButton_Click(object sender, EventArgs e)
        {
            lightTimer.Enabled = true;
        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            switch(lightRow)
            {
                case 1:
                    lightA1.BackColor = Color.Gold;
                    lightA2.BackColor = Color.Gold;
                    lightRow++;
                    break;
                case 2:
                    lightB1.BackColor = Color.Gold;
                    lightB2.BackColor = Color.Gold;
                    lightRow++;
                    break;
                case 3:
                    lightC1.BackColor = Color.Gold;
                    lightC2.BackColor = Color.Gold;
                    lightRow++;
                    break;
                case 4:
                    lightD1.BackColor = Color.Green;
                    lightD2.BackColor = Color.Green;
                    lightRow++;
                    break;
                default:
                    lightTimer.Enabled = false;
                    //starts timer
                    reactionTime.Start();
                    break;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //stops timer
            reactionTime.Stop();

            TimeSpan elapsed = reactionTime.Elapsed;

            if (Convert.ToInt32(elapsed.TotalMilliseconds) > 0)
            {
                outputLabel.Text = Convert.ToString(reactionTime.ElapsedMilliseconds);
            }
            else
            {
                outputLabel.Text = "False Start";
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            lightA1.BackColor = Color.Silver;
            lightA2.BackColor = Color.Silver;
            lightB1.BackColor = Color.Silver;
            lightB2.BackColor = Color.Silver;
            lightC1.BackColor = Color.Silver;
            lightC2.BackColor = Color.Silver;
            lightD1.BackColor = Color.Gray;
            lightD2.BackColor = Color.Gray;

            lightRow = 1;

            outputLabel.Text = "";

            reactionTime.Reset();
        }
    }

}
