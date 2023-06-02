using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckSimRadioManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Browse Button
        private void Browse_button_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath_Textbox.Text = openFileDialog1.FileName;
                Confirm_button.Enabled = true;
            }
        }
        //Confirm button giving a list of radios
        private void Confirm_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName)){
                    while (sr.Peek() >= 0){
                        string line = sr.ReadLine();
                        line = line.Trim();
                        if (line.Contains("stream_data[]:")){


                            //TODO: ADD PARSE_RADIO_DATA
                            string[] substrings = line.Split('|');
                            string link = substrings[0];
                            string radio_name = substrings[1];
                            string Genre = substrings[2];
                            string Language = substrings[3];
                            string Bitrate = substrings[4];



                            foreach (string substring in substrings) {
                                Console.WriteLine(substring);
                            }
                        }

                    }
                }
            }
            catch (Exception a){
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(a.Message);
            }

        }
        public Array Parse_Radio_Data()
        {


            return
        }
    }
}
