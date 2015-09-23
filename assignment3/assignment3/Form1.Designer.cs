namespace assignment3
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
            this.components = new System.ComponentModel.Container();
            this.t1_flag = new System.Windows.Forms.PictureBox();
            this.t1_country_groupBox = new System.Windows.Forms.GroupBox();
            this.t1_nzl = new System.Windows.Forms.RadioButton();
            this.t1_eng = new System.Windows.Forms.RadioButton();
            this.t1_aus = new System.Windows.Forms.RadioButton();
            this.t2_flag = new System.Windows.Forms.PictureBox();
            this.t2_country_groupBox = new System.Windows.Forms.GroupBox();
            this.t2_nzl = new System.Windows.Forms.RadioButton();
            this.t2_eng = new System.Windows.Forms.RadioButton();
            this.t2_aus = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.same_team_warn = new System.Windows.Forms.Label();
            this.t1_try = new System.Windows.Forms.Button();
            this.t1_score_groupBox = new System.Windows.Forms.GroupBox();
            this.t1_dropkick = new System.Windows.Forms.Button();
            this.t1_penalty = new System.Windows.Forms.Button();
            this.t1_conversion = new System.Windows.Forms.Button();
            this.t2_score_groupBox = new System.Windows.Forms.GroupBox();
            this.t2_dropkick = new System.Windows.Forms.Button();
            this.t2_penalty = new System.Windows.Forms.Button();
            this.t2_conversion = new System.Windows.Forms.Button();
            this.t2_try = new System.Windows.Forms.Button();
            this.t1_player_comboBox = new System.Windows.Forms.ComboBox();
            this.t2_player_comboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.t1_score_label = new System.Windows.Forms.Label();
            this.t2_score_label = new System.Windows.Forms.Label();
            this.status_TextBox = new System.Windows.Forms.RichTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.t1_no_player_label = new System.Windows.Forms.Label();
            this.t2_no_player_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t1_flag)).BeginInit();
            this.t1_country_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2_flag)).BeginInit();
            this.t2_country_groupBox.SuspendLayout();
            this.t1_score_groupBox.SuspendLayout();
            this.t2_score_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // t1_flag
            // 
            this.t1_flag.Image = global::assignment3.Properties.Resources.unselected;
            this.t1_flag.Location = new System.Drawing.Point(24, 27);
            this.t1_flag.Name = "t1_flag";
            this.t1_flag.Size = new System.Drawing.Size(200, 112);
            this.t1_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1_flag.TabIndex = 0;
            this.t1_flag.TabStop = false;
            // 
            // t1_country_groupBox
            // 
            this.t1_country_groupBox.Controls.Add(this.t1_nzl);
            this.t1_country_groupBox.Controls.Add(this.t1_eng);
            this.t1_country_groupBox.Controls.Add(this.t1_aus);
            this.t1_country_groupBox.Location = new System.Drawing.Point(24, 155);
            this.t1_country_groupBox.Name = "t1_country_groupBox";
            this.t1_country_groupBox.Size = new System.Drawing.Size(200, 90);
            this.t1_country_groupBox.TabIndex = 1;
            this.t1_country_groupBox.TabStop = false;
            this.t1_country_groupBox.Text = "Team One";
            // 
            // t1_nzl
            // 
            this.t1_nzl.AutoSize = true;
            this.t1_nzl.Location = new System.Drawing.Point(7, 67);
            this.t1_nzl.Name = "t1_nzl";
            this.t1_nzl.Size = new System.Drawing.Size(89, 16);
            this.t1_nzl.TabIndex = 2;
            this.t1_nzl.Text = "New Zealand";
            this.t1_nzl.UseVisualStyleBackColor = true;
            this.t1_nzl.CheckedChanged += new System.EventHandler(this.t1_nz_CheckedChanged);
            // 
            // t1_eng
            // 
            this.t1_eng.AutoSize = true;
            this.t1_eng.Location = new System.Drawing.Point(7, 44);
            this.t1_eng.Name = "t1_eng";
            this.t1_eng.Size = new System.Drawing.Size(65, 16);
            this.t1_eng.TabIndex = 1;
            this.t1_eng.Text = "England";
            this.t1_eng.UseVisualStyleBackColor = true;
            this.t1_eng.CheckedChanged += new System.EventHandler(this.t1_eng_CheckedChanged);
            // 
            // t1_aus
            // 
            this.t1_aus.AutoSize = true;
            this.t1_aus.Location = new System.Drawing.Point(7, 21);
            this.t1_aus.Name = "t1_aus";
            this.t1_aus.Size = new System.Drawing.Size(77, 16);
            this.t1_aus.TabIndex = 0;
            this.t1_aus.Text = "Australia";
            this.t1_aus.UseVisualStyleBackColor = true;
            this.t1_aus.CheckedChanged += new System.EventHandler(this.t1_aus_CheckedChanged);
            // 
            // t2_flag
            // 
            this.t2_flag.Image = global::assignment3.Properties.Resources.unselected;
            this.t2_flag.Location = new System.Drawing.Point(318, 27);
            this.t2_flag.Name = "t2_flag";
            this.t2_flag.Size = new System.Drawing.Size(200, 112);
            this.t2_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2_flag.TabIndex = 2;
            this.t2_flag.TabStop = false;
            // 
            // t2_country_groupBox
            // 
            this.t2_country_groupBox.Controls.Add(this.t2_nzl);
            this.t2_country_groupBox.Controls.Add(this.t2_eng);
            this.t2_country_groupBox.Controls.Add(this.t2_aus);
            this.t2_country_groupBox.Location = new System.Drawing.Point(318, 155);
            this.t2_country_groupBox.Name = "t2_country_groupBox";
            this.t2_country_groupBox.Size = new System.Drawing.Size(200, 90);
            this.t2_country_groupBox.TabIndex = 3;
            this.t2_country_groupBox.TabStop = false;
            this.t2_country_groupBox.Text = "Team Two";
            // 
            // t2_nzl
            // 
            this.t2_nzl.AutoSize = true;
            this.t2_nzl.Location = new System.Drawing.Point(7, 67);
            this.t2_nzl.Name = "t2_nzl";
            this.t2_nzl.Size = new System.Drawing.Size(89, 16);
            this.t2_nzl.TabIndex = 2;
            this.t2_nzl.Text = "New Zealand";
            this.t2_nzl.UseVisualStyleBackColor = true;
            this.t2_nzl.CheckedChanged += new System.EventHandler(this.t2_nz_CheckedChanged);
            // 
            // t2_eng
            // 
            this.t2_eng.AutoSize = true;
            this.t2_eng.Location = new System.Drawing.Point(7, 44);
            this.t2_eng.Name = "t2_eng";
            this.t2_eng.Size = new System.Drawing.Size(65, 16);
            this.t2_eng.TabIndex = 1;
            this.t2_eng.Text = "England";
            this.t2_eng.UseVisualStyleBackColor = true;
            this.t2_eng.CheckedChanged += new System.EventHandler(this.t2_eng_CheckedChanged);
            // 
            // t2_aus
            // 
            this.t2_aus.AutoSize = true;
            this.t2_aus.Location = new System.Drawing.Point(7, 21);
            this.t2_aus.Name = "t2_aus";
            this.t2_aus.Size = new System.Drawing.Size(77, 16);
            this.t2_aus.TabIndex = 0;
            this.t2_aus.Text = "Australia";
            this.t2_aus.UseVisualStyleBackColor = true;
            this.t2_aus.CheckedChanged += new System.EventHandler(this.t2_aus_CheckedChanged);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(149, 331);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Enabled = false;
            this.pause.Location = new System.Drawing.Point(233, 331);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 5;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Location = new System.Drawing.Point(318, 331);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 23);
            this.end.TabIndex = 6;
            this.end.Text = "End";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // same_team_warn
            // 
            this.same_team_warn.AutoSize = true;
            this.same_team_warn.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.same_team_warn.ForeColor = System.Drawing.Color.Red;
            this.same_team_warn.Location = new System.Drawing.Point(166, 270);
            this.same_team_warn.Name = "same_team_warn";
            this.same_team_warn.Size = new System.Drawing.Size(236, 12);
            this.same_team_warn.TabIndex = 7;
            this.same_team_warn.Text = "*Please select 2 different teams.";
            this.same_team_warn.Visible = false;
            // 
            // t1_try
            // 
            this.t1_try.Location = new System.Drawing.Point(21, 22);
            this.t1_try.Name = "t1_try";
            this.t1_try.Size = new System.Drawing.Size(75, 23);
            this.t1_try.TabIndex = 8;
            this.t1_try.Text = "Try";
            this.t1_try.UseVisualStyleBackColor = true;
            this.t1_try.Click += new System.EventHandler(this.t1_try_Click);
            // 
            // t1_score_groupBox
            // 
            this.t1_score_groupBox.Controls.Add(this.t1_dropkick);
            this.t1_score_groupBox.Controls.Add(this.t1_penalty);
            this.t1_score_groupBox.Controls.Add(this.t1_conversion);
            this.t1_score_groupBox.Controls.Add(this.t1_try);
            this.t1_score_groupBox.Location = new System.Drawing.Point(24, 156);
            this.t1_score_groupBox.Name = "t1_score_groupBox";
            this.t1_score_groupBox.Size = new System.Drawing.Size(136, 137);
            this.t1_score_groupBox.TabIndex = 9;
            this.t1_score_groupBox.TabStop = false;
            this.t1_score_groupBox.Text = "Team One";
            this.t1_score_groupBox.Visible = false;
            // 
            // t1_dropkick
            // 
            this.t1_dropkick.Location = new System.Drawing.Point(21, 108);
            this.t1_dropkick.Name = "t1_dropkick";
            this.t1_dropkick.Size = new System.Drawing.Size(75, 23);
            this.t1_dropkick.TabIndex = 11;
            this.t1_dropkick.Text = "Drop Kick";
            this.t1_dropkick.UseVisualStyleBackColor = true;
            this.t1_dropkick.Click += new System.EventHandler(this.t1_dropkick_Click);
            // 
            // t1_penalty
            // 
            this.t1_penalty.Location = new System.Drawing.Point(21, 79);
            this.t1_penalty.Name = "t1_penalty";
            this.t1_penalty.Size = new System.Drawing.Size(75, 23);
            this.t1_penalty.TabIndex = 10;
            this.t1_penalty.Text = "Penalty";
            this.t1_penalty.UseVisualStyleBackColor = true;
            this.t1_penalty.Click += new System.EventHandler(this.t1_penalty_Click);
            // 
            // t1_conversion
            // 
            this.t1_conversion.Location = new System.Drawing.Point(21, 51);
            this.t1_conversion.Name = "t1_conversion";
            this.t1_conversion.Size = new System.Drawing.Size(75, 23);
            this.t1_conversion.TabIndex = 9;
            this.t1_conversion.Text = "Conversion";
            this.t1_conversion.UseVisualStyleBackColor = true;
            this.t1_conversion.Click += new System.EventHandler(this.t1_conversion_Click);
            // 
            // t2_score_groupBox
            // 
            this.t2_score_groupBox.Controls.Add(this.t2_dropkick);
            this.t2_score_groupBox.Controls.Add(this.t2_penalty);
            this.t2_score_groupBox.Controls.Add(this.t2_conversion);
            this.t2_score_groupBox.Controls.Add(this.t2_try);
            this.t2_score_groupBox.Location = new System.Drawing.Point(387, 156);
            this.t2_score_groupBox.Name = "t2_score_groupBox";
            this.t2_score_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.t2_score_groupBox.Size = new System.Drawing.Size(131, 137);
            this.t2_score_groupBox.TabIndex = 10;
            this.t2_score_groupBox.TabStop = false;
            this.t2_score_groupBox.Text = "Team Two";
            this.t2_score_groupBox.Visible = false;
            // 
            // t2_dropkick
            // 
            this.t2_dropkick.Location = new System.Drawing.Point(34, 108);
            this.t2_dropkick.Name = "t2_dropkick";
            this.t2_dropkick.Size = new System.Drawing.Size(75, 23);
            this.t2_dropkick.TabIndex = 11;
            this.t2_dropkick.Text = "Drop Kick";
            this.t2_dropkick.UseVisualStyleBackColor = true;
            this.t2_dropkick.Click += new System.EventHandler(this.t2_dropkick_Click);
            // 
            // t2_penalty
            // 
            this.t2_penalty.Location = new System.Drawing.Point(34, 79);
            this.t2_penalty.Name = "t2_penalty";
            this.t2_penalty.Size = new System.Drawing.Size(75, 23);
            this.t2_penalty.TabIndex = 10;
            this.t2_penalty.Text = "Penalty";
            this.t2_penalty.UseVisualStyleBackColor = true;
            this.t2_penalty.Click += new System.EventHandler(this.t2_penalty_Click);
            // 
            // t2_conversion
            // 
            this.t2_conversion.Location = new System.Drawing.Point(34, 50);
            this.t2_conversion.Name = "t2_conversion";
            this.t2_conversion.Size = new System.Drawing.Size(75, 23);
            this.t2_conversion.TabIndex = 9;
            this.t2_conversion.Text = "Conversion";
            this.t2_conversion.UseVisualStyleBackColor = true;
            this.t2_conversion.Click += new System.EventHandler(this.t2_conversion_Click);
            // 
            // t2_try
            // 
            this.t2_try.Location = new System.Drawing.Point(34, 19);
            this.t2_try.Name = "t2_try";
            this.t2_try.Size = new System.Drawing.Size(75, 23);
            this.t2_try.TabIndex = 8;
            this.t2_try.Text = "Try";
            this.t2_try.UseVisualStyleBackColor = true;
            this.t2_try.Click += new System.EventHandler(this.t2_try_Click);
            // 
            // t1_player_comboBox
            // 
            this.t1_player_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t1_player_comboBox.FormattingEnabled = true;
            this.t1_player_comboBox.Location = new System.Drawing.Point(24, 299);
            this.t1_player_comboBox.Name = "t1_player_comboBox";
            this.t1_player_comboBox.Size = new System.Drawing.Size(200, 20);
            this.t1_player_comboBox.TabIndex = 11;
            this.t1_player_comboBox.Visible = false;
            this.t1_player_comboBox.SelectedIndexChanged += new System.EventHandler(this.t1_player_comboBox_SelectedIndexChanged);
            // 
            // t2_player_comboBox
            // 
            this.t2_player_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t2_player_comboBox.FormattingEnabled = true;
            this.t2_player_comboBox.Location = new System.Drawing.Point(318, 299);
            this.t2_player_comboBox.Name = "t2_player_comboBox";
            this.t2_player_comboBox.Size = new System.Drawing.Size(200, 20);
            this.t2_player_comboBox.TabIndex = 12;
            this.t2_player_comboBox.Visible = false;
            this.t2_player_comboBox.SelectedIndexChanged += new System.EventHandler(this.t2_player_comboBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_label.Location = new System.Drawing.Point(245, 236);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(53, 16);
            this.time_label.TabIndex = 13;
            this.time_label.Text = "00:00";
            this.time_label.Visible = false;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.score_label.Location = new System.Drawing.Point(245, 123);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(53, 16);
            this.score_label.TabIndex = 14;
            this.score_label.Text = "Score";
            this.score_label.Visible = false;
            // 
            // t1_score_label
            // 
            this.t1_score_label.AutoSize = true;
            this.t1_score_label.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t1_score_label.Location = new System.Drawing.Point(220, 156);
            this.t1_score_label.Name = "t1_score_label";
            this.t1_score_label.Size = new System.Drawing.Size(23, 24);
            this.t1_score_label.TabIndex = 15;
            this.t1_score_label.Text = "0";
            this.t1_score_label.Visible = false;
            // 
            // t2_score_label
            // 
            this.t2_score_label.AutoSize = true;
            this.t2_score_label.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t2_score_label.Location = new System.Drawing.Point(296, 156);
            this.t2_score_label.Name = "t2_score_label";
            this.t2_score_label.Size = new System.Drawing.Size(23, 24);
            this.t2_score_label.TabIndex = 16;
            this.t2_score_label.Text = "0";
            this.t2_score_label.Visible = false;
            // 
            // status_TextBox
            // 
            this.status_TextBox.Location = new System.Drawing.Point(24, 360);
            this.status_TextBox.Name = "status_TextBox";
            this.status_TextBox.Size = new System.Drawing.Size(494, 209);
            this.status_TextBox.TabIndex = 17;
            this.status_TextBox.Text = "";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(443, 581);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 18;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // t1_no_player_label
            // 
            this.t1_no_player_label.AutoSize = true;
            this.t1_no_player_label.Location = new System.Drawing.Point(22, 322);
            this.t1_no_player_label.Name = "t1_no_player_label";
            this.t1_no_player_label.Size = new System.Drawing.Size(101, 12);
            this.t1_no_player_label.TabIndex = 19;
            this.t1_no_player_label.Text = "*Select a player";
            this.t1_no_player_label.Visible = false;
            // 
            // t2_no_player_label
            // 
            this.t2_no_player_label.AutoSize = true;
            this.t2_no_player_label.Location = new System.Drawing.Point(417, 322);
            this.t2_no_player_label.Name = "t2_no_player_label";
            this.t2_no_player_label.Size = new System.Drawing.Size(101, 12);
            this.t2_no_player_label.TabIndex = 20;
            this.t2_no_player_label.Text = "*Select a player";
            this.t2_no_player_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 616);
            this.Controls.Add(this.t2_no_player_label);
            this.Controls.Add(this.t1_no_player_label);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.status_TextBox);
            this.Controls.Add(this.t2_score_label);
            this.Controls.Add(this.t1_score_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.t2_player_comboBox);
            this.Controls.Add(this.t1_player_comboBox);
            this.Controls.Add(this.t2_score_groupBox);
            this.Controls.Add(this.t1_score_groupBox);
            this.Controls.Add(this.same_team_warn);
            this.Controls.Add(this.end);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.t2_country_groupBox);
            this.Controls.Add(this.t2_flag);
            this.Controls.Add(this.t1_country_groupBox);
            this.Controls.Add(this.t1_flag);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.t1_flag)).EndInit();
            this.t1_country_groupBox.ResumeLayout(false);
            this.t1_country_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t2_flag)).EndInit();
            this.t2_country_groupBox.ResumeLayout(false);
            this.t2_country_groupBox.PerformLayout();
            this.t1_score_groupBox.ResumeLayout(false);
            this.t2_score_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox t1_flag;
        private System.Windows.Forms.GroupBox t1_country_groupBox;
        private System.Windows.Forms.RadioButton t1_eng;
        private System.Windows.Forms.RadioButton t1_aus;
        private System.Windows.Forms.RadioButton t1_nzl;
        private System.Windows.Forms.PictureBox t2_flag;
        private System.Windows.Forms.GroupBox t2_country_groupBox;
        private System.Windows.Forms.RadioButton t2_nzl;
        private System.Windows.Forms.RadioButton t2_eng;
        private System.Windows.Forms.RadioButton t2_aus;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Label same_team_warn;
        private System.Windows.Forms.Button t1_try;
        private System.Windows.Forms.GroupBox t1_score_groupBox;
        private System.Windows.Forms.Button t1_dropkick;
        private System.Windows.Forms.Button t1_penalty;
        private System.Windows.Forms.Button t1_conversion;
        private System.Windows.Forms.GroupBox t2_score_groupBox;
        private System.Windows.Forms.Button t2_dropkick;
        private System.Windows.Forms.Button t2_penalty;
        private System.Windows.Forms.Button t2_conversion;
        private System.Windows.Forms.Button t2_try;
        private System.Windows.Forms.ComboBox t1_player_comboBox;
        private System.Windows.Forms.ComboBox t2_player_comboBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label t1_score_label;
        private System.Windows.Forms.Label t2_score_label;
        private System.Windows.Forms.RichTextBox status_TextBox;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label t1_no_player_label;
        private System.Windows.Forms.Label t2_no_player_label;
    }
}

