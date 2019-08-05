namespace kda_rank
{
    partial class addForm
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
            this.killBox = new System.Windows.Forms.TextBox();
            this.killsLabel = new System.Windows.Forms.Label();
            this.deathsLabel = new System.Windows.Forms.Label();
            this.deathBox = new System.Windows.Forms.TextBox();
            this.assistsLabel = new System.Windows.Forms.Label();
            this.assistBox = new System.Windows.Forms.TextBox();
            this.gamemodeLabel = new System.Windows.Forms.Label();
            this.gamemodeComboBox = new System.Windows.Forms.ComboBox();
            this.dufficultyLabel = new System.Windows.Forms.Label();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // killBox
            // 
            this.killBox.Location = new System.Drawing.Point(73, 25);
            this.killBox.Name = "killBox";
            this.killBox.Size = new System.Drawing.Size(100, 20);
            this.killBox.TabIndex = 2;
            this.killBox.Text = "0";
            this.killBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // killsLabel
            // 
            this.killsLabel.AutoSize = true;
            this.killsLabel.Location = new System.Drawing.Point(10, 28);
            this.killsLabel.Name = "killsLabel";
            this.killsLabel.Size = new System.Drawing.Size(25, 13);
            this.killsLabel.TabIndex = 6;
            this.killsLabel.Text = "Kills";
            // 
            // deathsLabel
            // 
            this.deathsLabel.AutoSize = true;
            this.deathsLabel.Location = new System.Drawing.Point(10, 68);
            this.deathsLabel.Name = "deathsLabel";
            this.deathsLabel.Size = new System.Drawing.Size(41, 13);
            this.deathsLabel.TabIndex = 7;
            this.deathsLabel.Text = "Deaths";
            // 
            // deathBox
            // 
            this.deathBox.Location = new System.Drawing.Point(73, 65);
            this.deathBox.Name = "deathBox";
            this.deathBox.Size = new System.Drawing.Size(100, 20);
            this.deathBox.TabIndex = 8;
            this.deathBox.Text = "0";
            this.deathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // assistsLabel
            // 
            this.assistsLabel.AutoSize = true;
            this.assistsLabel.Location = new System.Drawing.Point(10, 109);
            this.assistsLabel.Name = "assistsLabel";
            this.assistsLabel.Size = new System.Drawing.Size(39, 13);
            this.assistsLabel.TabIndex = 9;
            this.assistsLabel.Text = "Assists";
            // 
            // assistBox
            // 
            this.assistBox.Location = new System.Drawing.Point(73, 106);
            this.assistBox.Name = "assistBox";
            this.assistBox.Size = new System.Drawing.Size(100, 20);
            this.assistBox.TabIndex = 10;
            this.assistBox.Text = "0";
            this.assistBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gamemodeLabel
            // 
            this.gamemodeLabel.AutoSize = true;
            this.gamemodeLabel.Location = new System.Drawing.Point(229, 28);
            this.gamemodeLabel.Name = "gamemodeLabel";
            this.gamemodeLabel.Size = new System.Drawing.Size(61, 13);
            this.gamemodeLabel.TabIndex = 12;
            this.gamemodeLabel.Text = "Gamemode";
            // 
            // gamemodeComboBox
            // 
            this.gamemodeComboBox.FormattingEnabled = true;
            this.gamemodeComboBox.Items.AddRange(new object[] {
            "Team Deathmatch",
            "Free For All"});
            this.gamemodeComboBox.Location = new System.Drawing.Point(310, 25);
            this.gamemodeComboBox.Name = "gamemodeComboBox";
            this.gamemodeComboBox.Size = new System.Drawing.Size(200, 21);
            this.gamemodeComboBox.TabIndex = 13;
            this.gamemodeComboBox.Text = "Team Deathmatch";
            // 
            // dufficultyLabel
            // 
            this.dufficultyLabel.AutoSize = true;
            this.dufficultyLabel.Location = new System.Drawing.Point(229, 68);
            this.dufficultyLabel.Name = "dufficultyLabel";
            this.dufficultyLabel.Size = new System.Drawing.Size(47, 13);
            this.dufficultyLabel.TabIndex = 14;
            this.dufficultyLabel.Text = "Difficulty";
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Items.AddRange(new object[] {
            "Recruit",
            "Regular",
            "Hard",
            "Veteran"});
            this.difficultyComboBox.Location = new System.Drawing.Point(310, 64);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(200, 21);
            this.difficultyComboBox.TabIndex = 15;
            this.difficultyComboBox.Text = "Regular";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(130, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(300, 180);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Game";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Call of Duty 4",
            "World at War",
            "Modern Warfare 2",
            "Black Ops",
            "Modern Warfare 3",
            "Black Ops II",
            "Ghosts",
            "Advanced Warfare",
            "Black Ops III",
            "Infinite Warfare",
            "World War II",
            "Black Ops IIII",
            "Modern Warfare"});
            this.comboBox1.Location = new System.Drawing.Point(310, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Black Ops 3";
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.dufficultyLabel);
            this.Controls.Add(this.gamemodeComboBox);
            this.Controls.Add(this.gamemodeLabel);
            this.Controls.Add(this.assistBox);
            this.Controls.Add(this.assistsLabel);
            this.Controls.Add(this.deathBox);
            this.Controls.Add(this.deathsLabel);
            this.Controls.Add(this.killsLabel);
            this.Controls.Add(this.killBox);
            this.Name = "addForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox killBox;
        private System.Windows.Forms.Label killsLabel;
        private System.Windows.Forms.Label deathsLabel;
        private System.Windows.Forms.TextBox deathBox;
        private System.Windows.Forms.Label assistsLabel;
        private System.Windows.Forms.TextBox assistBox;
        private System.Windows.Forms.Label gamemodeLabel;
        private System.Windows.Forms.ComboBox gamemodeComboBox;
        private System.Windows.Forms.Label dufficultyLabel;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}