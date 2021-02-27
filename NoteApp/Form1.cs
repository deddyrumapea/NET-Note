using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxFontSize.SelectedIndex = 4;
            comboBoxTextAlignment.SelectedIndex = 0;
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBoxNote.SelectionFont;
            Font newFont;

            if (oldFont.Bold) newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

            richTextBoxNote.SelectionFont = newFont;
            richTextBoxNote.Focus();
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBoxNote.SelectionFont;
            Font newFont;

            if (oldFont.Italic) newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            richTextBoxNote.SelectionFont = newFont;
            richTextBoxNote.Focus();
        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBoxNote.SelectionFont;
            Font newFont;

            if (oldFont.Underline) newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            richTextBoxNote.SelectionFont = newFont;
            richTextBoxNote.Focus();
        }

        private void buttonStrikeout_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBoxNote.SelectionFont;
            Font newFont;

            if (oldFont.Strikeout) newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);

            richTextBoxNote.SelectionFont = newFont;
            richTextBoxNote.Focus();
        }

        private void buttonIncreaseFontSize_Click(object sender, EventArgs e)
        {
            if(comboBoxFontSize.SelectedIndex < comboBoxFontSize.Items.Count - 1) comboBoxFontSize.SelectedIndex++;
        }

        private void buttonDecreaseFontSize_Click(object sender, EventArgs e)
        {
            if(comboBoxFontSize.SelectedIndex > 0) comboBoxFontSize.SelectedIndex--;
        }

        private void comboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            float newSize = float.Parse(comboBoxFontSize.Text);
            FontFamily currentFontFamily = richTextBoxNote.SelectionFont.FontFamily;
            Font newFont = new Font(currentFontFamily, newSize);

            richTextBoxNote.SelectionFont = newFont;
        }

        private void comboBoxTextAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTextAlignment.SelectedIndex)
            {
                case 0:
                    richTextBoxNote.SelectionAlignment = HorizontalAlignment.Left;
                    break;
                case 1:
                    richTextBoxNote.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case 2:
                    richTextBoxNote.SelectionAlignment = HorizontalAlignment.Right;
                    break;
                default:
                    // Do nothing
                    break;
            }
        }
    }
}
