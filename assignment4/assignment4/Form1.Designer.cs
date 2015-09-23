namespace assignment4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.CommonWords_TextBox = new System.Windows.Forms.RichTextBox();
            this.LongestWords_TextBox = new System.Windows.Forms.RichTextBox();
            this.ShortestWords_TextBox = new System.Windows.Forms.RichTextBox();
            this.AverageLength_TextBox = new System.Windows.Forms.RichTextBox();
            this.CommonWords_label = new System.Windows.Forms.Label();
            this.LongestWords_label = new System.Windows.Forms.Label();
            this.ShortestWords_label = new System.Windows.Forms.Label();
            this.AverageLength_label = new System.Windows.Forms.Label();
            this.SearchWordResult_TextBox = new System.Windows.Forms.RichTextBox();
            this.SearchLengthResult_TextBox = new System.Windows.Forms.RichTextBox();
            this.UniqueWords_TextBox = new System.Windows.Forms.RichTextBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.SearchLength_label = new System.Windows.Forms.Label();
            this.SearchWord_Textbox = new System.Windows.Forms.TextBox();
            this.SearchLength_TextBox = new System.Windows.Forms.TextBox();
            this.SearchWord_button = new System.Windows.Forms.Button();
            this.SearchLength_button = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UniqueWords_label = new System.Windows.Forms.Label();
            this.Chart_label = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CommonWords_TextBox
            // 
            this.CommonWords_TextBox.Location = new System.Drawing.Point(157, 40);
            this.CommonWords_TextBox.Name = "CommonWords_TextBox";
            this.CommonWords_TextBox.ReadOnly = true;
            this.CommonWords_TextBox.Size = new System.Drawing.Size(173, 73);
            this.CommonWords_TextBox.TabIndex = 0;
            this.CommonWords_TextBox.Text = "";
            // 
            // LongestWords_TextBox
            // 
            this.LongestWords_TextBox.Location = new System.Drawing.Point(157, 132);
            this.LongestWords_TextBox.Name = "LongestWords_TextBox";
            this.LongestWords_TextBox.ReadOnly = true;
            this.LongestWords_TextBox.Size = new System.Drawing.Size(173, 73);
            this.LongestWords_TextBox.TabIndex = 1;
            this.LongestWords_TextBox.Text = "";
            // 
            // ShortestWords_TextBox
            // 
            this.ShortestWords_TextBox.Location = new System.Drawing.Point(157, 228);
            this.ShortestWords_TextBox.Name = "ShortestWords_TextBox";
            this.ShortestWords_TextBox.ReadOnly = true;
            this.ShortestWords_TextBox.Size = new System.Drawing.Size(173, 73);
            this.ShortestWords_TextBox.TabIndex = 2;
            this.ShortestWords_TextBox.Text = "";
            // 
            // AverageLength_TextBox
            // 
            this.AverageLength_TextBox.Location = new System.Drawing.Point(157, 320);
            this.AverageLength_TextBox.Name = "AverageLength_TextBox";
            this.AverageLength_TextBox.ReadOnly = true;
            this.AverageLength_TextBox.Size = new System.Drawing.Size(173, 73);
            this.AverageLength_TextBox.TabIndex = 3;
            this.AverageLength_TextBox.Text = "";
            // 
            // CommonWords_label
            // 
            this.CommonWords_label.AutoSize = true;
            this.CommonWords_label.Location = new System.Drawing.Point(18, 47);
            this.CommonWords_label.Name = "CommonWords_label";
            this.CommonWords_label.Size = new System.Drawing.Size(107, 12);
            this.CommonWords_label.TabIndex = 4;
            this.CommonWords_label.Text = "Most common words";
            // 
            // LongestWords_label
            // 
            this.LongestWords_label.AutoSize = true;
            this.LongestWords_label.Location = new System.Drawing.Point(18, 135);
            this.LongestWords_label.Name = "LongestWords_label";
            this.LongestWords_label.Size = new System.Drawing.Size(83, 12);
            this.LongestWords_label.TabIndex = 5;
            this.LongestWords_label.Text = "Longest words";
            // 
            // ShortestWords_label
            // 
            this.ShortestWords_label.AutoSize = true;
            this.ShortestWords_label.Location = new System.Drawing.Point(18, 241);
            this.ShortestWords_label.Name = "ShortestWords_label";
            this.ShortestWords_label.Size = new System.Drawing.Size(89, 12);
            this.ShortestWords_label.TabIndex = 6;
            this.ShortestWords_label.Text = "Shortest words";
            // 
            // AverageLength_label
            // 
            this.AverageLength_label.AutoSize = true;
            this.AverageLength_label.Location = new System.Drawing.Point(18, 334);
            this.AverageLength_label.Name = "AverageLength_label";
            this.AverageLength_label.Size = new System.Drawing.Size(119, 12);
            this.AverageLength_label.TabIndex = 7;
            this.AverageLength_label.Text = "Average word length";
            // 
            // SearchWordResult_TextBox
            // 
            this.SearchWordResult_TextBox.Location = new System.Drawing.Point(599, 37);
            this.SearchWordResult_TextBox.Name = "SearchWordResult_TextBox";
            this.SearchWordResult_TextBox.ReadOnly = true;
            this.SearchWordResult_TextBox.Size = new System.Drawing.Size(224, 76);
            this.SearchWordResult_TextBox.TabIndex = 8;
            this.SearchWordResult_TextBox.Text = "";
            // 
            // SearchLengthResult_TextBox
            // 
            this.SearchLengthResult_TextBox.Location = new System.Drawing.Point(599, 129);
            this.SearchLengthResult_TextBox.Name = "SearchLengthResult_TextBox";
            this.SearchLengthResult_TextBox.ReadOnly = true;
            this.SearchLengthResult_TextBox.Size = new System.Drawing.Size(224, 76);
            this.SearchLengthResult_TextBox.TabIndex = 9;
            this.SearchLengthResult_TextBox.Text = "";
            // 
            // UniqueWords_TextBox
            // 
            this.UniqueWords_TextBox.Location = new System.Drawing.Point(412, 232);
            this.UniqueWords_TextBox.Name = "UniqueWords_TextBox";
            this.UniqueWords_TextBox.ReadOnly = true;
            this.UniqueWords_TextBox.Size = new System.Drawing.Size(411, 224);
            this.UniqueWords_TextBox.TabIndex = 10;
            this.UniqueWords_TextBox.Text = "";
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.Location = new System.Drawing.Point(410, 40);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(77, 12);
            this.Search_label.TabIndex = 11;
            this.Search_label.Text = "Search words";
            // 
            // SearchLength_label
            // 
            this.SearchLength_label.AutoSize = true;
            this.SearchLength_label.Location = new System.Drawing.Point(404, 132);
            this.SearchLength_label.Name = "SearchLength_label";
            this.SearchLength_label.Size = new System.Drawing.Size(83, 12);
            this.SearchLength_label.TabIndex = 12;
            this.SearchLength_label.Text = "Search length";
            // 
            // SearchWord_Textbox
            // 
            this.SearchWord_Textbox.Location = new System.Drawing.Point(493, 38);
            this.SearchWord_Textbox.Name = "SearchWord_Textbox";
            this.SearchWord_Textbox.Size = new System.Drawing.Size(100, 21);
            this.SearchWord_Textbox.TabIndex = 13;
            // 
            // SearchLength_TextBox
            // 
            this.SearchLength_TextBox.Location = new System.Drawing.Point(493, 129);
            this.SearchLength_TextBox.Name = "SearchLength_TextBox";
            this.SearchLength_TextBox.Size = new System.Drawing.Size(100, 21);
            this.SearchLength_TextBox.TabIndex = 14;
            this.SearchLength_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchLength_TextBox_KeyPress);
            // 
            // SearchWord_button
            // 
            this.SearchWord_button.Location = new System.Drawing.Point(506, 65);
            this.SearchWord_button.Name = "SearchWord_button";
            this.SearchWord_button.Size = new System.Drawing.Size(75, 21);
            this.SearchWord_button.TabIndex = 15;
            this.SearchWord_button.Text = "Search";
            this.SearchWord_button.UseVisualStyleBackColor = true;
            this.SearchWord_button.Click += new System.EventHandler(this.SearchWord_button_Click);
            // 
            // SearchLength_button
            // 
            this.SearchLength_button.Location = new System.Drawing.Point(506, 156);
            this.SearchLength_button.Name = "SearchLength_button";
            this.SearchLength_button.Size = new System.Drawing.Size(75, 21);
            this.SearchLength_button.TabIndex = 16;
            this.SearchLength_button.Text = "Search";
            this.SearchLength_button.UseVisualStyleBackColor = true;
            this.SearchLength_button.Click += new System.EventHandler(this.SearchLength_button_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(842, 25);
            this.menuStrip.TabIndex = 17;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text File|*.txt;”";
            // 
            // UniqueWords_label
            // 
            this.UniqueWords_label.AutoSize = true;
            this.UniqueWords_label.Location = new System.Drawing.Point(410, 217);
            this.UniqueWords_label.Name = "UniqueWords_label";
            this.UniqueWords_label.Size = new System.Drawing.Size(149, 12);
            this.UniqueWords_label.TabIndex = 18;
            this.UniqueWords_label.Text = "List of all unique words";
            // 
            // Chart_label
            // 
            this.Chart_label.AutoSize = true;
            this.Chart_label.Location = new System.Drawing.Point(18, 473);
            this.Chart_label.Name = "Chart_label";
            this.Chart_label.Size = new System.Drawing.Size(0, 12);
            this.Chart_label.TabIndex = 19;
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(20, 491);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(803, 300);
            this.Chart.TabIndex = 20;
            this.Chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 801);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Chart_label);
            this.Controls.Add(this.UniqueWords_label);
            this.Controls.Add(this.SearchLength_button);
            this.Controls.Add(this.SearchWord_button);
            this.Controls.Add(this.SearchLength_TextBox);
            this.Controls.Add(this.SearchWord_Textbox);
            this.Controls.Add(this.SearchLength_label);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.UniqueWords_TextBox);
            this.Controls.Add(this.SearchLengthResult_TextBox);
            this.Controls.Add(this.SearchWordResult_TextBox);
            this.Controls.Add(this.AverageLength_label);
            this.Controls.Add(this.ShortestWords_label);
            this.Controls.Add(this.LongestWords_label);
            this.Controls.Add(this.CommonWords_label);
            this.Controls.Add(this.AverageLength_TextBox);
            this.Controls.Add(this.ShortestWords_TextBox);
            this.Controls.Add(this.LongestWords_TextBox);
            this.Controls.Add(this.CommonWords_TextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CommonWords_TextBox;
        private System.Windows.Forms.RichTextBox LongestWords_TextBox;
        private System.Windows.Forms.RichTextBox ShortestWords_TextBox;
        private System.Windows.Forms.RichTextBox AverageLength_TextBox;
        private System.Windows.Forms.Label CommonWords_label;
        private System.Windows.Forms.Label LongestWords_label;
        private System.Windows.Forms.Label ShortestWords_label;
        private System.Windows.Forms.Label AverageLength_label;
        private System.Windows.Forms.RichTextBox SearchWordResult_TextBox;
        private System.Windows.Forms.RichTextBox SearchLengthResult_TextBox;
        private System.Windows.Forms.RichTextBox UniqueWords_TextBox;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Label SearchLength_label;
        private System.Windows.Forms.TextBox SearchWord_Textbox;
        private System.Windows.Forms.TextBox SearchLength_TextBox;
        private System.Windows.Forms.Button SearchWord_button;
        private System.Windows.Forms.Button SearchLength_button;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label UniqueWords_label;
        private System.Windows.Forms.Label Chart_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}

