using System;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();

        private readonly Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 7;
                if (timer1.Interval > 250)
                    timer1.Interval -= 4;
                if (timer1.Interval > 100)
                    timer1.Interval -= 1;
                UpdateDifficultyProgressBar();
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            UpdateLabels();
        }

        private void UpdateDifficultyProgressBar()
        {
            difficultyProgressBar.Value = 800 - timer1.Interval;
        }

        private void UpdateLabels()
        {
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 800;
            UpdateDifficultyProgressBar();
            stats.Reset();
            UpdateLabels();
            listBox1.Items.Clear();
            listBox1.Refresh();
            timer1.Start();
        }
    }
}
