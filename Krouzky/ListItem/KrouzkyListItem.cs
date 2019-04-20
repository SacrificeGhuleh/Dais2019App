#region UsingRegion

using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    internal class KrouzkyListItem : ListItem {
        private Krouzek krouzek_;

        public KrouzkyListItem(Krouzek krouzek) {
            this.krouzek_ = krouzek;
            this.setLabelStr(
                $"{krouzek.denVTydnu.popis} {krouzek.pravidelnost.popis} {krouzek.casKonaniOd.ToString("HH:mm")} - {krouzek.casKonaniDo.ToString("HH:mm")} {krouzek.skola.adresa.mesto} {krouzek.skola.adresa.ulice} {krouzek.skola.adresa.cisloPopisne}");
        }
    }
}