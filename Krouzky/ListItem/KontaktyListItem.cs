#region UsingRegion

using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    internal class KontaktyListItem : ListItem {
        private KontaktniOsoba kontaktniOsoba_;

        public KontaktyListItem(KontaktniOsoba kontaktniOsoba) {
            this.kontaktniOsoba_ = kontaktniOsoba;
            this.setLabelStr($"{kontaktniOsoba.osoba.jmeno} {kontaktniOsoba.osoba.prijmeni}");
        }
    }
}