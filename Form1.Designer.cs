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
            Confirm_button = new System.Windows.Forms.Button();
            Browse_button = new System.Windows.Forms.Button();
            FilePath_Textbox = new System.Windows.Forms.TextBox();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            Add_New_Radio_Station_Button = new System.Windows.Forms.Button();
            Remove_Radio_Station_Button = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Confirm_button
            // 
            Confirm_button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Confirm_button.Enabled = false;
            Confirm_button.Location = new System.Drawing.Point(779, 31);
            Confirm_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Confirm_button.Name = "Confirm_button";
            Confirm_button.Size = new System.Drawing.Size(84, 57);
            Confirm_button.TabIndex = 0;
            Confirm_button.Text = "Get a list of radios from selected file";
            Confirm_button.UseVisualStyleBackColor = true;
            Confirm_button.Click += Confirm_button_Click;
            // 
            // Browse_button
            // 
            Browse_button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Browse_button.Location = new System.Drawing.Point(685, 31);
            Browse_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Browse_button.Name = "Browse_button";
            Browse_button.Size = new System.Drawing.Size(84, 57);
            Browse_button.TabIndex = 1;
            Browse_button.Text = "Browse Files";
            Browse_button.UseVisualStyleBackColor = true;
            Browse_button.Click += Browse_button_Click;
            // 
            // FilePath_Textbox
            // 
            FilePath_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            FilePath_Textbox.Location = new System.Drawing.Point(14, 31);
            FilePath_Textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FilePath_Textbox.MinimumSize = new System.Drawing.Size(632, 20);
            FilePath_Textbox.Name = "FilePath_Textbox";
            FilePath_Textbox.ReadOnly = true;
            FilePath_Textbox.Size = new System.Drawing.Size(663, 23);
            FilePath_Textbox.TabIndex = 2;
            FilePath_Textbox.Text = "\r\n\r\n";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "Documents";
            // 
            // Add_New_Radio_Station_Button
            // 
            Add_New_Radio_Station_Button.AutoSize = true;
            Add_New_Radio_Station_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Add_New_Radio_Station_Button.Enabled = false;
            Add_New_Radio_Station_Button.Location = new System.Drawing.Point(14, 61);
            Add_New_Radio_Station_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Add_New_Radio_Station_Button.MaximumSize = new System.Drawing.Size(0, 27);
            Add_New_Radio_Station_Button.MinimumSize = new System.Drawing.Size(329, 27);
            Add_New_Radio_Station_Button.Name = "Add_New_Radio_Station_Button";
            Add_New_Radio_Station_Button.Size = new System.Drawing.Size(329, 27);
            Add_New_Radio_Station_Button.TabIndex = 3;
            Add_New_Radio_Station_Button.Text = "Add New Radio Station";
            Add_New_Radio_Station_Button.UseVisualStyleBackColor = true;
            Add_New_Radio_Station_Button.Click += Add_New_Radio_Station_Button_Click;
            // 
            // Remove_Radio_Station_Button
            // 
            Remove_Radio_Station_Button.AutoSize = true;
            Remove_Radio_Station_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Remove_Radio_Station_Button.Enabled = false;
            Remove_Radio_Station_Button.Location = new System.Drawing.Point(349, 61);
            Remove_Radio_Station_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Remove_Radio_Station_Button.MaximumSize = new System.Drawing.Size(0, 27);
            Remove_Radio_Station_Button.MinimumSize = new System.Drawing.Size(329, 27);
            Remove_Radio_Station_Button.Name = "Remove_Radio_Station_Button";
            Remove_Radio_Station_Button.Size = new System.Drawing.Size(329, 27);
            Remove_Radio_Station_Button.TabIndex = 4;
            Remove_Radio_Station_Button.Text = "Edit/Test Radio Stations";
            Remove_Radio_Station_Button.UseVisualStyleBackColor = true;
            Remove_Radio_Station_Button.Click += Remove_Radio_Station_Button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(872, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            fileToolStripMenuItem.Text = "Exit";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new System.Drawing.Point(15, 96);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(848, 376);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Enabled = false;
            button1.Location = new System.Drawing.Point(770, 479);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 0;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(872, 519);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Remove_Radio_Station_Button);
            Controls.Add(Add_New_Radio_Station_Button);
            Controls.Add(FilePath_Textbox);
            Controls.Add(Browse_button);
            Controls.Add(Confirm_button);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(888, 558);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

