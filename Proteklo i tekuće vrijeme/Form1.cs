using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Proteklo_i_tekuće_vrijeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick1;
            timer.Start();
            timer.Enabled = true;
            
        }
        DateTime pocetno = DateTime.Now;
        private void Timer_Tick1(object sender, EventArgs e)
        {
            
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripTrenutno.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            toolStripProteklo.Text = "Proteklo: " + ":" + proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
