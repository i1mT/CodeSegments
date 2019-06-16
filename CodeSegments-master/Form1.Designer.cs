namespace CodeSegments_master
{
    partial class MainForm
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
            this.searchInput = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.list = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.setComboBox = new System.Windows.Forms.ComboBox();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.cloneRichText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchInput.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchInput.Location = new System.Drawing.Point(415, 0);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(1045, 43);
            this.searchInput.TabIndex = 0;
            this.searchInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchInput_KeyPress);
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(0, 45);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.list);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.cloneRichText);
            this.splitContainer.Panel2.Controls.Add(this.deleteLabel);
            this.splitContainer.Panel2.Controls.Add(this.modeLabel);
            this.splitContainer.Panel2.Controls.Add(this.saveButton);
            this.splitContainer.Panel2.Controls.Add(this.setComboBox);
            this.splitContainer.Panel2.Controls.Add(this.richText);
            this.splitContainer.Size = new System.Drawing.Size(1460, 838);
            this.splitContainer.SplitterDistance = 410;
            this.splitContainer.TabIndex = 1;
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 21;
            this.list.Location = new System.Drawing.Point(0, 3);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(409, 823);
            this.list.TabIndex = 1;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveButton.Location = new System.Drawing.Point(823, 783);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(220, 44);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // setComboBox
            // 
            this.setComboBox.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setComboBox.FormattingEnabled = true;
            this.setComboBox.Location = new System.Drawing.Point(475, 784);
            this.setComboBox.Name = "setComboBox";
            this.setComboBox.Size = new System.Drawing.Size(333, 43);
            this.setComboBox.TabIndex = 3;
            // 
            // richText
            // 
            this.richText.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richText.Location = new System.Drawing.Point(1, 0);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(1045, 778);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            this.richText.Click += new System.EventHandler(this.richText_Click);
            this.richText.TextChanged += new System.EventHandler(this.richText_TextChanged);
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(0, 0);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(409, 43);
            this.searchComboBox.TabIndex = 2;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modeLabel.Location = new System.Drawing.Point(360, 793);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(88, 25);
            this.modeLabel.TabIndex = 5;
            this.modeLabel.Text = "阅读模式";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteLabel.Location = new System.Drawing.Point(276, 793);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(50, 25);
            this.deleteLabel.TabIndex = 6;
            this.deleteLabel.Text = "删除";
            this.deleteLabel.Click += new System.EventHandler(this.deleteLabel_Click);
            // 
            // cloneRichText
            // 
            this.cloneRichText.ForeColor = System.Drawing.Color.YellowGreen;
            this.cloneRichText.Location = new System.Drawing.Point(3, 783);
            this.cloneRichText.Name = "cloneRichText";
            this.cloneRichText.ShowSelectionMargin = true;
            this.cloneRichText.Size = new System.Drawing.Size(250, 52);
            this.cloneRichText.TabIndex = 7;
            this.cloneRichText.Text = "";
            this.cloneRichText.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1460, 881);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.searchInput);
            this.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.ComboBox setComboBox;
        public System.Windows.Forms.TextBox searchInput;
        public System.Windows.Forms.ComboBox searchComboBox;
        public System.Windows.Forms.ListBox list;
        public System.Windows.Forms.RichTextBox richText;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label deleteLabel;
        public System.Windows.Forms.RichTextBox cloneRichText;
    }
}

