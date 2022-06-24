using Lab2_win_forms.Assets;
using System;
// ReSharper disable MemberCanBeMadeStatic.Global

namespace Lab2_win_forms.KodyDoZadan {
    internal class ListaKod4 {

        /// <summary>
        /// Kluczowanie z przesuwem amplitudy (ASK)
        /// </summary>
        /// <param name="n">Rozmiar</param>
        /// <param name="input">Napis ktory ma zostac zamieniony</param>
        /// <param name="tb">Czas trwania pojedynczego bitu</param>
        /// <param name="ts">Okres probkowania, 1/fs</param>
        /// <param name="a1">Samodzielenie dobierany parametr</param>
        /// <param name="a2">Samodzielenie dobierany parametr</param>
        /// <param name="fn">Czestotliwosc nosna</param>
        /// <returns>Tablice wynikowa kluczowania amplitudy</returns>
        internal double[] PrzesuwAmplitudyAsk(int n, string input, double tb, double ts, int a1, int a2,
            double fn) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);
            var arrText = HelperFuncs.ConvertText(input, 7);
            for (var i = 0; i < n; i++) {
                if (arrText[(int)(Math.Floor(i / tb * ts))] == 0) {
                    result[i] = a1 * Math.Sin(2 * Math.PI * fn * x[i]);
                } else {
                    result[i] = a2 * Math.Sin(2 * Math.PI * fn * x[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Kluczowanie z przesuwem fazy (PSK)
        /// </summary>
        /// <param name="n">Rozmiar</param>
        /// <param name="input">Napis ktory ma zostac zamieniony</param>
        /// <param name="tb">Czas trwania pojedynczego bitu</param>
        /// <param name="ts">Okres probkowania, 1/fs</param>
        /// <param name="fn">Czestotliwosc nosna</param>
        /// <returns>Tablice wynikowa kluczowania fazy</returns>
        internal double[] PrzesuwFazyPsk(int n, string input, double tb, double ts, double fn) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);
            var arrText = HelperFuncs.ConvertText(input, 7);
            for (var i = 0; i < n; i++) {
                if (arrText[(int)(Math.Floor(i / tb * ts))] == 0) {
                    result[i] = Math.Sin(2 * Math.PI * fn * x[i]);
                } else {
                    result[i] = Math.Sin(2 * Math.PI * fn * x[i] + Math.PI);
                }
            }

            return result;
        }

        /// <summary>
        ///  Kluczowanie z przesuwem czestotliwosci (FSK)
        /// </summary>
        /// <param name="n">Rozmiar</param>
        /// <param name="input">Napis ktory ma zostac zamieniony</param>
        /// <param name="tb">Czas trwania pojedynczego bitu</param>
        /// <param name="ts">Okres probkowania, 1/fs</param>
        /// <param name="fn1">Samodzielenie dobierany parametr czestotliwosci</param>
        /// <param name="fn2">Samodzielenie dobierany parametr czestotliwosci</param>
        /// <returns></returns>
        internal double[] PrzesuwCzestotliwosciFsk(int n, string input, double tb, double ts, double fn1,
            double fn2) {
            var result = new double[n];
            var x = HelperFuncs.GenT(n, ts);
            var arrText = HelperFuncs.ConvertText(input, 7);
            for (var i = 0; i < n; i++) {
                if (arrText[(int)(Math.Floor(i / tb * ts))] == 0) {
                    result[i] = Math.Sin(2 * Math.PI * fn1 * x[i]);
                } else {
                    result[i] = Math.Sin(2 * Math.PI * fn2 * x[i]);
                }
            }

            return result;
        }

        internal double[] CombineArrays(double[] arr1, double[] arr2) {
            var result = new double[arr1.Length];
            for (var i = 0; i < arr1.Length; i++) {
                result[i] = arr1[i] - arr2[i];
            }

            return result;
        }

    }
}