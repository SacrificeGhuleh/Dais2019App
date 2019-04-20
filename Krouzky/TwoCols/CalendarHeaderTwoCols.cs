#region UsingRegion

using System;

#endregion

namespace Krouzky {
    internal class CalendarHeaderTwoCols : TwoCols {
        public CalendarHeaderTwoCols(DateTime dateTime) {
            this.InitializeComponent();
            this.rightLabel.Text = $"{dateTime.Day}.{dateTime.Month}.";
            this.leftLabel.Text = getDayStr(dateTime);
            
        }

        public static string getDayStr(DateTime dateTime) {
            switch (dateTime.DayOfWeek) {
                case DayOfWeek.Sunday:
                    return "Ne";
                case DayOfWeek.Monday:
                    return "Po";
                case DayOfWeek.Tuesday:
                    return "Út";
                case DayOfWeek.Wednesday:
                    return "St";
                case DayOfWeek.Thursday:
                    return "Čt";
                case DayOfWeek.Friday:
                    return "Pá";
                case DayOfWeek.Saturday:
                    return "So";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // rightLabel
            // 
            this.rightLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            // 
            // leftLabel
            // 
            this.leftLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}