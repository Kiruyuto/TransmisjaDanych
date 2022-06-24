using System;
using System.Windows.Forms;
using Lab2_win_forms.KodyDoZadan;
using static Lab2_win_forms.Assets.HelperFuncs;

namespace Lab2_win_forms {
    public partial class Lista1 : Form {
        private readonly ListaKod1 _lista1 = new ListaKod1();

        #region syf
        public Lista1() {
            InitializeComponent();
            Z2ComboBox.SelectedIndex = 0;
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
            wykres.Model = GenerateChartDft(item1, item2, n, "Amplituda", "t[s]");
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
                    wykres.Model = GenerateChartDft(tupleZad2.Item1, tupleZad2.Item2, n, "Amplituda", "t[s]");
                    break;
                case 1:
                    wykres.Model = GenerateChartDft(tupleZad2.Item3, tupleZad2.Item4, n, "Amplituda", "t[s]");
                    break;
                case 2:
                    wykres.Model = GenerateChartDft(tupleZad2.Item5, tupleZad2.Item6, n, "Amplituda", "t[s]");
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
            wykres.Model = GenerateChartDft(item1, item2, n, "Amplituda", "t[s]");
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
            wykres.Model = GenerateChartDft(item1, item2, n, "Amplituda", "t[s]");
        }
        #endregion
    }
}