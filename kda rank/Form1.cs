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
    public partial class Form1 : Form
    {
        stats statistics;
        Match curMatch;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader file = File.OpenText("stats.json");
            //JsonTextReader reader = new JsonTextReader(file);
            Match o1 = JsonConvert.DeserializeObject<Match>(file.ReadToEnd());
            killBox.Text = o1.Kills.ToString();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm AddForm = new addForm();
            AddForm.Show();
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KillBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}