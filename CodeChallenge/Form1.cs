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

namespace CodeChallenge
{
    public partial class Form1 : Form
    {

        private BindingList<Station> stationsList = new BindingList<Station>();
        public Form1()
        {
            InitializeComponent();
            myGridView.DataSource = stationsList;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            PopulateGridDataFile(getUserFilePath());
        }
       
        private void changeChar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myGridView.Rows.Count; i++) //lines
            {
                for (int j = 0; j < myGridView.Columns.Count; j++) //columns
                {
                    string temp = myGridView[j,i].Value?.ToString();
                    if(temp != null)
                        myGridView[j, i].Value = temp.Replace('a', '@');
                }
            }

        }

        private void comboShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myCombo.SelectedIndex + " - " + myCombo.SelectedItem);
        }

        private void populateCombo_Click(object sender, EventArgs e)
        {
            PopulateComboDataFile(getUserFilePath());
        }

        private string getUserFilePath() 
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    return filePath;
                }
            }
            return "";
        }

        private void PopulateComboDataFile(string path) 
        {
            if (path == string.Empty)
                MessageBox.Show("Error, No file chosen");
            else
            {
                string[] lines = System.IO.File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] content = line.Split(',');

                    Console.WriteLine(content.Length);
                    if (content.Length >= 2)
                    {
                        int index;
                        int.TryParse(content[0], out index);
                        myCombo.Items.Insert(index, content[1]);
                    }

                }
            }
        }
        private void PopulateGridDataFile(string path)
        {
            if (path == string.Empty)
                MessageBox.Show("Error, No file chosen");
            else 
            { 
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines.Length > 0)
                {
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] lineContent = lines[i].Split(',');
                        try
                        {
                            int id;
                            Int32.TryParse(lineContent[1], out id);
                            decimal depth;
                            Decimal.TryParse(lineContent[3], out depth);
                            Station content = new Station(lineContent[0], id, lineContent[2], depth, lineContent[4]);
                            stationsList.Add(content);
                            content = null;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(idInput.Text, out id);
            decimal depth;
            Decimal.TryParse(depthInput.Text, out depth);
            stationsList.Add(new Station(nameInput.Text.ToString(), id, dateInput.Text.ToString(), depth, commentsInput.Text.ToString()));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.myGridView.SelectedRows.Count > 0)
            {
                myGridView.Rows.RemoveAt(this.myGridView.SelectedRows[0].Index);
            }
            else
                MessageBox.Show("Select the entire line to delete");
        }
    }
}
