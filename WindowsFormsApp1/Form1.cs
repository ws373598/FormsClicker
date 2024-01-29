using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double count = 0;

        int score = 1;

        int cost = 1;

        int waiting = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Oil levels: {score}";
            button1.Text = $"Improve oil for {Math.Ceiling(cost * (cost * 3.5))} men";
        }
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (waiting == 0)
            {
                if (count >= 250)
                {
                    pictureBox1.Image = new Bitmap(Properties.Resources.musc);
                }

                await increase();
                await waitinge();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await clicked();
        }
        private async Task clicked()
        {
            if (count >= Math.Ceiling(cost * (cost * 3.5)))
            {
                count = count - Math.Ceiling(cost * (cost * 3.5));

                score += 1;

                cost += 1;

                label2.Text = $"Oil levels: {score}";

                button1.Text = $"Improve oil for {Math.Ceiling(cost * (cost * 3.5))} men";

                label1.Text = $"finlay has {count} oily men!";
            }
        }
        private async Task increase()
        {
            count += score;

            label1.Text = $"finlay has {count} oily men!";
        }

        private async Task waitinge()
        {
            waiting = 1;
            await Task.Delay(500);
            waiting = 0;
        }
    }
}
