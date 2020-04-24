﻿namespace TemtemTracker
{
    partial class TemtemTableRowUI
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
            this.buttonShowIndividualWindow = new System.Windows.Forms.Button();
            this.labelEncounteredPercent = new System.Windows.Forms.Label();
            this.labelChanceLuma = new System.Windows.Forms.Label();
            this.labelEncounters = new System.Windows.Forms.Label();
            this.labelTemtemName = new System.Windows.Forms.Label();
            this.labelTimeToLuma = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.334721F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.334721F));
            this.tableLayoutPanel1.Controls.Add(this.buttonShowIndividualWindow, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEncounteredPercent, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelChanceLuma, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEncounters, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTemtemName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTimeToLuma, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonShowIndividualWindow
            // 
            this.buttonShowIndividualWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowIndividualWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowIndividualWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowIndividualWindow.Location = new System.Drawing.Point(509, 2);
            this.buttonShowIndividualWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowIndividualWindow.Name = "buttonShowIndividualWindow";
            this.buttonShowIndividualWindow.Size = new System.Drawing.Size(30, 21);
            this.buttonShowIndividualWindow.TabIndex = 6;
            this.buttonShowIndividualWindow.Text = "W";
            this.buttonShowIndividualWindow.UseVisualStyleBackColor = true;
            this.buttonShowIndividualWindow.Click += new System.EventHandler(this.ButtonShowIndividualWindow_Click);
            // 
            // labelEncounteredPercent
            // 
            this.labelEncounteredPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEncounteredPercent.AutoSize = true;
            this.labelEncounteredPercent.Location = new System.Drawing.Point(279, 6);
            this.labelEncounteredPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEncounteredPercent.Name = "labelEncounteredPercent";
            this.labelEncounteredPercent.Size = new System.Drawing.Size(79, 13);
            this.labelEncounteredPercent.TabIndex = 5;
            this.labelEncounteredPercent.Text = "Encountered %";
            // 
            // labelChanceLuma
            // 
            this.labelChanceLuma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChanceLuma.AutoSize = true;
            this.labelChanceLuma.Location = new System.Drawing.Point(191, 6);
            this.labelChanceLuma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChanceLuma.Name = "labelChanceLuma";
            this.labelChanceLuma.Size = new System.Drawing.Size(73, 13);
            this.labelChanceLuma.TabIndex = 4;
            this.labelChanceLuma.Text = "Chance Luma";
            // 
            // labelEncounters
            // 
            this.labelEncounters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEncounters.AutoSize = true;
            this.labelEncounters.Location = new System.Drawing.Point(106, 6);
            this.labelEncounters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEncounters.Name = "labelEncounters";
            this.labelEncounters.Size = new System.Drawing.Size(61, 13);
            this.labelEncounters.TabIndex = 3;
            this.labelEncounters.Text = "Encounters";
            // 
            // labelTemtemName
            // 
            this.labelTemtemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTemtemName.AutoSize = true;
            this.labelTemtemName.Location = new System.Drawing.Point(23, 6);
            this.labelTemtemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemtemName.Name = "labelTemtemName";
            this.labelTemtemName.Size = new System.Drawing.Size(45, 13);
            this.labelTemtemName.TabIndex = 2;
            this.labelTemtemName.Text = "Temtem";
            // 
            // labelTimeToLuma
            // 
            this.labelTimeToLuma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeToLuma.AutoSize = true;
            this.labelTimeToLuma.Location = new System.Drawing.Point(374, 6);
            this.labelTimeToLuma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeToLuma.Name = "labelTimeToLuma";
            this.labelTimeToLuma.Size = new System.Drawing.Size(71, 13);
            this.labelTimeToLuma.TabIndex = 1;
            this.labelTimeToLuma.Text = "Time to Luma";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(462, 2);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(30, 21);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TemtemTableRowUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TemtemTableRowUI";
            this.Size = new System.Drawing.Size(553, 29);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEncounteredPercent;
        private System.Windows.Forms.Label labelChanceLuma;
        private System.Windows.Forms.Label labelEncounters;
        private System.Windows.Forms.Label labelTimeToLuma;
        private System.Windows.Forms.Label labelTemtemName;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button buttonShowIndividualWindow;
    }
}
