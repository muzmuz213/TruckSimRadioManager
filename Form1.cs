using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TruckSimRadioManager
{
    public partial class Form1 : Form
    {
        public List<string[]> List_Of_Radios;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Truck Simulator Radio Manager";
        }
        //Browse Button
        private void Browse_button_Click(object sender, EventArgs e)
        {
            Confirm_button.Enabled = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
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
                using (StreamReader sr = new StreamReader(FilePath_Textbox.Text))
                {
                    List<string[]> parsed_array = new List<string[]>();
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        line = line.Trim();
                        if (line.Contains("stream_data["))
                        {
                            string[] parsed_file_data = Parse_Radio_Data(line);
                            parsed_array.Add(parsed_file_data);
                        }
                    }
                    List_Of_Radios = parsed_array;
                    GenerateTable(parsed_array, tableLayoutPanel1);
                    Add_New_Radio_Station_Button.Enabled = true;
                    Remove_Radio_Station_Button.Enabled = true;
                    button1.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be read");
                Add_New_Radio_Station_Button.Enabled = false;
                Remove_Radio_Station_Button.Enabled = false;
            }

        }
        public string[] Parse_Radio_Data(string input)
        {
            string[] substrings = input.Split('|');
            List<string> list = new List<string>();
            string link = substrings[0].ToString();
            string[] link2 = link.Split('"');
            substrings[0] = link2[1];
            list.Add(substrings[0]);
            list.Add(substrings[1]);
            list.Add(substrings[2]);
            list.Add(substrings[3]);
            list.Add(substrings[4]);
            string[] output = list.ToArray();
            return output;
        }
        //Generating A table given a list of string[]
        public static void GenerateTable(List<string[]> data, TableLayoutPanel tableLayout)
        {
            // Clear existing rows and columns
            tableLayout.RowStyles.Clear();
            tableLayout.ColumnStyles.Clear();
            tableLayout.Controls.Clear();
            // Set column count
            tableLayout.ColumnCount = data[0].Length;
            string[] Default = { "Radio Link", "Radio Name", "Genre", "Language", "Bitrate" };
            data = data.Prepend(Default).ToList();

            // Add rows and columns dynamically
            for (int i = 0; i < data.Count; i++)
            {
                tableLayout.RowCount++;
                for (int j = 0; j < data[i].Length; j++)
                {
                    if (i == 0)
                    {
                        // Use a different style for the column header row
                        Label columnHeader = new Label();
                        columnHeader.Text = data[i][j];
                        columnHeader.Font = new System.Drawing.Font(columnHeader.Font, System.Drawing.FontStyle.Bold);
                        columnHeader.Dock = DockStyle.Fill;
                        tableLayout.Controls.Add(columnHeader, j, i);
                    }
                    else
                    {
                        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / data[i].Length));
                        TextBox label = new TextBox();
                        label.ReadOnly = true;
                        label.Text = data[i][j];
                        label.Dock = DockStyle.Fill;
                        tableLayout.Controls.Add(label, j, i);
                    }
                }
            }

        }
        //Add New Radio station Button
        private void Add_New_Radio_Station_Button_Click(object sender, EventArgs e)
        {
            bool is_confirm_selected;
            var formPopup = new AddRadioDialog();
            using (formPopup)
            {
                formPopup.ShowDialog();
                is_confirm_selected = formPopup.Is_Confirm_Selected;
            }
            string Radio_Link_input = formPopup.textBox1.Text;
            string Radio_Name_input = formPopup.textBox2.Text;
            string Genre_input = formPopup.textBox3.Text;
            string Language_input = formPopup.textBox4.Text;
            string Bitrate_input = formPopup.textBox5.Text;
            if (string.IsNullOrEmpty(Radio_Name_input) || string.IsNullOrEmpty(Genre_input) || string.IsNullOrEmpty(Language_input) || string.IsNullOrEmpty(Bitrate_input))
            {
                MessageBox.Show("No Empty Textboxes");
            }
            else if (is_confirm_selected == false)
            {

            }
            else
            {
                string[] input_array = { Radio_Link_input, Radio_Name_input, Genre_input, Language_input, Bitrate_input };
                List_Of_Radios.Add(input_array);
                GenerateTable(List_Of_Radios, tableLayoutPanel1);
            }
        }
        //Remove Radio Button
        private void Remove_Radio_Station_Button_Click(object sender, EventArgs e)
        {
            using (RemoveRadioDialog formOptions = new RemoveRadioDialog(List_Of_Radios))
            {
                formOptions.ShowDialog();

                List_Of_Radios = formOptions.Radio_list;
            }
            GenerateTable(List_Of_Radios, tableLayoutPanel1);
        }
        //Exit Button
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Confirm & Exit 
        private void button1_Click(object sender, EventArgs e)
        {
            List<string[]> final_list = List_Of_Radios;

            using (StreamWriter writetext = new StreamWriter("live_streams2.sii"))
            {
                writetext.WriteLine("SiiNunit");
                writetext.WriteLine("{");
                writetext.WriteLine("live_stream_def : _nameless.225.8609.9300 {");
                writetext.WriteLine(" stream_data: 313");
                for (int i = 0; i < final_list.Count; i++)
                {
                    writetext.WriteLine(" stream_data[]: " + '"' + final_list[i][0] + "|" + final_list[i][1] + "|" + final_list[i][2] + "|" + final_list[i][3] + "|" + final_list[i][4] + "|" + "0" + '"');
                }
                writetext.WriteLine("}");
                writetext.WriteLine("}");
            }
            Close();
        }



        //UNUSED_Adds rows to tables from a given string[]
        public static void AddRowToTable(TableLayoutPanel tableLayoutPanel, string[] rowData)
        {
            // Get the column count of the table
            int columnCount = tableLayoutPanel.ColumnCount;

            // Add a new row to the table
            tableLayoutPanel.RowCount++;

            // Add the data to the new row
            for (int i = 0; i < columnCount; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Text = rowData[i].ToString();
                tableLayoutPanel.Controls.Add(textBox, i, tableLayoutPanel.RowCount);
            }
        }
        //UNUSED_Converts Table data to a list of string[]
        public static List<string[]> ConvertTableLayoutPanelToList(TableLayoutPanel tableLayoutPanel)
        {
            List<string[]> dataArray = new List<string[]>();

            // Extract data from TableLayoutPanel
            int rowCount = tableLayoutPanel.RowCount;
            int columnCount = tableLayoutPanel.ColumnCount;

            for (int i = 1; i < rowCount; i++)
            {
                string[] rowArray = new string[columnCount];
                for (int j = 0; j < columnCount; j++)
                {
                    Control control = tableLayoutPanel.GetControlFromPosition(j, i);
                    TextBox textBox = control as TextBox;
                    if (textBox != null)
                    {
                        rowArray[j] = textBox.Text;
                    }
                }
                dataArray.Add(rowArray);
            }
            dataArray.RemoveAll(array => array.All(str => string.IsNullOrWhiteSpace(str)));
            return dataArray;
        }
    }
}

