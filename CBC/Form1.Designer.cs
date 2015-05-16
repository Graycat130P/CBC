namespace CBC
{
    partial class mainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.beforeText = new System.Windows.Forms.TextBox();
            this.afterText = new System.Windows.Forms.TextBox();
            this.arrowPic = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenMenu,
            this.fileSaveMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(40, 22);
            this.fileMenu.Text = "File";
            // 
            // fileOpenMenu
            // 
            this.fileOpenMenu.Name = "fileOpenMenu";
            this.fileOpenMenu.Size = new System.Drawing.Size(106, 22);
            this.fileOpenMenu.Text = "Open";
            this.fileOpenMenu.Click += new System.EventHandler(this.fileOpenMenu_Click);
            // 
            // fileSaveMenu
            // 
            this.fileSaveMenu.Name = "fileSaveMenu";
            this.fileSaveMenu.Size = new System.Drawing.Size(106, 22);
            this.fileSaveMenu.Text = "Save";
            this.fileSaveMenu.Click += new System.EventHandler(this.fileSaveMenu_Click);
            // 
            // beforeText
            // 
            this.beforeText.Location = new System.Drawing.Point(12, 42);
            this.beforeText.Multiline = true;
            this.beforeText.Name = "beforeText";
            this.beforeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.beforeText.Size = new System.Drawing.Size(450, 484);
            this.beforeText.TabIndex = 1;
            // 
            // afterText
            // 
            this.afterText.Location = new System.Drawing.Point(546, 42);
            this.afterText.Multiline = true;
            this.afterText.Name = "afterText";
            this.afterText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.afterText.Size = new System.Drawing.Size(450, 484);
            this.afterText.TabIndex = 2;
            // 
            // arrowPic
            // 
            this.arrowPic.Image = ((System.Drawing.Image)(resources.GetObject("arrowPic.Image")));
            this.arrowPic.ImageLocation = "";
            this.arrowPic.Location = new System.Drawing.Point(468, 288);
            this.arrowPic.Name = "arrowPic";
            this.arrowPic.Size = new System.Drawing.Size(72, 52);
            this.arrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowPic.TabIndex = 3;
            this.arrowPic.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(468, 110);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(72, 19);
            this.passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(468, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 12);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password :";
            // 
            // encryptionButton
            // 
            this.encryptionButton.Location = new System.Drawing.Point(468, 136);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(72, 23);
            this.encryptionButton.TabIndex = 6;
            this.encryptionButton.Text = "Encryption";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // decryptionButton
            // 
            this.decryptionButton.Location = new System.Drawing.Point(468, 166);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(72, 23);
            this.decryptionButton.TabIndex = 7;
            this.decryptionButton.Text = "Decryption";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 538);
            this.Controls.Add(this.decryptionButton);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.arrowPic);
            this.Controls.Add(this.afterText);
            this.Controls.Add(this.beforeText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "CBC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileOpenMenu;
        private System.Windows.Forms.ToolStripMenuItem fileSaveMenu;
        private System.Windows.Forms.TextBox beforeText;
        private System.Windows.Forms.TextBox afterText;
        private System.Windows.Forms.PictureBox arrowPic;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.Button decryptionButton;
    }
}

