using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckSimRadioManager
{
    public partial class AddRadioDialog : Form
    {
        public bool Is_Confirm_Selected = new bool();
        public AddRadioDialog()
        {
            InitializeComponent();
            this.Text = "Add Radio Station";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUri = Uri.IsWellFormedUriString(textBox1.Text, UriKind.Absolute);
            if (isUri == true)
            {
                Is_Confirm_Selected = true;
                this.Close();
            }
            else if (isUri == false)
            {
                MessageBox.Show("Invalid Radio Link", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Is_Confirm_Selected = false;
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            long a;
            if (!long.TryParse(textBox5.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                textBox5.Clear();
            }
        }
    }
}
