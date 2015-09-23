// 13158665 Yuxiang Zhang
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string team1 = "";
        public string team2 = "";

        public int t1_score = 0;
        public int t2_score = 0;

        public int t1_try_num = 0;
        public int t1_conversion_num = 0;
        public int t1_dropkick_num = 0;
        public int t1_penalty_num = 0;
        public int t2_try_num = 0;
        public int t2_conversion_num = 0;
        public int t2_dropkick_num = 0;
        public int t2_penalty_num = 0;

        public int sec = 0;
        public int min = 0;
        public string time = "";

        public void Start()
        {
            start.Enabled = false;
            pause.Enabled = true;
            end.Enabled = true;
            score_label.Visible = true;
            t1_country_groupBox.Visible = false;
            t2_country_groupBox.Visible = false;
            t1_score_groupBox.Visible = true;
            t2_score_groupBox.Visible = true;
            t1_score_groupBox.Enabled = false;
            t2_score_groupBox.Enabled = false;
            t1_player_comboBox.Visible = true;
            t2_player_comboBox.Visible = true;
            TeamPlayer();
            timer1.Enabled = true;
            time_label.Visible = true;
            t1_score_label.Visible = true;
            t2_score_label.Visible = true;
            t1_no_player_label.Visible = true;
            t2_no_player_label.Visible = true;
        }
        //Pause timing and disable scoring
        public void Pause()
        {
            if (pause.Text == "Pause")
            {
                timer1.Enabled = false;
                pause.Text = "Countine";
                t1_score_groupBox.Enabled = false;
                t2_score_groupBox.Enabled = false;
            }
            else if (pause.Text == "Countine")
            {
                timer1.Enabled = true;
                pause.Text = "Pause";
                if (t1_player_comboBox.Text != "")
                {
                    t1_score_groupBox.Enabled = true;
                }
                if (t2_player_comboBox.Text != "")
                {
                    t2_score_groupBox.Enabled = true;
                }
            }       
        }

        public void Stop()
        {
            end.Enabled = false;
            timer1.Enabled = false;
            pause.Enabled = false;
            t1_score_groupBox.Enabled = false;
            t2_score_groupBox.Enabled = false;

            MatchResult();
        }
        //Reset all specs and back to country selection
        public void Reset()
        {
            timer1.Enabled = false;
            sec = 0;
            min = 0;
            time_label.Text = "00:00";
            time_label.Visible = false;

            t1_score_label.Visible = false;
            t2_score_label.Visible = false;
            t1_score_label.Text = "0";
            t2_score_label.Text = "0";

            t1_score = 0;
            t2_score = 0;

            status_TextBox.Text = "";

            t1_score_groupBox.Visible = false;
            t2_score_groupBox.Visible = false;
            t1_player_comboBox.Visible = false;
            t2_player_comboBox.Visible = false;
            t1_country_groupBox.Visible = true;
            t2_country_groupBox.Visible = true;

            score_label.Visible = false;

            t1_aus.Checked = false;
            t1_eng.Checked = false;
            t1_nzl.Checked = false;
            t2_aus.Checked = false;
            t2_eng.Checked = false;
            t2_nzl.Checked = false;
            t1_flag.Load("unselected.png");
            t2_flag.Load("unselected.png");
            team1 = "";
            team2 = "";
            same_team_warn.Visible = false;
            
            //Clear all player names in all comboBoxes
            t1_player_comboBox.Items.Clear();
            t2_player_comboBox.Items.Clear();

            start.Enabled = false;
            pause.Enabled = false;
            end.Enabled = false;
            pause.Text = "Pause";
        }  

        //Validate if same teams are selected
        public void SameTeam()
        {  
            if (team1 == team2)
            {
                start.Enabled = false;
                same_team_warn.Visible = true; //display warning label if same team are selected
            }
            else if ((team1 != "")&&(team2 != ""))
            {
                start.Enabled = true;
                same_team_warn.Visible = false;
            }
        }

        //-----------Distribute specific player names for each team------------
        public void TeamPlayer()
        {
            //----Team One----
            if (team1.CompareTo("AUS") == 0)
            {
                t1_player_comboBox.Items.AddRange(new object[] { "Nathan Charles", "James Hanson", "Stephen Moore"});
            }
            if(team1.CompareTo("ENG") == 0)
            {
                t1_player_comboBox.Items.AddRange(new object[] { "Dylan Hartley", "Rob Webber", "Tom Youngs" });
            }
            if (team1.CompareTo("NZL") == 0)
            {
                t1_player_comboBox.Items.AddRange(new object[] { "Dane Coles", "Nathan Harris", "Keven Mealamu" });
            }
            //----Team Two----
            if (team2.CompareTo("AUS") == 0)
            {
                t2_player_comboBox.Items.AddRange(new object[] { "Nathan Charles", "James Hanson", "Stephen Moore" });
            }
            if (team2.CompareTo("ENG") == 0)
            {
                t2_player_comboBox.Items.AddRange(new object[] { "Dylan Hartley", "Rob Webber", "Tom Youngs" });
            }
            if (team2.CompareTo("NZL") == 0)
            {
                t2_player_comboBox.Items.AddRange(new object[] { "Dane Coles", "Nathan Harris", "Keven Mealamu" });
            }
        }

        //---------------SCORING SYSTEM-------------------
        //Calculate and display score when perform a "Try","Conversion" etc.
        public void Team1Try()
        {
            t1_score += 5;
            t1_score_label.Text = t1_score.ToString();
            status_TextBox.Text += team1 + " scored a try at " + time_label.Text + " by " + t1_player_comboBox.Text + "\n";
            t1_try_num++;
        }
        public void Team1Conversion()
        {
            t1_score += 2;
            t1_score_label.Text = t1_score.ToString();
            status_TextBox.Text += team1 + " converted at " + time_label.Text + " by " + t1_player_comboBox.Text + "\n";
            t1_conversion_num++;
        }
        public void Team1DropKick()
        {
            t1_score += 3;
            t1_score_label.Text = t1_score.ToString();
            status_TextBox.Text += team1 + " scored a drop-kick at " + time_label.Text + " by " + t1_player_comboBox.Text + "\n";
            t1_dropkick_num++;
        }
        public void Team1Penalty()
        {
            t1_score += 3;
            t1_score_label.Text = t1_score.ToString();
            status_TextBox.Text += team1 + " scored a penalty at " + time_label.Text + " by " + t1_player_comboBox.Text + "\n";
            t1_penalty_num++;
        }
        public void Team2Try()
        {
            t2_score += 5;
            t2_score_label.Text = t2_score.ToString();
            status_TextBox.Text += team2 + " scored a try at " + time_label.Text + " by " + t2_player_comboBox.Text + "\n";
            t2_try_num++;
        }
        public void Team2Conversion()
        {
            t2_score += 2;
            t2_score_label.Text = t2_score.ToString();
            status_TextBox.Text += team2 + " converted at " + time_label.Text + " by " + t2_player_comboBox.Text + "\n";
            t2_conversion_num++;
        }
        public void Team2DropKick()
        {
            t2_score += 3;
            t2_score_label.Text = t2_score.ToString();
            status_TextBox.Text += team2 + " scored a drop-kick " + time_label.Text + " by " + t2_player_comboBox.Text + "\n";
            t2_dropkick_num++;
        }
        public void Team2Penalty()
        {
            t2_score += 3;
            t2_score_label.Text = t2_score.ToString();
            status_TextBox.Text += team2 + " scored a penalty " + time_label.Text + " by " + t2_player_comboBox.Text + "\n";
            t2_penalty_num++;
        }
        //---------------------END------------------------
        //---------------SCORING SYSTEM-------------------


        //Convert time to "xx:xx" format and display when match starts
        public void Timer()
        {
            time = min.ToString("00") + ":" + sec.ToString("00");
            if (sec == 59)
            {
                min++;
                sec = 0;
            }
            else
            {
                sec++;
            }
            time_label.Text = time;
        }

        //Match result and feedback to status box
        public void MatchResult()
        {
            status_TextBox.Text += "===== MATCH STATS =====\n";
            if (t1_score == t2_score)
            {
                status_TextBox.Text += "Game is drawn.\n";
            }
            if (t1_score > t2_score)
            {
                status_TextBox.Text += "WINNER is " + team1 + "\n";
            }
            if (t1_score < t2_score)
            {
                status_TextBox.Text += "WINNER is " + team2 + "\n";
            }

            //Team 1 match stats
            status_TextBox.Text += "=======================\n";
            status_TextBox.Text += team1 + " stats: \n";
            status_TextBox.Text += "Tries: " + t1_try_num.ToString() + "\n";
            status_TextBox.Text += "Conversions: " + t1_conversion_num.ToString() + "\n";
            status_TextBox.Text += "Drop-Kicks: " + t1_dropkick_num.ToString() + "\n";
            status_TextBox.Text += "Penalties: " + t1_penalty_num.ToString() + "\n";
            //Team 2 match stats
            status_TextBox.Text += "=======================\n";
            status_TextBox.Text += team2 + " stats: \n";
            status_TextBox.Text += "Tries: " + t2_try_num.ToString() + "\n";
            status_TextBox.Text += "Conversions: " + t2_conversion_num.ToString() + "\n";
            status_TextBox.Text += "Drop-Kicks: " + t2_dropkick_num.ToString() + "\n";
            status_TextBox.Text += "Penalties: " + t2_penalty_num.ToString() + "\n";
        }

        /*-------------------CONTROLS---------------------*/
        //-------------Country Selection------------------
        private void t1_aus_CheckedChanged(object sender, EventArgs e)
        {
            t1_flag.Load("australia.png");
            team1 = "AUS";
            SameTeam();
        }

        private void t1_eng_CheckedChanged(object sender, EventArgs e)
        {
            t1_flag.Load("england.png");
            team1 = "ENG";
            SameTeam();
        }

        private void t1_nz_CheckedChanged(object sender, EventArgs e)
        {
            t1_flag.Load("new_zealand.png");
            team1 = "NZL";
            SameTeam();
        }

        private void t2_aus_CheckedChanged(object sender, EventArgs e)
        {
            t2_flag.Load("australia.png");
            team2 = "AUS";
            SameTeam();
        }

        private void t2_eng_CheckedChanged(object sender, EventArgs e)
        {
            t2_flag.Load("england.png");
            team2 = "ENG";
            SameTeam();
        }

        private void t2_nz_CheckedChanged(object sender, EventArgs e)
        {
            t2_flag.Load("new_zealand.png");
            team2 = "NZL";
            SameTeam();
        }


        //--------------------Timer-----------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer();
        }

        //-----------------Scoring buttons----------------
        private void t1_try_Click(object sender, EventArgs e)
        {
            Team1Try();
            
        }

        private void t1_conversion_Click(object sender, EventArgs e)
        {
            Team1Conversion();
        }

        private void t1_penalty_Click(object sender, EventArgs e)
        {
            Team1Penalty();
        }

        private void t1_dropkick_Click(object sender, EventArgs e)
        {
            Team1DropKick();
        }

        private void t2_try_Click(object sender, EventArgs e)
        {
            Team2Try();
        }

        private void t2_conversion_Click(object sender, EventArgs e)
        {
            Team2Conversion();
        }

        private void t2_penalty_Click(object sender, EventArgs e)
        {
            Team2Penalty();
        }

        private void t2_dropkick_Click(object sender, EventArgs e)
        {
            Team2DropKick();
        }
        
        //-------------Other Button Features--------------
        private void start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void t1_player_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            t1_no_player_label.Visible = false;
            if (pause.Text == "Pause")
            {
                t1_score_groupBox.Enabled = true;   
            }  
        }

        private void t2_player_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            t2_no_player_label.Visible = false;
            if (pause.Text == "Pause")
            {
                t2_score_groupBox.Enabled = true;
            } 
        }
    }
}
