
namespace Lab2_win_forms {
    partial class Lista4 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.wykres = new OxyPlot.WindowsForms.PlotView();
            this.ChooseZad = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.WprowadzText = new System.Windows.Forms.Label();
            this.txtValueCounter = new System.Windows.Forms.Label();
            this.currentValue = new System.Windows.Forms.Label();
            this.Amplituda = new System.Windows.Forms.Button();
            this.binBox = new System.Windows.Forms.TextBox();
            this.WartoscBinarna = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FsNumeric = new System.Windows.Forms.NumericUpDown();
            this.TcNumeric = new System.Windows.Forms.NumericUpDown();
            this.WartosciLabel = new System.Windows.Forms.Label();
            this.DefaultValues = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.A1Numeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.A2Numeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.WNumeric = new System.Windows.Forms.NumericUpDown();
            this.FazaA = new System.Windows.Forms.Button();
            this.CzestotliwoscA = new System.Windows.Forms.Button();
            this.CzestWidmo = new System.Windows.Forms.Button();
            this.FazaWidmo = new System.Windows.Forms.Button();
            this.AmplitudaWidmo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ANumeric = new System.Windows.Forms.NumericUpDown();
            this.demodulatorASKButton = new System.Windows.Forms.Button();
            this.demodulatorPSKButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.demodulatorFSKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // wykres
            // 
            this.wykres.BackColor = System.Drawing.Color.LightGray;
            this.wykres.Location = new System.Drawing.Point(10, 11);
            this.wykres.Name = "wykres";
            this.wykres.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.wykres.Size = new System.Drawing.Size(1128, 307);
            this.wykres.TabIndex = 1;
            this.wykres.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.wykres.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.wykres.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // ChooseZad
            // 
            this.ChooseZad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseZad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseZad.Location = new System.Drawing.Point(1056, 699);
            this.ChooseZad.Name = "ChooseZad";
            this.ChooseZad.Size = new System.Drawing.Size(86, 35);
            this.ChooseZad.TabIndex = 2;
            this.ChooseZad.Text = "Wybór Zad";
            this.ChooseZad.UseVisualStyleBackColor = true;
            this.ChooseZad.Click += new System.EventHandler(this.ChooseZad_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(10, 347);
            this.txtBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(226, 74);
            this.txtBox.TabIndex = 3;
            this.txtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            // 
            // WprowadzText
            // 
            this.WprowadzText.AutoSize = true;
            this.WprowadzText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WprowadzText.Location = new System.Drawing.Point(6, 321);
            this.WprowadzText.Name = "WprowadzText";
            this.WprowadzText.Size = new System.Drawing.Size(173, 25);
            this.WprowadzText.TabIndex = 18;
            this.WprowadzText.Text = "Wprowadź tekst:";
            // 
            // txtValueCounter
            // 
            this.txtValueCounter.AutoSize = true;
            this.txtValueCounter.Location = new System.Drawing.Point(187, 423);
            this.txtValueCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtValueCounter.Name = "txtValueCounter";
            this.txtValueCounter.Size = new System.Drawing.Size(13, 13);
            this.txtValueCounter.TabIndex = 20;
            this.txtValueCounter.Text = "0";
            // 
            // currentValue
            // 
            this.currentValue.AutoSize = true;
            this.currentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValue.Location = new System.Drawing.Point(7, 423);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(175, 13);
            this.currentValue.TabIndex = 21;
            this.currentValue.Text = "Obecna wartosc tekstu ASCII:";
            // 
            // Amplituda
            // 
            this.Amplituda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amplituda.Location = new System.Drawing.Point(579, 349);
            this.Amplituda.Name = "Amplituda";
            this.Amplituda.Size = new System.Drawing.Size(132, 46);
            this.Amplituda.TabIndex = 23;
            this.Amplituda.Text = "Amplituda";
            this.Amplituda.UseVisualStyleBackColor = true;
            this.Amplituda.Click += new System.EventHandler(this.Amplituda_Click);
            // 
            // binBox
            // 
            this.binBox.Location = new System.Drawing.Point(240, 347);
            this.binBox.Margin = new System.Windows.Forms.Padding(2);
            this.binBox.Multiline = true;
            this.binBox.Name = "binBox";
            this.binBox.ReadOnly = true;
            this.binBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binBox.Size = new System.Drawing.Size(226, 74);
            this.binBox.TabIndex = 24;
            // 
            // WartoscBinarna
            // 
            this.WartoscBinarna.AutoSize = true;
            this.WartoscBinarna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WartoscBinarna.Location = new System.Drawing.Point(235, 321);
            this.WartoscBinarna.Name = "WartoscBinarna";
            this.WartoscBinarna.Size = new System.Drawing.Size(99, 25);
            this.WartoscBinarna.TabIndex = 25;
            this.WartoscBinarna.Text = "Wartosc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Częstotliwość próbkowania (Fs) [Hz]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Czas trwania sygnału (Tc) [s]";
            // 
            // FsNumeric
            // 
            this.FsNumeric.DecimalPlaces = 2;
            this.FsNumeric.Location = new System.Drawing.Point(10, 490);
            this.FsNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FsNumeric.Name = "FsNumeric";
            this.FsNumeric.Size = new System.Drawing.Size(130, 20);
            this.FsNumeric.TabIndex = 51;
            this.FsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FsNumeric.ThousandsSeparator = true;
            // 
            // TcNumeric
            // 
            this.TcNumeric.DecimalPlaces = 2;
            this.TcNumeric.Location = new System.Drawing.Point(10, 464);
            this.TcNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TcNumeric.Name = "TcNumeric";
            this.TcNumeric.Size = new System.Drawing.Size(130, 20);
            this.TcNumeric.TabIndex = 50;
            this.TcNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TcNumeric.ThousandsSeparator = true;
            // 
            // WartosciLabel
            // 
            this.WartosciLabel.AutoSize = true;
            this.WartosciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WartosciLabel.Location = new System.Drawing.Point(5, 436);
            this.WartosciLabel.Name = "WartosciLabel";
            this.WartosciLabel.Size = new System.Drawing.Size(104, 25);
            this.WartosciLabel.TabIndex = 49;
            this.WartosciLabel.Text = "Wartości:";
            // 
            // DefaultValues
            // 
            this.DefaultValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultValues.Location = new System.Drawing.Point(9, 617);
            this.DefaultValues.Name = "DefaultValues";
            this.DefaultValues.Size = new System.Drawing.Size(130, 46);
            this.DefaultValues.TabIndex = 48;
            this.DefaultValues.Text = "Default Values";
            this.DefaultValues.UseVisualStyleBackColor = true;
            this.DefaultValues.Click += new System.EventHandler(this.DefaultValues_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "A1";
            // 
            // A1Numeric
            // 
            this.A1Numeric.DecimalPlaces = 2;
            this.A1Numeric.Location = new System.Drawing.Point(10, 516);
            this.A1Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.A1Numeric.Name = "A1Numeric";
            this.A1Numeric.Size = new System.Drawing.Size(130, 20);
            this.A1Numeric.TabIndex = 56;
            this.A1Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A1Numeric.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "A2";
            // 
            // A2Numeric
            // 
            this.A2Numeric.DecimalPlaces = 2;
            this.A2Numeric.Location = new System.Drawing.Point(10, 542);
            this.A2Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.A2Numeric.Name = "A2Numeric";
            this.A2Numeric.Size = new System.Drawing.Size(130, 20);
            this.A2Numeric.TabIndex = 58;
            this.A2Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A2Numeric.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "W";
            // 
            // WNumeric
            // 
            this.WNumeric.DecimalPlaces = 2;
            this.WNumeric.Location = new System.Drawing.Point(10, 568);
            this.WNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WNumeric.Name = "WNumeric";
            this.WNumeric.Size = new System.Drawing.Size(130, 20);
            this.WNumeric.TabIndex = 60;
            this.WNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WNumeric.ThousandsSeparator = true;
            // 
            // FazaA
            // 
            this.FazaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FazaA.Location = new System.Drawing.Point(717, 349);
            this.FazaA.Name = "FazaA";
            this.FazaA.Size = new System.Drawing.Size(132, 46);
            this.FazaA.TabIndex = 70;
            this.FazaA.Text = "Faza";
            this.FazaA.UseVisualStyleBackColor = true;
            this.FazaA.Click += new System.EventHandler(this.FazaA_Click);
            // 
            // CzestotliwoscA
            // 
            this.CzestotliwoscA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CzestotliwoscA.Location = new System.Drawing.Point(855, 349);
            this.CzestotliwoscA.Name = "CzestotliwoscA";
            this.CzestotliwoscA.Size = new System.Drawing.Size(132, 46);
            this.CzestotliwoscA.TabIndex = 71;
            this.CzestotliwoscA.Text = "Częstotliwość";
            this.CzestotliwoscA.UseVisualStyleBackColor = true;
            this.CzestotliwoscA.Click += new System.EventHandler(this.CzestotliwoscA_Click);
            // 
            // CzestWidmo
            // 
            this.CzestWidmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CzestWidmo.Location = new System.Drawing.Point(855, 426);
            this.CzestWidmo.Name = "CzestWidmo";
            this.CzestWidmo.Size = new System.Drawing.Size(132, 46);
            this.CzestWidmo.TabIndex = 74;
            this.CzestWidmo.Text = "CzęstWidmo";
            this.CzestWidmo.UseVisualStyleBackColor = true;
            this.CzestWidmo.Click += new System.EventHandler(this.CzestWidmo_Click);
            // 
            // FazaWidmo
            // 
            this.FazaWidmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FazaWidmo.Location = new System.Drawing.Point(717, 426);
            this.FazaWidmo.Name = "FazaWidmo";
            this.FazaWidmo.Size = new System.Drawing.Size(132, 46);
            this.FazaWidmo.TabIndex = 73;
            this.FazaWidmo.Text = "FazaWidmo";
            this.FazaWidmo.UseVisualStyleBackColor = true;
            this.FazaWidmo.Click += new System.EventHandler(this.FazaWidmo_Click);
            // 
            // AmplitudaWidmo
            // 
            this.AmplitudaWidmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmplitudaWidmo.Location = new System.Drawing.Point(579, 426);
            this.AmplitudaWidmo.Name = "AmplitudaWidmo";
            this.AmplitudaWidmo.Size = new System.Drawing.Size(132, 46);
            this.AmplitudaWidmo.TabIndex = 72;
            this.AmplitudaWidmo.Text = "AmpWidmo";
            this.AmplitudaWidmo.UseVisualStyleBackColor = true;
            this.AmplitudaWidmo.Click += new System.EventHandler(this.AmpWidmo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "A";
            // 
            // ANumeric
            // 
            this.ANumeric.DecimalPlaces = 2;
            this.ANumeric.Location = new System.Drawing.Point(9, 592);
            this.ANumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ANumeric.Name = "ANumeric";
            this.ANumeric.Size = new System.Drawing.Size(130, 20);
            this.ANumeric.TabIndex = 75;
            this.ANumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ANumeric.ThousandsSeparator = true;
            // 
            // demodulatorASKButton
            // 
            this.demodulatorASKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.demodulatorASKButton.Location = new System.Drawing.Point(579, 502);
            this.demodulatorASKButton.Margin = new System.Windows.Forms.Padding(2);
            this.demodulatorASKButton.Name = "demodulatorASKButton";
            this.demodulatorASKButton.Size = new System.Drawing.Size(132, 46);
            this.demodulatorASKButton.TabIndex = 77;
            this.demodulatorASKButton.Text = "Demudolator ASK";
            this.demodulatorASKButton.UseVisualStyleBackColor = true;
            this.demodulatorASKButton.Click += new System.EventHandler(this.DemodulatorASKButton_Click);
            // 
            // demodulatorPSKButton
            // 
            this.demodulatorPSKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.demodulatorPSKButton.Location = new System.Drawing.Point(716, 502);
            this.demodulatorPSKButton.Margin = new System.Windows.Forms.Padding(2);
            this.demodulatorPSKButton.Name = "demodulatorPSKButton";
            this.demodulatorPSKButton.Size = new System.Drawing.Size(132, 46);
            this.demodulatorPSKButton.TabIndex = 78;
            this.demodulatorPSKButton.Text = "Demudolator PSK";
            this.demodulatorPSKButton.UseVisualStyleBackColor = true;
            this.demodulatorPSKButton.Click += new System.EventHandler(this.DemodulatorPSKButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "L4Z3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(574, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "L4Z4:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(574, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 81;
            this.label9.Text = "L5Z2:";
            // 
            // demodulatorFSKButton
            // 
            this.demodulatorFSKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.demodulatorFSKButton.Location = new System.Drawing.Point(855, 501);
            this.demodulatorFSKButton.Margin = new System.Windows.Forms.Padding(2);
            this.demodulatorFSKButton.Name = "demodulatorFSKButton";
            this.demodulatorFSKButton.Size = new System.Drawing.Size(132, 46);
            this.demodulatorFSKButton.TabIndex = 82;
            this.demodulatorFSKButton.Text = "Demudolator FSK";
            this.demodulatorFSKButton.UseVisualStyleBackColor = true;
            this.demodulatorFSKButton.Click += new System.EventHandler(this.DemodulatorFSKButton_Click);
            // 
            // Lista4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 774);
            this.Controls.Add(this.demodulatorFSKButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.demodulatorPSKButton);
            this.Controls.Add(this.demodulatorASKButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ANumeric);
            this.Controls.Add(this.CzestWidmo);
            this.Controls.Add(this.FazaWidmo);
            this.Controls.Add(this.AmplitudaWidmo);
            this.Controls.Add(this.CzestotliwoscA);
            this.Controls.Add(this.FazaA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.A2Numeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.A1Numeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FsNumeric);
            this.Controls.Add(this.TcNumeric);
            this.Controls.Add(this.WartosciLabel);
            this.Controls.Add(this.DefaultValues);
            this.Controls.Add(this.WartoscBinarna);
            this.Controls.Add(this.binBox);
            this.Controls.Add(this.Amplituda);
            this.Controls.Add(this.currentValue);
            this.Controls.Add(this.txtValueCounter);
            this.Controls.Add(this.WprowadzText);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.ChooseZad);
            this.Controls.Add(this.wykres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lista4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmisja Danych - Lista 4+5";
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView wykres;
        private System.Windows.Forms.Button ChooseZad;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label WprowadzText;
        private System.Windows.Forms.Label txtValueCounter;
        private System.Windows.Forms.Label currentValue;
        private System.Windows.Forms.Button Amplituda;
        private System.Windows.Forms.TextBox binBox;
        private System.Windows.Forms.Label WartoscBinarna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FsNumeric;
        private System.Windows.Forms.NumericUpDown TcNumeric;
        private System.Windows.Forms.Label WartosciLabel;
        private System.Windows.Forms.Button DefaultValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown A1Numeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown A2Numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown WNumeric;
        private System.Windows.Forms.Button FazaA;
        private System.Windows.Forms.Button CzestotliwoscA;
        private System.Windows.Forms.Button CzestWidmo;
        private System.Windows.Forms.Button FazaWidmo;
        private System.Windows.Forms.Button AmplitudaWidmo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ANumeric;
        private System.Windows.Forms.Button demodulatorASKButton;
        private System.Windows.Forms.Button demodulatorPSKButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button demodulatorFSKButton;
    }
}