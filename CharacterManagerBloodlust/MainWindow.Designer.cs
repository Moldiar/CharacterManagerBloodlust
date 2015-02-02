namespace CharacterManagerBloodlust
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
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.CharacterTab = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.BaseInfo = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.ZodiacField = new System.Windows.Forms.TextBox();
            this.BloodlineField = new System.Windows.Forms.TextBox();
            this.PathField = new System.Windows.Forms.TextBox();
            this.GodField = new System.Windows.Forms.TextBox();
            this.SubraceField = new System.Windows.Forms.TextBox();
            this.RaceField = new System.Windows.Forms.TextBox();
            this.SexField = new System.Windows.Forms.TextBox();
            this.AlignmentField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InventoryBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.ScenarioTab = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FlowView = new System.Windows.Forms.ListView();
            this.OrderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JournalTab = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.JournalView = new System.Windows.Forms.ListView();
            this.JournalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.MainTabs.SuspendLayout();
            this.CharacterTab.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.BaseInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ScenarioTab.SuspendLayout();
            this.JournalTab.SuspendLayout();
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
            this.ScenarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScenarioBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScenarioBox.FormattingEnabled = true;
            this.ScenarioBox.Location = new System.Drawing.Point(67, 6);
            this.ScenarioBox.Name = "ScenarioBox";
            this.ScenarioBox.Size = new System.Drawing.Size(165, 21);
            this.ScenarioBox.TabIndex = 1;
            this.ScenarioBox.TabStop = false;
            this.ScenarioBox.SelectionChangeCommitted += new System.EventHandler(this.ScenarioBoxSelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reload Scenarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ScenarioRldBtn);
            // 
            // CharacterList
            // 
            this.CharacterList.FormattingEnabled = true;
            this.CharacterList.Location = new System.Drawing.Point(12, 55);
            this.CharacterList.Name = "CharacterList";
            this.CharacterList.Size = new System.Drawing.Size(123, 82);
            this.CharacterList.TabIndex = 3;
            this.CharacterList.Click += new System.EventHandler(this.CharListClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Character List";
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.CharacterTab);
            this.MainTabs.Controls.Add(this.ScenarioTab);
            this.MainTabs.Controls.Add(this.JournalTab);
            this.MainTabs.Location = new System.Drawing.Point(141, 33);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.Padding = new System.Drawing.Point(42, 3);
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(398, 253);
            this.MainTabs.TabIndex = 5;
            // 
            // CharacterTab
            // 
            this.CharacterTab.Controls.Add(this.TabControl);
            this.CharacterTab.Location = new System.Drawing.Point(4, 22);
            this.CharacterTab.Name = "CharacterTab";
            this.CharacterTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterTab.Size = new System.Drawing.Size(390, 227);
            this.CharacterTab.TabIndex = 0;
            this.CharacterTab.Text = "CharacterTab";
            this.CharacterTab.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.BaseInfo);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(38, 3);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(390, 227);
            this.TabControl.TabIndex = 0;
            // 
            // BaseInfo
            // 
            this.BaseInfo.Controls.Add(this.button9);
            this.BaseInfo.Controls.Add(this.ZodiacField);
            this.BaseInfo.Controls.Add(this.BloodlineField);
            this.BaseInfo.Controls.Add(this.PathField);
            this.BaseInfo.Controls.Add(this.GodField);
            this.BaseInfo.Controls.Add(this.SubraceField);
            this.BaseInfo.Controls.Add(this.RaceField);
            this.BaseInfo.Controls.Add(this.SexField);
            this.BaseInfo.Controls.Add(this.AlignmentField);
            this.BaseInfo.Controls.Add(this.SurnameField);
            this.BaseInfo.Controls.Add(this.NameField);
            this.BaseInfo.Controls.Add(this.label13);
            this.BaseInfo.Controls.Add(this.label12);
            this.BaseInfo.Controls.Add(this.label11);
            this.BaseInfo.Controls.Add(this.label10);
            this.BaseInfo.Controls.Add(this.label9);
            this.BaseInfo.Controls.Add(this.label8);
            this.BaseInfo.Controls.Add(this.label7);
            this.BaseInfo.Controls.Add(this.label6);
            this.BaseInfo.Controls.Add(this.label5);
            this.BaseInfo.Controls.Add(this.label4);
            this.BaseInfo.Location = new System.Drawing.Point(4, 22);
            this.BaseInfo.Name = "BaseInfo";
            this.BaseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.BaseInfo.Size = new System.Drawing.Size(382, 201);
            this.BaseInfo.TabIndex = 0;
            this.BaseInfo.Text = "Basic Information";
            this.BaseInfo.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(287, 162);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "Update Hero";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ZodiacField
            // 
            this.ZodiacField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZodiacField.Location = new System.Drawing.Point(287, 58);
            this.ZodiacField.Name = "ZodiacField";
            this.ZodiacField.Size = new System.Drawing.Size(89, 20);
            this.ZodiacField.TabIndex = 20;
            // 
            // BloodlineField
            // 
            this.BloodlineField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BloodlineField.Location = new System.Drawing.Point(287, 32);
            this.BloodlineField.Name = "BloodlineField";
            this.BloodlineField.Size = new System.Drawing.Size(89, 20);
            this.BloodlineField.TabIndex = 19;
            // 
            // PathField
            // 
            this.PathField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathField.Location = new System.Drawing.Point(287, 6);
            this.PathField.Name = "PathField";
            this.PathField.Size = new System.Drawing.Size(89, 20);
            this.PathField.TabIndex = 18;
            // 
            // GodField
            // 
            this.GodField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GodField.Location = new System.Drawing.Point(101, 162);
            this.GodField.Name = "GodField";
            this.GodField.Size = new System.Drawing.Size(89, 20);
            this.GodField.TabIndex = 17;
            // 
            // SubraceField
            // 
            this.SubraceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubraceField.Location = new System.Drawing.Point(101, 136);
            this.SubraceField.Name = "SubraceField";
            this.SubraceField.Size = new System.Drawing.Size(89, 20);
            this.SubraceField.TabIndex = 16;
            // 
            // RaceField
            // 
            this.RaceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaceField.Location = new System.Drawing.Point(101, 110);
            this.RaceField.Name = "RaceField";
            this.RaceField.Size = new System.Drawing.Size(89, 20);
            this.RaceField.TabIndex = 15;
            // 
            // SexField
            // 
            this.SexField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SexField.Location = new System.Drawing.Point(101, 58);
            this.SexField.Name = "SexField";
            this.SexField.Size = new System.Drawing.Size(89, 20);
            this.SexField.TabIndex = 14;
            // 
            // AlignmentField
            // 
            this.AlignmentField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlignmentField.Location = new System.Drawing.Point(101, 84);
            this.AlignmentField.Name = "AlignmentField";
            this.AlignmentField.Size = new System.Drawing.Size(89, 20);
            this.AlignmentField.TabIndex = 13;
            // 
            // SurnameField
            // 
            this.SurnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameField.Location = new System.Drawing.Point(101, 32);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(89, 20);
            this.SurnameField.TabIndex = 11;
            // 
            // NameField
            // 
            this.NameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameField.Location = new System.Drawing.Point(101, 6);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(89, 20);
            this.NameField.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Hero Race";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Hero Subrace";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Hero Zodiac";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Hero God";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Hero Bloodline";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hero Path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hero Alignment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hero Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hero Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hero Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InventoryBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 201);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InventoryBox
            // 
            this.InventoryBox.Location = new System.Drawing.Point(0, 0);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(382, 201);
            this.InventoryBox.TabIndex = 0;
            this.InventoryBox.Text = "";
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
            // ScenarioTab
            // 
            this.ScenarioTab.Controls.Add(this.button7);
            this.ScenarioTab.Controls.Add(this.button5);
            this.ScenarioTab.Controls.Add(this.FlowView);
            this.ScenarioTab.Location = new System.Drawing.Point(4, 22);
            this.ScenarioTab.Name = "ScenarioTab";
            this.ScenarioTab.Padding = new System.Windows.Forms.Padding(3);
            this.ScenarioTab.Size = new System.Drawing.Size(390, 227);
            this.ScenarioTab.TabIndex = 1;
            this.ScenarioTab.Text = "Scenario";
            this.ScenarioTab.UseVisualStyleBackColor = true;
            this.ScenarioTab.Enter += new System.EventHandler(this.button7_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Reload Entries";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "New Scenario Entry";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FlowView
            // 
            this.FlowView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderNumber,
            this.Content});
            this.FlowView.Location = new System.Drawing.Point(3, 3);
            this.FlowView.Name = "FlowView";
            this.FlowView.Size = new System.Drawing.Size(384, 201);
            this.FlowView.TabIndex = 1;
            this.FlowView.UseCompatibleStateImageBehavior = false;
            this.FlowView.View = System.Windows.Forms.View.Details;
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
            // JournalTab
            // 
            this.JournalTab.BackColor = System.Drawing.Color.Transparent;
            this.JournalTab.Controls.Add(this.button8);
            this.JournalTab.Controls.Add(this.button6);
            this.JournalTab.Controls.Add(this.JournalView);
            this.JournalTab.Location = new System.Drawing.Point(4, 22);
            this.JournalTab.Name = "JournalTab";
            this.JournalTab.Size = new System.Drawing.Size(390, 227);
            this.JournalTab.TabIndex = 2;
            this.JournalTab.Text = "Journal";
            this.JournalTab.Enter += new System.EventHandler(this.button8_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Reload Journal Entries";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(268, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Add Entry";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // JournalView
            // 
            this.JournalView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JournalName,
            this.Description,
            this.Date,
            this.Importance});
            this.JournalView.Location = new System.Drawing.Point(0, 0);
            this.JournalView.Name = "JournalView";
            this.JournalView.Size = new System.Drawing.Size(390, 204);
            this.JournalView.TabIndex = 0;
            this.JournalView.UseCompatibleStateImageBehavior = false;
            this.JournalView.View = System.Windows.Forms.View.Details;
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
            this.button2.Location = new System.Drawing.Point(12, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Load Characters";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Logged In as:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UsernameLabel.Location = new System.Drawing.Point(484, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "New Scenario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "New Hero";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(15, 263);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(119, 23);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 230);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(122, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Invite Player";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 298);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CharacterList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScenarioBox);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Character Manager - Bloodlust";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.LoadHeroes);
            this.MainTabs.ResumeLayout(false);
            this.CharacterTab.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.BaseInfo.ResumeLayout(false);
            this.BaseInfo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ScenarioTab.ResumeLayout(false);
            this.JournalTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox CharacterList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage CharacterTab;
        private System.Windows.Forms.ListView JournalView;
        private System.Windows.Forms.ColumnHeader JournalName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Importance;
        private System.Windows.Forms.ListView FlowView;
        private System.Windows.Forms.ColumnHeader OrderNumber;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage BaseInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox InventoryBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label UsernameLabel;
        public System.Windows.Forms.ComboBox ScenarioBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SubraceField;
        private System.Windows.Forms.TextBox RaceField;
        private System.Windows.Forms.TextBox SexField;
        private System.Windows.Forms.TextBox AlignmentField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox ZodiacField;
        private System.Windows.Forms.TextBox BloodlineField;
        private System.Windows.Forms.TextBox PathField;
        private System.Windows.Forms.TextBox GodField;
        public System.Windows.Forms.TabPage ScenarioTab;
        public System.Windows.Forms.TabPage JournalTab;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button button10;
    }
}

