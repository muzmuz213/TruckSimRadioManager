﻿namespace TruckSimRadioManager
{
    partial class Mp3StreamingPanel
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
            components = new System.ComponentModel.Container();
            buttonPlay = new System.Windows.Forms.Button();
            textBoxStreamingUrl = new System.Windows.Forms.TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            progressBarBuffer = new System.Windows.Forms.ProgressBar();
            label2 = new System.Windows.Forms.Label();
            buttonPause = new System.Windows.Forms.Button();
            buttonStop = new System.Windows.Forms.Button();
            labelBuffered = new System.Windows.Forms.Label();
            labelVolume = new System.Windows.Forms.Label();
            volumeSlider1 = new NAudio.Gui.VolumeSlider();
            SuspendLayout();
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new System.Drawing.Point(14, 113);
            buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new System.Drawing.Size(88, 26);
            buttonPlay.TabIndex = 0;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // textBoxStreamingUrl
            // 
            textBoxStreamingUrl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxStreamingUrl.Location = new System.Drawing.Point(113, 14);
            textBoxStreamingUrl.Margin = new System.Windows.Forms.Padding(4);
            textBoxStreamingUrl.Name = "textBoxStreamingUrl";
            textBoxStreamingUrl.ReadOnly = true;
            textBoxStreamingUrl.Size = new System.Drawing.Size(278, 23);
            textBoxStreamingUrl.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Streaming URL:";
            // 
            // progressBarBuffer
            // 
            progressBarBuffer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            progressBarBuffer.Location = new System.Drawing.Point(113, 45);
            progressBarBuffer.Margin = new System.Windows.Forms.Padding(4);
            progressBarBuffer.Name = "progressBarBuffer";
            progressBarBuffer.Size = new System.Drawing.Size(245, 26);
            progressBarBuffer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 52);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Buffered:";
            // 
            // buttonPause
            // 
            buttonPause.Location = new System.Drawing.Point(109, 113);
            buttonPause.Margin = new System.Windows.Forms.Padding(4);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new System.Drawing.Size(88, 26);
            buttonPause.TabIndex = 5;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new System.Drawing.Point(206, 113);
            buttonStop.Margin = new System.Windows.Forms.Padding(4);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(88, 26);
            buttonStop.TabIndex = 6;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelBuffered
            // 
            labelBuffered.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelBuffered.AutoSize = true;
            labelBuffered.Location = new System.Drawing.Point(364, 52);
            labelBuffered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelBuffered.Name = "labelBuffered";
            labelBuffered.Size = new System.Drawing.Size(27, 15);
            labelBuffered.TabIndex = 7;
            labelBuffered.Text = "0.0s";
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.Location = new System.Drawing.Point(14, 84);
            labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new System.Drawing.Size(50, 15);
            labelVolume.TabIndex = 8;
            labelVolume.Text = "Volume:";
            // 
            // volumeSlider1
            // 
            volumeSlider1.Location = new System.Drawing.Point(113, 80);
            volumeSlider1.Margin = new System.Windows.Forms.Padding(4);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new System.Drawing.Size(127, 22);
            volumeSlider1.TabIndex = 9;
            // 
            // Mp3StreamingPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(396, 149);
            Controls.Add(volumeSlider1);
            Controls.Add(labelVolume);
            Controls.Add(labelBuffered);
            Controls.Add(buttonStop);
            Controls.Add(buttonPause);
            Controls.Add(label2);
            Controls.Add(progressBarBuffer);
            Controls.Add(label1);
            Controls.Add(textBoxStreamingUrl);
            Controls.Add(buttonPlay);
            Margin = new System.Windows.Forms.Padding(4);
            MaximumSize = new System.Drawing.Size(412, 188);
            MinimumSize = new System.Drawing.Size(412, 188);
            Name = "Mp3StreamingPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.TextBox textBoxStreamingUrl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarBuffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelBuffered;
        private System.Windows.Forms.Label labelVolume;
        private NAudio.Gui.VolumeSlider volumeSlider1;
    }
}