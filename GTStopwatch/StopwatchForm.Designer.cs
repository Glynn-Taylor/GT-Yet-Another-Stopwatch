namespace GTStopwatch
{
    partial class StopwatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startStopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.timeDisplayLbl = new System.Windows.Forms.Label();
            this.quitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startStopBtn
            // 
            this.startStopBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startStopBtn.Location = new System.Drawing.Point(83, 56);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(76, 23);
            this.startStopBtn.TabIndex = 0;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = false;
            this.startStopBtn.Click += new System.EventHandler(this.StartStopClick);
            // 
            // resetBtn
            // 
            this.resetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.resetBtn.Location = new System.Drawing.Point(12, 56);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(65, 23);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.OnResetClick);
            // 
            // timeDisplayLbl
            // 
            this.timeDisplayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplayLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeDisplayLbl.Location = new System.Drawing.Point(12, 9);
            this.timeDisplayLbl.Name = "timeDisplayLbl";
            this.timeDisplayLbl.Size = new System.Drawing.Size(171, 44);
            this.timeDisplayLbl.TabIndex = 3;
            this.timeDisplayLbl.Text = "00:00:00";
            this.timeDisplayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitBtn
            // 
            this.quitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.quitBtn.Location = new System.Drawing.Point(165, 56);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(18, 23);
            this.quitBtn.TabIndex = 4;
            this.quitBtn.Text = "X";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.QuitClick);
            // 
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(195, 81);
            this.ControlBox = false;
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.timeDisplayLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startStopBtn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StopwatchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GT Stopwatch";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label timeDisplayLbl;
        private System.Windows.Forms.Button quitBtn;
    }
}

