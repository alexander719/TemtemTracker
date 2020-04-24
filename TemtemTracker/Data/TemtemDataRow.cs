using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemtemTracker.Data
{
    public class TemtemDataRow
    {
        public String name;
        public int encountered;
        public double lumaChance;
        public double encounteredPercent;
        public long timeToLuma;
    }


    public class TemtemDataRowforSorting : TemtemDataRow
    {
        public int controlTop;
        public TemtemTableRowUI element;
    }

    public class sortBuffer
    {
        public int code = -1;
        public bool ShiftAscendingDescending = true;
        public bool DefaultSorting = true;
    }
}
