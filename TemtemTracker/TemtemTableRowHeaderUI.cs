using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemtemTracker
{
    public partial class TemtemTableRowHeaderUI : UserControl
    {
        public event EventHandler<ClickControl> Clickr;

        public Font regular = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public Font bigger = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public Color TextColor = Color.Black;
        public Color HighligthText = Color.Gold;

        public TemtemTableRowHeaderUI()
        {
            InitializeComponent();
        }

        private void processClickr(object sender)
        {
            if (Clickr != null)
            {
                string controlName = (string)sender.GetType().GetProperty("Name").GetValue(sender);
                int controlCode = getControlCode(controlName);

                if (controlCode > -1)
                {
                    this.Clickr(this, new ClickControl
                    {
                        controlName = controlName,
                        code = controlCode
                    });
                }
            }
        }
        private int getControlCode (string strName)
        {
            switch (strName)
            {
                default:
                    return -1;
                case "labelTemtemName":
                    return 0;
                case "labelEncounters":
                    return 1;
                case "labelChanceLuma":
                    return 2;
                case "labelEncounteredPercent":
                    return 3;
                case "labelTimeToLuma":
                    return 4;
            }
        }
        private void resetFonts()
        {
            labelTemtemName.Font = regular; labelTemtemName.ForeColor = TextColor;
            labelEncounters.Font = regular; labelEncounters.ForeColor = TextColor;
            labelChanceLuma.Font = regular; labelChanceLuma.ForeColor = TextColor;
            labelEncounteredPercent.Font = regular; labelEncounteredPercent.ForeColor = TextColor;
            labelTimeToLuma.Font = regular; labelTimeToLuma.ForeColor = TextColor;
        }

        private void labelTemtemName_Click(object sender, EventArgs e)
        {
            processClickr(sender);
            resetFonts();
            labelTemtemName.Font = bigger;
            labelTemtemName.ForeColor = HighligthText;
        }
        private void labelEncounters_Click(object sender, EventArgs e)
        {
            processClickr(sender);
            resetFonts();
            labelEncounters.Font = bigger;
            labelEncounters.ForeColor = HighligthText;
        }
        private void labelChanceLuma_Click(object sender, EventArgs e)
        {
            processClickr(sender);
            resetFonts();
            labelChanceLuma.Font = bigger;
            labelChanceLuma.ForeColor = HighligthText;
        }
        private void labelEncounteredPercent_Click(object sender, EventArgs e)
        {
            processClickr(sender);
            resetFonts();
            labelEncounteredPercent.Font = bigger;
            labelEncounteredPercent.ForeColor = HighligthText;
        }
        private void labelTimeToLuma_Click(object sender, EventArgs e)
        {
            processClickr(sender);
            resetFonts();
            labelTimeToLuma.Font = bigger;
            labelTimeToLuma.ForeColor = HighligthText;
        }
    }

    public class ClickControl : EventArgs
    {
        public string controlName { get; set; }
        public int code { get; set; }
    }
}
