using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using Library;

namespace assignment4
{
    public partial class Form1 : Form
    {
        Library.BackEnd backend;

        public Form1()
        {
            InitializeComponent();
            DisableButtons();
        }
        public void DisableButtons()
        {
            SearchWord_button.Enabled = false;
            SearchLength_button.Enabled = false;
        }

        public void EnableButtons()
        {
            SearchWord_button.Enabled = true;
            SearchLength_button.Enabled = true;
        }

        //Load data into chart
        public void ShowChart()
        {
            Chart.Series.Clear();
            Chart.Series.Add("Words");
            
            
            int i = 0;
            foreach(string key in backend.frequency.Keys)
            {
                Chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                i++;
                if (i > 50)
                {
                    break;
                }
                DataPoint dp = new DataPoint();
                dp.SetValueXY(key, backend.frequency[key]);
                Chart.Series["Words"].Points.Add(dp);
            }
            
        }

        //Actions after loading file
        public void LoadFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EnableButtons();
                var reader = new StreamReader(openFileDialog.FileName);
                string data = reader.ReadToEnd().ToLower();
                backend = new Library.BackEnd(data);

                //Textbox Change
                CommonWords_TextBox.Text = backend.MostCommon();
                UniqueWords_TextBox.Text = backend.Unique();
                LongestWords_TextBox.Text = backend.LongestLength();
                ShortestWords_TextBox.Text = backend.ShortestLength();
                AverageLength_TextBox.Text = backend.AverageLength();
                SearchWord_Textbox.Text = "";
                SearchLength_TextBox.Text = "";
                SearchWordResult_TextBox.Text = "";
                SearchLengthResult_TextBox.Text = "";
                Chart_label.Text = "Absolute number of words(not counting repetitions) is " + backend.WordsCount().ToString() + ". Average word length all words is " + backend.AverageLengthAll();
               
                ShowChart();
            }
        }

        //------------------------------------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();   
        }
        private void SearchWord_button_Click(object sender, EventArgs e)
        {
            SearchWordResult_TextBox.Text = backend.SearchWord(SearchWord_Textbox.Text.ToLower());         
        }

        private void SearchLength_button_Click(object sender, EventArgs e)
        {
            SearchLengthResult_TextBox.Text = backend.SearchLength(int.Parse(SearchLength_TextBox.Text));
        }

        private void SearchLength_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
