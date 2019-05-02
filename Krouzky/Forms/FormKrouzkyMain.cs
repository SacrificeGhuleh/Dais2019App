#region UsingRegion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    public partial class FormKrouzkyMain : Form {
        private static readonly Color SelectedBtnColor = SystemColors.ControlLight;
        private static readonly Color UnSelectedBtnColor = SystemColors.Control;
        private readonly ToolTip toolTip_;
        public DateTime curDateTime;

        public ORM.ORM orm_;
        private selectorEnum selected_;
        public DateTime selecteDateTime;

        private int dayRow_ = -1;
        private int dayCol_ = -1;

        public FormKrouzkyMain(ORM.ORM orm) : this() {
            this.orm_ = orm;
            this.populate();
            this.populateCalendar(this.curDateTime);

            this.select(selectorEnum.Lektori);
        }

        public FormKrouzkyMain() {
            this.InitializeComponent();
            this.toolTip_ = new ToolTip();
            this.selecteDateTime = this.curDateTime = DateTime.Today;
        }

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
                case 1: return "Leden";
                case 2: return "Únor";
                case 3: return "Březen";
                case 4: return "Duben";
                case 5: return "Květen";
                case 6: return "Červen";
                case 7: return "Červenec";
                case 8: return "Srpen";
                case 9: return "Září";
                case 10: return "Říjen";
                case 11: return "Listopad";
                case 12: return "Prosinec";
            }

            return string.Empty;
        }

        public void select(selectorEnum e) {
            this.selected_ = e;
            this.selectBtn(e);
            this.selectPanel(e);
            this.populate();
        }

        private void populate(string substr = "") {
            switch (this.selected_) {
                case selectorEnum.Lektori:
                    this.lektoriPanel.Controls.Clear();
                    foreach (Lektor l in this.orm_.dto.lektor) {
                        LektorListItem i = new LektorListItem(l);
                        if (i.getLabelStr().ToLower().Contains(substr.ToLower())) this.lektoriPanel.Controls.Add(i);
                    }

                    break;

                case selectorEnum.Krouzky:
                    this.krouzkyPanel.Controls.Clear();
                    foreach (Krouzek l in this.orm_.dto.krouzek) {
                        KrouzkyListItem i = new KrouzkyListItem(l);
                        if (i.getLabelStr().ToLower().Contains(substr.ToLower())) this.krouzkyPanel.Controls.Add(i);
                    }

                    break;

                case selectorEnum.Skoly:
                    this.skolyPanel.Controls.Clear();
                    foreach (Skola l in this.orm_.dto.skola) {
                        SkolyListItem i = new SkolyListItem(l);
                        if (i.getLabelStr().ToLower().Contains(substr.ToLower())) this.skolyPanel.Controls.Add(i);
                    }

                    break;

                case selectorEnum.Kontakty:
                    this.kontaktyPanel.Controls.Clear();
                    foreach (KontaktniOsoba l in this.orm_.dto.kontaktniOsoba) {
                        KontaktyListItem i = new KontaktyListItem(l);
                        if (i.getLabelStr().ToLower().Contains(substr.ToLower())) this.kontaktyPanel.Controls.Add(i);
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
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
            this.lektoriBtn.BackColor = UnSelectedBtnColor;
            this.krouzkyBtn.BackColor = UnSelectedBtnColor;
            this.skolyBtn.BackColor = UnSelectedBtnColor;
            this.kontaktyBtn.BackColor = UnSelectedBtnColor;

            switch (e) {
                case selectorEnum.Lektori:
                    this.lektoriBtn.BackColor = SelectedBtnColor;
                    break;
                case selectorEnum.Krouzky:
                    this.krouzkyBtn.BackColor = SelectedBtnColor;
                    break;
                case selectorEnum.Skoly:
                    this.skolyBtn.BackColor = SelectedBtnColor;
                    break;
                case selectorEnum.Kontakty:
                    this.kontaktyBtn.BackColor = SelectedBtnColor;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(e), e, null);
            }
        }

        private void lektoriBtn_Click(object sender, EventArgs e) {
            this.select(selectorEnum.Lektori);
        }

        private void krouzkyBtn_Click(object sender, EventArgs e) {
            this.select(selectorEnum.Krouzky);
        }

        private void skolyBtn_Click(object sender, EventArgs e) {
            this.select(selectorEnum.Skoly);
        }

        private void kontaktyBtn_Click(object sender, EventArgs e) {
            this.select(selectorEnum.Kontakty);
        }

        private void calendarMoveLeft_Click(object sender, EventArgs e) {
            this.selecteDateTime = this.selecteDateTime.AddMonths(-1);
            this.populateCalendar(this.selecteDateTime);
        }

        private void calendarMoveRight_Click(object sender, EventArgs e) {
            this.selecteDateTime = this.selecteDateTime.AddMonths(1);
            this.populateCalendar(this.selecteDateTime);
        }

        public void populateCalendar(DateTime dateTime) {
            //BeginControlUpdate(this);
            this.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            this.mesicLabel.Text = $"{getMonthName(dateTime)} {dateTime.Year}".ToUpper();

            this.calendarPanel.Controls.Clear();
            calendarPanel.CellPaint += this.dayCellPaint;

            DateTime today = DateTime.Today;
            DateTime fromDateTime = new DateTime(dateTime.Year, dateTime.Month, 1);
            DateTime toDateTime = fromDateTime.AddMonths(1).AddDays(-1.0);

            int firstRowOffset = getDayNumber(fromDateTime);
            int lastRowOffset = 6 - getDayNumber(toDateTime);

            fromDateTime = fromDateTime.AddDays(-firstRowOffset);
            toDateTime = toDateTime.AddDays(lastRowOffset);


            var krouzky = ORM.ORM.instance.getPlannedAndPassed(fromDateTime, toDateTime, DateTime.Today);

            this.dayRow_ = -1;
            this.dayCol_ = -1;

            Collection<TableLayoutPanel> tablePanels = new Collection<TableLayoutPanel>();
            Collection<TwoCols> twoColsPanels = new Collection<TwoCols>();

            for (int row = 0; row < 5; row++)
            for (int col = 0; col < 7; col++) {
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.MaximumSize = tableLayoutPanel.Size;
                tableLayoutPanel.AutoScroll = true;
                tableLayoutPanel.SuspendLayout();
                tablePanels.Add(tableLayoutPanel);
                if ((row == 0 && col < firstRowOffset) || (row == 4 && col > 6 - lastRowOffset)) {
                    tableLayoutPanel.BackColor = SystemColors.ControlLight;
                }

                CalendarHeaderTwoCols h = new CalendarHeaderTwoCols(fromDateTime);
                tableLayoutPanel.Controls.Add(h);
                twoColsPanels.Add(h);
                h.SuspendLayout();

                foreach (var planned in krouzky.Item1)
                    if (planned.datum.Date.Equals(fromDateTime.Date)) {
                        NaplanovanyTwoCols n = new NaplanovanyTwoCols(planned);
                        twoColsPanels.Add(n);
                        n.SuspendLayout();
                        tableLayoutPanel.Controls.Add(n);
                        this.toolTip_.SetToolTip(n.leftLabel, n.getTooltipText());
                    }

                foreach (var passed in krouzky.Item2)
                    if (passed.datum.Date.Equals(fromDateTime.Date)) {
                        ProbehlyTwoCols p = new ProbehlyTwoCols(passed);
                        twoColsPanels.Add(p);
                        p.SuspendLayout();
                        tableLayoutPanel.Controls.Add(p);
                        this.toolTip_.SetToolTip(p.leftLabel, p.getTooltipText());
                    }

                this.calendarPanel.Controls.Add(tableLayoutPanel, col, row);


                if (fromDateTime.Date.Equals(today.Date)) {
                    this.dayRow_ = row;
                    this.dayCol_ = col;
                }

                fromDateTime = fromDateTime.AddDays(1.0);
                if (fromDateTime > toDateTime) {
                    /*PRASE!*/
                    row = col = 10;
                }
            }

            foreach (var panel in twoColsPanels) {
                panel.ResumeLayout();
            }

            foreach (var panel in tablePanels) {
                panel.ResumeLayout();
            }

            this.calendarPanel.ResumeLayout();
            this.ResumeLayout();
        }

        void dayCellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if (e.Column == this.dayCol_ && e.Row == this.dayRow_) {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 3F), e.CellBounds);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            this.populate(((TextBox) sender).Text);
        }

        private void button1_Click(object sender, EventArgs e) {
            new FormLektor(null).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            this.populate();
        }

        private void button2_Click(object sender, EventArgs e) {
            Control.ControlCollection controls = null;
            //delete selected
            switch (this.selected_) {
                case selectorEnum.Lektori:
                    controls = this.lektoriPanel.Controls;
                    break;
                case selectorEnum.Krouzky:
                    controls = this.krouzkyPanel.Controls;
                    break;
                case selectorEnum.Skoly:
                    controls = this.skolyPanel.Controls;
                    break;
                case selectorEnum.Kontakty:
                    controls = this.kontaktyPanel.Controls;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (controls == null) return;

            foreach (ListItem i in controls) {
                if (i.selected) {
                    try {
                        i.delete();
                    }
                    catch (Exception exception) {
                        Console.WriteLine(exception);
                        MessageBox.Show("Nelze smazat zaznam");
                    }
                }
            }

            this.populate();
        }
    }
}