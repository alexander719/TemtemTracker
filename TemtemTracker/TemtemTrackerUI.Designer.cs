namespace TemtemTracker
{
    partial class TemtemTrackerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemtemTrackerUI));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TLP_1 = new System.Windows.Forms.TableLayoutPanel();
            this.temtemTableRowHeaderUI = new TemtemTracker.TemtemTableRowHeaderUI();
            this.trackerTable = new System.Windows.Forms.TableLayoutPanel();
            this.temtemTableTotalUI = new TemtemTracker.TemtemTableTotalUI();
            this.timeTracker = new TemtemTracker.TimeTrackerUI();
            this.menuStrip1.SuspendLayout();
            this.TLP_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetTableToolStripMenuItem,
            this.pauseTimerToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveTableToolStripMenuItem,
            this.loadTableToolStripMenuItem,
            this.exportCSVToolStripMenuItem,
            this.toolStripSeparator2,
            this.propertiesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetTableToolStripMenuItem
            // 
            this.resetTableToolStripMenuItem.Name = "resetTableToolStripMenuItem";
            this.resetTableToolStripMenuItem.ShortcutKeyDisplayString = "F6";
            this.resetTableToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.resetTableToolStripMenuItem.Text = "Reset Table";
            this.resetTableToolStripMenuItem.Click += new System.EventHandler(this.ResetTableToolStripMenuItem_Click);
            // 
            // pauseTimerToolStripMenuItem
            // 
            this.pauseTimerToolStripMenuItem.Name = "pauseTimerToolStripMenuItem";
            this.pauseTimerToolStripMenuItem.ShortcutKeyDisplayString = "F8";
            this.pauseTimerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pauseTimerToolStripMenuItem.Text = "Pause Timer";
            this.pauseTimerToolStripMenuItem.Click += new System.EventHandler(this.PauseTimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // saveTableToolStripMenuItem
            // 
            this.saveTableToolStripMenuItem.Name = "saveTableToolStripMenuItem";
            this.saveTableToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveTableToolStripMenuItem.Text = "Save As";
            this.saveTableToolStripMenuItem.Click += new System.EventHandler(this.SaveTableToolStripMenuItem_Click);
            // 
            // loadTableToolStripMenuItem
            // 
            this.loadTableToolStripMenuItem.Name = "loadTableToolStripMenuItem";
            this.loadTableToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadTableToolStripMenuItem.Text = "Load";
            this.loadTableToolStripMenuItem.Click += new System.EventHandler(this.LoadTableToolStripMenuItem_Click);
            // 
            // exportCSVToolStripMenuItem
            // 
            this.exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            this.exportCSVToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportCSVToolStripMenuItem.Text = "Export CSV";
            this.exportCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportCSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.propertiesToolStripMenuItem.Text = "Settings";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.PropertiesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip";
            // 
            // TLP_1
            // 
            this.TLP_1.AutoSize = true;
            this.TLP_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_1.ColumnCount = 1;
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_1.Controls.Add(this.temtemTableRowHeaderUI, 0, 0);
            this.TLP_1.Controls.Add(this.trackerTable, 0, 1);
            this.TLP_1.Controls.Add(this.temtemTableTotalUI, 0, 2);
            this.TLP_1.Controls.Add(this.timeTracker, 0, 3);
            this.TLP_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_1.Location = new System.Drawing.Point(0, 24);
            this.TLP_1.Name = "TLP_1";
            this.TLP_1.RowCount = 4;
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLP_1.Size = new System.Drawing.Size(762, 390);
            this.TLP_1.TabIndex = 3;
            // 
            // temtemTableRowHeaderUI
            // 
            this.temtemTableRowHeaderUI.AutoSize = true;
            this.temtemTableRowHeaderUI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.temtemTableRowHeaderUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temtemTableRowHeaderUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temtemTableRowHeaderUI.Location = new System.Drawing.Point(2, 2);
            this.temtemTableRowHeaderUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.temtemTableRowHeaderUI.Name = "temtemTableRowHeaderUI";
            this.temtemTableRowHeaderUI.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temtemTableRowHeaderUI.Size = new System.Drawing.Size(758, 27);
            this.temtemTableRowHeaderUI.TabIndex = 1;
            this.temtemTableRowHeaderUI.Clickr += new System.EventHandler<TemtemTracker.ClickControl>(this.temtemTableRowHeaderUI_Clickr);
            // 
            // trackerTable
            // 
            this.trackerTable.AutoScroll = true;
            this.trackerTable.AutoSize = true;
            this.trackerTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackerTable.ColumnCount = 1;
            this.trackerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.trackerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackerTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackerTable.Location = new System.Drawing.Point(2, 29);
            this.trackerTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackerTable.Name = "trackerTable";
            this.trackerTable.RowCount = 1;
            this.trackerTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.trackerTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.trackerTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.trackerTable.Size = new System.Drawing.Size(758, 303);
            this.trackerTable.TabIndex = 3;
            // 
            // temtemTableTotalUI
            // 
            this.temtemTableTotalUI.AutoSize = true;
            this.temtemTableTotalUI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.temtemTableTotalUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temtemTableTotalUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temtemTableTotalUI.Location = new System.Drawing.Point(2, 335);
            this.temtemTableTotalUI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.temtemTableTotalUI.Name = "temtemTableTotalUI";
            this.temtemTableTotalUI.Size = new System.Drawing.Size(758, 23);
            this.temtemTableTotalUI.TabIndex = 4;
            // 
            // timeTracker
            // 
            this.timeTracker.AutoSize = true;
            this.timeTracker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timeTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTracker.Location = new System.Drawing.Point(2, 363);
            this.timeTracker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeTracker.Name = "timeTracker";
            this.timeTracker.Size = new System.Drawing.Size(758, 25);
            this.timeTracker.TabIndex = 5;
            // 
            // TemtemTrackerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(762, 414);
            this.Controls.Add(this.TLP_1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "TemtemTrackerUI";
            this.Text = "TemtemTracker";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.TemtemTrackerUI_Shown);
            this.ResizeEnd += new System.EventHandler(this.TemtemTrackerUI_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TLP_1.ResumeLayout(false);
            this.TLP_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TLP_1;
        private TemtemTableRowHeaderUI temtemTableRowHeaderUI;
        private System.Windows.Forms.TableLayoutPanel trackerTable;
        private TemtemTableTotalUI temtemTableTotalUI;
        private TimeTrackerUI timeTracker;
    }
}

