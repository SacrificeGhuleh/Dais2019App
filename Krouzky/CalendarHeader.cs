using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krouzky {
    using System.Windows.Forms;

    public partial class CalendarHeader : Panel {
        public static string getDayStr(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
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

        public CalendarHeader(DateTime dateTime) : this() {
            this.dateLabel.Text = $"{dateTime.Day}.{dateTime.Month}.";
            this.dayName.Text = getDayStr(dateTime);
        }

        public CalendarHeader() {
            InitializeComponent();

            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dayName);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(115, 4);
            this.Name = "calendarHeader";
            this.Size = new System.Drawing.Size(104, 25);
            this.TabIndex = 0;
        }

        public CalendarHeader(IContainer container) : this() {
            container.Add(this);
        }
    }
}
