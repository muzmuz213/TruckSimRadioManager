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
            this.SuspendLayout();
            // 
            // Confirm_button
            // 
            this.Confirm_button.Enabled = false;
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
            this.Browse_button.Location = new System.Drawing.Point(577, 12);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(72, 50);
            this.Browse_button.TabIndex = 1;
            this.Browse_button.Text = "Browse Files";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // FilePath_Textbox
            // 
            this.FilePath_Textbox.Enabled = false;
            this.FilePath_Textbox.Location = new System.Drawing.Point(29, 28);
            this.FilePath_Textbox.Name = "FilePath_Textbox";
            this.FilePath_Textbox.Size = new System.Drawing.Size(542, 20);
            this.FilePath_Textbox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.FilePath_Textbox);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.Confirm_button);
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
    }
}

