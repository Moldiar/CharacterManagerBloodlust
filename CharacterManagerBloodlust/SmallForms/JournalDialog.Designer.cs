namespace CharacterManagerBloodlust.SmallForms
{
    partial class JournalDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.JournalDescBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.JournalNameBox = new System.Windows.Forms.TextBox();
            this.ImportanceBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Journal Entry Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Journal Entry Name:";
            // 
            // JournalDescBox
            // 
            this.JournalDescBox.Location = new System.Drawing.Point(12, 51);
            this.JournalDescBox.Multiline = true;
            this.JournalDescBox.Name = "JournalDescBox";
            this.JournalDescBox.Size = new System.Drawing.Size(260, 100);
            this.JournalDescBox.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(12, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(137, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // JournalNameBox
            // 
            this.JournalNameBox.Location = new System.Drawing.Point(120, 12);
            this.JournalNameBox.Name = "JournalNameBox";
            this.JournalNameBox.Size = new System.Drawing.Size(152, 20);
            this.JournalNameBox.TabIndex = 16;
            // 
            // ImportanceBox
            // 
            this.ImportanceBox.FormattingEnabled = true;
            this.ImportanceBox.Items.AddRange(new object[] {
            "Unimportant",
            "Trivial",
            "Neutral",
            "Important",
            "Critical"});
            this.ImportanceBox.Location = new System.Drawing.Point(88, 157);
            this.ImportanceBox.Name = "ImportanceBox";
            this.ImportanceBox.Size = new System.Drawing.Size(184, 21);
            this.ImportanceBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Importance";
            // 
            // JournalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImportanceBox);
            this.Controls.Add(this.JournalNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JournalDescBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "JournalDialog";
            this.Text = "JournalDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox JournalDescBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox JournalNameBox;
        public System.Windows.Forms.ComboBox ImportanceBox;
        private System.Windows.Forms.Label label3;
    }
}