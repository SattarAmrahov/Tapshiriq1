namespace TaskRegularExpression1
{
    partial class frmRegularExpression
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
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.richTextBoxOriginalContent = new System.Windows.Forms.RichTextBox();
            this.richTextBoxConvertedContent = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(429, 20);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(453, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // richTextBoxOriginalContent
            // 
            this.richTextBoxOriginalContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOriginalContent.Location = new System.Drawing.Point(12, 47);
            this.richTextBoxOriginalContent.Name = "richTextBoxOriginalContent";
            this.richTextBoxOriginalContent.Size = new System.Drawing.Size(217, 487);
            this.richTextBoxOriginalContent.TabIndex = 2;
            this.richTextBoxOriginalContent.Text = "";
            // 
            // richTextBoxConvertedContent
            // 
            this.richTextBoxConvertedContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxConvertedContent.Location = new System.Drawing.Point(311, 47);
            this.richTextBoxConvertedContent.Name = "richTextBoxConvertedContent";
            this.richTextBoxConvertedContent.Size = new System.Drawing.Size(217, 487);
            this.richTextBoxConvertedContent.TabIndex = 2;
            this.richTextBoxConvertedContent.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(235, 218);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(70, 66);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = ">>";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmRegularExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 546);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.richTextBoxConvertedContent);
            this.Controls.Add(this.richTextBoxOriginalContent);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Name = "frmRegularExpression";
            this.Text = "Clear Comments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox richTextBoxOriginalContent;
        private System.Windows.Forms.RichTextBox richTextBoxConvertedContent;
        private System.Windows.Forms.Button btnConvert;
    }
}

