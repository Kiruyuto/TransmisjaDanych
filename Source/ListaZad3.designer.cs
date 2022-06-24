
namespace Lab2_win_forms {
    partial class Lista3 {
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
            System.Windows.Forms.Label CzestotliwoscLabel;
            this.wykres = new OxyPlot.WindowsForms.PlotView();
            this.ChooseZad = new System.Windows.Forms.Button();
            this.FnNumeric = new System.Windows.Forms.NumericUpDown();
            this.FmNumeric = new System.Windows.Forms.NumericUpDown();
            this.TrwanieSygnaluLabel = new System.Windows.Forms.Label();
            this.CzestotliwoscProbkowaniaLabel = new System.Windows.Forms.Label();
            this.DefaultValues = new System.Windows.Forms.Button();
            this.WartosciLabel = new System.Windows.Forms.Label();
            this.AmplitudaLabel = new System.Windows.Forms.Label();
            this.AmplitudaA = new System.Windows.Forms.Button();
            this.FazaLabel = new System.Windows.Forms.Label();
            this.FazaA = new System.Windows.Forms.Button();
            this.CzestotliwoscA = new System.Windows.Forms.Button();
            this.FiLabel = new System.Windows.Forms.Label();
            this.fLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiNumeric = new System.Windows.Forms.NumericUpDown();
            this.fNumeric = new System.Windows.Forms.NumericUpDown();
            this.FsNumeric = new System.Windows.Forms.NumericUpDown();
            this.TcNumeric = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.FazaNumeric = new System.Windows.Forms.NumericUpDown();
            this.AmplitudaNumeric = new System.Windows.Forms.NumericUpDown();
            this.CzestotliwoscNumeric = new System.Windows.Forms.NumericUpDown();
            CzestotliwoscLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FnNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FmNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CzestotliwoscNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // CzestotliwoscLabel
            // 
            CzestotliwoscLabel.AutoSize = true;
            CzestotliwoscLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CzestotliwoscLabel.Location = new System.Drawing.Point(8, 659);
            CzestotliwoscLabel.Name = "CzestotliwoscLabel";
            CzestotliwoscLabel.Size = new System.Drawing.Size(257, 25);
            CzestotliwoscLabel.TabIndex = 25;
            CzestotliwoscLabel.Text = "Modulacja częstotliwości:";
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
            this.ChooseZad.Location = new System.Drawing.Point(1054, 697);
            this.ChooseZad.Name = "ChooseZad";
            this.ChooseZad.Size = new System.Drawing.Size(86, 35);
            this.ChooseZad.TabIndex = 1;
            this.ChooseZad.Text = "Wybór Zad";
            this.ChooseZad.UseVisualStyleBackColor = true;
            this.ChooseZad.Click += new System.EventHandler(this.ChooseZad_Click);
            // 
            // FnNumeric
            // 
            this.FnNumeric.DecimalPlaces = 2;
            this.FnNumeric.Location = new System.Drawing.Point(13, 455);
            this.FnNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FnNumeric.Name = "FnNumeric";
            this.FnNumeric.Size = new System.Drawing.Size(130, 20);
            this.FnNumeric.TabIndex = 2;
            this.FnNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FnNumeric.ThousandsSeparator = true;
            // 
            // FmNumeric
            // 
            this.FmNumeric.DecimalPlaces = 2;
            this.FmNumeric.Location = new System.Drawing.Point(11, 481);
            this.FmNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FmNumeric.Name = "FmNumeric";
            this.FmNumeric.Size = new System.Drawing.Size(132, 20);
            this.FmNumeric.TabIndex = 3;
            this.FmNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FmNumeric.ThousandsSeparator = true;
            // 
            // TrwanieSygnaluLabel
            // 
            this.TrwanieSygnaluLabel.AutoSize = true;
            this.TrwanieSygnaluLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrwanieSygnaluLabel.Location = new System.Drawing.Point(147, 455);
            this.TrwanieSygnaluLabel.Name = "TrwanieSygnaluLabel";
            this.TrwanieSygnaluLabel.Size = new System.Drawing.Size(26, 17);
            this.TrwanieSygnaluLabel.TabIndex = 6;
            this.TrwanieSygnaluLabel.Text = "Fn";
            // 
            // CzestotliwoscProbkowaniaLabel
            // 
            this.CzestotliwoscProbkowaniaLabel.AutoSize = true;
            this.CzestotliwoscProbkowaniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CzestotliwoscProbkowaniaLabel.Location = new System.Drawing.Point(147, 481);
            this.CzestotliwoscProbkowaniaLabel.Name = "CzestotliwoscProbkowaniaLabel";
            this.CzestotliwoscProbkowaniaLabel.Size = new System.Drawing.Size(29, 17);
            this.CzestotliwoscProbkowaniaLabel.TabIndex = 7;
            this.CzestotliwoscProbkowaniaLabel.Text = "Fm";
            // 
            // DefaultValues
            // 
            this.DefaultValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultValues.Location = new System.Drawing.Point(216, 429);
            this.DefaultValues.Name = "DefaultValues";
            this.DefaultValues.Size = new System.Drawing.Size(202, 72);
            this.DefaultValues.TabIndex = 11;
            this.DefaultValues.Text = "Default Values";
            this.DefaultValues.UseVisualStyleBackColor = true;
            this.DefaultValues.Click += new System.EventHandler(this.DefaultValues_Click);
            // 
            // WartosciLabel
            // 
            this.WartosciLabel.AutoSize = true;
            this.WartosciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WartosciLabel.Location = new System.Drawing.Point(8, 323);
            this.WartosciLabel.Name = "WartosciLabel";
            this.WartosciLabel.Size = new System.Drawing.Size(104, 25);
            this.WartosciLabel.TabIndex = 16;
            this.WartosciLabel.Text = "Wartości:";
            // 
            // AmplitudaLabel
            // 
            this.AmplitudaLabel.AutoSize = true;
            this.AmplitudaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmplitudaLabel.Location = new System.Drawing.Point(7, 504);
            this.AmplitudaLabel.Name = "AmplitudaLabel";
            this.AmplitudaLabel.Size = new System.Drawing.Size(216, 25);
            this.AmplitudaLabel.TabIndex = 17;
            this.AmplitudaLabel.Text = "Modulacja amplitudy:";
            // 
            // AmplitudaA
            // 
            this.AmplitudaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmplitudaA.Location = new System.Drawing.Point(11, 531);
            this.AmplitudaA.Name = "AmplitudaA";
            this.AmplitudaA.Size = new System.Drawing.Size(132, 47);
            this.AmplitudaA.TabIndex = 22;
            this.AmplitudaA.Text = "Amplituda";
            this.AmplitudaA.UseVisualStyleBackColor = true;
            this.AmplitudaA.Click += new System.EventHandler(this.AmplitudaA_Click);
            // 
            // FazaLabel
            // 
            this.FazaLabel.AutoSize = true;
            this.FazaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FazaLabel.Location = new System.Drawing.Point(6, 581);
            this.FazaLabel.Name = "FazaLabel";
            this.FazaLabel.Size = new System.Drawing.Size(164, 25);
            this.FazaLabel.TabIndex = 26;
            this.FazaLabel.Text = "Modulacja fazy:";
            // 
            // FazaA
            // 
            this.FazaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FazaA.Location = new System.Drawing.Point(13, 609);
            this.FazaA.Name = "FazaA";
            this.FazaA.Size = new System.Drawing.Size(132, 47);
            this.FazaA.TabIndex = 27;
            this.FazaA.Text = "Faza";
            this.FazaA.UseVisualStyleBackColor = true;
            this.FazaA.Click += new System.EventHandler(this.FazaA_Click);
            // 
            // CzestotliwoscA
            // 
            this.CzestotliwoscA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CzestotliwoscA.Location = new System.Drawing.Point(12, 687);
            this.CzestotliwoscA.Name = "CzestotliwoscA";
            this.CzestotliwoscA.Size = new System.Drawing.Size(132, 45);
            this.CzestotliwoscA.TabIndex = 30;
            this.CzestotliwoscA.Text = "Częstotliwość";
            this.CzestotliwoscA.UseVisualStyleBackColor = true;
            this.CzestotliwoscA.Click += new System.EventHandler(this.CzestotliwoscA_Click);
            // 
            // FiLabel
            // 
            this.FiLabel.AutoSize = true;
            this.FiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiLabel.Location = new System.Drawing.Point(149, 429);
            this.FiLabel.Name = "FiLabel";
            this.FiLabel.Size = new System.Drawing.Size(47, 17);
            this.FiLabel.TabIndex = 41;
            this.FiLabel.Text = "Fi (ϕ)";
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabel.Location = new System.Drawing.Point(149, 403);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(13, 17);
            this.fLabel.TabIndex = 40;
            this.fLabel.Text = "f";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Częstotliwość próbkowania (Fs) [Hz]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Czas trwania sygnału (Tc) [s]";
            // 
            // FiNumeric
            // 
            this.FiNumeric.DecimalPlaces = 2;
            this.FiNumeric.Location = new System.Drawing.Point(13, 429);
            this.FiNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FiNumeric.Name = "FiNumeric";
            this.FiNumeric.Size = new System.Drawing.Size(130, 20);
            this.FiNumeric.TabIndex = 37;
            this.FiNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FiNumeric.ThousandsSeparator = true;
            // 
            // fNumeric
            // 
            this.fNumeric.DecimalPlaces = 2;
            this.fNumeric.Location = new System.Drawing.Point(13, 403);
            this.fNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fNumeric.Name = "fNumeric";
            this.fNumeric.Size = new System.Drawing.Size(130, 20);
            this.fNumeric.TabIndex = 36;
            this.fNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fNumeric.ThousandsSeparator = true;
            // 
            // FsNumeric
            // 
            this.FsNumeric.DecimalPlaces = 2;
            this.FsNumeric.Location = new System.Drawing.Point(13, 377);
            this.FsNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FsNumeric.Name = "FsNumeric";
            this.FsNumeric.Size = new System.Drawing.Size(130, 20);
            this.FsNumeric.TabIndex = 35;
            this.FsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FsNumeric.ThousandsSeparator = true;
            // 
            // TcNumeric
            // 
            this.TcNumeric.DecimalPlaces = 2;
            this.TcNumeric.Location = new System.Drawing.Point(13, 351);
            this.TcNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TcNumeric.Name = "TcNumeric";
            this.TcNumeric.Size = new System.Drawing.Size(130, 20);
            this.TcNumeric.TabIndex = 34;
            this.TcNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TcNumeric.ThousandsSeparator = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTextBox1.Location = new System.Drawing.Point(150, 531);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(130, 47);
            this.richTextBox1.TabIndex = 42;
            this.richTextBox1.Text = "A) 1 > Ka > 0\nB) 12 > Ka > 2\nC) Ka > 20";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox2.Location = new System.Drawing.Point(150, 609);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(130, 47);
            this.richTextBox2.TabIndex = 43;
            this.richTextBox2.Text = "A) Kp < 1\nB) 𝝅 > Kp >0\nC) Kp > 2𝝅";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(150, 687);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(130, 47);
            this.richTextBox3.TabIndex = 44;
            this.richTextBox3.Text = "A) Kf < 1\nB) 𝝅 > Kf > 0\nC) Kf > 2𝝅";
            // 
            // FazaNumeric
            // 
            this.FazaNumeric.DecimalPlaces = 2;
            this.FazaNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.FazaNumeric.Location = new System.Drawing.Point(248, 624);
            this.FazaNumeric.Name = "FazaNumeric";
            this.FazaNumeric.Size = new System.Drawing.Size(67, 20);
            this.FazaNumeric.TabIndex = 45;
            this.FazaNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FazaNumeric.ThousandsSeparator = true;
            // 
            // AmplitudaNumeric
            // 
            this.AmplitudaNumeric.DecimalPlaces = 2;
            this.AmplitudaNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.AmplitudaNumeric.Location = new System.Drawing.Point(248, 546);
            this.AmplitudaNumeric.Name = "AmplitudaNumeric";
            this.AmplitudaNumeric.Size = new System.Drawing.Size(67, 20);
            this.AmplitudaNumeric.TabIndex = 46;
            this.AmplitudaNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmplitudaNumeric.ThousandsSeparator = true;
            // 
            // CzestotliwoscNumeric
            // 
            this.CzestotliwoscNumeric.DecimalPlaces = 2;
            this.CzestotliwoscNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.CzestotliwoscNumeric.Location = new System.Drawing.Point(248, 701);
            this.CzestotliwoscNumeric.Name = "CzestotliwoscNumeric";
            this.CzestotliwoscNumeric.Size = new System.Drawing.Size(67, 20);
            this.CzestotliwoscNumeric.TabIndex = 47;
            this.CzestotliwoscNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CzestotliwoscNumeric.ThousandsSeparator = true;
            // 
            // Lista3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 744);
            this.Controls.Add(this.CzestotliwoscNumeric);
            this.Controls.Add(this.AmplitudaNumeric);
            this.Controls.Add(this.FazaNumeric);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FiLabel);
            this.Controls.Add(this.fLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiNumeric);
            this.Controls.Add(this.fNumeric);
            this.Controls.Add(this.FsNumeric);
            this.Controls.Add(this.TcNumeric);
            this.Controls.Add(this.CzestotliwoscA);
            this.Controls.Add(this.FazaA);
            this.Controls.Add(this.FazaLabel);
            this.Controls.Add(CzestotliwoscLabel);
            this.Controls.Add(this.AmplitudaA);
            this.Controls.Add(this.AmplitudaLabel);
            this.Controls.Add(this.WartosciLabel);
            this.Controls.Add(this.DefaultValues);
            this.Controls.Add(this.CzestotliwoscProbkowaniaLabel);
            this.Controls.Add(this.TrwanieSygnaluLabel);
            this.Controls.Add(this.FmNumeric);
            this.Controls.Add(this.FnNumeric);
            this.Controls.Add(this.ChooseZad);
            this.Controls.Add(this.wykres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Lista3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmisja Danych - Lista 3";
            ((System.ComponentModel.ISupportInitialize)(this.FnNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FmNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FazaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CzestotliwoscNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView wykres;
        private System.Windows.Forms.Button ChooseZad;
        private System.Windows.Forms.NumericUpDown FnNumeric;
        private System.Windows.Forms.NumericUpDown FmNumeric;
        private System.Windows.Forms.Label TrwanieSygnaluLabel;
        private System.Windows.Forms.Label CzestotliwoscProbkowaniaLabel;
        private System.Windows.Forms.Button DefaultValues;
        private System.Windows.Forms.Label WartosciLabel;
        private System.Windows.Forms.Label AmplitudaLabel;
        private System.Windows.Forms.Button AmplitudaA;
        private System.Windows.Forms.Label FazaLabel;
        private System.Windows.Forms.Button FazaA;
        private System.Windows.Forms.Button CzestotliwoscA;
        private System.Windows.Forms.Label FiLabel;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FiNumeric;
        private System.Windows.Forms.NumericUpDown fNumeric;
        private System.Windows.Forms.NumericUpDown FsNumeric;
        private System.Windows.Forms.NumericUpDown TcNumeric;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.NumericUpDown FazaNumeric;
        private System.Windows.Forms.NumericUpDown AmplitudaNumeric;
        private System.Windows.Forms.NumericUpDown CzestotliwoscNumeric;
    }
}