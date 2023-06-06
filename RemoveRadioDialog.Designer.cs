namespace TruckSimRadioManager
{
    partial class RemoveRadioDialog
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
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            Exit_Button = new System.Windows.Forms.Button();
            Confirm_Button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new System.Drawing.Point(14, 14);
            checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(322, 544);
            checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(344, 14);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 1;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(344, 47);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(88, 54);
            button2.TabIndex = 2;
            button2.Text = "Check Audio Stream";
            button2.UseVisualStyleBackColor = true;
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new System.Drawing.Point(345, 545);
            Exit_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new System.Drawing.Size(88, 27);
            Exit_Button.TabIndex = 3;
            Exit_Button.Text = "Exit";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // Confirm_Button
            // 
            Confirm_Button.Location = new System.Drawing.Point(345, 512);
            Confirm_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new System.Drawing.Size(88, 27);
            Confirm_Button.TabIndex = 4;
            Confirm_Button.Text = "Confirm";
            Confirm_Button.UseVisualStyleBackColor = true;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // RemoveRadioDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(446, 590);
            Controls.Add(Confirm_Button);
            Controls.Add(Exit_Button);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RemoveRadioDialog";
            Text = "RemoveRadioDialog";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Confirm_Button;
    }
}