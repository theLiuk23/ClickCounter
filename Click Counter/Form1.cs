using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Counter
{
    public partial class Form1 : Form
    {
        public int Clicks = 0;
        public string centoclicks = "100. Beh, non così male!";
        public string milleclicks = "1000. Un eroe!";
        public string diecimilaclicks = "10'000. Porca troia!!! Ebbene, ti sei meritato un premio: https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        public string mySite = "https://lucadallavilla.altervista.org/";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showClicks.Clear();
            showClicks.Text += Clicks;
            this.testoCommento.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.testoCommento_LinkClicked);
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            showClicks.Clear();
            Clicks++;
            showClicks.Text += Clicks;

            if (Clicks == 100)
            {
                testoCommento.Clear();
                testoCommento.Text += centoclicks;
            }
            if (Clicks == 1000)
            {
                testoCommento.Clear();
                testoCommento.Text += milleclicks;
            }
            if (Clicks == 10000)
            {
                testoCommento.Clear();
                testoCommento.Text += diecimilaclicks;
            }
            if (Clicks > 10000)
            {
                bottonePulisci_Click(sender, e);
            }
        }

        private void testoCommento_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Firefox.exe", e.LinkText);
        }

        private void bottonePulisci_Click(object sender, EventArgs e)
        {
            testoCommento.Clear();
            showClicks.Clear();
            Clicks = 0;
            showClicks.Text += Clicks;
        }

        private void bottoneInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Firefox.exe", mySite);
        }
    }
}
