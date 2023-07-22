using NAudio.Wave;
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
        public List<string[]> Radio_list = new List<string[]>();
        public RemoveRadioDialog(List<string[]> list_Of_Radios)
        {
            InitializeComponent();
            this.Text = "Edit/Test Radio Stations";
            foreach (string[] array in list_Of_Radios)
            {
                if (array.Length > 1)
                {
                    string secondString = array[1];
                    checkedListBox1.Items.Add(secondString);
                    checkedListBox1.CheckOnClick = true;
                }
            }
            Radio_list = list_Of_Radios;

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                list.Add(indexChecked);
            }
            list.Reverse();
            foreach (int i in list)
            {
                Radio_list.Remove(Radio_list[i]);
            }
            checkedListBox1.Items.Clear();
            foreach (string[] array in Radio_list)
            {
                if (array.Length > 1)
                {
                    string secondString = array[1];
                    checkedListBox1.Items.Add(secondString);
                    checkedListBox1.CheckOnClick = true;
                }
            }
        }
        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formPopup = new Mp3StreamingPanel();
            using (formPopup)
            {
                formPopup.textBoxStreamingUrl.Text = Radio_list[checkedListBox1.SelectedIndex][0];
                formPopup.ShowDialog();
            }
        }
    }
}
