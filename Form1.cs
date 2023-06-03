﻿using System;
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
                    List<string[]> parsed_array = new List<string[]>();
                    while (sr.Peek() >= 0){
                        string line = sr.ReadLine();
                        line = line.Trim();

                        if (line.Contains("stream_data[")){
                            string[] parsed_file_data = Parse_Radio_Data(line);
                            foreach (var item in parsed_file_data)      //temp debug command
                            {
                                Console.WriteLine(item.ToString());
                            }
                            parsed_array.Add(parsed_file_data);
                        }

                    }
                    TableGenerator.GenerateTable(parsed_array, this);
                }
            }
            catch (Exception a){
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(a.Message);
            }

        }
        public string[] Parse_Radio_Data(string input)
        {
            string[] substrings = input.Split('|');
            List<string> list = new List<string>();
            string link = substrings[0].ToString();
            string[]link2 = link.Split('"');
            substrings[0] = link2[1];
            list.Add(substrings[0]);
            list.Add(substrings[1]);
            list.Add(substrings[2]);
            list.Add(substrings[3]);
            list.Add(substrings[4]);
            string[] output = list.ToArray();
            return output;
        }

        
    }
    public class TableGenerator
    {
        public static void GenerateTable(List<string[]> data, Control parentControl)
        {
            // Create a TableLayoutPanel
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            parentControl.Controls.Add(tableLayout);

            // Set column count
            tableLayout.ColumnCount = data[0].Length;

            // Add rows and columns dynamically
            for (int i = 0; i < data.Count; i++)
            {
                tableLayout.RowCount++;
                for (int j = 0; j < data[i].Length; j++)
                {
                    tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / data[i].Length));
                    Label label = new Label();
                    label.Text = data[i][j];
                    label.Dock = DockStyle.Fill;
                    tableLayout.Controls.Add(label, j, i);
                }
            }
        }
    }
}
