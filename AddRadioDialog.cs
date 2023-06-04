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
                this.Close();
            }
            else if(isUri == false)
            {
                MessageBox.Show("Invalid Radio Link", "Invalid Input",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
