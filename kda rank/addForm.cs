using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kda_rank.Classes;
using Newtonsoft.Json;

namespace kda_rank
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        public void calcScore()
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

            }
            catch
            {

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
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
                //if (difficulty == "Recruit")
                //{
                //    score = (((kills * 100) + (assists * 50) - (deaths * 70)) * 7) / 10;
                //}
                //if (difficulty == "Regular")
                //{
                //    score = ((kills * 100) + (assists * 50) - (deaths * 70));
                //}
                //if (difficulty == "Hard")
                //{
                //    score = (((kills * 100) + (assists * 50) - (deaths * 70)) * 8) / 5;
                //}
                //if (difficulty == "Veteran")
                //{
                //    score = ((kills * 100) + (assists * 50) - (deaths * 70)) * 3;
                //}
                Match match = new Match()
                {
                    Kills = kills,
                    Deaths = deaths,
                    Assists = assists,
                    DateTime = DateTime.Now.ToString("MM/dd/yyyy")
                    //Difficulty = difficulty
                };
                String strResultJSON = JsonConvert.SerializeObject(match);
                File.WriteAllText(@"stats.json", strResultJSON);
                this.Close();
            }
            catch
            {

            }
        }
    }
}
