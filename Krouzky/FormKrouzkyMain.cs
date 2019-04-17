using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krouzky {
    using System.Threading;
    using Krouzky.ORM.Database.DTO;

    public partial class FormKrouzkyMain : Form {
        private selectorEnum selected;

        public static int getDayNumber(DateTime dateTime) {
            switch (dateTime.DayOfWeek) {
                case DayOfWeek.Sunday:
                    return 6;
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string getMonthName(DateTime dateTime) {
            switch (dateTime.Month) {
                case 1:  return "Leden";
                case 2:  return "Únor";
                case 3:  return "Březen";
                case 4:  return "Duben";
                case 5:  return "Květen";
                case 6:  return "Červen";
                case 7:  return "Červenec";
                case 8:  return "Srpen";
                case 9:  return "Září";
                case 10: return "Říjen";
                case 11: return "Listopad";
                case 12: return "Prosinec";
            }

            return String.Empty;
        }

        public Krouzky.ORM.ORM orm_;
        public DateTime curDateTime;
        public DateTime selecteDateTime;

        public void select(selectorEnum e) {
            selected = e;
            selectBtn(e);
            selectPanel(e);
        }

        void populate(string substr = "") {
            switch (selected) {
                case selectorEnum.Lektori:
                    this.lektoriPanel.Controls.Clear();
                    foreach (Lektor l in this.orm_.dto.lektor) {
                        if ((l.osoba.jmeno + l.osoba.prijmeni).ToLower().Contains(substr.ToLower())) {
                            this.lektoriPanel.Controls.Add(new ListItem(l));
                        }
                    }

                    break;

                case selectorEnum.Krouzky:
                    this.krouzkyPanel.Controls.Clear();
                    break;

                case selectorEnum.Skoly:
                    this.skolyPanel.Controls.Clear();
                    break;

                case selectorEnum.Kontakty:
                    this.lektoriPanel.Controls.Clear();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public FormKrouzkyMain(ORM.ORM orm) : this() {
            this.orm_ = orm;
            this.populate();
            populateCalendar(this.curDateTime);
        }

        public FormKrouzkyMain() {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            this.select(selectorEnum.Lektori);
            this.selecteDateTime = this.curDateTime = DateTime.Today;
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private static Color selectedBtnColor = System.Drawing.Color.FromArgb(81, 85, 92);
        private static Color unSelectedBtnColor = System.Drawing.Color.FromArgb(41, 44, 51);

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void selectPanel(selectorEnum e) {
            this.lektoriPanel.Visible = false;
            this.kontaktyPanel.Visible = false;
            this.krouzkyPanel.Visible = false;
            this.skolyPanel.Visible = false;

            switch (e) {
                case selectorEnum.Lektori:
                    this.lektoriPanel.Visible = true;
                    break;
                case selectorEnum.Krouzky:
                    this.krouzkyPanel.Visible = true;
                    break;
                case selectorEnum.Skoly:
                    this.skolyPanel.Visible = true;
                    break;
                case selectorEnum.Kontakty:
                    this.kontaktyPanel.Visible = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(e), e, null);
            }
        }

        public void selectBtn(selectorEnum e) {
            this.lektoriBtn.BackColor = unSelectedBtnColor;
            this.krouzkyBtn.BackColor = unSelectedBtnColor;
            this.skolyBtn.BackColor = unSelectedBtnColor;
            this.kontaktyBtn.BackColor = unSelectedBtnColor;

            switch (e) {
                case selectorEnum.Lektori:
                    this.lektoriBtn.BackColor = selectedBtnColor;
                    break;
                case selectorEnum.Krouzky:
                    this.krouzkyBtn.BackColor = selectedBtnColor;
                    break;
                case selectorEnum.Skoly:
                    this.skolyBtn.BackColor = selectedBtnColor;
                    break;
                case selectorEnum.Kontakty:
                    this.kontaktyBtn.BackColor = selectedBtnColor;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(e), e, null);
            }
        }

        private void lektoriBtn_Click(object sender, EventArgs e) {
            select(selectorEnum.Lektori);
        }

        private void krouzkyBtn_Click(object sender, EventArgs e) {
            select(selectorEnum.Krouzky);
        }

        private void skolyBtn_Click(object sender, EventArgs e) {
            select(selectorEnum.Skoly);
        }

        private void kontaktyBtn_Click(object sender, EventArgs e) {
            select(selectorEnum.Kontakty);
        }

        private void calendarMoveLeft_Click(object sender, EventArgs e) {
            this.selecteDateTime = this.selecteDateTime.AddMonths(-1);
            populateCalendar(this.selecteDateTime);
        }

        private void calendarMoveRight_Click(object sender, EventArgs e) {
            this.selecteDateTime = this.selecteDateTime.AddMonths(1);
            populateCalendar(this.selecteDateTime);
        }

        public void populateCalendar(DateTime dateTime) {
            //BeginControlUpdate(this);
            this.SuspendLayout();
            this.mesicLabel.Text = $"{getMonthName(dateTime)} {dateTime.Year}".ToUpper();

            this.calendarPanel.Controls.Clear();

            DateTime fromDateTime = new DateTime(dateTime.Year, dateTime.Month, 1);

            /*SORRY*/
            DateTime toDateTime = fromDateTime.AddMonths(1).AddDays(-1.0);

            bool first = true;
            //this.SuspendLayout();
            //this.calendarPanel.SuspendLayout();
            for (int row = 0; row < 5; row++) {
                for (int col = 0; col < 7; col++) {
                    if (first) {
                        col = getDayNumber(fromDateTime);
                    }

                    first = false;
                    this.calendarPanel.Controls.Add(new CalendarHeader(fromDateTime) /*TODO*/, col, row);
                    fromDateTime = fromDateTime.AddDays(1.0);
                    if (fromDateTime > toDateTime) {
                        return;
                    }
                }
            }

            //EndControlUpdate(this);
            //this.calendarPanel.ResumeLayout(false);
            this.ResumeLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            this.populate(((TextBox) sender).Text);
        }
    }
}
