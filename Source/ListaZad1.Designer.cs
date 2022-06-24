namespace Lab2_win_forms
{
    partial class Lista1
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
            this.wykres = new OxyPlot.WindowsForms.PlotView();
            this.ChooseZad = new System.Windows.Forms.Button();
            this.TcNumeric = new System.Windows.Forms.NumericUpDown();
            this.FsNumeric = new System.Windows.Forms.NumericUpDown();
            this.fNumeric = new System.Windows.Forms.NumericUpDown();
            this.FiNumeric = new System.Windows.Forms.NumericUpDown();
            this.TrwanieSygnaluLabel = new System.Windows.Forms.Label();
            this.CzestotliwoscProbkowaniaLabel = new System.Windows.Forms.Label();
            this.fLabel = new System.Windows.Forms.Label();
            this.FiLabel = new System.Windows.Forms.Label();
            this.DefaultValues = new System.Windows.Forms.Button();
            this.Zad1 = new System.Windows.Forms.Button();
            this.Zad2 = new System.Windows.Forms.Button();
            this.Zad4 = new System.Windows.Forms.Button();
            this.Zad3 = new System.Windows.Forms.Button();
            this.WartosciLabel = new System.Windows.Forms.Label();
            this.WykresyLabel = new System.Windows.Forms.Label();
            this.Z2ComboBox = new System.Windows.Forms.ComboBox();
            this.Z4NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // wykres
            // 
            this.wykres.BackColor = System.Drawing.Color.LightGray;
            this.wykres.Location = new System.Drawing.Point(12, 12);
            this.wykres.Name = "wykres";
            this.wykres.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.wykres.Size = new System.Drawing.Size(1128, 307);
            this.wykres.TabIndex = 0;
            this.wykres.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.wykres.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.wykres.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // ChooseZad
            // 
            this.ChooseZad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseZad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseZad.Location = new System.Drawing.Point(1054, 622);
            this.ChooseZad.Name = "ChooseZad";
            this.ChooseZad.Size = new System.Drawing.Size(86, 35);
            this.ChooseZad.TabIndex = 1;
            this.ChooseZad.Text = "Wybór Zad";
            this.ChooseZad.UseVisualStyleBackColor = true;
            this.ChooseZad.Click += new System.EventHandler(this.ChooseZad_Click);
            // 
            // TcNumeric
            // 
            this.TcNumeric.DecimalPlaces = 2;
            this.TcNumeric.Location = new System.Drawing.Point(12, 350);
            this.TcNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TcNumeric.Name = "TcNumeric";
            this.TcNumeric.Size = new System.Drawing.Size(120, 20);
            this.TcNumeric.TabIndex = 2;
            this.TcNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TcNumeric.ThousandsSeparator = true;
            // 
            // FsNumeric
            // 
            this.FsNumeric.DecimalPlaces = 2;
            this.FsNumeric.Location = new System.Drawing.Point(12, 376);
            this.FsNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FsNumeric.Name = "FsNumeric";
            this.FsNumeric.Size = new System.Drawing.Size(120, 20);
            this.FsNumeric.TabIndex = 3;
            this.FsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FsNumeric.ThousandsSeparator = true;
            // 
            // fNumeric
            // 
            this.fNumeric.DecimalPlaces = 2;
            this.fNumeric.Location = new System.Drawing.Point(12, 402);
            this.fNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fNumeric.Name = "fNumeric";
            this.fNumeric.Size = new System.Drawing.Size(120, 20);
            this.fNumeric.TabIndex = 4;
            this.fNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fNumeric.ThousandsSeparator = true;
            // 
            // FiNumeric
            // 
            this.FiNumeric.DecimalPlaces = 2;
            this.FiNumeric.Location = new System.Drawing.Point(12, 428);
            this.FiNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FiNumeric.Name = "FiNumeric";
            this.FiNumeric.Size = new System.Drawing.Size(120, 20);
            this.FiNumeric.TabIndex = 5;
            this.FiNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FiNumeric.ThousandsSeparator = true;
            // 
            // TrwanieSygnaluLabel
            // 
            this.TrwanieSygnaluLabel.AutoSize = true;
            this.TrwanieSygnaluLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrwanieSygnaluLabel.Location = new System.Drawing.Point(138, 350);
            this.TrwanieSygnaluLabel.Name = "TrwanieSygnaluLabel";
            this.TrwanieSygnaluLabel.Size = new System.Drawing.Size(214, 17);
            this.TrwanieSygnaluLabel.TabIndex = 6;
            this.TrwanieSygnaluLabel.Text = "Czas trwania sygnału(Tc) [s]";
            // 
            // CzestotliwoscProbkowaniaLabel
            // 
            this.CzestotliwoscProbkowaniaLabel.AutoSize = true;
            this.CzestotliwoscProbkowaniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CzestotliwoscProbkowaniaLabel.Location = new System.Drawing.Point(138, 376);
            this.CzestotliwoscProbkowaniaLabel.Name = "CzestotliwoscProbkowaniaLabel";
            this.CzestotliwoscProbkowaniaLabel.Size = new System.Drawing.Size(269, 17);
            this.CzestotliwoscProbkowaniaLabel.TabIndex = 7;
            this.CzestotliwoscProbkowaniaLabel.Text = "Częstotliwość próbkowania (Fs) [Hz]";
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel.Location = new System.Drawing.Point(138, 402);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(13, 17);
            this.fLabel.TabIndex = 8;
            this.fLabel.Text = "f";
            // 
            // FiLabel
            // 
            this.FiLabel.AutoSize = true;
            this.FiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiLabel.Location = new System.Drawing.Point(138, 428);
            this.FiLabel.Name = "FiLabel";
            this.FiLabel.Size = new System.Drawing.Size(47, 17);
            this.FiLabel.TabIndex = 9;
            this.FiLabel.Text = "Fi (ϕ)";
            // 
            // DefaultValues
            // 
            this.DefaultValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultValues.Location = new System.Drawing.Point(12, 454);
            this.DefaultValues.Name = "DefaultValues";
            this.DefaultValues.Size = new System.Drawing.Size(120, 35);
            this.DefaultValues.TabIndex = 11;
            this.DefaultValues.Text = "Default Values";
            this.DefaultValues.UseVisualStyleBackColor = true;
            this.DefaultValues.Click += new System.EventHandler(this.DefaultValues_Click);
            // 
            // Zad1
            // 
            this.Zad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zad1.Location = new System.Drawing.Point(12, 520);
            this.Zad1.Name = "Zad1";
            this.Zad1.Size = new System.Drawing.Size(60, 35);
            this.Zad1.TabIndex = 12;
            this.Zad1.Text = "Z1";
            this.Zad1.UseVisualStyleBackColor = true;
            this.Zad1.Click += new System.EventHandler(this.Zad1_Click);
            // 
            // Zad2
            // 
            this.Zad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zad2.Location = new System.Drawing.Point(12, 561);
            this.Zad2.Name = "Zad2";
            this.Zad2.Size = new System.Drawing.Size(60, 35);
            this.Zad2.TabIndex = 13;
            this.Zad2.Text = "Z2";
            this.Zad2.UseVisualStyleBackColor = true;
            this.Zad2.Click += new System.EventHandler(this.Zad2_Click);
            // 
            // Zad4
            // 
            this.Zad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zad4.Location = new System.Drawing.Point(12, 643);
            this.Zad4.Name = "Zad4";
            this.Zad4.Size = new System.Drawing.Size(60, 35);
            this.Zad4.TabIndex = 14;
            this.Zad4.Text = "Z4";
            this.Zad4.UseVisualStyleBackColor = true;
            this.Zad4.Click += new System.EventHandler(this.Zad4_Click);
            // 
            // Zad3
            // 
            this.Zad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zad3.Location = new System.Drawing.Point(12, 602);
            this.Zad3.Name = "Zad3";
            this.Zad3.Size = new System.Drawing.Size(60, 35);
            this.Zad3.TabIndex = 15;
            this.Zad3.Text = "Z3";
            this.Zad3.UseVisualStyleBackColor = true;
            this.Zad3.Click += new System.EventHandler(this.Zad3_Click);
            // 
            // WartosciLabel
            // 
            this.WartosciLabel.AutoSize = true;
            this.WartosciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WartosciLabel.Location = new System.Drawing.Point(12, 322);
            this.WartosciLabel.Name = "WartosciLabel";
            this.WartosciLabel.Size = new System.Drawing.Size(104, 25);
            this.WartosciLabel.TabIndex = 16;
            this.WartosciLabel.Text = "Wartości:";
            // 
            // WykresyLabel
            // 
            this.WykresyLabel.AutoSize = true;
            this.WykresyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WykresyLabel.Location = new System.Drawing.Point(7, 492);
            this.WykresyLabel.Name = "WykresyLabel";
            this.WykresyLabel.Size = new System.Drawing.Size(103, 25);
            this.WykresyLabel.TabIndex = 17;
            this.WykresyLabel.Text = "Wykresy:";
            // 
            // Z2ComboBox
            // 
            this.Z2ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z2ComboBox.FormattingEnabled = true;
            this.Z2ComboBox.IntegralHeight = false;
            this.Z2ComboBox.Items.AddRange(new object[] {
            "y(t)",
            "z(t)",
            "v(t)"});
            this.Z2ComboBox.Location = new System.Drawing.Point(78, 563);
            this.Z2ComboBox.Name = "Z2ComboBox";
            this.Z2ComboBox.Size = new System.Drawing.Size(54, 33);
            this.Z2ComboBox.TabIndex = 18;
            // 
            // Z4NumericUpDown
            // 
            this.Z4NumericUpDown.Location = new System.Drawing.Point(78, 652);
            this.Z4NumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Z4NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Z4NumericUpDown.Name = "Z4NumericUpDown";
            this.Z4NumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.Z4NumericUpDown.TabIndex = 19;
            this.Z4NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Z4NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kCounter
            // 
            this.kCounter.AutoSize = true;
            this.kCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kCounter.Location = new System.Drawing.Point(138, 652);
            this.kCounter.Name = "kCounter";
            this.kCounter.Size = new System.Drawing.Size(84, 17);
            this.kCounter.TabIndex = 20;
            this.kCounter.Text = "k = {1,2,3}";
            // 
            // Lista1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 709);
            this.Controls.Add(this.kCounter);
            this.Controls.Add(this.Z4NumericUpDown);
            this.Controls.Add(this.Z2ComboBox);
            this.Controls.Add(this.WykresyLabel);
            this.Controls.Add(this.WartosciLabel);
            this.Controls.Add(this.Zad3);
            this.Controls.Add(this.Zad4);
            this.Controls.Add(this.Zad2);
            this.Controls.Add(this.Zad1);
            this.Controls.Add(this.DefaultValues);
            this.Controls.Add(this.FiLabel);
            this.Controls.Add(this.fLabel);
            this.Controls.Add(this.CzestotliwoscProbkowaniaLabel);
            this.Controls.Add(this.TrwanieSygnaluLabel);
            this.Controls.Add(this.FiNumeric);
            this.Controls.Add(this.fNumeric);
            this.Controls.Add(this.FsNumeric);
            this.Controls.Add(this.TcNumeric);
            this.Controls.Add(this.ChooseZad);
            this.Controls.Add(this.wykres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Lista1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmisja Danych - Lista 1";
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView wykres;
        private System.Windows.Forms.Button ChooseZad;
        private System.Windows.Forms.NumericUpDown TcNumeric;
        private System.Windows.Forms.NumericUpDown FsNumeric;
        private System.Windows.Forms.NumericUpDown fNumeric;
        private System.Windows.Forms.NumericUpDown FiNumeric;
        private System.Windows.Forms.Label TrwanieSygnaluLabel;
        private System.Windows.Forms.Label CzestotliwoscProbkowaniaLabel;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Label FiLabel;
        private System.Windows.Forms.Button DefaultValues;
        private System.Windows.Forms.Button Zad1;
        private System.Windows.Forms.Button Zad2;
        private System.Windows.Forms.Button Zad4;
        private System.Windows.Forms.Button Zad3;
        private System.Windows.Forms.Label WartosciLabel;
        private System.Windows.Forms.Label WykresyLabel;
        private System.Windows.Forms.ComboBox Z2ComboBox;
        private System.Windows.Forms.NumericUpDown Z4NumericUpDown;
        private System.Windows.Forms.Label kCounter;
    }
}