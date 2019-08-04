﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kda_rank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not ready yet
            //will write to a file
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int kills;
            int deaths;
            int assists;
            int score = 0;
            string difficulty = difficultyComboBox.Text;
            try
            {
                kills = int.Parse(killBox.Text);
                deaths = int.Parse(deathBox.Text);
                assists = int.Parse(assistBox.Text);
                if (difficulty == "Recruit")
                {
                    score = (((kills * 100) + (assists * 50) - (deaths * 70)) * 7) / 10;
                }
                if (difficulty == "Regular")
                {
                    score = ((kills * 100) + (assists * 50) - (deaths * 70));
                }
                if (difficulty == "Hard")
                {
                    score = (((kills * 100) + (assists * 50) - (deaths * 70)) * 8) / 5;
                }
                if (difficulty == "Veteran")
                {
                    score = ((kills * 100) + (assists * 50) - (deaths * 70)) * 3;
                }
                rankLabel.Text = score.ToString();
            }
            catch
            {
                rankLabel.Text = "please enter in WHOLE NUMBERS";
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}