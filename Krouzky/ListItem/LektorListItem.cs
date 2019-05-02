#region UsingRegion

using System;
using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    internal class LektorListItem : ListItem {
        private readonly Lektor lektor_;

        public override void delete() {
            ORM.ORM.instance.dao.lektorTable.Delete(this.lektor_.idLektor, "idLektor");
        }

        public LektorListItem(Lektor lektor) {
            this.lektor_ = lektor;
            this.setLabelStr($"{lektor.osoba.jmeno} {lektor.osoba.prijmeni}");
        }

        protected override void nameLabel_DoubleClick(object sender, EventArgs e) {
            new FormLektor(this.lektor_).ShowDialog();
        }
    }
}