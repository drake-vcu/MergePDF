namespace MergePDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMergePdf = new System.Windows.Forms.Button();
            this.richConsole = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMergeAmount = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.flpFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMergePdf
            // 
            this.btnMergePdf.Location = new System.Drawing.Point(12, 311);
            this.btnMergePdf.Name = "btnMergePdf";
            this.btnMergePdf.Size = new System.Drawing.Size(604, 23);
            this.btnMergePdf.TabIndex = 0;
            this.btnMergePdf.TabStop = false;
            this.btnMergePdf.Text = "Merge PDF";
            this.btnMergePdf.UseVisualStyleBackColor = true;
            this.btnMergePdf.Click += new System.EventHandler(this.btnMergePdf_Click);
            // 
            // richConsole
            // 
            this.richConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richConsole.Location = new System.Drawing.Point(12, 373);
            this.richConsole.Name = "richConsole";
            this.richConsole.ReadOnly = true;
            this.richConsole.Size = new System.Drawing.Size(604, 96);
            this.richConsole.TabIndex = 1;
            this.richConsole.Text = "";
            this.richConsole.TextChanged += new System.EventHandler(this.richConsole_TextChanged);
            this.richConsole.Enter += new System.EventHandler(this.richConsole_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblMergeAmount
            // 
            this.lblMergeAmount.AutoSize = true;
            this.lblMergeAmount.Location = new System.Drawing.Point(94, 44);
            this.lblMergeAmount.Name = "lblMergeAmount";
            this.lblMergeAmount.Size = new System.Drawing.Size(213, 13);
            this.lblMergeAmount.TabIndex = 4;
            this.lblMergeAmount.Text = "How many PDF files do you want to merge?";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(12, 340);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(604, 23);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.TabStop = false;
            this.btnClearAll.Text = "Clear all fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // flpFiles
            // 
            this.flpFiles.AutoScroll = true;
            this.flpFiles.Location = new System.Drawing.Point(13, 68);
            this.flpFiles.Name = "flpFiles";
            this.flpFiles.Size = new System.Drawing.Size(603, 203);
            this.flpFiles.TabIndex = 6;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 39);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 7;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(13, 282);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 8;
            this.btnSaveFile.Text = "Save File at";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(106, 285);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.Size = new System.Drawing.Size(510, 20);
            this.txtSaveFile.TabIndex = 9;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(308, 44);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(13, 13);
            this.lblFileCount.TabIndex = 10;
            this.lblFileCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 481);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.txtSaveFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.flpFiles);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblMergeAmount);
            this.Controls.Add(this.richConsole);
            this.Controls.Add(this.btnMergePdf);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MergePDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMergePdf;
        private System.Windows.Forms.RichTextBox richConsole;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblMergeAmount;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.FlowLayoutPanel flpFiles;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.Label lblFileCount;
    }
}

