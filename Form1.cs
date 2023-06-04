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
        public Form1()
        {
            InitializeComponent();
            this.Text = "Truck Simulator Radio Manager";
        }
        //Browse Button
        private void Browse_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath_Textbox.Text = openFileDialog1.FileName;
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

                    GenerateTable(parsed_array, tableLayoutPanel1);
                }
            }
            catch (Exception a)
            {
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
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_New_Radio_Station_Button_Click(object sender, EventArgs e)
        {
            var formPopup = new AddRadioDialog();
            formPopup.ShowDialog(this);
            string Radio_Link_input = formPopup.textBox1.Text;
            string Radio_Name_input = formPopup.textBox2.Text;
            string Genre_input = formPopup.textBox3.Text;
            string Language_input = formPopup.textBox4.Text;
            string Bitrate_input = formPopup.textBox5.Text;
            string[] input_array = { Radio_Link_input, Radio_Name_input, Genre_input, Language_input, Bitrate_input };
            AddRowToTable(tableLayoutPanel1,input_array);
            GenerateTable(ConvertTableLayoutPanelToList(tableLayoutPanel1),tableLayoutPanel1);
        }
        //Opens About Box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
        }
        public void AddRowToTable(TableLayoutPanel tableLayout, string[] rowData)
        {
            // Get the index of the last row
            int lastRowIndex = tableLayout.RowCount - 1;

            // Add a new row to the table
            tableLayout.RowCount++;

            // Add the new row data to the table
            for (int i = 0; i < rowData.Length; i++)
            {
                // Create a label for each cell in the new row
                TextBox label = new TextBox();
                label.Text = rowData[i];
                label.Dock = DockStyle.Fill;
                label.BackColor = Color.LightGreen;
                tableLayout.Controls.Add(label, i, lastRowIndex);
            }
        }
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

            return dataArray;
        }

    }

}