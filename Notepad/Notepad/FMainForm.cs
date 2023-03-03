using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Notepad
{
    public partial class FMainForm : Form
    {
        bool tbChange = false;
        string docPath = "";

        string buffer;
        public FMainForm()
        {
            InitializeComponent();           

            textBox1.Multiline = true;
            textBox1.Dock = DockStyle.Fill;

            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Скопировать");
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Вставить");

            copyMenuItem.Click += copyMenuIteam_Click;
            pasteMenuItem.Click += pasteMenuIteam_Click;

        }        

        void copyMenuIteam_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
        }

        void pasteMenuIteam_Click(object sender, EventArgs e)
        {
            textBox1.Paste(buffer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            textBox1.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusStripVisible == true)
            { mViewStatusStrip.CheckState = CheckState.Checked; }
            else
            { mViewStatusStrip.CheckState = CheckState.Unchecked; }
            if (Properties.Settings.Default.textTransfer == true)
            { mFormatTransfer.CheckState = CheckState.Checked; }
            else
            { mFormatTransfer.CheckState = CheckState.Unchecked; }
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = textBox1.WordWrap;
            Properties.Settings.Default.textFont = textBox1.Font;
            Properties.Settings.Default.statusStripVisible = statusStrip.Visible;
            Properties.Settings.Default.Save();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Cut();
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.SelectedText = "";
            }
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now));
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog.Font = textBox1.Font;
            DialogResult = FontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                textBox1.Font = FontDialog.Font;
            }
        }

        private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mFormatTransfer.CheckState == CheckState.Checked)
            {
                textBox1.WordWrap = true;
                textBox1.ScrollBars = ScrollBars.Vertical;
                mEditGo.Enabled = false;
                statusLab1.Visible = false;
                statusLinesCount.Visible = false;
            }
            else
            {
                textBox1.WordWrap = false;
                textBox1.ScrollBars = ScrollBars.Both;
                mEditGo.Enabled = true;
                statusLab1.Visible = true;
                statusLinesCount.Visible = true;
            }
        }

        private void строкаСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mViewStatusStrip.CheckState == CheckState.Checked)
            {
                statusStrip.Visible = true;
            }
            else
            {
                statusStrip.Visible = false;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            tbChange = true;
            TextWork.StatusAnalize(ref textBox1, ref statusLinesCount, ref statusWordsCount, ref statusCharSpaceCount, ref statusCharCount);

           
        }
        private void mFileNew_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref textBox1, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref textBox1, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref textBox1, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref textBox1, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.CreateFile(ref textBox1, ref tbChange, ref docPath);
                }
            }
            else
            {
                FileWork.CreateFile(ref textBox1, ref tbChange, ref docPath);
            }
        }

        private void mFileSave_Click(object sender, EventArgs e)
        {
            if (docPath != "")
            {
                FileWork.SaveFile(ref textBox1, ref tbChange, ref docPath);
            }
            else
            {
                FileWork.SaveAsFile(ref textBox1, ref tbChange, ref docPath);
            }
        }

        private void mFileSaveAs_Click(object sender, EventArgs e)
        {
            FileWork.SaveAsFile(ref textBox1, ref tbChange, ref docPath);
        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mEditFind_Click(object sender, EventArgs e)
        {
            SearchForm findText = new SearchForm();
            findText.Owner = this;
            findText.Show();
        }

        private void mFileOpen_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref textBox1, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref textBox1, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref textBox1, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref textBox1, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWork.OpenFile(ref textBox1, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                FileWork.OpenFile(ref textBox1, ref tbChange, ref docPath);
            }
        }

        private void mFileSaveAs_Click_1(object sender, EventArgs e)
        {
            FileWork.SaveAsFile(ref textBox1, ref tbChange, ref docPath);
        }

        private void mFilePageParam_Click_1(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void mFilePrint_Click_1(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mFileExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mEditFind_Click_1(object sender, EventArgs e)
        {
            SearchForm findText = new SearchForm();
            findText.Owner = this;
            findText.Show();
        }

        private void mEditGo_Click(object sender, EventArgs e)
        {
            GoToForm gotoform = new GoToForm();
            gotoform.Owner = this;
            gotoform.tbLineNum.Minimum = 0;
            gotoform.tbLineNum.Maximum = textBox1.Lines.Count();
            gotoform.ShowDialog();
        }

        private void FontDialog_Apply(object sender, EventArgs e)
        {
            FontDialog.Font = textBox1.Font;
            DialogResult = FontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                textBox1.Font = FontDialog.Font;
            }
        }

        private void mFormatTransfer_CheckStateChanged(object sender, EventArgs e)
        {
            if (mFormatTransfer.CheckState == CheckState.Checked)
            {
                textBox1.WordWrap = true;
                textBox1.ScrollBars = ScrollBars.Vertical;
                mEditGo.Enabled = false;
                statusLab1.Visible = false;
                statusLinesCount.Visible = false;
            }
            else
            {
                textBox1.WordWrap = false;
                textBox1.ScrollBars = ScrollBars.Both;
                mEditGo.Enabled = true;
                statusLab1.Visible = true;
                statusLinesCount.Visible = true;
            }
        }

        private void mViewStatusStrip_CheckStateChanged(object sender, EventArgs e)
        {
            if (mViewStatusStrip.CheckState == CheckState.Checked)
            {
                statusStrip.Visible = true;
            }
            else
            {
                statusStrip.Visible = false;
            }
        }
    }
}
