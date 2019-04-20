namespace Krouzky
{
    partial class FormLoading
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.stateLabel = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.mainPanel);
            this.panel1.Controls.Add(this.errorPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 253);
            this.panel1.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.stateLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(282, 127);
            this.mainPanel.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.stateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.stateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stateLabel.Location = new System.Drawing.Point(0, 0);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Padding = new System.Windows.Forms.Padding(3);
            this.stateLabel.Size = new System.Drawing.Size(282, 127);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "FormLoading...";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.errorPanel.Controls.Add(this.errorField);
            this.errorPanel.Controls.Add(this.label1);
            this.errorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorPanel.Location = new System.Drawing.Point(0, 127);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Padding = new System.Windows.Forms.Padding(1);
            this.errorPanel.Size = new System.Drawing.Size(282, 126);
            this.errorPanel.TabIndex = 0;
            // 
            // errorField
            // 
            this.errorField.BackColor = System.Drawing.SystemColors.Control;
            this.errorField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.errorField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorField.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.errorField.Location = new System.Drawing.Point(92, 1);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(189, 124);
            this.errorField.TabIndex = 1;
            this.errorField.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(91, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading";
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.errorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.RichTextBox errorField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label stateLabel;
    }
}