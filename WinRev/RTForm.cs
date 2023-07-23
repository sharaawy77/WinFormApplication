using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRev
{
    public partial class RTForm : Form
    {
        public RTForm()
        {
            InitializeComponent();
        }


        private void RTForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtinput.SelectedText.Length > 0)
            {
                fontDialog1.Font = txtinput.SelectionFont;
            }

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtinput.SelectionFont = fontDialog1.Font;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text File |*.rtf| Text File |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtinput.LoadFile(openFileDialog1.FileName, (RichTextBoxStreamType)(openFileDialog1.FilterIndex - 1));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text File |*.rtf| Text File |*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtinput.SaveFile(saveFileDialog1.FileName, (RichTextBoxStreamType)(saveFileDialog1.FilterIndex - 1));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RTForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are U Sure u Wanna Exit ?", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)

            {
                e.Cancel = true;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (txtinput.SelectedText.Length > 0)
            {
                colorDialog1.Color = txtinput.SelectionColor;
            }

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtinput.SelectionColor = colorDialog1.Color;
            }
        }
        CustomDailo customDailo = new CustomDailo();
        private void ctnCustom_Click(object sender, EventArgs e)
        {
            customDailo.customtext = "enter u Text";
            if (customDailo.ShowDialog()==DialogResult.OK)
            {
                txtinput.Text=customDailo.customtext;
            }
            
        }
    }
}
