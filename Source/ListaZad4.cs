using System;
using System.Linq;
using System.Windows.Forms;
using DSPLib;
using Lab2_win_forms.KodyDoZadan;
using Lab2_win_forms.Assets;

namespace Lab2_win_forms {
    public partial class Lista4 : Form {

        #region Syf

        private readonly ListaKod2 _lista2 = new ListaKod2();
        private readonly ListaKod4 _lista4 = new ListaKod4();
        private readonly ListaKod5 _lista5 = new ListaKod5();

        public Lista4() {
            InitializeComponent();
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
            A1Numeric.Value = 2;
            A2Numeric.Value = 14;
            ANumeric.Value = 1;
            WNumeric.Value = 2;
            txtBox.Text = @"xdD";
        }

        private void TxtBox_TextChanged(object sender, EventArgs e) {
            var str = txtBox.Text;
            var cnt = str.Aggregate(0, (current, t) => current + t);

            txtValueCounter.Text = cnt.ToString();
            var binArr = HelperFuncs.ConvertText(txtBox.Text, 7);
            binBox.Text = "";
            foreach (var item in binArr) {
                binBox.Text += item + @" ";
            }
        }
        #endregion

        #region Zad 3

        private void Amplituda_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var a1 = (int)A1Numeric.Value;
            var a2 = (int)A2Numeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn = w / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var ask = _lista4.PrzesuwAmplitudyAsk(n, inputString, tb, ts, a1, a2, fn);
            //wykres.Model = HelperFuncs.RysujWidmo(x, amplitudaDFTWidmoDecybelowa, N);
            wykres.Model = HelperFuncs.GenerateChartDft(x, ask, n, "", "");
        }

        private void FazaA_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn = w / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var psk = _lista4.PrzesuwFazyPsk(n, inputString, tb, ts, fn);
            wykres.Model = HelperFuncs.GenerateChartDft(x, psk, n, "", "");
        }

        private void CzestotliwoscA_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn1 = w + 1 / tb;
            var fn2 = w + 2 / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var fsk = _lista4.PrzesuwCzestotliwosciFsk(n, inputString, tb, ts, fn1, fn2);
            wykres.Model = HelperFuncs.GenerateChartDft(x, fsk, n, "", "");
        }

        #endregion

        #region Zad4

        private void AmpWidmo_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var a1 = (int)A1Numeric.Value;
            var a2 = (int)A2Numeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn = w / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var ask = _lista4.PrzesuwAmplitudyAsk(n, inputString, tb, ts, a1, a2, fn);
            //var (item1, item2) = _lista2.Dft(ask, n);
            //var dftWidmo = _lista2.WidmoAmplitudowe(item1, item2, n);
            var fft = new FFT();
            fft.Initialize((uint)n);
            var fftRes = fft.Execute(ask);
            var fftWidmo = _lista2.WidmoAmplitudoweFft(fftRes, n);
            var widmoDecybelowa = _lista2.SkalaDecybelowa(fftWidmo, n);
            wykres.Model = HelperFuncs.GenerateChartDft(x, widmoDecybelowa, n, "", "");
        }

        private void FazaWidmo_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn = w / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var psk = _lista4.PrzesuwFazyPsk(n, inputString, tb, ts, fn);
            //var (item1, item2) = _lista2.Dft(psk, n);
            //var dftWidmo = _lista2.WidmoAmplitudowe(item1, item2, n);
            var fft = new FFT();
            fft.Initialize((uint)n);
            var fftRes = fft.Execute(psk);
            var fftWidmo = _lista2.WidmoAmplitudoweFft(fftRes, n);
            var widmoDecybelowa = _lista2.SkalaDecybelowa(fftWidmo, n);
            wykres.Model = HelperFuncs.GenerateChartDft(x, widmoDecybelowa, n, "", "");
        }

        private void CzestWidmo_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn1 = w + 1 / tb;
            var fn2 = w + 2 / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var fsk = _lista4.PrzesuwCzestotliwosciFsk(n, inputString, tb, ts, fn1, fn2);
            //var (item1, item2) = _lista2.Dft(fsk, n);
            //var dftWidmo = _lista2.WidmoAmplitudowe(item1, item2, n);
            var fft = new FFT();
            fft.Initialize((uint)n);
            var fftRes = fft.Execute(fsk);
            var fftWidmo = _lista2.WidmoAmplitudoweFft(fftRes, n);
            var widmoDecybelowa = _lista2.SkalaDecybelowa(fftWidmo, n);
            wykres.Model = HelperFuncs.GenerateChartDft(x, widmoDecybelowa, n, "", "");
        }

        #endregion

        #region Lab 5

        private void DemodulatorASKButton_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var a = (double)ANumeric.Value;
            var a1 = (int)A1Numeric.Value;
            var a2 = (int)A2Numeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn = w / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var ask = _lista4.PrzesuwAmplitudyAsk(n, inputString, tb, ts, a1, a2, fn);
            var xt = _lista5.XOdT(ask, a, fn, ts, n);
            var itgr = _lista5.Itgr(xt, n, tb, fs);
            var largerH = _lista5.MoreThanH(itgr, n, 572);

            wykres.Model = HelperFuncs.GenerateChartDft(x, largerH, n, "", "");
        }

        private void DemodulatorPSKButton_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var a = (double)ANumeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn = w / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var psk = _lista4.PrzesuwFazyPsk(n, inputString, tb, ts, fn);
            var xt = _lista5.XOdT(psk, a, fn, ts, n);
            var itgr = _lista5.Itgr(xt, n, tb, fs);
            var largerH = _lista5.MoreThanH(itgr, n, 0);

            wykres.Model = HelperFuncs.GenerateChartDft(x, largerH, n, "", "");
        }

        private void DemodulatorFSKButton_Click(object sender, EventArgs e) {
            //Dane do zadania:
            var fs = (double)FsNumeric.Value;
            var tc = (double)TcNumeric.Value;
            var w = (double)WNumeric.Value;
            var a = (double)ANumeric.Value;
            var inputString = txtBox.Text;
            var tb = tc / (inputString.Length * 7);
            var fn1 = w + 1 / tb;
            var fn2 = w + 2 / tb;
            var n = (int)tc * (int)fs;
            var ts = 1.0 / fs;

            var x = HelperFuncs.GenT(n, ts);
            var fsk = _lista4.PrzesuwCzestotliwosciFsk(n, inputString, tb, ts, fn1, fn2);
            var xt1 = _lista5.XOdT(fsk, a, fn1, ts, n);
            var xt2 = _lista5.XOdT(fsk, a, fn2, ts, n);
            var itgr1 = _lista5.Itgr(xt1, n, tb, fs);
            var itgr2 = _lista5.Itgr(xt2, n, tb, fs);
            var itgrCombined = _lista4.CombineArrays(itgr1, itgr2);
            var largerH = _lista5.MoreThanH(itgrCombined, n, 0);

            wykres.Model = HelperFuncs.GenerateChartDft(x, largerH, n, "", "");
        }

        #endregion
    }
}