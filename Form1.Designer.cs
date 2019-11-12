namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Stat = new System.Windows.Forms.ToolStripMenuItem();
            this.TextEditor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.Stat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.toolStripMenuItem1,
            this.Save,
            this.toolStripMenuItem2,
            this.Exit});
            this.Menu.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(59, 25);
            this.Menu.Text = "Файл";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(155, 26);
            this.Open.Text = "Открыть";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(155, 26);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(155, 26);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Stat
            // 
            this.Stat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stat.ForeColor = System.Drawing.Color.Coral;
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(110, 27);
            this.Stat.Text = "Статистика";
            this.Stat.Click += new System.EventHandler(this.Stat_Click);
            // 
            // TextEditor
            // 
            this.TextEditor.Location = new System.Drawing.Point(12, 32);
            this.TextEditor.Multiline = true;
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextEditor.Size = new System.Drawing.Size(1027, 488);
            this.TextEditor.TabIndex = 1;
            this.TextEditor.TextChanged += new System.EventHandler(this.TextEditor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 532);
            this.Controls.Add(this.TextEditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.TextBox TextEditor;
        private System.Windows.Forms.ToolStripMenuItem Stat;
    }
}

