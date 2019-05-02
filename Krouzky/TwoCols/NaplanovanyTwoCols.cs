#region UsingRegion

using System;
using System.Drawing;
using System.Linq;
using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    internal class NaplanovanyTwoCols : TwoCols {
        private readonly KonkretniKrouzekPrototype planned_;

        public NaplanovanyTwoCols(KonkretniKrouzekPrototype planned) {
            this.InitializeComponent();
            this.planned_ = planned;
            string cityName = this.planned_.krouzek.skola.adresa.mesto;

            if (cityName.Contains('-')) cityName = cityName.Substring(0, cityName.IndexOf('-'));
            if (cityName.Contains(' ')) cityName = cityName.Substring(0, cityName.IndexOf(' '));
            this.leftLabel.Text = cityName;
            this.rightLabel.Text = planned.krouzek.casKonaniOd.ToString("HH:mm");
        }

        public string getTooltipText() {
            try {
                return
                    $"Naplanovany krouzek\n" +
                    $"ID: {this.planned_.krouzek.idKrouzek}\n" +
                    $"{this.planned_.krouzek.pravidelnost.popis}\n" +
                    $"{this.planned_.krouzek.skola.adresa.mesto}\n" +
                    $"{this.planned_.krouzek.skola.adresa.ulice} {this.planned_.krouzek.skola.adresa.cisloPopisne}\n" +
                    $"{this.planned_.krouzek.casKonaniOd.ToString("HH:mm")} - {this.planned_.krouzek.casKonaniDo.ToString("HH:mm")}";
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return $"Naplanovany krouzek\n" +
                       $"ID: {this.planned_.krouzek.idKrouzek}\n" +
                       $"NULL POINTER EXCEPTION";
                //throw;
            }
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // NaplanovanyTwoCols
            // 
            this.BackColor = SystemColors.Control;
            this.ResumeLayout(false);
        }
    }
}