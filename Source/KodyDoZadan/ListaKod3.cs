using System;
// ReSharper disable MemberCanBeMadeStatic.Global

namespace Lab2_win_forms.KodyDoZadan {
    internal class ListaKod3 {

        /// <summary>
        /// Funkcja generujaca tablice m(t)
        /// </summary>
        /// <param name="fm">Czestotliwosc sygnalu informacyjnego</param>
        /// <param name="n">Rozmiar Tablicy</param>
        /// <returns>Ton prosty m(t)</returns>
        internal double[] MtArray(double fm, int n) {
            var arr = new double[n];
            for (var i = 0; i < n; i++) {
                arr[i] = Math.Sin(2 * Math.PI * fm * i);
            }

            return arr;
        }

        /// <summary>
        /// Sygnal zmodulowany amplitudowo - Za(t)
        /// </summary>
        /// <param name="mt">Ton Prosty</param>
        /// <param name="ka">Samodzielenie dobierany parametr</param>
        /// <param name="fn">Czestotliwosc nosna</param>
        /// <param name="n">Rozmiar tablicy</param>
        /// <returns>Tablica wartosci typu double, wynik sygnalu Za(t)</returns>
        internal double[] ModulacjaAmplitudy(double[] mt, double ka, double fn, int n) {
            var result = new double[n];
            for (var i = 0; i < n; i++) {
                result[i] = (ka * mt[i] + 1) * Math.Cos(2 * Math.PI * fn * i);
            }

            return result;
        }

        /// <summary>
        /// Sygnal zmodulowany katowo - Zp(t)
        /// </summary>
        /// <param name="mt">Ton Prosty</param>
        /// <param name="fn">Czestotliwosc nosna</param>
        /// <param name="kp">Samodzielenie dobierany parametr</param>
        /// <param name="n">Rozmiar tablicy</param>
        /// <returns>Tablice wartosci typu double, wynik sygnalu Zp(t)</returns>
        internal double[] ModulacjaFazy(double[] mt, double fn, double kp, int n) {
            var result = new double[n];
            for (var i = 0; i < n; i++) {
                result[i] = Math.Cos(2 * Math.PI * fn * i + kp * mt[i]);
            }

            return result;
        }

        /// <summary>
        /// Sygnal zmodulowany katowo - Zf(t)
        /// </summary>
        /// <param name="mt">Ton Prosty</param>
        /// <param name="fn">Czestotliwosc nosna</param>
        /// <param name="fm">Czestotliwosc sygnalu informacyjnego</param>
        /// <param name="kf">Samodzielenie dobierany parametr</param>
        /// <param name="n">Rozmiar tablicy</param>
        /// <returns>Tablice wartosci typu double, wynik sygnalu Zf(t)</returns>
        internal double[] ModulacjaCzestotliwosci(double[] mt, double fn, double fm, double kf, int n) {
            var result = new double[n];
            for (var i = 0; i < n; i++) {
                result[i] = Math.Cos(2 * Math.PI * fn * i + (kf / fm) * mt[i]);
            }

            return result;
        }
    }
}