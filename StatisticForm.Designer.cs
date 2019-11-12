namespace TextEditor
{
    partial class StatisticForm
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
            this.Length = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.TextLengthLabel = new System.Windows.Forms.Label();
            this.WordsCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.BackColor = System.Drawing.SystemColors.Info;
            this.Length.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Length.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Length.Location = new System.Drawing.Point(12, 34);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(124, 23);
            this.Length.TabIndex = 0;
            this.Length.Text = "Длина текста:";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.BackColor = System.Drawing.SystemColors.Info;
            this.Count.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Count.Location = new System.Drawing.Point(30, 83);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(106, 23);
            this.Count.TabIndex = 1;
            this.Count.Text = "Число слов:";
            // 
            // TextLengthLabel
            // 
            this.TextLengthLabel.AutoSize = true;
            this.TextLengthLabel.BackColor = System.Drawing.SystemColors.Info;
            this.TextLengthLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLengthLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextLengthLabel.Location = new System.Drawing.Point(146, 34);
            this.TextLengthLabel.Name = "TextLengthLabel";
            this.TextLengthLabel.Size = new System.Drawing.Size(56, 23);
            this.TextLengthLabel.TabIndex = 2;
            this.TextLengthLabel.Text = "label2";
            // 
            // WordsCountLabel
            // 
            this.WordsCountLabel.AutoSize = true;
            this.WordsCountLabel.BackColor = System.Drawing.SystemColors.Info;
            this.WordsCountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsCountLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.WordsCountLabel.Location = new System.Drawing.Point(146, 83);
            this.WordsCountLabel.Name = "WordsCountLabel";
            this.WordsCountLabel.Size = new System.Drawing.Size(56, 23);
            this.WordsCountLabel.TabIndex = 3;
            this.WordsCountLabel.Text = "label3";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(263, 151);
            this.Controls.Add(this.WordsCountLabel);
            this.Controls.Add(this.TextLengthLabel);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Length);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label TextLengthLabel;
        private System.Windows.Forms.Label WordsCountLabel;
    }
}