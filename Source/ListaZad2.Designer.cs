namespace Lab2_win_forms
{
    partial class Lista2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DFTLabel = new System.Windows.Forms.Label();
            this.Z1DFT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FFTCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z2DFT = new System.Windows.Forms.Button();
            this.Z2DFTCombBox = new System.Windows.Forms.ComboBox();
            this.Z3DFT = new System.Windows.Forms.Button();
            this.Z4DFT = new System.Windows.Forms.Button();
            this.FFTLabel = new System.Windows.Forms.Label();
            this.Z4FFT = new System.Windows.Forms.Button();
            this.Z3FFT = new System.Windows.Forms.Button();
            this.Z2FFT = new System.Windows.Forms.Button();
            this.Z1FFT = new System.Windows.Forms.Button();
            this.Z4DFTNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Z2FFTComboBox = new System.Windows.Forms.ComboBox();
            this.Z4FFTNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4DFTNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4FFTNumericUpDown)).BeginInit();
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
            this.ChooseZad.Location = new System.Drawing.Point(1054, 643);
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
            this.TrwanieSygnaluLabel.Size = new System.Drawing.Size(219, 17);
            this.TrwanieSygnaluLabel.TabIndex = 6;
            this.TrwanieSygnaluLabel.Text = "Czas trwania sygnału (Tc) [s]";
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
            this.Z2ComboBox.Location = new System.Drawing.Point(78, 561);
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
            // DFTLabel
            // 
            this.DFTLabel.AutoSize = true;
            this.DFTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFTLabel.Location = new System.Drawing.Point(236, 492);
            this.DFTLabel.Name = "DFTLabel";
            this.DFTLabel.Size = new System.Drawing.Size(61, 25);
            this.DFTLabel.TabIndex = 21;
            this.DFTLabel.Text = "DFT:";
            // 
            // Z1DFT
            // 
            this.Z1DFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z1DFT.Location = new System.Drawing.Point(241, 520);
            this.Z1DFT.Name = "Z1DFT";
            this.Z1DFT.Size = new System.Drawing.Size(122, 35);
            this.Z1DFT.TabIndex = 22;
            this.Z1DFT.Text = "Z1 - DFT";
            this.Z1DFT.UseVisualStyleBackColor = true;
            this.Z1DFT.Click += new System.EventHandler(this.Z1DFT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DFTCol,
            this.FFTCol});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(837, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(303, 225);
            this.dataGridView1.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // DFTCol
            // 
            this.DFTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            this.DFTCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.DFTCol.HeaderText = "DFT [ms]";
            this.DFTCol.MinimumWidth = 6;
            this.DFTCol.Name = "DFTCol";
            this.DFTCol.ReadOnly = true;
            this.DFTCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DFTCol.Width = 125;
            // 
            // FFTCol
            // 
            this.FFTCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.FFTCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.FFTCol.HeaderText = "FFT [ms]";
            this.FFTCol.MinimumWidth = 6;
            this.FFTCol.Name = "FFTCol";
            this.FFTCol.ReadOnly = true;
            this.FFTCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FFTCol.Width = 125;
            // 
            // Z2DFT
            // 
            this.Z2DFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z2DFT.Location = new System.Drawing.Point(241, 561);
            this.Z2DFT.Name = "Z2DFT";
            this.Z2DFT.Size = new System.Drawing.Size(122, 35);
            this.Z2DFT.TabIndex = 24;
            this.Z2DFT.Text = "Z2 - DFT";
            this.Z2DFT.UseVisualStyleBackColor = true;
            this.Z2DFT.Click += new System.EventHandler(this.Z2DFT_Click);
            // 
            // Z2DFTCombBox
            // 
            this.Z2DFTCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z2DFTCombBox.FormattingEnabled = true;
            this.Z2DFTCombBox.IntegralHeight = false;
            this.Z2DFTCombBox.Items.AddRange(new object[] {
            "y(t)",
            "z(t)",
            "v(t)"});
            this.Z2DFTCombBox.Location = new System.Drawing.Point(369, 561);
            this.Z2DFTCombBox.Name = "Z2DFTCombBox";
            this.Z2DFTCombBox.Size = new System.Drawing.Size(54, 33);
            this.Z2DFTCombBox.TabIndex = 25;
            // 
            // Z3DFT
            // 
            this.Z3DFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z3DFT.Location = new System.Drawing.Point(241, 602);
            this.Z3DFT.Name = "Z3DFT";
            this.Z3DFT.Size = new System.Drawing.Size(122, 35);
            this.Z3DFT.TabIndex = 26;
            this.Z3DFT.Text = "Z3 - DFT";
            this.Z3DFT.UseVisualStyleBackColor = true;
            this.Z3DFT.Click += new System.EventHandler(this.Z3DFT_Click);
            // 
            // Z4DFT
            // 
            this.Z4DFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z4DFT.Location = new System.Drawing.Point(241, 643);
            this.Z4DFT.Name = "Z4DFT";
            this.Z4DFT.Size = new System.Drawing.Size(122, 35);
            this.Z4DFT.TabIndex = 27;
            this.Z4DFT.Text = "Z4 - DFT";
            this.Z4DFT.UseVisualStyleBackColor = true;
            this.Z4DFT.Click += new System.EventHandler(this.Z4DFT_Click);
            // 
            // FFTLabel
            // 
            this.FFTLabel.AutoSize = true;
            this.FFTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FFTLabel.Location = new System.Drawing.Point(473, 492);
            this.FFTLabel.Name = "FFTLabel";
            this.FFTLabel.Size = new System.Drawing.Size(59, 25);
            this.FFTLabel.TabIndex = 28;
            this.FFTLabel.Text = "FFT:";
            // 
            // Z4FFT
            // 
            this.Z4FFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z4FFT.Location = new System.Drawing.Point(478, 641);
            this.Z4FFT.Name = "Z4FFT";
            this.Z4FFT.Size = new System.Drawing.Size(122, 35);
            this.Z4FFT.TabIndex = 32;
            this.Z4FFT.Text = "Z4 - FFT";
            this.Z4FFT.UseVisualStyleBackColor = true;
            this.Z4FFT.Click += new System.EventHandler(this.Z4FFT_Click);
            // 
            // Z3FFT
            // 
            this.Z3FFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z3FFT.Location = new System.Drawing.Point(478, 600);
            this.Z3FFT.Name = "Z3FFT";
            this.Z3FFT.Size = new System.Drawing.Size(122, 35);
            this.Z3FFT.TabIndex = 31;
            this.Z3FFT.Text = "Z3 - FFT";
            this.Z3FFT.UseVisualStyleBackColor = true;
            this.Z3FFT.Click += new System.EventHandler(this.Z3FFT_Click);
            // 
            // Z2FFT
            // 
            this.Z2FFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z2FFT.Location = new System.Drawing.Point(478, 559);
            this.Z2FFT.Name = "Z2FFT";
            this.Z2FFT.Size = new System.Drawing.Size(122, 35);
            this.Z2FFT.TabIndex = 30;
            this.Z2FFT.Text = "Z2 - FFT";
            this.Z2FFT.UseVisualStyleBackColor = true;
            this.Z2FFT.Click += new System.EventHandler(this.Z2FFT_Click);
            // 
            // Z1FFT
            // 
            this.Z1FFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z1FFT.Location = new System.Drawing.Point(478, 518);
            this.Z1FFT.Name = "Z1FFT";
            this.Z1FFT.Size = new System.Drawing.Size(122, 35);
            this.Z1FFT.TabIndex = 29;
            this.Z1FFT.Text = "Z1 - FFT";
            this.Z1FFT.UseVisualStyleBackColor = true;
            this.Z1FFT.Click += new System.EventHandler(this.Z1FFT_Click);
            // 
            // Z4DFTNumericUpDown
            // 
            this.Z4DFTNumericUpDown.Location = new System.Drawing.Point(369, 652);
            this.Z4DFTNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Z4DFTNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Z4DFTNumericUpDown.Name = "Z4DFTNumericUpDown";
            this.Z4DFTNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.Z4DFTNumericUpDown.TabIndex = 33;
            this.Z4DFTNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Z4DFTNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Z2FFTComboBox
            // 
            this.Z2FFTComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z2FFTComboBox.FormattingEnabled = true;
            this.Z2FFTComboBox.IntegralHeight = false;
            this.Z2FFTComboBox.Items.AddRange(new object[] {
            "y(t)",
            "z(t)",
            "v(t)"});
            this.Z2FFTComboBox.Location = new System.Drawing.Point(606, 561);
            this.Z2FFTComboBox.Name = "Z2FFTComboBox";
            this.Z2FFTComboBox.Size = new System.Drawing.Size(54, 33);
            this.Z2FFTComboBox.TabIndex = 34;
            // 
            // Z4FFTNumericUpDown
            // 
            this.Z4FFTNumericUpDown.Location = new System.Drawing.Point(606, 652);
            this.Z4FFTNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Z4FFTNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Z4FFTNumericUpDown.Name = "Z4FFTNumericUpDown";
            this.Z4FFTNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.Z4FFTNumericUpDown.TabIndex = 35;
            this.Z4FFTNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Z4FFTNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lista2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 686);
            this.Controls.Add(this.Z4FFTNumericUpDown);
            this.Controls.Add(this.Z2FFTComboBox);
            this.Controls.Add(this.Z4DFTNumericUpDown);
            this.Controls.Add(this.Z4FFT);
            this.Controls.Add(this.Z3FFT);
            this.Controls.Add(this.Z2FFT);
            this.Controls.Add(this.Z1FFT);
            this.Controls.Add(this.FFTLabel);
            this.Controls.Add(this.Z4DFT);
            this.Controls.Add(this.Z3DFT);
            this.Controls.Add(this.Z2DFTCombBox);
            this.Controls.Add(this.Z2DFT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Z1DFT);
            this.Controls.Add(this.DFTLabel);
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
            this.Name = "Lista2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmisja Danych - Lista 2";
            ((System.ComponentModel.ISupportInitialize)(this.TcNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4DFTNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z4FFTNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label DFTLabel;
        private System.Windows.Forms.Button Z1DFT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Z2DFT;
        private System.Windows.Forms.ComboBox Z2DFTCombBox;
        private System.Windows.Forms.Button Z3DFT;
        private System.Windows.Forms.Button Z4DFT;
        private System.Windows.Forms.Label FFTLabel;
        private System.Windows.Forms.Button Z4FFT;
        private System.Windows.Forms.Button Z3FFT;
        private System.Windows.Forms.Button Z2FFT;
        private System.Windows.Forms.Button Z1FFT;
        private System.Windows.Forms.NumericUpDown Z4DFTNumericUpDown;
        private System.Windows.Forms.ComboBox Z2FFTComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFTCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FFTCol;
        private System.Windows.Forms.NumericUpDown Z4FFTNumericUpDown;
    }
}