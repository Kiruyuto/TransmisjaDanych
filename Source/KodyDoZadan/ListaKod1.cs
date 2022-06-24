using System;
// ReSharper disable MemberCanBeMadeStatic.Global

namespace Lab2_win_forms.KodyDoZadan {
    internal class ListaKod1 {

        /// <summary>
        /// Zad 1, Wzor nr 5 z Tabeli 1
        /// </summary>
        /// <param name="fs">Czestotliwosc probkowania (Hz)</param>
        /// <param name="f">Samodzielnie dobierany parametr</param>
        /// <param name="fi">Samodzielenie dobierany parametr</param>
        /// <param name="n">Dlugosc sygnalu, w tym wypadku rozmiar tablicy. Tc*Fs zaokraglone do najblizszej l. calk.</param>
        /// <returns>Tablice wartosci X i Y, pozwalajace utworzyc wykres</returns>
        internal Tuple<double[], double[]> ZadanieNumer1(double fs, double f, double fi, int n) {
            var xArrX = new double[n];
            var yArrX = new double[n];
            for (var i = 0; i < n; i++) {
                var t = 1.0 * i / fs; //Definicja z PDFa
                xArrX[i] = t;
                yArrX[i] = Math.Sin(2 * Math.PI * f * t * Math.Cos(3 * Math.PI * t) + t + fi);
            }

            return Tuple.Create(xArrX, yArrX);
        }

        /// <summary>
        /// Zad 2, Wzor nr 3 z Tabeli 1
        /// </summary>
        /// <param name="fs">Czestotliwosc probkowania (Hz)</param>
        /// <param name="f">Samodzielnie dobierany parametr</param>
        /// <param name="fi">Samodzielenie dobierany parametr</param>
        /// <param name="n">Dlugosc sygnalu, w tym wypadku rozmiar tablicy. Tc*Fs zaokraglone do najblizszej l. calk.</param>
        /// <returns>Tablice wartosci X i Y dla kazdej z funkcji [y(t), z(t) i v(t)], pozwalajace utworzyc wykres</returns>
        internal Tuple<double[], double[], double[], double[], double[], double[]> ZadanieNumer2(double fs, double f,
            double fi, int n) {
            //y(t)
            var xArrY = new double[n];
            var yArrY = new double[n];
            for (var i = 0; i < n; i++) {
                var t = 1.0 * i / fs;
                xArrY[i] = t;
                yArrY[i] = (Math.Pow(t, 3) - 1) + Math.Cos(4 * Math.Pow(t, 2) * Math.PI) * t;
            }

            //z(t)
            var xArrZ = new double[n];
            var yArrZ = new double[n];
            var (_, item2) = ZadanieNumer1(fs, f, fi, n);
            for (var i = 0; i < n; i++) {
                var t = 1.0 * i / fs;
                xArrZ[i] = t;
                yArrZ[i] = item2[i] / (Math.Abs(yArrY[i] * Math.Cos(5 * t) - item2[i] * yArrY[i]) + 3);
            }

            //v(t)
            var xArrV = new double[n];
            var yArrV = new double[n];
            for (var i = 0; i < n; i++) {
                var t = 1.0 * i / fs;
                xArrV[i] = t;
                yArrV[i] = item2[i] * 662 / (Math.Abs(item2[i] - yArrY[i]) + 0.5);
            }

            return Tuple.Create(xArrY, yArrY, xArrZ, yArrZ, xArrV, yArrV);
        }

        /// <summary>
        /// Zad 3, Wzor nr 6 z Tabeli 3
        /// </summary>
        /// <param name="fs">Czestotliwosc probkowania (Hz)</param>
        /// <param name="n">Dlugosc sygnalu, w tym wypadku rozmiar tablicy. Tc*Fs zaokraglone do najblizszej l. calk.</param>
        /// <returns>Tablice wartosci X i Y, pozwalajace utworzyc wykres</returns>
        internal Tuple<double[], double[]> ZadanieNumer3(double fs, int n) {
            var xArrU = new double[n];
            var yArrU = new double[n];
            var i = 0;
            while (i < n) {
                var t = 1.0 * i / fs;
                xArrU[i] = t;
                if (t < 1.8 && t >= 0) {
                    yArrU[i] = (-t / 2) * Math.Sin(20 * Math.Pow(t, 3) - 18 * Math.Pow(t, 2));
                }
                else if (t < 3 && t >= 1.8) {
                    yArrU[i] = Math.Cos(5 * Math.PI * t) * Math.Sin(12 * Math.PI * Math.Pow(t, 2));
                }
                else if (t < 4.5 && t >= 3) {
                    yArrU[i] = ((t - 3) / 3) * Math.Sin((12 - t) * Math.PI * Math.Pow(t, 2));
                }

                i++;
            }

            return Tuple.Create(xArrU, yArrU);
        }

        /// <summary>
        /// Zad 4, Wzor nr 13 z Tabeli 4
        /// </summary>
        /// <param name="bkCounter">Dla ktorego H wyrysowac wykres [H1, H2, H3] </param>
        /// <param name="fs">Czestotliwosc probkowania (Hz)</param>
        /// <param name="n">Dlugosc sygnalu, w tym wypadku rozmiar tablicy. Tc*Fs zaokraglone do najblizszej l. calk.</param>
        /// <returns>Tablice wartosci X i Y, pozwalajace utworzyc wykres</returns>
        internal Tuple<double[], double[]> ZadanieNumer4(int bkCounter, double fs, int n) {
            var xArrBk = new double[n];
            var yArrBk = new double[n];
            var bk = 0;
            if (bkCounter == 1) {
                bk = 2;
            }
            else if (bkCounter == 2) {
                bk = 4;
            }
            else if (bkCounter == 3) {
                bk = 8;
            }

            for (var i = 0; i < n; i++) {
                var t = 1.0 * i / fs;
                xArrBk[i] = t;
                double suma = 0;
                for (var k = 1; k <= bk; k++) {
                    suma += Math.Sin((6 * k + 1) * t * Math.PI) * Math.Sin(Math.Pow(k, 3)) / (6 * k + 2);
                    if (k == 2) {
                        yArrBk[i] = suma;
                    }
                    else if (k == 4) {
                        yArrBk[i] = suma;
                    }
                    else if (k == 8) {
                        yArrBk[i] = suma;
                    }
                }
            }

            return Tuple.Create(xArrBk, yArrBk);
        }
    }
}