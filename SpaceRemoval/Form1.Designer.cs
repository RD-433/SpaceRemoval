namespace SpaceRemoval
{
    partial class Form1
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
            this.richTextBoxIn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonPCC = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.checkBoxRemoveIllegal = new System.Windows.Forms.CheckBox();
            this.checkBoxContPar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDot = new System.Windows.Forms.CheckBox();
            this.checkBoxComma = new System.Windows.Forms.CheckBox();
            this.checkBoxColon = new System.Windows.Forms.CheckBox();
            this.checkBoxSemicolon = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxIn
            // 
            this.richTextBoxIn.Location = new System.Drawing.Point(12, 141);
            this.richTextBoxIn.Name = "richTextBoxIn";
            this.richTextBoxIn.Size = new System.Drawing.Size(683, 407);
            this.richTextBoxIn.TabIndex = 0;
            this.richTextBoxIn.Text = "";
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Location = new System.Drawing.Point(725, 107);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.ReadOnly = true;
            this.richTextBoxOut.Size = new System.Drawing.Size(683, 441);
            this.richTextBoxOut.TabIndex = 1;
            this.richTextBoxOut.Text = "";
            // 
            // buttonPaste
            // 
            this.buttonPaste.Location = new System.Drawing.Point(568, 12);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(75, 48);
            this.buttonPaste.TabIndex = 2;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonPCC
            // 
            this.buttonPCC.Location = new System.Drawing.Point(1333, 12);
            this.buttonPCC.Name = "buttonPCC";
            this.buttonPCC.Size = new System.Drawing.Size(75, 62);
            this.buttonPCC.TabIndex = 3;
            this.buttonPCC.Text = "Paste Convert Copy";
            this.buttonPCC.UseVisualStyleBackColor = true;
            this.buttonPCC.Click += new System.EventHandler(this.buttonPCC_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(786, 12);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 48);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(675, 12);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 48);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // checkBoxRemoveIllegal
            // 
            this.checkBoxRemoveIllegal.AutoSize = true;
            this.checkBoxRemoveIllegal.Location = new System.Drawing.Point(12, 12);
            this.checkBoxRemoveIllegal.Name = "checkBoxRemoveIllegal";
            this.checkBoxRemoveIllegal.Size = new System.Drawing.Size(126, 17);
            this.checkBoxRemoveIllegal.TabIndex = 6;
            this.checkBoxRemoveIllegal.Text = "Remove Illegal Chars";
            this.checkBoxRemoveIllegal.UseVisualStyleBackColor = true;
            // 
            // checkBoxContPar
            // 
            this.checkBoxContPar.AutoSize = true;
            this.checkBoxContPar.Location = new System.Drawing.Point(6, 19);
            this.checkBoxContPar.Name = "checkBoxContPar";
            this.checkBoxContPar.Size = new System.Drawing.Size(120, 17);
            this.checkBoxContPar.TabIndex = 7;
            this.checkBoxContPar.Text = "Continue Paragraph";
            this.checkBoxContPar.UseVisualStyleBackColor = true;
            this.checkBoxContPar.CheckedChanged += new System.EventHandler(this.checkBoxContPar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSemicolon);
            this.groupBox1.Controls.Add(this.checkBoxColon);
            this.groupBox1.Controls.Add(this.checkBoxComma);
            this.groupBox1.Controls.Add(this.checkBoxDot);
            this.groupBox1.Controls.Add(this.checkBoxContPar);
            this.groupBox1.Location = new System.Drawing.Point(207, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBoxDot
            // 
            this.checkBoxDot.AutoSize = true;
            this.checkBoxDot.Location = new System.Drawing.Point(26, 42);
            this.checkBoxDot.Name = "checkBoxDot";
            this.checkBoxDot.Size = new System.Drawing.Size(53, 17);
            this.checkBoxDot.TabIndex = 8;
            this.checkBoxDot.Text = ". (dot)";
            this.checkBoxDot.UseVisualStyleBackColor = true;
            // 
            // checkBoxComma
            // 
            this.checkBoxComma.AutoSize = true;
            this.checkBoxComma.Location = new System.Drawing.Point(85, 42);
            this.checkBoxComma.Name = "checkBoxComma";
            this.checkBoxComma.Size = new System.Drawing.Size(72, 17);
            this.checkBoxComma.TabIndex = 9;
            this.checkBoxComma.Text = ", (comma)";
            this.checkBoxComma.UseVisualStyleBackColor = true;
            // 
            // checkBoxColon
            // 
            this.checkBoxColon.AutoSize = true;
            this.checkBoxColon.Location = new System.Drawing.Point(163, 42);
            this.checkBoxColon.Name = "checkBoxColon";
            this.checkBoxColon.Size = new System.Drawing.Size(64, 17);
            this.checkBoxColon.TabIndex = 10;
            this.checkBoxColon.Text = ": (colon)";
            this.checkBoxColon.UseVisualStyleBackColor = true;
            // 
            // checkBoxSemicolon
            // 
            this.checkBoxSemicolon.AutoSize = true;
            this.checkBoxSemicolon.Location = new System.Drawing.Point(26, 65);
            this.checkBoxSemicolon.Name = "checkBoxSemicolon";
            this.checkBoxSemicolon.Size = new System.Drawing.Size(85, 17);
            this.checkBoxSemicolon.TabIndex = 11;
            this.checkBoxSemicolon.Text = "; (semicolon)";
            this.checkBoxSemicolon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxRemoveIllegal);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonPCC);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.richTextBoxOut);
            this.Controls.Add(this.richTextBoxIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxIn;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonPCC;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.CheckBox checkBoxRemoveIllegal;
        private System.Windows.Forms.CheckBox checkBoxContPar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxColon;
        private System.Windows.Forms.CheckBox checkBoxComma;
        private System.Windows.Forms.CheckBox checkBoxDot;
        private System.Windows.Forms.CheckBox checkBoxSemicolon;
    }
}

