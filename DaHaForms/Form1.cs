using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaHaForms
{
    public partial class Form1 : Form
    {
        int score = 0;
        int force = 1;
        int price = 50;
        int korm = 200;
        int koshkaScore = 0;
        Timer timer;
        public Form1()
        {
            
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clik();
        }

        private void clik ()
        {
            score += force;
            label1.Text = $"Деньги: {score}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (score >= price)
            {
                score -= price;
                label1.Text = $"Деньги: {score}";
                force++;
                price = (int)(price * 1.25);
                label2.Text = $"Цена: {price}";
                button1.Text = $"нажимать ({force})";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (score >= korm)
            {
                score -= korm;
                label1.Text = $"Деньги: {score}";
                koshkaScore += 30;
                korm = (int)(korm * 2.5);
                label3.Text = $"Цена: {korm}";
                label4.Text = $"Кошка дает вам\n: {koshkaScore} в секунду";
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            score += koshkaScore;
            label1.Text = $"Деньги: {score}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
