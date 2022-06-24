using System;
using Lab2_win_forms.Assets;
// ReSharper disable MemberCanBeMadeStatic.Global

namespace Lab2_win_forms.KodyDoZadan {
    internal class ListaKod5 {

        /// <summary>
        /// Generuje sygnal x(t)
        /// </summary>
        /// <param name="input"></param>
        /// <param name="a">Amplituda Sygnalu Odniesienia</param>
        /// <param name="fn">Czestotliwosc fali nosnej</param>
        /// <param name="ts">Okres probkowania, 1/fs</param>
        /// <param name="n">Rozmiar</param>
        /// <returns>x(t)</returns>
        internal double[] XOdT(double[] input, double a, double fn, double ts, int n) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);

            for (var i = 0; i < n; i++) {
                result[i] = input[i] * (a * Math.Sin(2 * Math.PI * fn * x[i]));
            }

            return result;
        }

        /// <summary>
        /// czemu itgr??XD (od całki XD [20 min myslenia])
        /// </summary>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <param name="tb">Czas trwania pojedynczego bitu</param>
        /// <param name="fs">Czestotliwosc probkowania (Hz)</param>
        /// <returns>p(t)</returns>
        internal double[] Itgr(double[] input, int n, double tb, double fs) {
            var results = new double[n];
            var przeskok = tb * fs;
            //Console.WriteLine(przeskok);
            double suma = 0;
            for (var i = 0; i < n; i++) {
                if (i % przeskok >= 0 && i % przeskok < 1) {
                    suma = 0;
                } else {
                    suma += input[i];
                    results[i] = suma;
                }
            }

            return results;
        }

        /// <summary>
        /// Ostatnia czesc demodulatorow
        /// </summary>
        /// <param name="input">Tablica wejsciowa</param>
        /// <param name="n">Rozmiar</param>
        /// <param name="h">Wartosc progowa</param>
        /// <returns>Sygnal c(t)</returns>
        internal double[] MoreThanH(double[] input, int n, int h) {
            var results = new double[n];
            for (var i = 0; i < n; i++) {
                if (input[i] < h) {
                    results[i] = 1;
                } else {
                    results[i] = 0;
                }
            }

            return results;
        }
    }
}