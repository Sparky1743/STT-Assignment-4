using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlarmApp
{
    public partial class Form1 : Form
    {
        private DateTime targetTime;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtTime.Text, out targetTime))
            {
                timer1.Start();
                lblMessage.Text = "";
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Text = "❌ Invalid time format. Use HH:MM:SS.";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            DateTime currentTime = DateTime.Now;
            lblCurrentTime.Text = currentTime.ToLongTimeString();

            TimeSpan remaining = targetTime - currentTime;
            int secondsRemaining = Math.Max(0, (int)remaining.TotalSeconds);
            lblSecondsRemaining.Text = secondsRemaining.ToString();

            if (secondsRemaining == 0)
            {
                timer1.Stop();
                lblMessage.Text = "⏰ Time matched! Alarm ringing!";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Visible = true;

                // 💥 Show popup message
                MessageBox.Show("⏰ Alarm Time Reached!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTime_Enter(object sender, EventArgs e)
        {
            txtTime.Clear();
        }
    }
}
