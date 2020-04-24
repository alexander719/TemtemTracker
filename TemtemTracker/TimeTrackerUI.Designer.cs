namespace TemtemTracker
{
    partial class TimeTrackerUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTimeTitle = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.temtemHLabel = new System.Windows.Forms.Label();
            this.labelTemtemHTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.labelTimeTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.temtemHLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTemtemHTitle, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1278, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTimeTitle
            // 
            this.labelTimeTitle.AutoSize = true;
            this.labelTimeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeTitle.Location = new System.Drawing.Point(4, 0);
            this.labelTimeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeTitle.Name = "labelTimeTitle";
            this.labelTimeTitle.Size = new System.Drawing.Size(205, 64);
            this.labelTimeTitle.TabIndex = 0;
            this.labelTimeTitle.Text = "Time:";
            this.labelTimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(217, 0);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(205, 64);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // temtemHLabel
            // 
            this.temtemHLabel.AutoSize = true;
            this.temtemHLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temtemHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temtemHLabel.Location = new System.Drawing.Point(856, 0);
            this.temtemHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temtemHLabel.Name = "temtemHLabel";
            this.temtemHLabel.Size = new System.Drawing.Size(205, 64);
            this.temtemHLabel.TabIndex = 3;
            this.temtemHLabel.Text = "0.00";
            this.temtemHLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTemtemHTitle
            // 
            this.labelTemtemHTitle.AutoSize = true;
            this.labelTemtemHTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTemtemHTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemtemHTitle.Location = new System.Drawing.Point(643, 0);
            this.labelTemtemHTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemtemHTitle.Name = "labelTemtemHTitle";
            this.labelTemtemHTitle.Size = new System.Drawing.Size(205, 64);
            this.labelTemtemHTitle.TabIndex = 4;
            this.labelTemtemHTitle.Text = "Temtem/h";
            this.labelTemtemHTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeTrackerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeTrackerUI";
            this.Size = new System.Drawing.Size(1278, 64);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label temtemHLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label labelTimeTitle;
        private System.Windows.Forms.Label labelTemtemHTitle;
    }
}
