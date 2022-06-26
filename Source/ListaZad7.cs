using Lab2_win_forms.Assets;
using Lab2_win_forms.KodyDoZadan;
using System;
using System.Linq;
using System.Windows.Forms;
// ReSharper disable LocalizableElement
// ReSharper disable PossibleMultipleEnumeration

namespace Lab2_win_forms {
    public partial class ListaZad7 : Form {
        private readonly ListaKod4 _lista4 = new ListaKod4();
        private readonly ListaKod5 _lista5 = new ListaKod5();
        private readonly ListaKod6 _lista6 = new ListaKod6();
        private readonly ListaKod7 _lista7 = new ListaKod7();

        #region Syf

        public ListaZad7() {
            InitializeComponent();
        }

        private void ChooseZad_Click(object sender, EventArgs e) {
            Hide();
            var wyborZadania = new WybierzZad();
            wyborZadania.Closed += (s, args) => this.Close();
            wyborZadania.Show();
        }

        private void DefaultValues_Click(object sender, EventArgs e) {
            TcNumeric.Value = 2;
            FsNumeric.Value = 4096;
            A1Numeric.Value = (decimal)0.5;
            A2Numeric.Value = 1;
            ANumeric.Value = 1;
            WNumeric.Value = 2;
            alfaNumeric.Value = (decimal)0.5;
            betaNumeric.Value = 5;
            outputBox74.Text = @"";
            inputBox74.Text = @"01000110011110101110111000011110001110001101";
            berCounter.Text = @"Wspolczynnik BER: N/A";
        }

        #endregion

        #region Z1

        private void CodeButtonASK_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length < 42) {
                MessageBox.Show(@"Musisz wpisac min. 42 bity!");
            } else {
                var input = HelperFuncs.DivideAndConvertToBits(inputBox74.Text, 4);
                var hammCodeResult = _lista7.Hamming74JagArr(input);
                var stringAsk = "";
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 7; j++) {
                        stringAsk += hammCodeResult[i][j].ToString();
                    }
                }

                // Zrob smiglo i string => int arr[]
                var combinedHammCoded = new int[stringAsk.Length];
                for (var i = 0; i < stringAsk.Length; i++) {
                    combinedHammCoded[i] = (int)char.GetNumericValue(stringAsk[i]);
                }

                // Dane do ASK
                var fs = (double)FsNumeric.Value;
                var tc = (double)TcNumeric.Value;
                var w = (double)WNumeric.Value;
                var a1 = (double)A1Numeric.Value;
                var a2 = (double)A2Numeric.Value;
                var a = (double)ANumeric.Value;
                var tb = tc / (inputBox74.Text.Length / 4 * 7);
                var fn = w / tb;
                var n = (int)tc * (int)fs;
                var ts = 1.0 / fs;

                // Modulacja ASK
                var modulateAsk = _lista7.PrzesuwAmplitudyAsk(n, combinedHammCoded, tb, ts, a1, a2, fn);

                // Demodulacja ASK
                var xt = _lista7.XOdT(modulateAsk, a, n, ts, fn);
                var itgr = _lista5.Itgr(xt, n, tb, fs);
                var largerH = _lista7.MoreThanH(itgr, n, a1, a2); // H z automatu
                var hammCodedArray = HelperFuncs.ConvertBackToHammCodedArr(largerH, tb, tc, n, ts);

                // Split into 7 elements long jagged arrays
                var splittedHammCodedArray = HelperFuncs.DivideArray(hammCodedArray, 7);

                // Decode each array and assign result to string + create int[] from result 
                var decodedString = "";
                var odebraneArr = new int[input.Length * 4];
                var tmp = 0;
                for (var i = 0; i < splittedHammCodedArray.Length; i++) {
                    var decodedArr = _lista6.Hamming74Decoder(splittedHammCodedArray[i], false);
                    for (var j = 0; j < 4; j++) {
                        decodedString += decodedArr.ElementAt(j);
                        odebraneArr[tmp] = decodedArr.ElementAt(j);
                        tmp++;
                    }
                }

                //BER = E/N (E - Liczba bitow odebranych blednie, N - liczbe bitow przeslanych)
                // Przeslane => input, E => roznica odebranych i przeslanych
                var przeslaneArr = new int[input.Length * 4];
                var inputCnter = 0;
                // Create int[] from input
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 4; j++) {
                        przeslaneArr[inputCnter] = input[i][j];
                        inputCnter++;
                    }
                }
                var ber = _lista7.BerCounter(przeslaneArr, odebraneArr);
                // Results into txtboxes
                berCounter.Text = @"Wspolczynnik BER: " + ber;
                outputBox74.Text = decodedString;
            }
        }

        #endregion

        #region Z2

        private void CodeButtonASK2_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length < 42) {
                MessageBox.Show(@"Musisz wpisac min. 42 bity!");
            } else {
                var input = HelperFuncs.DivideAndConvertToBits(inputBox74.Text, 4);
                var hammCodeResult = _lista7.Hamming74JagArr(input);
                var stringAsk = "";
                for (var i = 0; i < hammCodeResult.Length; i++) {
                    for (var j = 0; j < 7; j++) {
                        stringAsk += hammCodeResult[i][j].ToString();
                    }
                }

                // Zrob smiglo i string => int arr[]
                var combinedHammCoded = new int[stringAsk.Length];
                for (var i = 0; i < stringAsk.Length; i++) {
                    combinedHammCoded[i] = (int)char.GetNumericValue(stringAsk[i]);
                }

                // Dane do ASK
                var fs = (double)FsNumeric.Value;
                var tc = (double)TcNumeric.Value;
                var w = (double)WNumeric.Value;
                var a1 = (double)A1Numeric.Value;
                var a2 = (double)A2Numeric.Value;
                var a = (double)ANumeric.Value;
                var alfa = (double)alfaNumeric.Value;
                var tb = tc / (inputBox74.Text.Length / 4 * 7);
                var fn = w / tb;
                var n = (int)tc * (int)fs;
                var ts = 1.0 / fs;

                // Modulacja ASK
                var modulateAsk = _lista7.PrzesuwAmplitudyAsk(n, combinedHammCoded, tb, ts, a1, a2, fn);

                // KANAL TRANSMISYJNY 
                var gOdT = HelperFuncs.GenerateWhiteNoise(0, 1, alfa, n);
                var xt = _lista7.XOdT(modulateAsk, a, n, ts, fn);
                //y(t) => x(t) + g(t) * a
                //y(t)=>integral=>...
                var yOdT = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT[i] = xt[i] + gOdT[i];
                }

                // Demodulacja ASK
                var itgr = _lista5.Itgr(yOdT, n, tb, fs);
                var largerH = _lista7.MoreThanH(itgr, n, a1, a2); // H z automatu
                //var largerH = _lista5.MoreThanH(itgr, n, 572); //H z palca wpisywane
                var hammCodedArray = HelperFuncs.ConvertBackToHammCodedArr(largerH, tb, tc, n, ts);

                // Split into 7 elements long jagged arrays
                var splittedHammCodedArray = HelperFuncs.DivideArray(hammCodedArray, 7);

                // Decode each array and assign result to string + create int[] from result 
                var decodedString = "";
                var odebraneArr = new int[input.Length * 4];
                var tmp = 0;
                for (var i = 0; i < splittedHammCodedArray.Length; i++) {
                    var decodedArr = _lista6.Hamming74Decoder(splittedHammCodedArray[i], false);
                    for (var j = 0; j < 4; j++) {
                        decodedString += decodedArr.ElementAt(j);
                        odebraneArr[tmp] = decodedArr.ElementAt(j);
                        tmp++;
                    }
                }

                //BER = E/N (E - Liczba bitow odebranych blednie, N - liczbe bitow przeslanych)
                // Przeslane => input, E => roznica odebranych i przeslanych
                var przeslaneArr = new int[input.Length * 4];
                var inputCnter = 0;
                // Create int[] from input
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 4; j++) {
                        przeslaneArr[inputCnter] = input[i][j];
                        inputCnter++;
                    }
                }


                // Calculate ber
                var ber = _lista7.BerCounter(przeslaneArr, odebraneArr);

                // Put all results into display
                outputBox74.Text = decodedString;
                berCounter.Text = @"Wspolczynnik BER: " + ber;
            }
        }

        private void CodeButtonPSK2_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length < 42) {
                MessageBox.Show(@"Musisz wpisac min. 42 bity!");
            } else {
                var input = HelperFuncs.DivideAndConvertToBits(inputBox74.Text, 4);
                var hammCodeResult = _lista7.Hamming74JagArr(input);
                var stringAsk = "";
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 7; j++) {
                        stringAsk += hammCodeResult[i][j].ToString();
                    }
                }

                // Zrob smiglo i string => int arr[]
                var combinedHammCoded = new int[stringAsk.Length];
                for (var i = 0; i < stringAsk.Length; i++) {
                    combinedHammCoded[i] = (int)char.GetNumericValue(stringAsk[i]);
                }

                // Dane do ASK
                var fs = (double)FsNumeric.Value;
                var tc = (double)TcNumeric.Value;
                var w = (double)WNumeric.Value;
                var a = (double)ANumeric.Value;
                var alfa = (double)alfaNumeric.Value;
                var tb = tc / (inputBox74.Text.Length / 4 * 7);
                var fn = w / tb;
                var n = (int)tc * (int)fs;
                var ts = 1.0 / fs;

                // Modulacja PSK
                var modulatePsk = _lista7.PrzesuwFazyPsk(n, combinedHammCoded, tb, ts, fn);

                // KANAL TRANSMISYJNY 
                var gOdT = HelperFuncs.GenerateWhiteNoise(0, 1, alfa, n);
                var xt = _lista7.XOdT(modulatePsk, a, n, ts, fn);
                //y(t) => x(t) + g(t)*a 
                //y(t)=>integral=>...
                var yOdT = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT[i] = xt[i] + gOdT[i];
                }

                // Demodulacja ASK
                var itgr = _lista5.Itgr(yOdT, n, tb, fs);
                //var largerH = _lista7.MoreThanH(itgr, n, a1, a2); // H z automatu
                var largerH = _lista5.MoreThanH(itgr, n, 0); //H z palca wpisywane
                var hammCodedArray = HelperFuncs.ConvertBackToHammCodedArr(largerH, tb, tc, n, ts);

                // Split into 7 elements long jagged arrays
                var splittedHammCodedArray = HelperFuncs.DivideArray(hammCodedArray, 7);

                // Decode each array and assign result to string + create int[] from result 
                var decodedString = "";
                var odebraneArr = new int[input.Length * 4];
                var tmp = 0;
                for (var i = 0; i < splittedHammCodedArray.Length; i++) {
                    var decodedArr = _lista6.Hamming74Decoder(splittedHammCodedArray[i], false);
                    for (var j = 0; j < 4; j++) {
                        decodedString += decodedArr.ElementAt(j);
                        odebraneArr[tmp] = decodedArr.ElementAt(j);
                        tmp++;
                    }
                }

                //BER = E/N (E - Liczba bitow odebranych blednie, N - liczbe bitow przeslanych)
                // Przeslane => input, E => roznica odebranych i przeslanych
                var przeslaneArr = new int[input.Length * 4];
                var inputCnter = 0;
                // Create int[] from input
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 4; j++) {
                        przeslaneArr[inputCnter] = input[i][j];
                        inputCnter++;
                    }
                }


                // Calculate ber
                var ber = _lista7.BerCounter(przeslaneArr, odebraneArr);

                // Put all results into display
                outputBox74.Text = decodedString;
                berCounter.Text = @"Wspolczynnik BER: " + ber;
            }
        }

        private void CodeButtonFSK2_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length < 42) {
                MessageBox.Show(@"Musisz wpisac min. 42 bity!");
            } else {
                var input = HelperFuncs.DivideAndConvertToBits(inputBox74.Text, 4);
                var hammCodeResult = _lista7.Hamming74JagArr(input);
                var stringAsk = "";
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 7; j++) {
                        stringAsk += hammCodeResult[i][j].ToString();
                    }
                }

                // Zrob smiglo i string => int arr[]
                var combinedHammCoded = new int[stringAsk.Length];
                for (var i = 0; i < stringAsk.Length; i++) {
                    combinedHammCoded[i] = (int)char.GetNumericValue(stringAsk[i]);
                }

                // Dane do FSK
                var fs = (double)FsNumeric.Value;
                var tc = (double)TcNumeric.Value;
                var w = (double)WNumeric.Value;
                var a = (double)ANumeric.Value;
                var alfa = (double)alfaNumeric.Value;
                var tb = tc / (inputBox74.Text.Length / 4 * 7);
                var n = (int)tc * (int)fs;
                var ts = 1.0 / fs;
                var fn1 = w + 1 / tb;
                var fn2 = w + 2 / tb;

                // Modulacja FSK
                var modulateFsk = _lista7.PrzesuwCzestotliwosciFsk(n, combinedHammCoded, ts, tb, fn1, fn2);

                // KANAL TRANSMISYJNY 
                var gOdT = HelperFuncs.GenerateWhiteNoise(0, 1, alfa, n);
                var xt1 = _lista7.XOdT(modulateFsk, a, n, ts, fn1);
                var xt2 = _lista7.XOdT(modulateFsk, a, n, ts, fn2);
                //y(t) => x(t) + g(t)*a 
                //y(t)=>integral=>...
                var yOdT1 = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT1[i] = xt1[i] + gOdT[i];
                }

                var yOdT2 = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT2[i] = xt2[i] + gOdT[i];
                }

                // Demodulacja FSK
                //var itgr1 = _lista5.Itgr(yOdT1, n, tb, fs);
                //var itgr2 = _lista5.Itgr(yOdT2, n, tb, fs);
                var itgr1 = _lista7.Itgr(yOdT1, n, tb, fs);
                var itgr2 = _lista7.Itgr(yOdT2, n, tb, fs);

                var itgrCombined = _lista4.CombineArrays(itgr1, itgr2);
               // var largerH = _lista7.MoreThanH(itgrCombined, n, a1, a2); // H z automatu
                var largerH = _lista5.MoreThanH(itgrCombined, n, 0); //H z palca wpisywane
                var hammCodedArray = HelperFuncs.ConvertBackToHammCodedArr(largerH, tb, tc, n, ts);

                // Split into 7 elements long jagged arrays
                var splittedHammCodedArray = HelperFuncs.DivideArray(hammCodedArray, 7);

                // Decode each array and assign result to string + create int[] from result 
                var decodedString = "";
                var odebraneArr = new int[input.Length * 4];
                var tmp = 0;
                for (var i = 0; i < splittedHammCodedArray.Length; i++) {
                    var decodedArr = _lista6.Hamming74Decoder(splittedHammCodedArray[i], false);
                    for (var j = 0; j < 4; j++) {
                        decodedString += decodedArr.ElementAt(j);
                        odebraneArr[tmp] = decodedArr.ElementAt(j);
                        tmp++;
                    }
                }

                //BER = E/N (E - Liczba bitow odebranych blednie, N - liczbe bitow przeslanych)
                // Przeslane => input, E => roznica odebranych i przeslanych
                var przeslaneArr = new int[input.Length * 4];
                var inputCnter = 0;
                // Create int[] from input
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 4; j++) {
                        przeslaneArr[inputCnter] = input[i][j];
                        inputCnter++;
                    }
                }


                // Calculate ber
                var ber = _lista7.BerCounter(przeslaneArr, odebraneArr);

                // Put all results into display
                outputBox74.Text = decodedString;
                berCounter.Text = @"Wspolczynnik BER: " + ber;
            }
        }

        #endregion

        #region Z3

        private void codeButtonASK3_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length < 42) {
                MessageBox.Show(@"Musisz wpisac min. 42 bity!");
            } else {
                var input = HelperFuncs.DivideAndConvertToBits(inputBox74.Text, 4);
                var hammCodeResult = _lista7.Hamming74JagArr(input);
                var stringAsk = "";
                for (var i = 0; i < hammCodeResult.Length; i++) {
                    for (var j = 0; j < 7; j++) {
                        stringAsk += hammCodeResult[i][j].ToString();
                    }
                }

                // Zrob smiglo i string => int arr[]
                var combinedHammCoded = new int[stringAsk.Length];
                for (var i = 0; i < stringAsk.Length; i++) {
                    combinedHammCoded[i] = (int)char.GetNumericValue(stringAsk[i]);
                }

                // Dane do ASK
                var fs = (double)FsNumeric.Value;
                var tc = (double)TcNumeric.Value;
                var w = (double)WNumeric.Value;
                var a1 = (double)A1Numeric.Value;
                var a2 = (double)A2Numeric.Value;
                var a = (double)ANumeric.Value;
                var beta = (double)betaNumeric.Value;
                var tb = tc / (inputBox74.Text.Length / 4 * 7);
                var fn = w / tb;
                var n = (int)tc * (int)fs;
                var ts = 1.0 / fs;

                // Modulacja ASK
                var modulateAsk = _lista7.PrzesuwAmplitudyAsk(n, combinedHammCoded, tb, ts, a1, a2, fn);

                // KANAL TRANSMISYJNY 
                var xt = _lista7.XOdT(modulateAsk, a, n, ts, fn);
                var yOdT = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT[i] = xt[i] * Math.Pow(Math.E, (-beta) * xt[i]);
                }

                // Demodulacja ASK
                var itgr = _lista5.Itgr(yOdT, n, tb, fs);
                var largerH = _lista7.MoreThanH(itgr, n, a1, a2); // H z automatu
                var hammCodedArray = HelperFuncs.ConvertBackToHammCodedArr(largerH, tb, tc, n, ts);

                // Split into 7 elements long jagged arrays
                var splittedHammCodedArray = HelperFuncs.DivideArray(hammCodedArray, 7);

                // Decode each array and assign result to string + create int[] from result 
                var decodedString = "";
                var odebraneArr = new int[input.Length * 4];
                var tmp = 0;
                for (var i = 0; i < splittedHammCodedArray.Length; i++) {
                    var decodedArr = _lista6.Hamming74Decoder(splittedHammCodedArray[i], false);
                    for (var j = 0; j < 4; j++) {
                        decodedString += decodedArr.ElementAt(j);
                        odebraneArr[tmp] = decodedArr.ElementAt(j);
                        tmp++;
                    }
                }

                //BER = E/N (E - Liczba bitow odebranych blednie, N - liczbe bitow przeslanych)
                // Przeslane => input, E => roznica odebranych i przeslanych
                var przeslaneArr = new int[input.Length * 4];
                var inputCnter = 0;
                // Create int[] from input
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 4; j++) {
                        przeslaneArr[inputCnter] = input[i][j];
                        inputCnter++;
                    }
                }


                // Calculate ber
                var ber = _lista7.BerCounter(przeslaneArr, odebraneArr);

                // Put all results into display
                outputBox74.Text = decodedString;
                berCounter.Text = @"Wspolczynnik BER: " + ber;
            }
        }

        private void codeButtonPSK3_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length < 42) {
                MessageBox.Show(@"Musisz wpisac min. 42 bity!");
            } else {
                var input = HelperFuncs.DivideAndConvertToBits(inputBox74.Text, 4);
                var hammCodeResult = _lista7.Hamming74JagArr(input);
                var stringAsk = "";
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 7; j++) {
                        stringAsk += hammCodeResult[i][j].ToString();
                    }
                }

                // Zrob smiglo i string => int arr[]
                var combinedHammCoded = new int[stringAsk.Length];
                for (var i = 0; i < stringAsk.Length; i++) {
                    combinedHammCoded[i] = (int)char.GetNumericValue(stringAsk[i]);
                }

                // Dane do ASK
                var fs = (double)FsNumeric.Value;
                var tc = (double)TcNumeric.Value;
                var w = (double)WNumeric.Value;
                var a = (double)ANumeric.Value;
                var beta = (double)betaNumeric.Value;
                var tb = tc / (inputBox74.Text.Length / 4 * 7);
                var fn = w / tb;
                var n = (int)tc * (int)fs;
                var ts = 1.0 / fs;

                // Modulacja PSK
                var modulatePsk = _lista7.PrzesuwFazyPsk(n, combinedHammCoded, tb, ts, fn);

                // KANAL TRANSMISYJNY 
                var xt = _lista7.XOdT(modulatePsk, a, n, ts, fn);
                var yOdT = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT[i] = xt[i] * Math.Pow(Math.E, (-beta) * xt[i]);
                }

                // Demodulacja ASK
                var itgr = _lista5.Itgr(yOdT, n, tb, fs);
                //var largerH = _lista7.MoreThanH(itgr, n, a1, a2); // H z automatu
                var largerH = _lista5.MoreThanH(itgr, n, 0); //H z palca wpisywane
                var hammCodedArray = HelperFuncs.ConvertBackToHammCodedArr(largerH, tb, tc, n, ts);

                // Split into 7 elements long jagged arrays
                // Split into 7 elements long jagged arrays
                var splittedHammCodedArray = HelperFuncs.DivideArray(hammCodedArray, 7);

                // Decode each array and assign result to string + create int[] from result 
                var decodedString = "";
                var odebraneArr = new int[input.Length * 4];
                var tmp = 0;
                for (var i = 0; i < splittedHammCodedArray.Length; i++) {
                    var decodedArr = _lista6.Hamming74Decoder(splittedHammCodedArray[i], false);
                    for (var j = 0; j < 4; j++) {
                        decodedString += decodedArr.ElementAt(j);
                        odebraneArr[tmp] = decodedArr.ElementAt(j);
                        tmp++;
                    }
                }

                //BER = E/N (E - Liczba bitow odebranych blednie, N - liczbe bitow przeslanych)
                // Przeslane => input, E => roznica odebranych i przeslanych
                var przeslaneArr = new int[input.Length * 4];
                var inputCnter = 0;
                // Create int[] from input
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 4; j++) {
                        przeslaneArr[inputCnter] = input[i][j];
                        inputCnter++;
                    }
                }


                // Calculate ber
                var ber = _lista7.BerCounter(przeslaneArr, odebraneArr);

                // Put all results into display
                outputBox74.Text = decodedString;
                berCounter.Text = @"Wspolczynnik BER: " + ber;
            }
        }

        private void codeButtonFSK3_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length < 42) {
                MessageBox.Show(@"Musisz wpisac min. 42 bity!");
            } else {
                var input = HelperFuncs.DivideAndConvertToBits(inputBox74.Text, 4);
                var hammCodeResult = _lista7.Hamming74JagArr(input);
                var stringAsk = "";
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 7; j++) {
                        stringAsk += hammCodeResult[i][j].ToString();
                    }
                }

                // Zrob smiglo i string => int arr[]
                var combinedHammCoded = new int[stringAsk.Length];
                for (var i = 0; i < stringAsk.Length; i++) {
                    combinedHammCoded[i] = (int)char.GetNumericValue(stringAsk[i]);
                }

                // Dane do FSK
                var fs = (double)FsNumeric.Value;
                var tc = (double)TcNumeric.Value;
                var w = (double)WNumeric.Value;
                var a1 = (double)A1Numeric.Value;
                var a2 = (double)A2Numeric.Value;
                var a = (double)ANumeric.Value;
                var beta = (double)betaNumeric.Value;
                var tb = tc / (inputBox74.Text.Length / 4 * 7);
                var n = (int)tc * (int)fs;
                var ts = 1.0 / fs;
                var fn1 = w + 1 / tb;
                var fn2 = w + 2 / tb;

                // Modulacja FSK
                var modulateFsk = _lista7.PrzesuwCzestotliwosciFsk(n, combinedHammCoded, ts, tb, fn1, fn2);

                // KANAL TRANSMISYJNY 
                var xt1 = _lista7.XOdT(modulateFsk, a, n, ts, fn1);
                var xt2 = _lista7.XOdT(modulateFsk, a, n, ts, fn2);
                var yOdT1 = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT1[i] = xt1[i] * Math.Pow(Math.E, (-beta) * xt1[i]);
                }
                var yOdT2 = new double[n];
                for (var i = 0; i < n; i++) {
                    yOdT2[i] = xt2[i] * Math.Pow(Math.E, (-beta)* xt2[i]);
                }

                // Demodulacja FSK
                //var itgr1 = _lista5.Itgr(yOdT1, n, tb, fs);
                //var itgr2 = _lista5.Itgr(yOdT2, n, tb, fs);
                var itgr1 = _lista7.Itgr(yOdT1, n, tb, fs);
                var itgr2 = _lista7.Itgr(yOdT2, n, tb, fs);
                
                var itgrCombined = _lista4.CombineArrays(itgr1, itgr2);
                var largerH = _lista7.MoreThanH(itgrCombined, n, a1, a2); // H z automatu
                var hammCodedArray = HelperFuncs.ConvertBackToHammCodedArr(largerH, tb, tc, n, ts);

                // Split into 7 elements long jagged arrays
                var splittedHammCodedArray = HelperFuncs.DivideArray(hammCodedArray, 7);

                // Decode each array and assign result to string + create int[] from result 
                var decodedString = "";
                var odebraneArr = new int[input.Length * 4];
                var tmp = 0;
                for (var i = 0; i < splittedHammCodedArray.Length; i++) {
                    var decodedArr = _lista6.Hamming74Decoder(splittedHammCodedArray[i], false);
                    for (var j = 0; j < 4; j++) {
                        decodedString += decodedArr.ElementAt(j);
                        odebraneArr[tmp] = decodedArr.ElementAt(j);
                        tmp++;
                    }
                }

                //BER = E/N (E - Liczba bitow odebranych blednie, N - liczbe bitow przeslanych)
                // Przeslane => input, E => roznica odebranych i przeslanych
                var przeslaneArr = new int[input.Length * 4];
                var inputCnter = 0;
                // Create int[] from input
                for (var i = 0; i < input.Length; i++) {
                    for (var j = 0; j < 4; j++) {
                        przeslaneArr[inputCnter] = input[i][j];
                        inputCnter++;
                    }
                }

                // Calculate ber
                var ber = _lista7.BerCounter(przeslaneArr, odebraneArr);

                // Put all results into display
                outputBox74.Text = decodedString;
                berCounter.Text = @"Wspolczynnik BER: " + ber;
            }
        }

        #endregion

    }
}