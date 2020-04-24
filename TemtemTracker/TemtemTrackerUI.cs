using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemtemTracker;
using TemtemTracker.Controllers;
using TemtemTracker.Data;

namespace TemtemTracker
{
    public partial class TemtemTrackerUI : Form
    {
        private delegate void AddRowDelegate(TemtemTableRowUI row);
        private delegate void TimerPauseDelegate(object sender, bool TimerState);
        private delegate void StyleChangeDelegate(object sender, Style windowStyle);
        private delegate void OpacityChangeDelegate(object sender, double opacity);
        private SettingsController settingsController;
        private TemtemTableController tableController;
        private readonly AboutWindow aboutWindow;
        private Style style;

        public TemtemTrackerUI(SettingsController settingsController)
        {
            InitializeComponent();
            aboutWindow = new AboutWindow();
            this.Width = settingsController.GetUserSettings().mainWindowWidth;
            this.Height = settingsController.GetUserSettings().mainWindowHeight;
            this.Opacity = settingsController.GetUserSettings().mainWindowOpacity;
            settingsController.TimerPausedToggled += TogglePauseTimerUIIndication;
            this.settingsController = settingsController;
            settingsController.StyleChanged += SetWindowStyle;
            settingsController.MainWindowOpacityChanged += SetWindowOpacity;
            SetWindowStyle(null, settingsController.GetWindowStyle());
        }
        public void SetSettingsController(SettingsController settingsController)
        {
            this.settingsController = settingsController;
        }
        public void SetTableController(TemtemTableController tableController)
        {
            this.tableController = tableController;
        }

        public void AddRowToTable(TemtemTableRowUI row)
        {
            if (this.InvokeRequired)
            {
                AddRowDelegate d = new AddRowDelegate(AddRowToTable);
                this.Invoke(d, new object[] { row });
            }
            else
            {
                trackerTable.Controls.Add(row);
            } 
        }
        public void RemoveRowFromTable(TemtemTableRowUI row)
        {
            trackerTable.Controls.Remove(row);
        }

        private void SetWindowOpacity(object sender, double opacity)
        {
            if (this.InvokeRequired)
            {
                OpacityChangeDelegate d = new OpacityChangeDelegate(SetWindowOpacity);
                this.Invoke(d, new object[] { sender, opacity });
            }
            else
            {
                this.Opacity = opacity;
            }         
        }
        public void RecolorTableRows()
        {
            int i = 1;
            foreach (TemtemTableRowUI r in trackerTable.Controls)
            {
                if (i % 2 == 0)
                {
                    r.SetLight(style);
                }
                else
                {
                    r.SetDark(style);
                }
                i++;
            }
        }
        public void RemoveAllTableRows()
        {
            trackerTable.Controls.Clear();
        }

        public void SetTotal(TemtemDataRow totalRow)
        {
            temtemTableTotalUI.SetTotal(totalRow);
        }

        public void UpdateTotal()
        {
            temtemTableTotalUI.UpdateRow();
        }
        public void UpdateTime(long timeMilis)
        {
            absolute_timeMilis = timeMilis;
            timeTracker.UpdateTime(timeMilis);
            updateWindowTextInformation();
        }
        public void UpdateTemtemH(double temtemH)
        {
            absolute_temtemH = temtemH;
            timeTracker.UpdateTemtemH(temtemH);
            updateWindowTextInformation();
        }

        public void SetMenuStripHotkeyStrings(string resetTableHotkey, string pauseTimerHotkey)
        {
            resetTableToolStripMenuItem.ShortcutKeyDisplayString = resetTableHotkey;
            pauseTimerToolStripMenuItem.ShortcutKeyDisplayString = pauseTimerHotkey;
        }

        public void TogglePauseTimerUIIndication(object sender, bool timerState)
        {
            if (this.InvokeRequired)
            {
                TimerPauseDelegate d = new TimerPauseDelegate(TogglePauseTimerUIIndication);
                this.Invoke(d, new object[] { sender, timerState });
            }
            else
            {
                if (timerState)
                {
                    pauseTimerToolStripMenuItem.Text = "Pause timer";
                }
                else
                {
                    pauseTimerToolStripMenuItem.Text = "Unpause timer";
                }
                updateWindowTextInformation(!timerState);
                timeTracker.SetPausedVisualIndication(timerState);
            } 
        }
        private void SetWindowStyle(object sender, Style style)
        {
            if (this.InvokeRequired)
            {
                StyleChangeDelegate d = new StyleChangeDelegate(SetWindowStyle);
                this.Invoke(d, new object[] { sender, style });
            }
            else
            {
                //Set the style
                this.style = style;
                //Set the foreground and background colors
                this.BackColor = ColorTranslator.FromHtml(style.trackerBackground);
                this.ForeColor = ColorTranslator.FromHtml(style.trackerForeground);
                temtemTableRowHeaderUI.TextColor = ColorTranslator.FromHtml(style.trackerForeground);
                temtemTableRowHeaderUI.HighligthText = ColorTranslator.FromHtml(style.timerPausedForeground);

                //Create a custom color table for the menu and set the colors
                CustomMenuColorTable colorTable = new CustomMenuColorTable(style);
                menuStrip1.Renderer = new ToolStripProfessionalRenderer(colorTable);
                menuStrip1.BackColor = ColorTranslator.FromHtml(style.menuStripBackground);
                menuStrip1.ForeColor = ColorTranslator.FromHtml(style.menuStripForeground);
                //Set the colors of items in the menu strip
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                {
                    foreach (ToolStripItem dropdownItem in item.DropDownItems)
                    {
                        dropdownItem.ForeColor = ColorTranslator.FromHtml(style.menuStripForeground);
                    }
                    item.ForeColor = ColorTranslator.FromHtml(style.menuStripForeground);
                }
                //Recolor the table rows
                RecolorTableRows();
                //Set the time tracker UI style
                timeTracker.SetStyle(style);
            }
        }

        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsController.ShowSettingsWindow();
        }

        private void ResetTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableController.ResetTable();
        }

        private void PauseTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsController.ToggleTimerPaused();
        }

        private void TemtemTrackerUI_ResizeEnd(object sender, EventArgs e)
        {
            settingsController.SetMainWindowSize(this.Size);
        }

        private void LoadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "json files (*.json)|*.json",
                FilterIndex = 0,
                RestoreDirectory = true
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Reset the table. This is necessary because loading adds elements to the UI
                //so we need to clear the UI first
                tableController.ResetTable();
                //Load the table from the provided file
                tableController.LoadTableFromFile(openFile.FileName);
            }
        }

        private void SaveTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "json files (*.json)|*.json",
                FilterIndex = 0,
                RestoreDirectory = true
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                tableController.SaveTableAs(saveDialog.FileName);
            }
        }

        private void ExportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportDialog = new SaveFileDialog
            {
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 0,
                RestoreDirectory = true
            };
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                tableController.ExportCSV(exportDialog.FileName);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow.Show();
        }

        #region ADDED STUFF
        private delegate void Function();
        private long absolute_timeMilis = 0;
        private double absolute_temtemH = 0.0;
        private sortBuffer sort_buffer = new sortBuffer();

        private void updateWindowTextInformation(bool paused = false)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Function( delegate () { updateWindowTextInformation(paused); }));
            }
            else
            {
                string defaultText = "TemtemTracker";
                TimeSpan ts = TimeSpan.FromMilliseconds(absolute_timeMilis);
                string formatTime = ((int)ts.TotalHours).ToString("00") + ts.ToString(@"\:mm\:ss");
                string temtemH = Math.Round(absolute_temtemH, 2).ToString();

                if (paused)
                {
                    this.Text = $"{defaultText} -PAUSED- Time: {formatTime}, Temtem/h: {temtemH}";
                }
                else
                {
                    this.Text = $"{defaultText} - Time: {formatTime}, Temtem/h: {temtemH}";
                }
            }
        }

        private void temtemTableRowHeaderUI_Clickr(object sender, ClickControl e)
        {
            if (trackerTable.Controls.Count > 0)
            {
                sort_buffer.DefaultSorting = false;
                if (sort_buffer.code != e.code)
                {
                    // setting the code for sorting kind and ascending by default
                    sort_buffer.code = e.code;
                    sort_buffer.ShiftAscendingDescending = true;
                }
                else
                {
                    // setting how to sort elements ascending or descending
                    sort_buffer.ShiftAscendingDescending = !sort_buffer.ShiftAscendingDescending;
                }

                sortingTableRows();
            }
        }

        public void sortingTableRows()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Function(delegate () { sortingTableRows(); }));
            }
            else
            {
                if (sort_buffer.DefaultSorting) { RecolorTableRows(); return; }

                // top_index save an original index structure
                List<int> top_index = new List<int>();
                // copy existing elements for process
                List<TemtemDataRowforSorting> rows_elements = new List<TemtemDataRowforSorting>();

                foreach (TemtemTableRowUI ctrl in trackerTable.Controls)
                {
                    rows_elements.Add(new TemtemDataRowforSorting
                    {
                        controlTop = ctrl.Top,
                        element = ctrl,

                        name = ctrl.row.name,
                        encountered = ctrl.row.encountered,
                        encounteredPercent = ctrl.row.encounteredPercent,
                        lumaChance = ctrl.row.lumaChance,
                        timeToLuma = ctrl.row.timeToLuma,
                    });

                    top_index.Add(ctrl.Top);
                }

                // sorting
                switch (sort_buffer.code)
                {
                    case 0: // by name
                        if (sort_buffer.ShiftAscendingDescending)
                        {
                            rows_elements = rows_elements.OrderBy(X => X.name).ToList();
                        }
                        else
                        {
                            rows_elements = rows_elements.OrderByDescending(X => X.name).ToList();
                        }
                        break;
                    case 1: // by encounters - next name
                        if (sort_buffer.ShiftAscendingDescending)
                        {
                            rows_elements = rows_elements.OrderByDescending(X => X.encountered).ThenBy(X => X.name).ToList();
                        }
                        else
                        {
                            rows_elements = rows_elements.OrderBy(X => X.encountered).ThenByDescending(X => X.name).ToList();
                        }
                        break;
                    case 2: // by luma chance - next name
                        if (sort_buffer.ShiftAscendingDescending)
                        {
                            rows_elements = rows_elements.OrderByDescending(X => X.lumaChance).ThenBy(X => X.name).ToList();
                        }
                        else
                        {
                            rows_elements = rows_elements.OrderBy(X => X.lumaChance).ThenByDescending(X => X.name).ToList();
                        }
                        break;
                    case 3: // by encountered Percentaje - next name
                        if (sort_buffer.ShiftAscendingDescending)
                        {
                            rows_elements = rows_elements.OrderByDescending(X => X.encounteredPercent).ThenBy(X => X.name).ToList();
                        }
                        else
                        {
                            rows_elements = rows_elements.OrderBy(X => X.encounteredPercent).ThenByDescending(X => X.name).ToList();
                        }

                        break;
                    case 4: // by time to luma - next name
                        if (sort_buffer.ShiftAscendingDescending)
                        {
                            rows_elements = rows_elements.OrderByDescending(X => X.timeToLuma).ThenBy(X => X.name).ToList();
                        }
                        else
                        {
                            rows_elements = rows_elements.OrderBy(X => X.timeToLuma).ThenByDescending(X => X.name).ToList();
                        }
                        break;
                }
                // check if its really necesary to reorder, useful to skip the process, for example when only data is updated
                bool reorder = false;
                for (int x = 0; x < rows_elements.Count; x++)
                {
                    if (rows_elements[x].controlTop != top_index[x])
                    {
                        reorder = true;
                        break;
                    }
                }


                if (reorder)
                {
                    // remove existing elements
                    trackerTable.Controls.Clear();

                    // add new elements with new sorting list
                    for (int i = 0; i < rows_elements.Count; i++)
                    {
                        trackerTable.Controls.Add(rows_elements[i].element);
                    }
                }

                RecolorTableRows();
            }
        }

        private void TemtemTrackerUI_Shown(object sender, EventArgs e)
        {
            // recalculate and measure text (usefull for high dpi screens upscale)
            System.Drawing.Size textRow = TextRenderer.MeasureText("AgujaL", temtemTableRowHeaderUI.bigger);

            TLP_1.RowStyles[0] = new RowStyle(SizeType.Absolute, (float)Math.Round((textRow.Height * 1.4)));

            TLP_1.RowStyles[2] = new RowStyle(SizeType.Absolute, (float)Math.Round((textRow.Height * 1.25)));
            TLP_1.RowStyles[3] = new RowStyle(SizeType.Absolute, (float)Math.Round((textRow.Height * 1.4)));
        }
        #endregion



    }
}
