namespace Krouzky
{
    partial class ListItem
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.nameLabel.Location = new System.Drawing.Point(51, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(200, 100);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Lorem ipsum dolor sit amet";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.DoubleClick += new System.EventHandler(this.nameLabel_DoubleClick);
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.checkBox.Location = new System.Drawing.Point(3, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(0, 0);
            this.checkBox.TabIndex = 0;
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // ListItem
            // 
            this.MinimumSize = new System.Drawing.Size(200, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
