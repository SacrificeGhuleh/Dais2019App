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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainPanel);
            this.panel1.Controls.Add(this.errorPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 360);
            this.panel1.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.stateLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(640, 260);
            this.mainPanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(5);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.headerPanel.Size = new System.Drawing.Size(640, 50);
            this.headerPanel.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBtn.Location = new System.Drawing.Point(593, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(3);
            this.closeBtn.Size = new System.Drawing.Size(42, 40);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.stateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stateLabel.Location = new System.Drawing.Point(0, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(640, 260);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "FormLoading...";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.errorField);
            this.errorPanel.Controls.Add(this.label1);
            this.errorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorPanel.Location = new System.Drawing.Point(0, 260);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Padding = new System.Windows.Forms.Padding(3);
            this.errorPanel.Size = new System.Drawing.Size(640, 100);
            this.errorPanel.TabIndex = 0;
            // 
            // errorField
            // 
            this.errorField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.errorField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorField.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.errorField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.errorField.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.errorField.Location = new System.Drawing.Point(103, 3);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(534, 94);
            this.errorField.TabIndex = 1;
            this.errorField.Text = "";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading";
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeBtn;
    }
}