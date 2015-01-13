namespace CharacterManagerBloodlust.SmallForms
{
    partial class FlowDialog
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EntryDescBox = new System.Windows.Forms.TextBox();
            this.EntryNumberBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EntryNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(12, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(137, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Entry Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Entry Nr:";
            // 
            // EntryDescBox
            // 
            this.EntryDescBox.Location = new System.Drawing.Point(12, 51);
            this.EntryDescBox.Multiline = true;
            this.EntryDescBox.Name = "EntryDescBox";
            this.EntryDescBox.Size = new System.Drawing.Size(260, 100);
            this.EntryDescBox.TabIndex = 8;
            // 
            // EntryNumberBox
            // 
            this.EntryNumberBox.Location = new System.Drawing.Point(67, 12);
            this.EntryNumberBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EntryNumberBox.Name = "EntryNumberBox";
            this.EntryNumberBox.Size = new System.Drawing.Size(46, 20);
            this.EntryNumberBox.TabIndex = 11;
            this.EntryNumberBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // FlowDialog
            // 
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.EntryNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntryDescBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FlowDialog";
            ((System.ComponentModel.ISupportInitialize)(this.EntryNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox EntryDescBox;
        public System.Windows.Forms.NumericUpDown EntryNumberBox;

    }
}