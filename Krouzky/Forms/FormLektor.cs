#region UsingRegion

using System;
using System.Windows.Forms;
using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    public partial class FormLektor : Form {
        private Lektor lektor;
        private readonly ORM.ORM orm_;

        private bool insert_;

        public FormLektor(Lektor lektor) : this() {
            this.insert_ = lektor == null;
            if (insert_) {
                this.orm_ = ORM.ORM.instance;

                this.jmenoTextBox.Text = ""; //lektor.osoba.jmeno;
                this.prostredniJmenoTextBox.Text = ""; //lektor.osoba.prostredniJmeno;
                this.prijmeniTextBox.Text = ""; //lektor.osoba.prijmeni;
                this.emailTextBox.Text = ""; //lektor.osoba.email;
                this.telefonOsobniTextBox.Text = ""; //lektor.osoba.telefonOsobni;
                this.telefonPracovniTextBox.Text = ""; //lektor.osoba.telefonPracovni;
                this.poznamkaTextBox.Text = ""; //lektor.popis;

                this.celkemHodinTextBox.Text = "0";
            }
            else {
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
                this.mzdaTextBox.Text = "0";
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
                this.mzdaTextBox.Text = "0";
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
                this.hodinTextBox.Text = "0";
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
                this.hodinTextBox.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (this.insert_) {
                lektor = new Lektor();
                this.lektor.idOsoba = orm_.dao.osobaTable.Insert(new Osoba());
                this.lektor.idLektor = orm_.dao.lektorTable.Insert(lektor);
            }

            lektor.osoba.jmeno = jmenoTextBox.Text;
            lektor.osoba.prostredniJmeno = prostredniJmenoTextBox.Text;
            lektor.osoba.prijmeni = prijmeniTextBox.Text;
            lektor.osoba.email = emailTextBox.Text;
            lektor.osoba.telefonOsobni = telefonOsobniTextBox.Text;
            lektor.osoba.telefonPracovni = telefonPracovniTextBox.Text;
            lektor.popis = poznamkaTextBox.Text;

            orm_.dao.osobaTable.Update(this.lektor.osoba);
            orm_.dao.lektorTable.Update(this.lektor);

            this.Close();
        }
    }
}