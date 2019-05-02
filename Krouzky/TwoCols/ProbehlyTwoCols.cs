#region UsingRegion

using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Krouzky.ORM.Database.DTO;

#endregion

namespace Krouzky {
    internal class ProbehlyTwoCols : TwoCols {
        private readonly KonkretniKrouzek passed_;

        private static readonly Color zrusenyColor_ = System.Drawing.Color.FromArgb(((int) (((byte) (255)))),
            ((int) (((byte) (192)))), ((int) (((byte) (192)))));

        private static readonly Color probehlyColor_ = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
            ((int) (((byte) (255)))), ((int) (((byte) (192)))));

        public ProbehlyTwoCols(KonkretniKrouzek passed) {
            this.InitializeComponent();
            this.passed_ = passed;
            string cityName = this.passed_.krouzek.skola.adresa.mesto;

            if (cityName.Contains('-')) cityName = cityName.Substring(0, cityName.IndexOf('-'));

            if (cityName.Contains(' ')) cityName = cityName.Substring(0, cityName.IndexOf(' '));

            this.leftLabel.Text = cityName;
            this.rightLabel.Text = passed.krouzek.casKonaniOd.ToString("HH:mm");

            if (this.passed_.zrusen) {
                this.BackColor = zrusenyColor_;
                this.leftLabel.BackColor = zrusenyColor_;
                this.rightLabel.BackColor = zrusenyColor_;
            }
            else {
                this.BackColor = probehlyColor_;
                this.leftLabel.BackColor = probehlyColor_;
                this.rightLabel.BackColor = probehlyColor_;
            }
        }

        public string getTooltipText() {
            return
                $"Probehly krouzek\nID:{this.passed_.krouzek.idKrouzek}\n{this.passed_.krouzek.pravidelnost.popis}\n{this.passed_.krouzek.skola.adresa.mesto}\n{this.passed_.krouzek.skola.adresa.ulice} {this.passed_.krouzek.skola.adresa.cisloPopisne}\n{this.passed_.krouzek.casKonaniOd.ToString("HH:mm")} - {this.passed_.krouzek.casKonaniDo.ToString("HH:mm")}";
        }


        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // rightLabel
            // 
            this.rightLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightLabel.Margin = new System.Windows.Forms.Padding(3);
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leftLabel
            // 
            this.leftLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftLabel.Margin = new System.Windows.Forms.Padding(3);
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // ProbehlyTwoCols
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}