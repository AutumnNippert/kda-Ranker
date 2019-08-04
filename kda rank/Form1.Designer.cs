namespace kda_rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killBox = new System.Windows.Forms.TextBox();
            this.deathBox = new System.Windows.Forms.TextBox();
            this.assistBox = new System.Windows.Forms.TextBox();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.killsLabel = new System.Windows.Forms.Label();
            this.deathsLabel = new System.Windows.Forms.Label();
            this.assistsLabel = new System.Windows.Forms.Label();
            this.gamemodeComboBox = new System.Windows.Forms.ComboBox();
            this.gamemodeLabel = new System.Windows.Forms.Label();
            this.dufficultyLabel = new System.Windows.Forms.Label();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // killBox
            // 
            this.killBox.Location = new System.Drawing.Point(70, 31);
            this.killBox.Name = "killBox";
            this.killBox.Size = new System.Drawing.Size(100, 20);
            this.killBox.TabIndex = 1;
            this.killBox.Text = "0";
            this.killBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.killBox.TextChanged += new System.EventHandler(this.KillBox_TextChanged);
            // 
            // deathBox
            // 
            this.deathBox.Location = new System.Drawing.Point(70, 68);
            this.deathBox.Name = "deathBox";
            this.deathBox.Size = new System.Drawing.Size(100, 20);
            this.deathBox.TabIndex = 2;
            this.deathBox.Text = "0";
            this.deathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deathBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // assistBox
            // 
            this.assistBox.Location = new System.Drawing.Point(70, 103);
            this.assistBox.Name = "assistBox";
            this.assistBox.Size = new System.Drawing.Size(100, 20);
            this.assistBox.TabIndex = 3;
            this.assistBox.Text = "0";
            this.assistBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.assistBox.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Items.AddRange(new object[] {
            "Recruit",
            "Regular",
            "Hard",
            "Veteran"});
            this.difficultyComboBox.Location = new System.Drawing.Point(292, 65);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(200, 21);
            this.difficultyComboBox.TabIndex = 4;
            this.difficultyComboBox.Text = "Regular";
            this.difficultyComboBox.SelectedIndexChanged += new System.EventHandler(this.DifficultyComboBox_SelectedIndexChanged);
            // 
            // killsLabel
            // 
            this.killsLabel.AutoSize = true;
            this.killsLabel.Location = new System.Drawing.Point(12, 34);
            this.killsLabel.Name = "killsLabel";
            this.killsLabel.Size = new System.Drawing.Size(25, 13);
            this.killsLabel.TabIndex = 5;
            this.killsLabel.Text = "Kills";
            // 
            // deathsLabel
            // 
            this.deathsLabel.AutoSize = true;
            this.deathsLabel.Location = new System.Drawing.Point(10, 68);
            this.deathsLabel.Name = "deathsLabel";
            this.deathsLabel.Size = new System.Drawing.Size(41, 13);
            this.deathsLabel.TabIndex = 6;
            this.deathsLabel.Text = "Deaths";
            // 
            // assistsLabel
            // 
            this.assistsLabel.AutoSize = true;
            this.assistsLabel.Location = new System.Drawing.Point(12, 106);
            this.assistsLabel.Name = "assistsLabel";
            this.assistsLabel.Size = new System.Drawing.Size(39, 13);
            this.assistsLabel.TabIndex = 7;
            this.assistsLabel.Text = "Assists";
            // 
            // gamemodeComboBox
            // 
            this.gamemodeComboBox.FormattingEnabled = true;
            this.gamemodeComboBox.Items.AddRange(new object[] {
            "Team Deathmatch",
            "Free For All"});
            this.gamemodeComboBox.Location = new System.Drawing.Point(292, 30);
            this.gamemodeComboBox.Name = "gamemodeComboBox";
            this.gamemodeComboBox.Size = new System.Drawing.Size(200, 21);
            this.gamemodeComboBox.TabIndex = 10;
            this.gamemodeComboBox.Text = "Team Deathmatch";
            // 
            // gamemodeLabel
            // 
            this.gamemodeLabel.AutoSize = true;
            this.gamemodeLabel.Location = new System.Drawing.Point(225, 34);
            this.gamemodeLabel.Name = "gamemodeLabel";
            this.gamemodeLabel.Size = new System.Drawing.Size(61, 13);
            this.gamemodeLabel.TabIndex = 11;
            this.gamemodeLabel.Text = "Gamemode";
            this.gamemodeLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // dufficultyLabel
            // 
            this.dufficultyLabel.AutoSize = true;
            this.dufficultyLabel.Location = new System.Drawing.Point(225, 68);
            this.dufficultyLabel.Name = "dufficultyLabel";
            this.dufficultyLabel.Size = new System.Drawing.Size(47, 13);
            this.dufficultyLabel.TabIndex = 12;
            this.dufficultyLabel.Text = "Difficulty";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.resetToolStripMenuItem.Text = "reset";
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(70, 169);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(100, 20);
            this.scoreBox.TabIndex = 13;
            this.scoreBox.Text = "0";
            this.scoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(16, 172);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 14;
            this.scoreLabel.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.dufficultyLabel);
            this.Controls.Add(this.gamemodeLabel);
            this.Controls.Add(this.gamemodeComboBox);
            this.Controls.Add(this.assistsLabel);
            this.Controls.Add(this.deathsLabel);
            this.Controls.Add(this.killsLabel);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.assistBox);
            this.Controls.Add(this.deathBox);
            this.Controls.Add(this.killBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KDA Ranker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox killBox;
        private System.Windows.Forms.TextBox deathBox;
        private System.Windows.Forms.TextBox assistBox;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.Label killsLabel;
        private System.Windows.Forms.Label deathsLabel;
        private System.Windows.Forms.Label assistsLabel;
        private System.Windows.Forms.ComboBox gamemodeComboBox;
        private System.Windows.Forms.Label gamemodeLabel;
        private System.Windows.Forms.Label dufficultyLabel;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.Label scoreLabel;
    }
}

