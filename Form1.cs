using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        

        private void Open_Click(object sender, EventArgs e)
        {
            var open_dialog = new OpenFileDialog();
            open_dialog.Title = "Выбор файла";
            open_dialog.Filter = "Текстовый файл*|*.txt|Все файлы|*.*";
            var result = open_dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;
            var file_name = open_dialog.FileName;
            if (!File.Exists(file_name))
                return;
            var file_text = File.ReadAllText(file_name);
            TextEditor.Text = file_text;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var save_dialog = new SaveFileDialog();
            save_dialog.Title = "Выбор файла";
            save_dialog.Filter = "Текстовый файл*|*.txt|Все файлы|*.*";
            var result = save_dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;
            var file_name = save_dialog.FileName;
            File.WriteAllText(file_name, TextEditor.Text);

        }

        private void Menu_Click(object sender, EventArgs e)
        {



        }
        

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        private void Stat_Click(object sender, EventArgs e)
        {
            var stat_form = new StatisticForm(TextEditor.Text);
            stat_form.Show();
        }
    }
}
