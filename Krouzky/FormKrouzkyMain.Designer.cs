namespace Krouzky
{
    partial class FormKrouzkyMain
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calendarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mesicLabel = new System.Windows.Forms.Label();
            this.calendarMoveLeft = new System.Windows.Forms.Button();
            this.calendarMoveRight = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.controlledPanel = new System.Windows.Forms.Panel();
            this.kontaktyPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.skolyPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.krouzkyPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lektoriPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kontaktyBtn = new System.Windows.Forms.Button();
            this.skolyBtn = new System.Windows.Forms.Button();
            this.krouzkyBtn = new System.Windows.Forms.Button();
            this.lektoriBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.controlledPanel.SuspendLayout();
            this.kontaktyPanel.SuspendLayout();
            this.skolyPanel.SuspendLayout();
            this.krouzkyPanel.SuspendLayout();
            this.lektoriPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.closeBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(3);
            this.headerPanel.Size = new System.Drawing.Size(1256, 50);
            this.headerPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(899, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "INFORMAČNÍ SYSTÉM EVIDENCE ZÁJMOVÝCH KROUŽKŮ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.closeBtn.FlatAppearance.BorderSize = 2;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeBtn.Location = new System.Drawing.Point(1209, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(3);
            this.closeBtn.Size = new System.Drawing.Size(42, 42);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.calendarPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(471, 53);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(788, 617);
            this.panel2.TabIndex = 1;
            // 
            // calendarPanel
            // 
            this.calendarPanel.AutoScroll = true;
            this.calendarPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.calendarPanel.ColumnCount = 7;
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel.Location = new System.Drawing.Point(3, 51);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.RowCount = 5;
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.calendarPanel.Size = new System.Drawing.Size(780, 561);
            this.calendarPanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mesicLabel);
            this.panel4.Controls.Add(this.calendarMoveLeft);
            this.panel4.Controls.Add(this.calendarMoveRight);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel4.Size = new System.Drawing.Size(780, 48);
            this.panel4.TabIndex = 0;
            // 
            // mesicLabel
            // 
            this.mesicLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mesicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mesicLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesicLabel.Location = new System.Drawing.Point(0, 3);
            this.mesicLabel.Margin = new System.Windows.Forms.Padding(3);
            this.mesicLabel.Name = "mesicLabel";
            this.mesicLabel.Size = new System.Drawing.Size(336, 42);
            this.mesicLabel.TabIndex = 2;
            this.mesicLabel.Text = "LEDEN";
            this.mesicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calendarMoveLeft
            // 
            this.calendarMoveLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.calendarMoveLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.calendarMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.calendarMoveLeft.FlatAppearance.BorderSize = 2;
            this.calendarMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarMoveLeft.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calendarMoveLeft.Location = new System.Drawing.Point(696, 3);
            this.calendarMoveLeft.Name = "calendarMoveLeft";
            this.calendarMoveLeft.Padding = new System.Windows.Forms.Padding(3);
            this.calendarMoveLeft.Size = new System.Drawing.Size(42, 42);
            this.calendarMoveLeft.TabIndex = 1;
            this.calendarMoveLeft.Text = "<";
            this.calendarMoveLeft.UseVisualStyleBackColor = false;
            this.calendarMoveLeft.Click += new System.EventHandler(this.calendarMoveLeft_Click);
            // 
            // calendarMoveRight
            // 
            this.calendarMoveRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.calendarMoveRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.calendarMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.calendarMoveRight.FlatAppearance.BorderSize = 2;
            this.calendarMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarMoveRight.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calendarMoveRight.Location = new System.Drawing.Point(738, 3);
            this.calendarMoveRight.Name = "calendarMoveRight";
            this.calendarMoveRight.Padding = new System.Windows.Forms.Padding(3);
            this.calendarMoveRight.Size = new System.Drawing.Size(42, 42);
            this.calendarMoveRight.TabIndex = 0;
            this.calendarMoveRight.Text = ">";
            this.calendarMoveRight.UseVisualStyleBackColor = false;
            this.calendarMoveRight.Click += new System.EventHandler(this.calendarMoveRight_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.controlledPanel);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel3.Size = new System.Drawing.Size(468, 617);
            this.panel3.TabIndex = 2;
            // 
            // controlledPanel
            // 
            this.controlledPanel.Controls.Add(this.kontaktyPanel);
            this.controlledPanel.Controls.Add(this.skolyPanel);
            this.controlledPanel.Controls.Add(this.krouzkyPanel);
            this.controlledPanel.Controls.Add(this.lektoriPanel);
            this.controlledPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlledPanel.Location = new System.Drawing.Point(0, 128);
            this.controlledPanel.Name = "controlledPanel";
            this.controlledPanel.Size = new System.Drawing.Size(466, 484);
            this.controlledPanel.TabIndex = 2;
            // 
            // kontaktyPanel
            // 
            this.kontaktyPanel.AutoScroll = true;
            this.kontaktyPanel.Controls.Add(this.label6);
            this.kontaktyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kontaktyPanel.Location = new System.Drawing.Point(0, 0);
            this.kontaktyPanel.Name = "kontaktyPanel";
            this.kontaktyPanel.Size = new System.Drawing.Size(466, 484);
            this.kontaktyPanel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kontakty";
            this.label6.Visible = false;
            // 
            // skolyPanel
            // 
            this.skolyPanel.AutoScroll = true;
            this.skolyPanel.Controls.Add(this.label5);
            this.skolyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skolyPanel.Location = new System.Drawing.Point(0, 0);
            this.skolyPanel.Name = "skolyPanel";
            this.skolyPanel.Size = new System.Drawing.Size(466, 484);
            this.skolyPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Skoly";
            this.label5.Visible = false;
            // 
            // krouzkyPanel
            // 
            this.krouzkyPanel.AutoScroll = true;
            this.krouzkyPanel.Controls.Add(this.label4);
            this.krouzkyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.krouzkyPanel.Location = new System.Drawing.Point(0, 0);
            this.krouzkyPanel.Name = "krouzkyPanel";
            this.krouzkyPanel.Size = new System.Drawing.Size(466, 484);
            this.krouzkyPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Krouzky";
            this.label4.Visible = false;
            // 
            // lektoriPanel
            // 
            this.lektoriPanel.AutoScroll = true;
            this.lektoriPanel.Controls.Add(this.label3);
            this.lektoriPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lektoriPanel.Location = new System.Drawing.Point(0, 0);
            this.lektoriPanel.Name = "lektoriPanel";
            this.lektoriPanel.Size = new System.Drawing.Size(466, 484);
            this.lektoriPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lektori";
            this.label3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 3, 3);
            this.panel5.Size = new System.Drawing.Size(466, 50);
            this.panel5.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.textBox1.Location = new System.Drawing.Point(263, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Krouzky.Properties.Resources.Asset_3_2x;
            this.button5.Location = new System.Drawing.Point(100, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 37);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Krouzky.Properties.Resources.Asset_2_2x;
            this.button4.Location = new System.Drawing.Point(50, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 37);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Krouzky.Properties.Resources.Asset_1_2x;
            this.button3.Location = new System.Drawing.Point(0, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 37);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.kontaktyBtn);
            this.panel1.Controls.Add(this.skolyBtn);
            this.panel1.Controls.Add(this.krouzkyBtn);
            this.panel1.Controls.Add(this.lektoriBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Size = new System.Drawing.Size(466, 75);
            this.panel1.TabIndex = 0;
            // 
            // kontaktyBtn
            // 
            this.kontaktyBtn.AutoSize = true;
            this.kontaktyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kontaktyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.kontaktyBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.kontaktyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.kontaktyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kontaktyBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontaktyBtn.Location = new System.Drawing.Point(360, 3);
            this.kontaktyBtn.Name = "kontaktyBtn";
            this.kontaktyBtn.Size = new System.Drawing.Size(153, 48);
            this.kontaktyBtn.TabIndex = 3;
            this.kontaktyBtn.Text = "KONTAKTY";
            this.kontaktyBtn.UseVisualStyleBackColor = false;
            this.kontaktyBtn.Click += new System.EventHandler(this.kontaktyBtn_Click);
            // 
            // skolyBtn
            // 
            this.skolyBtn.AutoSize = true;
            this.skolyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.skolyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.skolyBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.skolyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.skolyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skolyBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skolyBtn.Location = new System.Drawing.Point(257, 3);
            this.skolyBtn.Name = "skolyBtn";
            this.skolyBtn.Size = new System.Drawing.Size(103, 48);
            this.skolyBtn.TabIndex = 2;
            this.skolyBtn.Text = "ŠKOLY";
            this.skolyBtn.UseVisualStyleBackColor = false;
            this.skolyBtn.Click += new System.EventHandler(this.skolyBtn_Click);
            // 
            // krouzkyBtn
            // 
            this.krouzkyBtn.AutoSize = true;
            this.krouzkyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.krouzkyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.krouzkyBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.krouzkyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.krouzkyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.krouzkyBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krouzkyBtn.Location = new System.Drawing.Point(120, 3);
            this.krouzkyBtn.Name = "krouzkyBtn";
            this.krouzkyBtn.Size = new System.Drawing.Size(137, 48);
            this.krouzkyBtn.TabIndex = 1;
            this.krouzkyBtn.Text = "KROUŽKY";
            this.krouzkyBtn.UseVisualStyleBackColor = false;
            this.krouzkyBtn.Click += new System.EventHandler(this.krouzkyBtn_Click);
            // 
            // lektoriBtn
            // 
            this.lektoriBtn.AutoSize = true;
            this.lektoriBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lektoriBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.lektoriBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lektoriBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lektoriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lektoriBtn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lektoriBtn.Location = new System.Drawing.Point(0, 3);
            this.lektoriBtn.Name = "lektoriBtn";
            this.lektoriBtn.Size = new System.Drawing.Size(120, 48);
            this.lektoriBtn.TabIndex = 0;
            this.lektoriBtn.Text = "LEKTOŘI";
            this.lektoriBtn.UseVisualStyleBackColor = false;
            this.lektoriBtn.Click += new System.EventHandler(this.lektoriBtn_Click);
            // 
            // FormKrouzkyMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKrouzkyMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.headerPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.controlledPanel.ResumeLayout(false);
            this.kontaktyPanel.ResumeLayout(false);
            this.kontaktyPanel.PerformLayout();
            this.skolyPanel.ResumeLayout(false);
            this.skolyPanel.PerformLayout();
            this.krouzkyPanel.ResumeLayout(false);
            this.krouzkyPanel.PerformLayout();
            this.lektoriPanel.ResumeLayout(false);
            this.lektoriPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label mesicLabel;
        private System.Windows.Forms.Button calendarMoveLeft;
        private System.Windows.Forms.Button calendarMoveRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel calendarPanel;
        //private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        //private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kontaktyBtn;
        private System.Windows.Forms.Button skolyBtn;
        private System.Windows.Forms.Button krouzkyBtn;
        private System.Windows.Forms.Button lektoriBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel controlledPanel;
        private System.Windows.Forms.Panel lektoriPanel;
        private System.Windows.Forms.Panel kontaktyPanel;
        private System.Windows.Forms.Panel skolyPanel;
        private System.Windows.Forms.Panel krouzkyPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

