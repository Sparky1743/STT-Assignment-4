namespace AlarmApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCurrentTimeLabel;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblSecondsRemainingLabel;
        private System.Windows.Forms.Label lblSecondsRemaining;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCurrentTimeLabel = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblSecondsRemainingLabel = new System.Windows.Forms.Label();
            this.lblSecondsRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // button1
            this.button1.Location = new System.Drawing.Point(350, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // txtTime
            this.txtTime.Location = new System.Drawing.Point(275, 50);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(250, 22);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "HH:MM:SS";
            this.txtTime.Enter += new System.EventHandler(this.txtTime_Enter);

            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMessage.Location = new System.Drawing.Point(275, 150);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Visible = false;

            // lblCurrentTimeLabel
            this.lblCurrentTimeLabel.AutoSize = true;
            this.lblCurrentTimeLabel.Location = new System.Drawing.Point(275, 200);
            this.lblCurrentTimeLabel.Name = "lblCurrentTimeLabel";
            this.lblCurrentTimeLabel.Size = new System.Drawing.Size(94, 17);
            this.lblCurrentTimeLabel.TabIndex = 3;
            this.lblCurrentTimeLabel.Text = "Current Time:";

            // lblCurrentTime
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(380, 200);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentTime.TabIndex = 4;

            // lblSecondsRemainingLabel
            this.lblSecondsRemainingLabel.AutoSize = true;
            this.lblSecondsRemainingLabel.Location = new System.Drawing.Point(275, 230);
            this.lblSecondsRemainingLabel.Name = "lblSecondsRemainingLabel";
            this.lblSecondsRemainingLabel.Size = new System.Drawing.Size(135, 17);
            this.lblSecondsRemainingLabel.TabIndex = 5;
            this.lblSecondsRemainingLabel.Text = "Seconds Remaining:";

            // lblSecondsRemaining
            this.lblSecondsRemaining.AutoSize = true;
            this.lblSecondsRemaining.Location = new System.Drawing.Point(420, 230);
            this.lblSecondsRemaining.Name = "lblSecondsRemaining";
            this.lblSecondsRemaining.Size = new System.Drawing.Size(0, 17);
            this.lblSecondsRemaining.TabIndex = 6;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecondsRemaining);
            this.Controls.Add(this.lblSecondsRemainingLabel);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblCurrentTimeLabel);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Alarm App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
