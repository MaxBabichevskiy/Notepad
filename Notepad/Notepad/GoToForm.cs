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
    public partial class GoToForm : Form
    {
        public GoToForm()
        {
            InitializeComponent();
        }


        private void butGo_Click(object sender, EventArgs e)
        {
            FMainForm main = this.Owner as FMainForm;
            if (main != null)
            {
                int lineNumber = Convert.ToInt32(tbLineNum.Text);
                if (lineNumber > 0 && lineNumber <= main.textBox1.Lines.Count())
                {
                    main.textBox1.SelectionStart = main.textBox1.GetFirstCharIndexFromLine(Convert.ToInt32(tbLineNum.Text) - 1);
                    main.textBox1.ScrollToCaret();
                    this.Close();
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Перейти_Load(object sender, EventArgs e)
        {

        }
    }
}
