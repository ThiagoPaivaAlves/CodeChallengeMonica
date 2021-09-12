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
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            PopulateGridDataFile(getUserFilePath());
        }

       
        private void changeChar_Click(object sender, EventArgs e)
        {
            int rows = myGridView.Rows.Count;
            int col = myGridView.Columns.Count;

            for (int i = 0; i < rows; i++) //lines
            {
                for (int j = 0; j < col; j++) //columns
                {
                    string temp = myGridView[j,i].Value?.ToString();
                    if(temp != null)
                        myGridView[j, i].Value = temp.Replace('a', '@');
                }
            }

        }

        private void myCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
        private void PopulateGridDataFile(string path)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines.Length > 0)
            {
                //creating headers
                string headers = lines[0];
                string[] labels = headers.Split(',');

                foreach (string word in labels)
                {
                    dt.Columns.Add(new DataColumn(word));
                }
                //getting the data

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] lineContent = lines[i].Split(',');
                    DataRow row = dt.NewRow(); //adding rows
                    int index = 0;
                    foreach (string content in labels)
                    {
                        row[content] = lineContent[index++];
                    }
                    dt.Rows.Add(row);
                }

                if (dt.Rows.Count > 0)
                {
                    myGridView.DataSource = dt;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
