using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Windows_Timer
{
    public class PartOfTimer
    {
        private uint maxValue;
        public enum TimerPart
        {
            Seconds,
            Minutes,
            Hours
        }

        public PartOfTimer(TimerPart part)
        {
            switch (part)
            {
                case TimerPart.Seconds:
                case TimerPart.Minutes:
                    maxValue = 59;
                    break;
                case TimerPart.Hours:
                    maxValue = 99;
                    break;
            }
        }
    }
}
