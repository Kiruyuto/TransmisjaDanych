using Lab2_win_forms.Assets;
using Lab2_win_forms.KodyDoZadan;
using System;
using System.Windows.Forms;
using DSPLib;

namespace Lab2_win_forms {
    public partial class Lista3 : Form {
        private readonly ListaKod2 _lista2 = new ListaKod2();
        private readonly ListaKod3 _lista3 = new ListaKod3();

        #region Syf
        
        public Lista3() {
            InitializeComponent();
        }

        private void ChooseZad_Click(object sender, EventArgs e) {
            Hide();
            var wyborZadania = new WybierzZad();
            wyborZadania.Closed += (s, args) => this.Close();
            wyborZadania.Show();
        }

        private void DefaultValues_Click(object sender, EventArgs e) {
            FnNumeric.Value = 100;
            FmNumeric.Value = 5;
            TcNumeric.Value = 1;
            FsNumeric.Value = 2048;
            fNumeric.Value = 10;
            FiNumeric.Value = 0;
        }
        #endregion


        #region Modulacja amplitudy i kata

        private void AmplitudaA_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fn = (double)FnNumeric.Value;
            var fm = (double)FmNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var n = (int)tc * (int)fs;
            var ka = (double)AmplitudaNumeric.Value;
            //Wykresy
            var mOdT = _lista3.MtArray(fm, n);
            var amplituda = _lista3.ModulacjaAmplitudy(mOdT, ka, fn, n);
            var fft = new FFT();
            try {
                fft.Initialize((uint)n);
                var fftRes = fft.Execute(amplituda);
                var amplitudaDftWidmo = _lista2.WidmoAmplitudoweFft(fftRes, n);
                var amplitudaDftWidmoDecybelowa = _lista2.SkalaDecybelowa(amplitudaDftWidmo, n);
                var x = _lista2.SkalaCzestotliwosci(fs, n);
                wykres.Model = HelperFuncs.GenerateChartDft(x, amplitudaDftWidmoDecybelowa, n, "", "");
            }
            catch (Exception) {
                MessageBox.Show(@"Nie można wykonać FFT na danym zakresie");
            }
        }

        private void FazaA_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fn = (double)FnNumeric.Value;
            var fm = (double)FmNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var n = (int)tc * (int)fs;
            var kp = (double)FazaNumeric.Value;
            //Wykresy
            var mOdT = _lista3.MtArray(fm, n);
            var faza = _lista3.ModulacjaFazy(mOdT, fn, kp, n);
            //var fft = new FFT();
            //try {
            //fft.Initialize((uint)n);
            //var fftRes = fft.Execute(faza);
            var (item1, item2) = _lista2.Dft(faza, n);

            var fazaDftWidmo = _lista2.WidmoAmplitudowe(item1, item2, n);
            var fazaDftWidmoDecybelowa = _lista2.SkalaDecybelowa(fazaDftWidmo, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            wykres.Model = HelperFuncs.GenerateChartDft(x, fazaDftWidmoDecybelowa, n, "", "");
            //}
            //catch (Exception) {
            //    MessageBox.Show(@"Nie można wykonać FFT na danym zakresie");
            //}
        }

        private void CzestotliwoscA_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fn = (double)FnNumeric.Value;
            var fm = (double)FmNumeric.Value;
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var n = (int)tc * (int)fs;
            var kf = (double)CzestotliwoscNumeric.Value;
            //Wykresy
            var mOdT = _lista3.MtArray(fm, n);
            var czestotliwosc = _lista3.ModulacjaCzestotliwosci(mOdT, fn, fm, kf, n);
            //var fft = new FFT();
            //fft.Initialize((uint)n);
            //var fftRes = fft.Execute(czestotliwosc);
            var (item1, item2) = _lista2.Dft(czestotliwosc, n);
            var czestotliwoscDftWidmo = _lista2.WidmoAmplitudowe(item1, item2, n);
            var czestotliwoscDftWidmoDecybelowa = _lista2.SkalaDecybelowa(czestotliwoscDftWidmo, n);
            var x = _lista2.SkalaCzestotliwosci(fs, n);
            wykres.Model = HelperFuncs.GenerateChartDft(x, czestotliwoscDftWidmoDecybelowa, n, "", "");

            //foreach (var xd in czestotliwosc) {
            //    Console.WriteLine(xd);
            //}
        }
        #endregion
    }
}
