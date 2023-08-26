namespace ReportApp_Server
{
    partial class ReportApp_Server
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
            this.textBoxForPath = new System.Windows.Forms.TextBox();
            this.FetchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPathView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalFileCountLabel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NewFileCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.label5 = new System.Windows.Forms.Label();
            this.DuplicateFileCountLabel = new System.Windows.Forms.Label();
            this.ViewDupBtn = new System.Windows.Forms.Button();
            this.CDInpBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ListForDuplicateFile = new System.Windows.Forms.ListBox();
            this.DuplicateFilesListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxForPath
            // 
            this.textBoxForPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxForPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForPath.Location = new System.Drawing.Point(101, 100);
            this.textBoxForPath.Name = "textBoxForPath";
            this.textBoxForPath.Size = new System.Drawing.Size(393, 24);
            this.textBoxForPath.TabIndex = 0;
            this.textBoxForPath.Text = "D:\\uploads\\CD";
            // 
            // FetchBtn
            // 
            this.FetchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FetchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetchBtn.Location = new System.Drawing.Point(500, 99);
            this.FetchBtn.Name = "FetchBtn";
            this.FetchBtn.Size = new System.Drawing.Size(100, 28);
            this.FetchBtn.TabIndex = 1;
            this.FetchBtn.Text = "Fetch Files";
            this.FetchBtn.UseVisualStyleBackColor = true;
            this.FetchBtn.Click += new System.EventHandler(this.FetchBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Path";
            // 
            // FolderPathView
            // 
            this.FolderPathView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FolderPathView.AutoSize = true;
            this.FolderPathView.Location = new System.Drawing.Point(99, 135);
            this.FolderPathView.Name = "FolderPathView";
            this.FolderPathView.Size = new System.Drawing.Size(74, 13);
            this.FolderPathView.TabIndex = 3;
            this.FolderPathView.Text = "Selected Path";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Files: ";
            // 
            // TotalFileCountLabel
            // 
            this.TotalFileCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TotalFileCountLabel.AutoSize = true;
            this.TotalFileCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFileCountLabel.Location = new System.Drawing.Point(330, 175);
            this.TotalFileCountLabel.Name = "TotalFileCountLabel";
            this.TotalFileCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalFileCountLabel.Size = new System.Drawing.Size(16, 18);
            this.TotalFileCountLabel.TabIndex = 5;
            this.TotalFileCountLabel.Text = "0";
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(331, 354);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 6;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadBtn
            // 
            this.UploadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UploadBtn.Enabled = false;
            this.UploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBtn.Location = new System.Drawing.Point(208, 280);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(100, 30);
            this.UploadBtn.TabIndex = 7;
            this.UploadBtn.Text = "Upload Now";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Files to be Uploaded";
            // 
            // NewFileCountLabel
            // 
            this.NewFileCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NewFileCountLabel.AutoSize = true;
            this.NewFileCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFileCountLabel.Location = new System.Drawing.Point(330, 220);
            this.NewFileCountLabel.Name = "NewFileCountLabel";
            this.NewFileCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewFileCountLabel.Size = new System.Drawing.Size(16, 18);
            this.NewFileCountLabel.TabIndex = 9;
            this.NewFileCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Report App";
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duplicate Files:";
            // 
            // DuplicateFileCountLabel
            // 
            this.DuplicateFileCountLabel.AutoSize = true;
            this.DuplicateFileCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuplicateFileCountLabel.Location = new System.Drawing.Point(330, 198);
            this.DuplicateFileCountLabel.Name = "DuplicateFileCountLabel";
            this.DuplicateFileCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DuplicateFileCountLabel.Size = new System.Drawing.Size(16, 18);
            this.DuplicateFileCountLabel.TabIndex = 12;
            this.DuplicateFileCountLabel.Text = "0";
            // 
            // ViewDupBtn
            // 
            this.ViewDupBtn.Location = new System.Drawing.Point(352, 198);
            this.ViewDupBtn.Name = "ViewDupBtn";
            this.ViewDupBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewDupBtn.TabIndex = 13;
            this.ViewDupBtn.Text = "View";
            this.ViewDupBtn.UseVisualStyleBackColor = true;
            this.ViewDupBtn.Visible = false;
            this.ViewDupBtn.Click += new System.EventHandler(this.ViewDupBtn_Click);
            // 
            // CDInpBox
            // 
            this.CDInpBox.Enabled = false;
            this.CDInpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDInpBox.Location = new System.Drawing.Point(102, 282);
            this.CDInpBox.Name = "CDInpBox";
            this.CDInpBox.Size = new System.Drawing.Size(100, 24);
            this.CDInpBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CD Name";
            // 
            // ListForDuplicateFile
            // 
            this.ListForDuplicateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListForDuplicateFile.FormattingEnabled = true;
            this.ListForDuplicateFile.ItemHeight = 16;
            this.ListForDuplicateFile.Location = new System.Drawing.Point(438, 167);
            this.ListForDuplicateFile.Name = "ListForDuplicateFile";
            this.ListForDuplicateFile.ScrollAlwaysVisible = true;
            this.ListForDuplicateFile.Size = new System.Drawing.Size(162, 132);
            this.ListForDuplicateFile.TabIndex = 16;
            this.ListForDuplicateFile.Visible = false;
            // 
            // DuplicateFilesListLabel
            // 
            this.DuplicateFilesListLabel.AutoSize = true;
            this.DuplicateFilesListLabel.Location = new System.Drawing.Point(435, 151);
            this.DuplicateFilesListLabel.Name = "DuplicateFilesListLabel";
            this.DuplicateFilesListLabel.Size = new System.Drawing.Size(76, 13);
            this.DuplicateFilesListLabel.TabIndex = 17;
            this.DuplicateFilesListLabel.Text = "Duplicate Files";
            this.DuplicateFilesListLabel.Visible = false;
            // 
            // ReportApp_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.DuplicateFilesListLabel);
            this.Controls.Add(this.ListForDuplicateFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CDInpBox);
            this.Controls.Add(this.ViewDupBtn);
            this.Controls.Add(this.DuplicateFileCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewFileCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.TotalFileCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FolderPathView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FetchBtn);
            this.Controls.Add(this.textBoxForPath);
            this.Name = "ReportApp_Server";
            this.Text = "ReportApp_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForPath;
        private System.Windows.Forms.Button FetchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FolderPathView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalFileCountLabel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NewFileCountLabel;
        private System.Windows.Forms.Label label4;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DuplicateFileCountLabel;
        private System.Windows.Forms.Button ViewDupBtn;
        private System.Windows.Forms.TextBox CDInpBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ListForDuplicateFile;
        private System.Windows.Forms.Label DuplicateFilesListLabel;
    }
}

