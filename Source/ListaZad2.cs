using System;
using System.Diagnostics;
using System.Windows.Forms;
using DSPLib;
using Lab2_win_forms.Assets;
using Lab2_win_forms.KodyDoZadan;
using static Lab2_win_forms.Assets.HelperFuncs;

namespace Lab2_win_forms {
    public partial class Lista2 : Form {
        private readonly ListaKod1 _lista1 = new ListaKod1();
        private readonly ListaKod2 _lista2 = new ListaKod2();
        private const string DenyFft = @"Nie można wykonać FFT na danym zakresie";
        private const string NotApplicable = @"N/A";

        #region Syf
        public Lista2() {
            InitializeComponent();
            Z2ComboBox.SelectedIndex = 0;
            Z2DFTCombBox.SelectedIndex = 0;
            Z2FFTComboBox.SelectedIndex = 0;
            dataGridView1.Rows.Add(8);
            dataGridView1.Rows[0].Cells[0].Value = "Z1";
            dataGridView1.Rows[1].Cells[0].Value = "Z2 y";
            dataGridView1.Rows[2].Cells[0].Value = "Z2 z";
            dataGridView1.Rows[3].Cells[0].Value = "Z2 v";
            dataGridView1.Rows[4].Cells[0].Value = "Z3";
            dataGridView1.Rows[5].Cells[0].Value = "Z4 k1";
            dataGridView1.Rows[6].Cells[0].Value = "Z4 k2";
            dataGridView1.Rows[7].Cells[0].Value = "Z4 k3";
        }

        private void ChooseZad_Click(object sender, EventArgs e) {
            Hide();
            var wyborZadania = new WybierzZad();
            wyborZadania.Closed += (s, args) => this.Close();
            wyborZadania.Show();
        }

        private void DefaultValues_Click(object sender, EventArgs e) {
            TcNumeric.Value = 1;
            FsNumeric.Value = 2048;
            fNumeric.Value = 5;
            FiNumeric.Value = 0;
        }
        #endregion

        #region List1
        private void Zad1_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var f = (double)fNumeric.Value;
            var fi = (double)FiNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu
            var (item1, item2) = _lista1.ZadanieNumer1(fs, f, fi, n);
            wykres.Model = GenerateChartDft(item1, item2, n, "", "");
        }

        private void Zad2_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var f = (double)fNumeric.Value;
            var fi = (double)FiNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu
            var tupleZad2 = _lista1.ZadanieNumer2(fs, f, fi, n);
            switch (Z2ComboBox.SelectedIndex) {
                case 0:
                    wykres.Model = GenerateChartDft(tupleZad2.Item1, tupleZad2.Item2, n, "", "");
                    break;
                case 1:
                    wykres.Model = GenerateChartDft(tupleZad2.Item3, tupleZad2.Item4, n, "", "");
                    break;
                case 2:
                    wykres.Model = GenerateChartDft(tupleZad2.Item5, tupleZad2.Item6, n, "", "");
                    break;
            }

        }

        private void Zad3_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu
            var (item1, item2) = _lista1.ZadanieNumer3(fs, n);
            wykres.Model = GenerateChartDft(item1, item2, n, "", "");
        }

        private void Zad4_Click(object sender, EventArgs e) {
            //Dane do zadania:
            const int tc = 1;
            TcNumeric.Value = tc;
            const int fs = 22050;
            FsNumeric.Value = fs;
            const int n = tc * fs;
            //Rysowanie wykresu
            var (item1, item2) = _lista1.ZadanieNumer4((int)Z4NumericUpDown.Value, fs, n);
            wykres.Model = GenerateChartDft(item1, item2, n, "", "");
        }
        #endregion

        #region List2 - DFT
        private void Z1DFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var f = (double)fNumeric.Value;
            var fi = (double)FiNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer1(fs, f, fi, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            timer.Start();
            var (item1, item2) = _lista2.Dft(signal.Item2, n);
            timer.Stop();
            dataGridView1.Rows[0].Cells[1].Value = timer.ElapsedMilliseconds;
            var y = _lista2.WidmoAmplitudowe(item1, item2, n);
            wykres.Model = GenerateChartDft(x, y, n, "", "");
        }

        private void Z2DFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var f = (double)fNumeric.Value;
            var fi = (double)FiNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer2(fs, f, fi, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            Tuple<double[], double[]> dftSignal = null;
            switch (Z2DFTCombBox.SelectedIndex) {
                case 0:
                    timer.Start();
                    dftSignal = _lista2.Dft(signal.Item2, n);
                    timer.Stop();
                    dataGridView1.Rows[1].Cells[1].Value = timer.ElapsedMilliseconds;
                    break;
                case 1:
                    timer.Start();
                    dftSignal = _lista2.Dft(signal.Item4, n);
                    timer.Stop();
                    dataGridView1.Rows[2].Cells[1].Value = timer.ElapsedMilliseconds;
                    break;
                case 2:
                    timer.Start();
                    dftSignal = _lista2.Dft(signal.Item6, n);
                    timer.Stop();
                    dataGridView1.Rows[3].Cells[1].Value = timer.ElapsedMilliseconds;
                    break;

            }

            if (dftSignal != null) {
                var y = _lista2.WidmoAmplitudowe(dftSignal.Item1, dftSignal.Item2, n);
                wykres.Model = GenerateChartDft(x, y, n, "", "");
            } else {
                MessageBox.Show(@"System.NullReferenceException: Sygnal = NULL.");
            }
        }

        private void Z3DFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer3(fs, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            timer.Start();
            var (item1, item2) = _lista2.Dft(signal.Item2, n);
            timer.Stop();
            dataGridView1.Rows[4].Cells[1].Value = timer.ElapsedMilliseconds;
            var y = _lista2.WidmoAmplitudowe(item1, item2, n);
            wykres.Model = GenerateChartDft(x, y, n, "", "");
        }

        private void Z4DFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            FsNumeric.Value = 22050;
            TcNumeric.Value = 1;
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer4((int)Z4NumericUpDown.Value, fs, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            timer.Start();
            var (item1, item2) = _lista2.Dft(signal.Item2, n);
            timer.Stop();
            dataGridView1.Rows[4 + (int)Z4DFTNumericUpDown.Value].Cells[1].Value = timer.ElapsedMilliseconds;
            var y = _lista2.WidmoAmplitudowe(item1, item2, n);
            wykres.Model = HelperFuncs.GenerateChartDft(x, y, n, "", "");
            Z4FFT.Enabled = true;
        }
        #endregion

        #region List2 - FFT
        private void Z1FFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var f = (double)fNumeric.Value;
            var fi = (double)FiNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer1(fs, f, fi, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            //FFT
            var fft = new FFT();
            try {
                fft.Initialize((uint)n);
                timer.Start();
                var fftRes = fft.Execute(signal.Item2);
                timer.Stop();
                dataGridView1.Rows[0].Cells[2].Value = timer.ElapsedMilliseconds;
                var y = _lista2.WidmoAmplitudoweFft(fftRes, n);
                wykres.Model = GenerateChartDft(x, y, n, "", "");
            }
            catch (Exception) {
                MessageBox.Show(DenyFft);
                dataGridView1.Rows[0].Cells[2].Value = NotApplicable;
            }
        }

        private void Z2FFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var f = (double)fNumeric.Value;
            var fi = (double)FiNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer2(fs, f, fi, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            //FFT
            var fft = new FFT();
            switch (Z2FFTComboBox.SelectedIndex) {
                case 0:
                    try {
                        fft.Initialize((uint)n);
                        timer.Start();
                        var fftRes = fft.Execute(signal.Item2);
                        timer.Stop();
                        dataGridView1.Rows[1].Cells[2].Value = timer.ElapsedMilliseconds;
                        var y = _lista2.WidmoAmplitudoweFft(fftRes, n);
                        wykres.Model = GenerateChartDft(x, y, n, "", "");
                        break;
                    }
                    catch (Exception) {
                        MessageBox.Show(DenyFft);
                        dataGridView1.Rows[1].Cells[2].Value = NotApplicable;
                        break;
                    }
                case 1:
                    try {
                        fft.Initialize((uint)n);
                        timer.Start();
                        var fftRes = fft.Execute(signal.Item4);
                        timer.Stop();
                        dataGridView1.Rows[2].Cells[2].Value = timer.ElapsedMilliseconds;
                        var y = _lista2.WidmoAmplitudoweFft(fftRes, n);
                        wykres.Model = GenerateChartDft(x, y, n, "", "");
                        break;
                    }
                    catch (Exception) {
                        MessageBox.Show(DenyFft);
                        dataGridView1.Rows[2].Cells[2].Value = NotApplicable;
                        break;
                    }
                case 2:
                    try {
                        fft.Initialize((uint)n);
                        timer.Start();
                        var fftRes = fft.Execute(signal.Item6);
                        timer.Stop();
                        dataGridView1.Rows[3].Cells[2].Value = timer.ElapsedMilliseconds;
                        var y = _lista2.WidmoAmplitudoweFft(fftRes, n);
                        wykres.Model = GenerateChartDft(x, y, n, "", "");
                        break;
                    }
                    catch (Exception) {
                        MessageBox.Show(DenyFft);
                        dataGridView1.Rows[3].Cells[2].Value = NotApplicable;
                        break;
                    }
            }
        }

        private void Z3FFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var n = (int)tc * (int)fs;
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer3(fs, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            //FFT
            var fft = new FFT();
            try {
                fft.Initialize((uint)n);
                timer.Start();
                var fftRes = fft.Execute(signal.Item2);
                timer.Stop();
                dataGridView1.Rows[4].Cells[2].Value = timer.ElapsedMilliseconds;
                var y = _lista2.WidmoAmplitudoweFft(fftRes, n);
                wykres.Model = GenerateChartDft(x, y, n, "", "");
            }
            catch (Exception) {
                MessageBox.Show(DenyFft);
                dataGridView1.Rows[4].Cells[2].Value = NotApplicable;
            }
        }

        private void Z4FFT_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var tc = (double)TcNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var n = (int)tc * (int)fs;
            //Dane do zadania: PODANE W FUNKCJI.
            //Rysowanie wykresu + Zegar
            var timer = new Stopwatch();
            var signal = _lista1.ZadanieNumer4((int)Z4NumericUpDown.Value, fs, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            //FFT
            var fft = new FFT();
            try {
                fft.Initialize((uint)n);
                timer.Start();
                var fftRes = fft.Execute(signal.Item2);
                timer.Stop();
                dataGridView1.Rows[4 + (int)Z4DFTNumericUpDown.Value].Cells[2].Value = timer.ElapsedMilliseconds;
                var y = _lista2.WidmoAmplitudoweFft(fftRes, n);
                wykres.Model = GenerateChartDft(x, y, n, "", "");
            }
            catch (Exception) {
                MessageBox.Show(DenyFft);
                dataGridView1.Rows[4 + (int)Z4DFTNumericUpDown.Value].Cells[2].Value = NotApplicable;
            }
        }
        #endregion

    }
}