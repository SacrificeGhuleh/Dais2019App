namespace Krouzky
{
    partial class CalendarHeader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel.Location = new System.Drawing.Point(52, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 25);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "1.1.";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayName
            // 
            this.dayName.Dock = System.Windows.Forms.DockStyle.Left;
            this.dayName.Location = new System.Drawing.Point(0, 0);
            this.dayName.Name = "dayName";
            this.dayName.Size = new System.Drawing.Size(46, 25);
            this.dayName.TabIndex = 0;
            this.dayName.Text = "Po";
            this.dayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dayName;
    }
}
