using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckSimRadioManager
{
    public partial class RemoveRadioDialog : Form
    {
        public RemoveRadioDialog(List<string[]> list_Of_Radios)
        {
            InitializeComponent();
            foreach (string[] array in list_Of_Radios)
            {
                if (array.Length > 1)
                {
                    string secondString = array[1];
                    checkedListBox1.Items.Add(secondString);
                }
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
