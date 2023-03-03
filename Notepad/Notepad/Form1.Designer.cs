namespace Notepad
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
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePageParam = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGiveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mView = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.mEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLab1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharSpaceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mFormat,
            this.mView,
            this.mHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFileOpen,
            this.mFileSave,
            this.mFileSaveAs,
            this.mFilePageParam,
            this.mFilePrint,
            this.mFileExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(48, 20);
            this.mFile.Text = "Файл";
            this.mFile.Click += new System.EventHandler(this.файлToolStripMenuItem_Click_1);
            // 
            // mFileNew
            // 
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNew.Size = new System.Drawing.Size(204, 22);
            this.mFileNew.Text = "Создать";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mFileOpen.Size = new System.Drawing.Size(204, 22);
            this.mFileOpen.Text = "Открыть...";
            // 
            // mFileSave
            // 
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mFileSave.Size = new System.Drawing.Size(204, 22);
            this.mFileSave.Text = "Сохранить";
            // 
            // mFileSaveAs
            // 
            this.mFileSaveAs.Name = "mFileSaveAs";
            this.mFileSaveAs.Size = new System.Drawing.Size(204, 22);
            this.mFileSaveAs.Text = "Сохранить как...";
            // 
            // mFilePageParam
            // 
            this.mFilePageParam.Name = "mFilePageParam";
            this.mFilePageParam.Size = new System.Drawing.Size(204, 22);
            this.mFilePageParam.Text = "Параметры страницы...";
            // 
            // mFilePrint
            // 
            this.mFilePrint.Name = "mFilePrint";
            this.mFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mFilePrint.Size = new System.Drawing.Size(204, 22);
            this.mFilePrint.Text = "Печать...";
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.Size = new System.Drawing.Size(204, 22);
            this.mFileExit.Text = "Выход";
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditCancel,
            this.mEditCut,
            this.mEditCopy,
            this.mEditPaste,
            this.mEditDel,
            this.mEditFind,
            this.mEditGo,
            this.mEditGiveAll,
            this.mEditTime});
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(59, 20);
            this.mEdit.Text = "Правка";
            this.mEdit.Click += new System.EventHandler(this.правкаToolStripMenuItem_Click);
            // 
            // mEditCancel
            // 
            this.mEditCancel.Name = "mEditCancel";
            this.mEditCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditCancel.Size = new System.Drawing.Size(221, 22);
            this.mEditCancel.Text = "Отменить";
            this.mEditCancel.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // mEditCut
            // 
            this.mEditCut.Name = "mEditCut";
            this.mEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditCut.Size = new System.Drawing.Size(221, 22);
            this.mEditCut.Text = "Вырезать";
            this.mEditCut.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // mEditCopy
            // 
            this.mEditCopy.Name = "mEditCopy";
            this.mEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditCopy.Size = new System.Drawing.Size(221, 22);
            this.mEditCopy.Text = "Копировать";
            this.mEditCopy.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // mEditPaste
            // 
            this.mEditPaste.Name = "mEditPaste";
            this.mEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditPaste.Size = new System.Drawing.Size(221, 22);
            this.mEditPaste.Text = "Вставить";
            this.mEditPaste.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // mEditDel
            // 
            this.mEditDel.Name = "mEditDel";
            this.mEditDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditDel.Size = new System.Drawing.Size(221, 22);
            this.mEditDel.Text = "Удалить";
            this.mEditDel.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // mEditGiveAll
            // 
            this.mEditGiveAll.Name = "mEditGiveAll";
            this.mEditGiveAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mEditGiveAll.Size = new System.Drawing.Size(221, 22);
            this.mEditGiveAll.Text = "Выделить все";
            this.mEditGiveAll.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // mEditTime
            // 
            this.mEditTime.Name = "mEditTime";
            this.mEditTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditTime.Size = new System.Drawing.Size(221, 22);
            this.mEditTime.Text = "Время и дата";
            this.mEditTime.Click += new System.EventHandler(this.времяИДатаToolStripMenuItem_Click);
            // 
            // mFormat
            // 
            this.mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatTransfer,
            this.mFormatFont});
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(62, 20);
            this.mFormat.Text = "Формат";
            // 
            // mFormatTransfer
            // 
            this.mFormatTransfer.Checked = true;
            this.mFormatTransfer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mFormatTransfer.Name = "mFormatTransfer";
            this.mFormatTransfer.Size = new System.Drawing.Size(183, 22);
            this.mFormatTransfer.Text = "Перенос по словам";
            this.mFormatTransfer.Click += new System.EventHandler(this.переносПоСловамToolStripMenuItem_Click);
            // 
            // mFormatFont
            // 
            this.mFormatFont.Name = "mFormatFont";
            this.mFormatFont.Size = new System.Drawing.Size(183, 22);
            this.mFormatFont.Text = "Шрифт...";
            this.mFormatFont.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewStatusStrip});
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(39, 20);
            this.mView.Text = "Вид";
            this.mView.Click += new System.EventHandler(this.видToolStripMenuItem_Click);
            // 
            // mViewStatusStrip
            // 
            this.mViewStatusStrip.Checked = true;
            this.mViewStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewStatusStrip.Name = "mViewStatusStrip";
            this.mViewStatusStrip.Size = new System.Drawing.Size(180, 22);
            this.mViewStatusStrip.Text = "Строка состояния";
            this.mViewStatusStrip.Click += new System.EventHandler(this.строкаСостоянияToolStripMenuItem_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpAboutProgram});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(65, 20);
            this.mHelp.Text = "Справка";
            // 
            // mHelpAboutProgram
            // 
            this.mHelpAboutProgram.Name = "mHelpAboutProgram";
            this.mHelpAboutProgram.Size = new System.Drawing.Size(180, 22);
            this.mHelpAboutProgram.Text = "О программе";
            this.mHelpAboutProgram.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 426);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // mEditFind
            // 
            this.mEditFind.Name = "mEditFind";
            this.mEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mEditFind.Size = new System.Drawing.Size(221, 22);
            this.mEditFind.Text = "Найти и заменить...";
            // 
            // mEditGo
            // 
            this.mEditGo.Name = "mEditGo";
            this.mEditGo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mEditGo.Size = new System.Drawing.Size(221, 22);
            this.mEditGo.Text = "Перейти...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLab1,
            this.statusLinesCount,
            this.statusLab2,
            this.statusWordsCount,
            this.statusLab3,
            this.statusCharSpaceCount,
            this.statusLab4,
            this.statusCharCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLab1
            // 
            this.statusLab1.Name = "statusLab1";
            this.statusLab1.Size = new System.Drawing.Size(109, 17);
            this.statusLab1.Text = "Количество строк:";
            this.statusLab1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statusLinesCount
            // 
            this.statusLinesCount.Name = "statusLinesCount";
            this.statusLinesCount.Size = new System.Drawing.Size(13, 17);
            this.statusLinesCount.Text = "0";
            // 
            // statusLab2
            // 
            this.statusLab2.Name = "statusLab2";
            this.statusLab2.Size = new System.Drawing.Size(104, 17);
            this.statusLab2.Text = "Количество слов:";
            // 
            // statusWordsCount
            // 
            this.statusWordsCount.Name = "statusWordsCount";
            this.statusWordsCount.Size = new System.Drawing.Size(13, 17);
            this.statusWordsCount.Text = "0";
            // 
            // statusLab3
            // 
            this.statusLab3.Name = "statusLab3";
            this.statusLab3.Size = new System.Drawing.Size(142, 17);
            this.statusLab3.Text = "Символов с пробелами:";
            // 
            // statusCharSpaceCount
            // 
            this.statusCharSpaceCount.Name = "statusCharSpaceCount";
            this.statusCharSpaceCount.Size = new System.Drawing.Size(13, 17);
            this.statusCharSpaceCount.Text = "0";
            // 
            // statusLab4
            // 
            this.statusLab4.Name = "statusLab4";
            this.statusLab4.Size = new System.Drawing.Size(145, 17);
            this.statusLab4.Text = "Символов без пробелов:";
            // 
            // statusCharCount
            // 
            this.statusCharCount.Name = "statusCharCount";
            this.statusCharCount.Size = new System.Drawing.Size(13, 17);
            this.statusCharCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mFileSave;
        private System.Windows.Forms.ToolStripMenuItem mFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mFilePageParam;
        private System.Windows.Forms.ToolStripMenuItem mFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem mEditCancel;
        private System.Windows.Forms.ToolStripMenuItem mEditCut;
        private System.Windows.Forms.ToolStripMenuItem mEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mEditDel;
        private System.Windows.Forms.ToolStripMenuItem mEditGiveAll;
        private System.Windows.Forms.ToolStripMenuItem mEditTime;
        private System.Windows.Forms.ToolStripMenuItem mFormat;
        private System.Windows.Forms.ToolStripMenuItem mFormatTransfer;
        private System.Windows.Forms.ToolStripMenuItem mFormatFont;
        private System.Windows.Forms.ToolStripMenuItem mView;
        private System.Windows.Forms.ToolStripMenuItem mViewStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpAboutProgram;
        private System.Windows.Forms.TextBox textBox1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem mEditFind;
        private System.Windows.Forms.ToolStripMenuItem mEditGo;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLab1;
        private System.Windows.Forms.ToolStripStatusLabel statusLinesCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab2;
        private System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab3;
        private System.Windows.Forms.ToolStripStatusLabel statusCharSpaceCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab4;
        private System.Windows.Forms.ToolStripStatusLabel statusCharCount;
    }
}

