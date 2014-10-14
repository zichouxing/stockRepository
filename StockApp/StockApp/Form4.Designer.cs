namespace WindowsFormsApplication1
{
    partial class FileUploadForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.filePathTextField = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePathTextField
            // 
            this.filePathTextField.Location = new System.Drawing.Point(210, 81);
            this.filePathTextField.Name = "filePathTextField";
            this.filePathTextField.Size = new System.Drawing.Size(204, 20);
            this.filePathTextField.TabIndex = 0;
            this.filePathTextField.TextChanged += new System.EventHandler(this.filePathTextField_TextChanged);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(501, 78);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 1;
            this.uploadBtn.Text = "上传";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件路径：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(420, 79);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.fileSelectBtn.TabIndex = 3;
            this.fileSelectBtn.Text = "选择文件";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // FileUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 369);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.filePathTextField);
            this.Name = "FileUploadForm";
            this.Text = "文件上传";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextField;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fileSelectBtn;
    }
}

