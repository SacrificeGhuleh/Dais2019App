#region UsingRegion

using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    internal class SkolyListItem : ListItem {
        private Skola skola_;

        public SkolyListItem(Skola skola) {
            this.skola_ = skola;
            this.setLabelStr($"{skola.adresa.ulice} {skola.adresa.cisloPopisne} {skola.adresa.mesto}");
        }
    }
}