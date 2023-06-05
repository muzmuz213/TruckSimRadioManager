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
            this.Add_New_Radio_Station_Button = new System.Windows.Forms.Button();
            this.Remove_Radio_Station_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confirm_button
            // 
            this.Confirm_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm_button.Enabled = false;
            this.Confirm_button.Location = new System.Drawing.Point(668, 27);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(72, 49);
            this.Confirm_button.TabIndex = 0;
            this.Confirm_button.Text = "Get a list of radios from selected file";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Browse_button
            // 
            this.Browse_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse_button.Location = new System.Drawing.Point(587, 27);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(72, 49);
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
            this.FilePath_Textbox.Location = new System.Drawing.Point(12, 27);
            this.FilePath_Textbox.MinimumSize = new System.Drawing.Size(542, 20);
            this.FilePath_Textbox.Name = "FilePath_Textbox";
            this.FilePath_Textbox.ReadOnly = true;
            this.FilePath_Textbox.Size = new System.Drawing.Size(569, 20);
            this.FilePath_Textbox.TabIndex = 2;
            this.FilePath_Textbox.Text = "\r\n\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "Documents";
            // 
            // Add_New_Radio_Station_Button
            // 
            this.Add_New_Radio_Station_Button.AutoSize = true;
            this.Add_New_Radio_Station_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_New_Radio_Station_Button.Enabled = false;
            this.Add_New_Radio_Station_Button.Location = new System.Drawing.Point(12, 53);
            this.Add_New_Radio_Station_Button.MaximumSize = new System.Drawing.Size(0, 23);
            this.Add_New_Radio_Station_Button.MinimumSize = new System.Drawing.Size(282, 23);
            this.Add_New_Radio_Station_Button.Name = "Add_New_Radio_Station_Button";
            this.Add_New_Radio_Station_Button.Size = new System.Drawing.Size(282, 23);
            this.Add_New_Radio_Station_Button.TabIndex = 3;
            this.Add_New_Radio_Station_Button.Text = "Add New Radio Station";
            this.Add_New_Radio_Station_Button.UseVisualStyleBackColor = true;
            this.Add_New_Radio_Station_Button.Click += new System.EventHandler(this.Add_New_Radio_Station_Button_Click);
            // 
            // Remove_Radio_Station_Button
            // 
            this.Remove_Radio_Station_Button.AutoSize = true;
            this.Remove_Radio_Station_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Remove_Radio_Station_Button.Enabled = false;
            this.Remove_Radio_Station_Button.Location = new System.Drawing.Point(299, 53);
            this.Remove_Radio_Station_Button.MaximumSize = new System.Drawing.Size(0, 23);
            this.Remove_Radio_Station_Button.MinimumSize = new System.Drawing.Size(282, 23);
            this.Remove_Radio_Station_Button.Name = "Remove_Radio_Station_Button";
            this.Remove_Radio_Station_Button.Size = new System.Drawing.Size(282, 23);
            this.Remove_Radio_Station_Button.TabIndex = 4;
            this.Remove_Radio_Station_Button.Text = "Remove Radio Station";
            this.Remove_Radio_Station_Button.UseVisualStyleBackColor = true;
            this.Remove_Radio_Station_Button.Click += new System.EventHandler(this.Remove_Radio_Station_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "Exit";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 326);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(660, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Remove_Radio_Station_Button);
            this.Controls.Add(this.Add_New_Radio_Station_Button);
            this.Controls.Add(this.FilePath_Textbox);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.Confirm_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(763, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.TextBox FilePath_Textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Add_New_Radio_Station_Button;
        private System.Windows.Forms.Button Remove_Radio_Station_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

