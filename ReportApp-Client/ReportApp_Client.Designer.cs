namespace ReportApp_Client
{
    partial class ReportApp_Client
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
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.CheckedListForRecivedFile = new System.Windows.Forms.CheckedListBox();
            this.FileDownloadBtn = new System.Windows.Forms.Button();
            this.CDDropDown = new System.Windows.Forms.ComboBox();
            this.StatusBox = new System.Windows.Forms.Label();
            this.CSVIcon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecievedFileCount = new System.Windows.Forms.Label();
            this.SendRequestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Report App";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GenerateBtn.Location = new System.Drawing.Point(458, 311);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 98;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // CheckedListForRecivedFile
            // 
            this.CheckedListForRecivedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CheckedListForRecivedFile.CheckOnClick = true;
            this.CheckedListForRecivedFile.FormattingEnabled = true;
            this.CheckedListForRecivedFile.Location = new System.Drawing.Point(139, 211);
            this.CheckedListForRecivedFile.Name = "CheckedListForRecivedFile";
            this.CheckedListForRecivedFile.Size = new System.Drawing.Size(393, 94);
            this.CheckedListForRecivedFile.TabIndex = 97;
            // 
            // FileDownloadBtn
            // 
            this.FileDownloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FileDownloadBtn.Enabled = false;
            this.FileDownloadBtn.Location = new System.Drawing.Point(377, 311);
            this.FileDownloadBtn.Name = "FileDownloadBtn";
            this.FileDownloadBtn.Size = new System.Drawing.Size(75, 23);
            this.FileDownloadBtn.TabIndex = 96;
            this.FileDownloadBtn.Text = "Download";
            this.FileDownloadBtn.UseVisualStyleBackColor = true;
            // 
            // CDDropDown
            // 
            this.CDDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CDDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CDDropDown.FormattingEnabled = true;
            this.CDDropDown.Location = new System.Drawing.Point(139, 97);
            this.CDDropDown.Name = "CDDropDown";
            this.CDDropDown.Size = new System.Drawing.Size(279, 24);
            this.CDDropDown.TabIndex = 95;
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StatusBox.AutoSize = true;
            this.StatusBox.Location = new System.Drawing.Point(311, 356);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(37, 13);
            this.StatusBox.TabIndex = 94;
            this.StatusBox.Text = "Status";
            this.StatusBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CSVIcon
            // 
            this.CSVIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CSVIcon.Image = global::ReportApp_Client.Properties.Resources.csv__1_;
            this.CSVIcon.Location = new System.Drawing.Point(136, 170);
            this.CSVIcon.Name = "CSVIcon";
            this.CSVIcon.Size = new System.Drawing.Size(35, 23);
            this.CSVIcon.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Recieved Files:";
            // 
            // RecievedFileCount
            // 
            this.RecievedFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RecievedFileCount.AutoSize = true;
            this.RecievedFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievedFileCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecievedFileCount.Location = new System.Drawing.Point(177, 175);
            this.RecievedFileCount.Name = "RecievedFileCount";
            this.RecievedFileCount.Size = new System.Drawing.Size(14, 16);
            this.RecievedFileCount.TabIndex = 91;
            this.RecievedFileCount.Text = "0";
            this.RecievedFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SendRequestBtn
            // 
            this.SendRequestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SendRequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequestBtn.Location = new System.Drawing.Point(424, 97);
            this.SendRequestBtn.Name = "SendRequestBtn";
            this.SendRequestBtn.Size = new System.Drawing.Size(108, 24);
            this.SendRequestBtn.TabIndex = 90;
            this.SendRequestBtn.Text = "Fetch Files";
            this.SendRequestBtn.UseVisualStyleBackColor = true;
            this.SendRequestBtn.Click += new System.EventHandler(this.SendRequestBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Select CD";
            // 
            // ReportApp_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.CheckedListForRecivedFile);
            this.Controls.Add(this.FileDownloadBtn);
            this.Controls.Add(this.CDDropDown);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.CSVIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecievedFileCount);
            this.Controls.Add(this.SendRequestBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "ReportApp_Client";
            this.Text = "ReportApp_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.CheckedListBox CheckedListForRecivedFile;
        private System.Windows.Forms.Button FileDownloadBtn;
        private System.Windows.Forms.ComboBox CDDropDown;
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.Label CSVIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RecievedFileCount;
        private System.Windows.Forms.Button SendRequestBtn;
        private System.Windows.Forms.Label label1;
    }
}

