namespace KatmanliOrnek.UI.Forms
{
    partial class MainForm
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
            dgvPlakDetail = new DataGridView();
            dgvDiscontinued = new DataGridView();
            dgvContinued = new DataGridView();
            dgvLastTen = new DataGridView();
            dgvDiscounted = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlakDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiscontinued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContinued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLastTen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiscounted).BeginInit();
            SuspendLayout();
            // 
            // dgvPlakDetail
            // 
            dgvPlakDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlakDetail.Location = new Point(34, 67);
            dgvPlakDetail.Name = "dgvPlakDetail";
            dgvPlakDetail.RowHeadersWidth = 51;
            dgvPlakDetail.RowTemplate.Height = 29;
            dgvPlakDetail.Size = new Size(384, 188);
            dgvPlakDetail.TabIndex = 0;
            // 
            // dgvDiscontinued
            // 
            dgvDiscontinued.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscontinued.Location = new Point(448, 67);
            dgvDiscontinued.Name = "dgvDiscontinued";
            dgvDiscontinued.RowHeadersWidth = 51;
            dgvDiscontinued.RowTemplate.Height = 29;
            dgvDiscontinued.Size = new Size(267, 188);
            dgvDiscontinued.TabIndex = 0;
            // 
            // dgvContinued
            // 
            dgvContinued.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContinued.Location = new Point(752, 67);
            dgvContinued.Name = "dgvContinued";
            dgvContinued.RowHeadersWidth = 51;
            dgvContinued.RowTemplate.Height = 29;
            dgvContinued.Size = new Size(384, 188);
            dgvContinued.TabIndex = 0;
            // 
            // dgvLastTen
            // 
            dgvLastTen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLastTen.Location = new Point(212, 326);
            dgvLastTen.Name = "dgvLastTen";
            dgvLastTen.RowHeadersWidth = 51;
            dgvLastTen.RowTemplate.Height = 29;
            dgvLastTen.Size = new Size(337, 188);
            dgvLastTen.TabIndex = 0;
            // 
            // dgvDiscounted
            // 
            dgvDiscounted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscounted.Location = new Point(672, 326);
            dgvDiscounted.Name = "dgvDiscounted";
            dgvDiscounted.RowHeadersWidth = 51;
            dgvDiscounted.RowTemplate.Height = 29;
            dgvDiscounted.Size = new Size(337, 188);
            dgvDiscounted.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 596);
            Controls.Add(dgvDiscounted);
            Controls.Add(dgvLastTen);
            Controls.Add(dgvContinued);
            Controls.Add(dgvDiscontinued);
            Controls.Add(dgvPlakDetail);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlakDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiscontinued).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContinued).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLastTen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiscounted).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPlakDetail;
        private DataGridView dgvDiscontinued;
        private DataGridView dgvContinued;
        private DataGridView dgvLastTen;
        private DataGridView dgvDiscounted;
    }
}