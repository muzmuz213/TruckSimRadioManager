namespace TruckSimRadioManager
{
    partial class Form1
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
            this.Confirm_button = new System.Windows.Forms.Button();
            this.Browse_button = new System.Windows.Forms.Button();
            this.FilePath_Textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Confirm_button
            // 
            this.Confirm_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm_button.Location = new System.Drawing.Point(655, 12);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(72, 50);
            this.Confirm_button.TabIndex = 0;
            this.Confirm_button.Text = "Get a list of radios from selected file";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Browse_button
            // 
            this.Browse_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse_button.Location = new System.Drawing.Point(574, 12);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(72, 50);
            this.Browse_button.TabIndex = 1;
            this.Browse_button.Text = "Browse Files";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // FilePath_Textbox
            // 
            this.FilePath_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath_Textbox.Location = new System.Drawing.Point(26, 12);
            this.FilePath_Textbox.MinimumSize = new System.Drawing.Size(542, 20);
            this.FilePath_Textbox.Name = "FilePath_Textbox";
            this.FilePath_Textbox.ReadOnly = true;
            this.FilePath_Textbox.Size = new System.Drawing.Size(542, 20);
            this.FilePath_Textbox.TabIndex = 2;
            this.FilePath_Textbox.Text = "\r\n\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "Documents";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(26, 38);
            this.button1.MaximumSize = new System.Drawing.Size(0, 23);
            this.button1.MinimumSize = new System.Drawing.Size(269, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add New Radio Station";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(299, 38);
            this.button2.MaximumSize = new System.Drawing.Size(0, 23);
            this.button2.MinimumSize = new System.Drawing.Size(269, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove Radio Station";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilePath_Textbox);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.Confirm_button);
            this.MinimumSize = new System.Drawing.Size(763, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.TextBox FilePath_Textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

