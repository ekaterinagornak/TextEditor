using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class StatisticForm : Form
    {
        public StatisticForm(string Text)
        {
            InitializeComponent();
            var text_length = Text.Length;
            var words = Text.Split(' ');
            var words_count = words.Length;

            TextLengthLabel.Text = text_length.ToString();
            WordsCountLabel.Text = words_count.ToString();
            
        }

    }
}
