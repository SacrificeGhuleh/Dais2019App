#region UsingRegion

using System;
using System.Windows.Forms;
using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    public partial class FormLektor : Form {
        private readonly Lektor lektor;
        private readonly ORM.ORM orm_;

        public FormLektor(Lektor lektor) : this() {
            this.lektor = lektor;
            this.orm_ = ORM.ORM.instance;

            this.jmenoTextBox.Text = lektor.osoba.jmeno;
            this.prostredniJmenoTextBox.Text = lektor.osoba.prostredniJmeno;
            this.prijmeniTextBox.Text = lektor.osoba.prijmeni;
            this.emailTextBox.Text = lektor.osoba.email;
            this.telefonOsobniTextBox.Text = lektor.osoba.telefonOsobni;
            this.telefonPracovniTextBox.Text = lektor.osoba.telefonPracovni;
            this.poznamkaTextBox.Text = lektor.popis;

            this.celkemHodinTextBox.Text = Convert.ToString(this.orm_.calculateHoursTotal(lektor.idLektor));
        }

        public FormLektor() {
            this.InitializeComponent();
        }

        private static int getMonth(string month) {
            switch (month.ToLower()) {
                case "leden":
                    return 1;
                case "únor":
                    return 2;
                case "březen":
                    return 3;
                case "duben":
                    return 4;
                case "květen":
                    return 5;
                case "červen":
                    return 6;
                case "červenec":
                    return 7;
                case "srpen":
                    return 8;
                case "září":
                    return 9;
                case "říjen":
                    return 10;
                case "listopad":
                    return 11;
                case "prosinec":
                    return 12;
            }

            return -1;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mzdaMesicCombo_SelectionChangeCommitted(object sender, EventArgs e) {
            try {
                DateTime dateTime = new DateTime(int.Parse(this.mzdaRokCombo.Text),
                    getMonth(this.mzdaMesicCombo.Text), 1);
                this.mzdaTextBox.Text =
                    Convert.ToString(this.orm_.calculateSalary(dateTime, dateTime.AddMonths(1), this.lektor.idLektor));
            }
            catch (Exception) {
            }
        }

        private void mzdaRokCombo_SelectionChangeCommitted(object sender, EventArgs e) {
            try {
                DateTime dateTime = new DateTime(int.Parse(this.mzdaRokCombo.Text),
                    getMonth(this.mzdaMesicCombo.Text), 1);
                this.mzdaTextBox.Text =
                    Convert.ToString(this.orm_.calculateSalary(dateTime, dateTime.AddMonths(1), this.lektor.idLektor));
            }
            catch (Exception) {
            }
        }

        private void hodinMesicCombo_SelectionChangeCommitted(object sender, EventArgs e) {
            try {
                DateTime dateTime = new DateTime(int.Parse(this.mzdaRokCombo.Text),
                    getMonth(this.mzdaMesicCombo.Text), 1);
                this.hodinTextBox.Text =
                    Convert.ToString(this.orm_.calculateHoursInPeriod(dateTime, dateTime.AddMonths(1),
                        this.lektor.idLektor));
            }
            catch (Exception) {
            }
        }

        private void hodinRokCombo_SelectionChangeCommitted(object sender, EventArgs e) {
            try {
                DateTime dateTime = new DateTime(int.Parse(this.mzdaRokCombo.Text),
                    getMonth(this.mzdaMesicCombo.Text), 1);
                this.hodinTextBox.Text =
                    Convert.ToString(this.orm_.calculateHoursInPeriod(dateTime, dateTime.AddMonths(1),
                        this.lektor.idLektor));
            }
            catch (Exception) {
            }
        }
    }
}