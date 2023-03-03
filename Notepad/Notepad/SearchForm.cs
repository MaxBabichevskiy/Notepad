using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Shown(object sender, EventArgs e)
        {
            tbFind.Focus();
        }

        int findCutLength = 0;

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            findCutLength = 0;
        }

        private void tbReplace_TextChanged(object sender, EventArgs e)
        {
            findCutLength = 0;
        }

        private void cbReg_CheckStateChanged(object sender, EventArgs e)
        {
            findCutLength = 0;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            findCutLength = 0;
        }






        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        

        private void btFind_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbReg.CheckState == CheckState.Checked)
                {
                    TextWork.FindTextBox(ref main.notebox, tbFind.Text, ref findCutLength, true);
                }
                else
                {
                    TextWork.FindTextBox(ref main.notebox, tbFind.Text, ref findCutLength, false);
                }
            }
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbReg.CheckState == CheckState.Checked)
                {
                    TextWork.ReplaceTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, ref findCutLength, true);
                }
                else
                {
                    TextWork.ReplaceTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, ref findCutLength, false);
                }
            }
        }

        private void btReplaceAll_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (cbReg.CheckState == CheckState.Checked)
                {
                    TextWork.ReplaceAllTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, true);
                }
                else
                {
                    TextWork.ReplaceAllTextBox(ref main.notebox, tbFind.Text, tbReplace.Text, false);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
