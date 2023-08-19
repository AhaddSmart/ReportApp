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
            this.label1 = new System.Windows.Forms.Label();
            this.SendRequestBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecievedFileCount = new System.Windows.Forms.Label();
            this.CSVIcon = new System.Windows.Forms.Label();
            this.NumOfFileBox = new System.Windows.Forms.NumericUpDown();
            this.StatusBox = new System.Windows.Forms.Label();
            this.CDDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfFileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Files";
            // 
            // SendRequestBtn
            // 
            this.SendRequestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SendRequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequestBtn.Location = new System.Drawing.Point(483, 100);
            this.SendRequestBtn.Name = "SendRequestBtn";
            this.SendRequestBtn.Size = new System.Drawing.Size(108, 24);
            this.SendRequestBtn.TabIndex = 2;
            this.SendRequestBtn.Text = "Send Request";
            this.SendRequestBtn.UseVisualStyleBackColor = true;
            this.SendRequestBtn.Click += new System.EventHandler(this.SendRequestBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Report App";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Recieved Files:";
            // 
            // RecievedFileCount
            // 
            this.RecievedFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RecievedFileCount.AutoSize = true;
            this.RecievedFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievedFileCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecievedFileCount.Location = new System.Drawing.Point(122, 178);
            this.RecievedFileCount.Name = "RecievedFileCount";
            this.RecievedFileCount.Size = new System.Drawing.Size(14, 16);
            this.RecievedFileCount.TabIndex = 13;
            this.RecievedFileCount.Text = "0";
            this.RecievedFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CSVIcon
            // 
            this.CSVIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CSVIcon.Image = global::ReportApp_Client.Properties.Resources.csv__1_;
            this.CSVIcon.Location = new System.Drawing.Point(81, 173);
            this.CSVIcon.Name = "CSVIcon";
            this.CSVIcon.Size = new System.Drawing.Size(35, 23);
            this.CSVIcon.TabIndex = 15;
            // 
            // NumOfFileBox
            // 
            this.NumOfFileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NumOfFileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfFileBox.Location = new System.Drawing.Point(211, 100);
            this.NumOfFileBox.Name = "NumOfFileBox";
            this.NumOfFileBox.Size = new System.Drawing.Size(266, 24);
            this.NumOfFileBox.TabIndex = 12;
            this.NumOfFileBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StatusBox.AutoSize = true;
            this.StatusBox.Location = new System.Drawing.Point(286, 299);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(37, 13);
            this.StatusBox.TabIndex = 16;
            this.StatusBox.Text = "Status";
            this.StatusBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDDropDown
            // 
            this.CDDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CDDropDown.FormattingEnabled = true;
            this.CDDropDown.Location = new System.Drawing.Point(84, 100);
            this.CDDropDown.Name = "CDDropDown";
            this.CDDropDown.Size = new System.Drawing.Size(121, 24);
            this.CDDropDown.TabIndex = 17;
            // 
            // ReportApp_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.CDDropDown);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.CSVIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecievedFileCount);
            this.Controls.Add(this.NumOfFileBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SendRequestBtn);
            this.Controls.Add(this.label1);
            this.Name = "ReportApp_Client";
            this.Text = "ReportApp_Client";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfFileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendRequestBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RecievedFileCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CSVIcon;
        private System.Windows.Forms.NumericUpDown NumOfFileBox;
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.ComboBox CDDropDown;
    }
}

