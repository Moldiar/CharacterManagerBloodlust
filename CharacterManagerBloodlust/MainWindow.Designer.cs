﻿namespace CharacterManagerBloodlust
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.ScenarioBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CharacterList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Character = new System.Windows.Forms.TabPage();
            this.InventoryBox = new System.Windows.Forms.TabControl();
            this.BaseInfo = new System.Windows.Forms.TabPage();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.Scenario = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.OrderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Journal = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.JournalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Character.SuspendLayout();
            this.InventoryBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Scenario.SuspendLayout();
            this.Journal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scenario";
            // 
            // ScenarioBox
            // 
            this.ScenarioBox.FormattingEnabled = true;
            this.ScenarioBox.Location = new System.Drawing.Point(67, 6);
            this.ScenarioBox.Name = "ScenarioBox";
            this.ScenarioBox.Size = new System.Drawing.Size(186, 21);
            this.ScenarioBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Scenario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterList
            // 
            this.CharacterList.FormattingEnabled = true;
            this.CharacterList.Location = new System.Drawing.Point(12, 64);
            this.CharacterList.Name = "CharacterList";
            this.CharacterList.Size = new System.Drawing.Size(123, 82);
            this.CharacterList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Character List";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Character);
            this.tabControl1.Controls.Add(this.Scenario);
            this.tabControl1.Controls.Add(this.Journal);
            this.tabControl1.Location = new System.Drawing.Point(141, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 253);
            this.tabControl1.TabIndex = 5;
            // 
            // Character
            // 
            this.Character.Controls.Add(this.InventoryBox);
            this.Character.Location = new System.Drawing.Point(4, 22);
            this.Character.Name = "Character";
            this.Character.Padding = new System.Windows.Forms.Padding(3);
            this.Character.Size = new System.Drawing.Size(390, 227);
            this.Character.TabIndex = 0;
            this.Character.Text = "Character";
            this.Character.UseVisualStyleBackColor = true;
            // 
            // InventoryBox
            // 
            this.InventoryBox.Controls.Add(this.BaseInfo);
            this.InventoryBox.Controls.Add(this.Statistics);
            this.InventoryBox.Controls.Add(this.tabPage1);
            this.InventoryBox.Controls.Add(this.tabPage2);
            this.InventoryBox.Location = new System.Drawing.Point(0, 0);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.SelectedIndex = 0;
            this.InventoryBox.Size = new System.Drawing.Size(390, 227);
            this.InventoryBox.TabIndex = 0;
            // 
            // BaseInfo
            // 
            this.BaseInfo.Location = new System.Drawing.Point(4, 22);
            this.BaseInfo.Name = "BaseInfo";
            this.BaseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.BaseInfo.Size = new System.Drawing.Size(382, 201);
            this.BaseInfo.TabIndex = 0;
            this.BaseInfo.Text = "Basic Information";
            this.BaseInfo.UseVisualStyleBackColor = true;
            // 
            // Statistics
            // 
            this.Statistics.Location = new System.Drawing.Point(4, 22);
            this.Statistics.Name = "Statistics";
            this.Statistics.Padding = new System.Windows.Forms.Padding(3);
            this.Statistics.Size = new System.Drawing.Size(382, 201);
            this.Statistics.TabIndex = 1;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 201);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 201);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NotesBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 201);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(0, 0);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(382, 201);
            this.NotesBox.TabIndex = 1;
            this.NotesBox.Text = "";
            // 
            // Scenario
            // 
            this.Scenario.Controls.Add(this.listView2);
            this.Scenario.Location = new System.Drawing.Point(4, 22);
            this.Scenario.Name = "Scenario";
            this.Scenario.Padding = new System.Windows.Forms.Padding(3);
            this.Scenario.Size = new System.Drawing.Size(390, 227);
            this.Scenario.TabIndex = 1;
            this.Scenario.Text = "Scenario";
            this.Scenario.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderNumber,
            this.Content});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(384, 221);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // OrderNumber
            // 
            this.OrderNumber.Text = "#";
            this.OrderNumber.Width = 31;
            // 
            // Content
            // 
            this.Content.Text = "Description";
            this.Content.Width = 348;
            // 
            // Journal
            // 
            this.Journal.Controls.Add(this.listView1);
            this.Journal.Location = new System.Drawing.Point(4, 22);
            this.Journal.Name = "Journal";
            this.Journal.Size = new System.Drawing.Size(390, 227);
            this.Journal.TabIndex = 2;
            this.Journal.Text = "Journal";
            this.Journal.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JournalName,
            this.Description,
            this.Date,
            this.Importance});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 227);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // JournalName
            // 
            this.JournalName.Text = "Name";
            this.JournalName.Width = 74;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 178;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 67;
            // 
            // Importance
            // 
            this.Importance.Text = "Importance";
            this.Importance.Width = 66;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Logged In as:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UsernameLabel.Location = new System.Drawing.Point(450, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 298);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CharacterList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScenarioBox);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Character Manager - Bloodlust";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.Character.ResumeLayout(false);
            this.InventoryBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.Scenario.ResumeLayout(false);
            this.Journal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ScenarioBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox CharacterList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Character;
        private System.Windows.Forms.TabPage Scenario;
        private System.Windows.Forms.TabPage Journal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader JournalName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Importance;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader OrderNumber;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.TabControl InventoryBox;
        private System.Windows.Forms.TabPage BaseInfo;
        private System.Windows.Forms.TabPage Statistics;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UsernameLabel;
    }
}
