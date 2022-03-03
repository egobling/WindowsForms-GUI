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

namespace Wforms_GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void babaB_Click(object sender, EventArgs e)
        {

                SoundPlayer ljudSpelare = new SoundPlayer(@"C:\ljud\funnymp3\What the dog doing Sound Effect.wav");
                ljudSpelare.Play();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Link_YES_YES(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.youtube.com/watch?v=lPGipwoJiOM");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer ljudSpelare = new SoundPlayer(@"C:\ljud\funnymp3\What the dog doing Sound Effect.wav");
            ljudSpelare.Play();
        }
    }
}
