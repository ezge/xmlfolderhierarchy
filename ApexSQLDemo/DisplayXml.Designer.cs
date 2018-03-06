namespace ApexSQLDemo
{
    partial class frmDisplayXml
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateXml = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowXml = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBrowseFolder);
            this.panel1.Controls.Add(this.txtFolderName);
            this.panel1.Controls.Add(this.lblFolderName);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateXml
            // 
            this.btnCreateXml.Location = new System.Drawing.Point(358, 20);
            this.btnCreateXml.Name = "btnCreateXml";
            this.btnCreateXml.Size = new System.Drawing.Size(81, 23);
            this.btnCreateXml.TabIndex = 2;
            this.btnCreateXml.Text = "Create Xml";
            this.btnCreateXml.UseVisualStyleBackColor = true;
            this.btnCreateXml.Click += new System.EventHandler(this.btnCreateXml_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(73, 11);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.ReadOnly = true;
            this.txtFolderName.Size = new System.Drawing.Size(366, 20);
            this.txtFolderName.TabIndex = 1;
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(3, 14);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(64, 13);
            this.lblFolderName.TabIndex = 0;
            this.lblFolderName.Text = "Folder Path:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\Users\\Rea\\Downloads";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(358, 38);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(81, 23);
            this.btnBrowseFolder.TabIndex = 3;
            this.btnBrowseFolder.Text = "Open Folder";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.treeView);
            this.panel2.Controls.Add(this.btnCreateXml);
            this.panel2.Controls.Add(this.btnShowXml);
            this.panel2.Location = new System.Drawing.Point(13, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 338);
            this.panel2.TabIndex = 1;
            // 
            // btnShowXml
            // 
            this.btnShowXml.Location = new System.Drawing.Point(358, 49);
            this.btnShowXml.Name = "btnShowXml";
            this.btnShowXml.Size = new System.Drawing.Size(81, 23);
            this.btnShowXml.TabIndex = 0;
            this.btnShowXml.Text = "Load Xml";
            this.btnShowXml.UseVisualStyleBackColor = true;
            this.btnShowXml.Click += new System.EventHandler(this.btnShowXml_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(6, 16);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(346, 305);
            this.treeView.TabIndex = 1;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.AddExtension = false;
            this.OpenFileDialog.DefaultExt = "xml";
            this.OpenFileDialog.Filter = "XML files (*.xml)|*.xml";
            this.OpenFileDialog.InitialDirectory = "c:\\";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "xml";
            this.SaveFileDialog.Filter = "XML files (*.xml)|*.xml";
            // 
            // frmDisplayXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDisplayXml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Xml";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateXml;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnShowXml;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

