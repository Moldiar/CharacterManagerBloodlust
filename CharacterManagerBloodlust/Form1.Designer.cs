namespace CharacterManagerBloodlust
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Character = new System.Windows.Forms.TabPage();
            this.Scenario = new System.Windows.Forms.TabPage();
            this.Journal = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.JournalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.OrderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 1;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 82);
            this.listBox1.TabIndex = 3;
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
            this.Character.Location = new System.Drawing.Point(4, 22);
            this.Character.Name = "Character";
            this.Character.Padding = new System.Windows.Forms.Padding(3);
            this.Character.Size = new System.Drawing.Size(390, 227);
            this.Character.TabIndex = 0;
            this.Character.Text = "Character";
            this.Character.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 298);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Character Manager - Bloodlust";
            this.tabControl1.ResumeLayout(false);
            this.Scenario.ResumeLayout(false);
            this.Journal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}

