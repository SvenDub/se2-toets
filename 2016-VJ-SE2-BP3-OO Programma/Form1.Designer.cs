namespace _2016_VJ_SE2_BP3_OO_Programma
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtZoneCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLaadConfiguratie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUurPrijs = new System.Windows.Forms.TextBox();
            this.txtPlaatsenTotaal = new System.Windows.Forms.TextBox();
            this.txtPlaatsenBezet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOpeningstijden = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInkomsten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radParkeerApp = new System.Windows.Forms.RadioButton();
            this.radVrijeUitrijkaart = new System.Windows.Forms.RadioButton();
            this.radUurkaart = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lstParkeerders = new System.Windows.Forms.ListBox();
            this.btnVertrek = new System.Windows.Forms.Button();
            this.btnInrijden = new System.Windows.Forms.Button();
            this.txtKenteken = new System.Windows.Forms.TextBox();
            this.nudAankomstMinuut = new System.Windows.Forms.NumericUpDown();
            this.nudAankomstUur = new System.Windows.Forms.NumericUpDown();
            this.cmbAankomstDag = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAankomstMinuut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAankomstUur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtZoneCode);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnLaadConfiguratie);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUurPrijs);
            this.groupBox1.Controls.Add(this.txtPlaatsenTotaal);
            this.groupBox1.Controls.Add(this.txtPlaatsenBezet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstOpeningstijden);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Garageinformatie";
            // 
            // txtZoneCode
            // 
            this.txtZoneCode.Enabled = false;
            this.txtZoneCode.Location = new System.Drawing.Point(88, 19);
            this.txtZoneCode.Name = "txtZoneCode";
            this.txtZoneCode.Size = new System.Drawing.Size(106, 20);
            this.txtZoneCode.TabIndex = 0;
            this.txtZoneCode.Text = "0";
            this.txtZoneCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Zonecode:";
            // 
            // btnLaadConfiguratie
            // 
            this.btnLaadConfiguratie.Location = new System.Drawing.Point(88, 97);
            this.btnLaadConfiguratie.Name = "btnLaadConfiguratie";
            this.btnLaadConfiguratie.Size = new System.Drawing.Size(106, 23);
            this.btnLaadConfiguratie.TabIndex = 4;
            this.btnLaadConfiguratie.Text = "Laad configuratie";
            this.btnLaadConfiguratie.UseVisualStyleBackColor = true;
            this.btnLaadConfiguratie.Click += new System.EventHandler(this.btnLaadConfiguratie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(92, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prijs per uur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Openingstijden:";
            // 
            // txtUurPrijs
            // 
            this.txtUurPrijs.Enabled = false;
            this.txtUurPrijs.Location = new System.Drawing.Point(88, 72);
            this.txtUurPrijs.Name = "txtUurPrijs";
            this.txtUurPrijs.Size = new System.Drawing.Size(45, 20);
            this.txtUurPrijs.TabIndex = 3;
            this.txtUurPrijs.Text = "0";
            this.txtUurPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlaatsenTotaal
            // 
            this.txtPlaatsenTotaal.Enabled = false;
            this.txtPlaatsenTotaal.Location = new System.Drawing.Point(149, 45);
            this.txtPlaatsenTotaal.Name = "txtPlaatsenTotaal";
            this.txtPlaatsenTotaal.Size = new System.Drawing.Size(45, 20);
            this.txtPlaatsenTotaal.TabIndex = 2;
            this.txtPlaatsenTotaal.Text = "0";
            this.txtPlaatsenTotaal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlaatsenBezet
            // 
            this.txtPlaatsenBezet.Enabled = false;
            this.txtPlaatsenBezet.Location = new System.Drawing.Point(88, 45);
            this.txtPlaatsenBezet.Name = "txtPlaatsenBezet";
            this.txtPlaatsenBezet.Size = new System.Drawing.Size(45, 20);
            this.txtPlaatsenBezet.TabIndex = 1;
            this.txtPlaatsenBezet.Text = "0";
            this.txtPlaatsenBezet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaatsen:";
            // 
            // lstOpeningstijden
            // 
            this.lstOpeningstijden.Enabled = false;
            this.lstOpeningstijden.FormattingEnabled = true;
            this.lstOpeningstijden.Location = new System.Drawing.Point(6, 148);
            this.lstOpeningstijden.Name = "lstOpeningstijden";
            this.lstOpeningstijden.Size = new System.Drawing.Size(188, 95);
            this.lstOpeningstijden.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtInkomsten);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radParkeerApp);
            this.groupBox2.Controls.Add(this.radVrijeUitrijkaart);
            this.groupBox2.Controls.Add(this.radUurkaart);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lstParkeerders);
            this.groupBox2.Controls.Add(this.btnVertrek);
            this.groupBox2.Controls.Add(this.btnInrijden);
            this.groupBox2.Controls.Add(this.txtKenteken);
            this.groupBox2.Controls.Add(this.nudAankomstMinuut);
            this.groupBox2.Controls.Add(this.nudAankomstUur);
            this.groupBox2.Controls.Add(this.cmbAankomstDag);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parkeersimulatie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(244, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(178, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Inkomsten:";
            // 
            // txtInkomsten
            // 
            this.txtInkomsten.Enabled = false;
            this.txtInkomsten.Location = new System.Drawing.Point(241, 129);
            this.txtInkomsten.Name = "txtInkomsten";
            this.txtInkomsten.Size = new System.Drawing.Size(45, 20);
            this.txtInkomsten.TabIndex = 14;
            this.txtInkomsten.Text = "0";
            this.txtInkomsten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tijd:";
            // 
            // radParkeerApp
            // 
            this.radParkeerApp.AutoSize = true;
            this.radParkeerApp.Location = new System.Drawing.Point(180, 72);
            this.radParkeerApp.Name = "radParkeerApp";
            this.radParkeerApp.Size = new System.Drawing.Size(81, 17);
            this.radParkeerApp.TabIndex = 13;
            this.radParkeerApp.TabStop = true;
            this.radParkeerApp.Text = "ParkeerApp";
            this.radParkeerApp.UseVisualStyleBackColor = true;
            // 
            // radVrijeUitrijkaart
            // 
            this.radVrijeUitrijkaart.AutoSize = true;
            this.radVrijeUitrijkaart.Location = new System.Drawing.Point(180, 46);
            this.radVrijeUitrijkaart.Name = "radVrijeUitrijkaart";
            this.radVrijeUitrijkaart.Size = new System.Drawing.Size(90, 17);
            this.radVrijeUitrijkaart.TabIndex = 12;
            this.radVrijeUitrijkaart.TabStop = true;
            this.radVrijeUitrijkaart.Text = "Vrije uitrijkaart";
            this.radVrijeUitrijkaart.UseVisualStyleBackColor = true;
            // 
            // radUurkaart
            // 
            this.radUurkaart.AutoSize = true;
            this.radUurkaart.Checked = true;
            this.radUurkaart.Location = new System.Drawing.Point(180, 20);
            this.radUurkaart.Name = "radUurkaart";
            this.radUurkaart.Size = new System.Drawing.Size(66, 17);
            this.radUurkaart.TabIndex = 11;
            this.radUurkaart.TabStop = true;
            this.radUurkaart.Text = "Uurkaart";
            this.radUurkaart.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Parkeerders:";
            // 
            // lstParkeerders
            // 
            this.lstParkeerders.FormattingEnabled = true;
            this.lstParkeerders.Location = new System.Drawing.Point(6, 148);
            this.lstParkeerders.Name = "lstParkeerders";
            this.lstParkeerders.Size = new System.Drawing.Size(280, 95);
            this.lstParkeerders.TabIndex = 15;
            // 
            // btnVertrek
            // 
            this.btnVertrek.Location = new System.Drawing.Point(180, 97);
            this.btnVertrek.Name = "btnVertrek";
            this.btnVertrek.Size = new System.Drawing.Size(105, 23);
            this.btnVertrek.TabIndex = 14;
            this.btnVertrek.Text = "Vertrek";
            this.btnVertrek.UseVisualStyleBackColor = true;
            this.btnVertrek.Click += new System.EventHandler(this.btnVertrek_Click);
            // 
            // btnInrijden
            // 
            this.btnInrijden.Location = new System.Drawing.Point(69, 97);
            this.btnInrijden.Name = "btnInrijden";
            this.btnInrijden.Size = new System.Drawing.Size(105, 23);
            this.btnInrijden.TabIndex = 10;
            this.btnInrijden.Text = "Inrijden";
            this.btnInrijden.UseVisualStyleBackColor = true;
            this.btnInrijden.Click += new System.EventHandler(this.btnInrijden_Click);
            // 
            // txtKenteken
            // 
            this.txtKenteken.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKenteken.Location = new System.Drawing.Point(69, 20);
            this.txtKenteken.MaxLength = 8;
            this.txtKenteken.Name = "txtKenteken";
            this.txtKenteken.Size = new System.Drawing.Size(106, 20);
            this.txtKenteken.TabIndex = 6;
            this.txtKenteken.Text = "12-BCD-3";
            this.txtKenteken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudAankomstMinuut
            // 
            this.nudAankomstMinuut.Location = new System.Drawing.Point(134, 72);
            this.nudAankomstMinuut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudAankomstMinuut.Name = "nudAankomstMinuut";
            this.nudAankomstMinuut.Size = new System.Drawing.Size(40, 20);
            this.nudAankomstMinuut.TabIndex = 9;
            this.nudAankomstMinuut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAankomstMinuut.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // nudAankomstUur
            // 
            this.nudAankomstUur.Location = new System.Drawing.Point(69, 72);
            this.nudAankomstUur.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudAankomstUur.Name = "nudAankomstUur";
            this.nudAankomstUur.Size = new System.Drawing.Size(40, 20);
            this.nudAankomstUur.TabIndex = 8;
            this.nudAankomstUur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAankomstUur.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // cmbAankomstDag
            // 
            this.cmbAankomstDag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAankomstDag.FormattingEnabled = true;
            this.cmbAankomstDag.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbAankomstDag.Location = new System.Drawing.Point(69, 45);
            this.cmbAankomstDag.Name = "cmbAankomstDag";
            this.cmbAankomstDag.Size = new System.Drawing.Size(106, 21);
            this.cmbAankomstDag.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dag:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kenteken:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Parkeermanager - Ontwikkeld door Sven Dubbeld";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAankomstMinuut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAankomstUur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlaatsenTotaal;
        private System.Windows.Forms.TextBox txtPlaatsenBezet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOpeningstijden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUurPrijs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAankomstDag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKenteken;
        private System.Windows.Forms.NumericUpDown nudAankomstMinuut;
        private System.Windows.Forms.NumericUpDown nudAankomstUur;
        private System.Windows.Forms.Button btnLaadConfiguratie;
        private System.Windows.Forms.Button btnInrijden;
        private System.Windows.Forms.Button btnVertrek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstParkeerders;
        private System.Windows.Forms.RadioButton radParkeerApp;
        private System.Windows.Forms.RadioButton radVrijeUitrijkaart;
        private System.Windows.Forms.RadioButton radUurkaart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZoneCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInkomsten;
    }
}

