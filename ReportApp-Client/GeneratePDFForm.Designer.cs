namespace ReportApp_Client
{
    partial class GeneratePDFForm
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
            this.GeneratePDFslabel = new System.Windows.Forms.Label();
            this.GenenrateFileDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GenenrateFileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratePDFslabel
            // 
            this.GeneratePDFslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GeneratePDFslabel.AutoSize = true;
            this.GeneratePDFslabel.Location = new System.Drawing.Point(282, 111);
            this.GeneratePDFslabel.Name = "GeneratePDFslabel";
            this.GeneratePDFslabel.Size = new System.Drawing.Size(80, 13);
            this.GeneratePDFslabel.TabIndex = 1;
            this.GeneratePDFslabel.Text = "Generate PDFs";
            // 
            // GenenrateFileDataGridView
            // 
            this.GenenrateFileDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenenrateFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenenrateFileDataGridView.Location = new System.Drawing.Point(137, 141);
            this.GenenrateFileDataGridView.Name = "GenenrateFileDataGridView";
            this.GenenrateFileDataGridView.Size = new System.Drawing.Size(385, 217);
            this.GenenrateFileDataGridView.TabIndex = 2;
            this.GenenrateFileDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GenenrateFileDataGridView_CellContentClick);
            // 
            // GeneratePDFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.GenenrateFileDataGridView);
            this.Controls.Add(this.GeneratePDFslabel);
            this.Name = "GeneratePDFForm";
            this.Text = "GeneratePDFForm";
            ((System.ComponentModel.ISupportInitialize)(this.GenenrateFileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GeneratePDFslabel;
        private System.Windows.Forms.DataGridView GenenrateFileDataGridView;
    }
}