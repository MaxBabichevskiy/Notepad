namespace Notepad
{
    partial class Перейти
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLineNum = new System.Windows.Forms.NumericUpDown();
            this.butGo = new System.Windows.Forms.Button();
            this.labGo = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLineNum
            // 
            this.tbLineNum.Location = new System.Drawing.Point(21, 44);
            this.tbLineNum.Name = "tbLineNum";
            this.tbLineNum.Size = new System.Drawing.Size(122, 20);
            this.tbLineNum.TabIndex = 0;
            // 
            // butGo
            // 
            this.butGo.Location = new System.Drawing.Point(21, 70);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(57, 23);
            this.butGo.TabIndex = 1;
            this.butGo.Text = "button1";
            this.butGo.UseVisualStyleBackColor = true;
            // 
            // labGo
            // 
            this.labGo.AutoSize = true;
            this.labGo.Location = new System.Drawing.Point(18, 18);
            this.labGo.Name = "labGo";
            this.labGo.Size = new System.Drawing.Size(125, 13);
            this.labGo.TabIndex = 3;
            this.labGo.Text = "Введите номер строки:";
            this.labGo.Click += new System.EventHandler(this.label1_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(84, 70);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(57, 23);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "button2";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // Перейти
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 111);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.labGo);
            this.Controls.Add(this.butGo);
            this.Controls.Add(this.tbLineNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Перейти";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GoToForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butGo;
        private System.Windows.Forms.Label labGo;
        private System.Windows.Forms.Button butCancel;
        public System.Windows.Forms.NumericUpDown tbLineNum;
    }
}