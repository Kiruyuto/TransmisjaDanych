using Lab2_win_forms.Assets;
using System;
using System.Linq;
// ReSharper disable LocalizableElement
// ReSharper disable PossibleLossOfFraction
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable ReturnTypeCanBeEnumerable.Global

namespace Lab2_win_forms.KodyDoZadan {
    internal class ListaKod7 {

        /// <summary>
        /// Koder (7, 4) dla wielu tablic
        /// </summary>
        /// <param name="input">jagged arr of 4-elements long arrays</param>
        /// <returns>jagg arr of 7-elem long arrays</returns>
        internal int[][] Hamming74JagArr(int[][] input) {
            // Init new arrs
            var size = input.Length;
            var result = new int[size][];
            for (var i = 0; i < size; i++) {
                result[i] = new int[7];
            }

            // 4bitowe slowo zapisuje sie na 3, 5, 6 i 7 bicie (forach arr)
            for (var i = 0; i < size; i++) {
                result[i][2] = input[i][0]; // x3 = 3 bit
                result[i][4] = input[i][1]; // x5 = 5 bit
                result[i][5] = input[i][2]; // x6 = 6 bit
                result[i][6] = input[i][3]; // x7 = 7 bit
                // Code
                var x1 = result[i][2] ^ result[i][4] ^ result[i][6];
                var x2 = result[i][2] ^ result[i][5] ^ result[i][6];
                var x4 = result[i][4] ^ result[i][5] ^ result[i][6];
                // Assign coding bits to arr
                result[i][0] = x1; // x1 = 1 bit
                result[i][1] = x2; // x2 = 2 bit
                result[i][3] = x4; // x4 = 4 bit
            }

            return result;
        }

        #region Kluczowania zmienione na int[]

        /// <summary>
        /// Kluczowanie z przesuwem amplitudy (ASK) dla int[]
        /// </summary>
        /// <param name="n">Rozmiar</param>
        /// <param name="input">Tablica wartosci wejsciowych</param>
        /// <param name="tb">Czas trwania pojedynczego bitu</param>
        /// <param name="ts">Okres probkowania, 1/fs</param>
        /// <param name="a1">Samodzielenie dobierany parametr</param>
        /// <param name="a2">Samodzielenie dobierany parametr</param>
        /// <param name="fn">Czestotliwosc nosna</param>
        /// <returns>Tablice wynikowa kluczowania amplitudy</returns>
        internal double[] PrzesuwAmplitudyAsk(int n, int[] input, double tb, double ts, double a1, double a2,
            double fn) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);
            for (var i = 0; i < n; i++) {
                if (input[(int)Math.Floor(i / tb * ts)] == 0) {
                    result[i] = a1 * Math.Sin(2 * Math.PI * fn * x[i]);
                } else {
                    result[i] = a2 * Math.Sin(2 * Math.PI * fn * x[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Kluczowanie z przesuwem fazy (PSK) dla int[]
        /// </summary>
        /// <param name="n">Rozmiar</param>
        /// <param name="input">Tablica wartosci</param>
        /// <param name="tb">Czas trwania pojedynczego bitu</param>
        /// <param name="ts">Okres probkowania, 1/fs</param>
        /// <param name="fn">Czestotliwosc nosna</param>
        /// <returns>Tablice wynikowa kluczowania fazy</returns>
        internal double[] PrzesuwFazyPsk(int n, int[] input, double tb, double ts, double fn) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);
            for (var i = 0; i < n; i++) {
                if (input[(int)Math.Floor(i / tb * ts)] == 0) {
                    result[i] = Math.Sin(2 * Math.PI * fn * x[i]);
                } else {
                    result[i] = Math.Sin(2 * Math.PI * fn * x[i] + Math.PI);
                }
            }

            return result;
        }

        /// <summary>
        ///  Kluczowanie z przesuwem czestotliwosci (FSK) dla int[]
        /// </summary>
        /// <param name="n">Rozmiar</param>
        /// <param name="input">Napis ktory ma zostac zamieniony</param>
        /// <param name="tb">Czas trwania pojedynczego bitu</param>
        /// <param name="ts">Okres probkowania, 1/fs</param>
        /// <param name="fn1">Samodzielenie dobierany parametr czestotliwosci</param>
        /// <param name="fn2">Samodzielenie dobierany parametr czestotliwosci</param>
        /// <returns>Tablica wynikowa kluczowania czestotliwosci</returns>
        internal double[] PrzesuwCzestotliwosciFsk(int n, int[] input, double ts, double tb, double fn1, double fn2) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);
            for (var i = 0; i < n; i++) {
                if (input[(int)Math.Floor(i / tb * ts)] == 0) {
                    result[i] = Math.Sin(2 * Math.PI * fn1 * x[i]);
                } else {
                    result[i] = Math.Sin(2 * Math.PI * fn2 * x[i]);
                }
            }

            return result;
        }

        #endregion

        /// <summary>
        ///  Funkcja odpowiadajaca za automatyczne obliczanie "H" (progu)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        internal double[] MoreThanH(double[] input, int n, double a1, double a2) {
            var results = new double[n];
            double decideH;
            if (a1 / a2 < 1) {
                decideH = a1 / a2;
            } else {
                decideH = a2 / a1;
            }

            var h = (input.Max() * decideH) + 3;

            for (var i = 0; i < n; i++) {
                if (input[i] > h) {
                    results[i] = 1;
                } else {
                    results[i] = 0;
                }
            }

            return results;
        }

        /// <summary>
        /// Funkcja obliczająca x(t)
        /// Poprawiona przy pomocy Jakuba Znyka, zakomentowana część kodu jest moja, ta używana obecnie jest efektem jego pomocy
        /// Przy swojej implementacji przypisywalem caly gotowy wynik do pamieci result[i], a w drugim rozwiązaniu mnożenie odbywa się w dwóch operacjach
        /// co skutkowało *NIE* zaokrąglaniem wyniku. W mojej wersji błąd był na poziomie ~[10^-6, 10^-8]
        /// </summary>
        /// <param name="input"></param>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="ts"></param>
        /// <param name="fn"></param>
        /// <returns></returns>
        internal double[] XOdT(double[] input, double a, int n, double ts, double fn) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);

            //for (var i = 0; i < n; i++) {
            //    result[i] = (a * Math.Sin(2 * Math.PI * fn * x[i])) * input[i];
            //}

            //return result;
            for (var i = 0; i < n; i++) {
                result[i] = a * Math.Sin(2 * Math.PI * fn * x[i]);
                result[i] *= input[i];
            }

            return result;
        }

        /// <summary>
        /// Funkcja obliczajaca bit error rate
        /// </summary>
        /// <param name="przeslane">tablica bitow przeslanych</param>
        /// <param name="odebrane">tablica bitow odeebranych</param>
        /// <returns>wspolczynnik ber</returns>
        internal double BerCounter(int[] przeslane, int[] odebrane) {
            var n = przeslane.Length;
            var result = 0.0;
            for (var i = 0; i < n; i++) {
                if (przeslane[i] != odebrane[i]) {
                    result++;
                }
            }

            result /= n;
            return result;
        }

        internal double[] itgr(double[] input, int n, double ts, double tb) {
            var result = new double[n];
            var calka = 0.0;
            var x = HelperFuncs.GenT(n, ts);
            var tb2 = tb;
            for (var i = 0; i < n; i++) {
                calka += x[i];
                result[i] = calka;
                if (tb2 < x[i]) {
                    calka = 0.0;
                    tb2 += tb;
                }
            }
            return result;
        }
    }
}