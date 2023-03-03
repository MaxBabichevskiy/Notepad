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
    public partial class Form1 : Form
    {
        bool tbChange = false;
        string docPath = "";

        string buffer;
        public Form1()
        {
            InitializeComponent();

            

            textBox1.Multiline = true;
            textBox1.Dock = DockStyle.Fill;


            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Скопировать");
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Вставить");


//            contextMenuStrip1.Items.AddRange(new[] { copyMenuItem, pasteMenuItem });

           // textBox1.ContextMenuStrip = contextMenuStrip1;


            copyMenuItem.Click += copyMenuIteam_Click;
            pasteMenuItem.Click += pasteMenuIteam_Click;

        }
        //    ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

        //    ToolStripMenuItem newItem = new ToolStripMenuItem("Создать")
        //    {
        //        Checked = true,
        //        CheckOnClick = true

        //    };
        //    newItem.CheckedChanged += menuItem_ChakedChanged;
        //    fileItem.DropDownItems.Add(newItem);

        //    ToolStripMenuItem saveItem = new ToolStripMenuItem("Сохранить")
        //    {
        //        Checked = true,
        //        CheckOnClick = true

        //    };
        //    saveItem.CheckedChanged += menuItem_ChakedChanged;
        //    saveItem.ShortcutKeys = Keys.Control | Keys.P;
        //    fileItem.DropDownItems.Add(saveItem);

        //    //fileItem.DropDownItems.Add(new ToolStripMenuItem("Сохранить"));

        //    menuStrip1.Items.Add(fileItem);

        //    ToolStripMenuItem aboutItem = new ToolStripMenuItem("About");
        //    aboutItem.Click += aboutItem_Click;
        //    menuStrip1.Items.Add(aboutItem);
        //}

        //void aboutItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("About programm");
        //}
        //void menuItem_ChakedChanged(object sender, EventArgs e)
        //{
        //    ToolStripMenuItem menuItem= sender as ToolStripMenuItem;
        //    if (menuItem.CheckState == CheckState.Checked)
        //        MessageBox.Show("Checked");
        //    else if(menuItem.CheckState == CheckState.Unchecked)
        //        MessageBox.Show("Unchecked");

        //}

        







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void файлToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now));
        }

        private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void перейтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void найтиДалееToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = textBox1.Font;
            DialogResult = fontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
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
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

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

        private void mFilePageParam_Click(object sender, EventArgs e)
        {

        }

        private void mFilePrint_Click(object sender, EventArgs e)
        {

        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

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
            gotoform.tbLineNum.Maximum = notebox.Lines.Count();
            gotoform.ShowDialog();
        }
    }
}
