using System;
using System.Numerics;
// ReSharper disable MemberCanBeMadeStatic.Global

namespace Lab2_win_forms.KodyDoZadan {
    internal class ListaKod2 {

        /// <summary>
        /// Discrete Fourier Transform function
        /// </summary>
        /// <param name="input">Tablica wejsciowa</param>
        /// <param name="n">Liczba probek sygnalow w dziedzinie czasu i czestotliwosci, w tym wypadku rozmiar tablicy</param>
        /// <returns>Krotke Re[] & Im[]</returns>
        internal Tuple<double[], double[]> Dft(double[] input, double n) {
            var real = new double[(int)n];
            var imagined = new double[(int)n];
            for (double i = 0; i < n; i++) {
                for (double k = 0; k < n; k++) {
                    real[(int)i] += input[(int)k] * Math.Cos(2 * Math.PI * i * k / n); //Czesc rzeczywista
                    imagined[(int)i] += -1 * (input[(int)k] * Math.Sin(2 * Math.PI * i * k / n)); //Czesc urojona
                }
            }

            return Tuple.Create(real, imagined);
        }

        /// <summary>
        /// Funkcja obliczajaca Widmo Amplitudowe dla DFT
        /// </summary>
        /// <param name="real">Tablica wartosci rzeczywistych</param>
        /// <param name="imag">Tablica wartosci urojonych</param>
        /// <param name="n">Dlugosc sygnalu, w tym wypadku rozmiar tablicy. Tc*Fs zaokraglone do najblizszej l. calk.</param>
        /// <returns>Tablica wartosci "Widma" w typie double</returns>
        internal double[] WidmoAmplitudowe(double[] real, double[] imag, int n) {
            var dziedzina = n / 2 - 1;
            var widmo = new double[dziedzina];
            for (var i = 0; i < dziedzina; i++) {
                widmo[i] = Math.Sqrt(Math.Pow(real[i], 2) + Math.Pow(imag[i], 2));
            }

            return widmo;
        }

        /// <summary>
        /// Funkcja obliczajaca Widmo Amplitudowe dla FFT
        /// </summary>
        /// <param name="input">Tablica liczb zlozonych</param>
        /// <param name="n">Dlugosc sygnalu, w tym wypadku rozmiar tablicy. Tc*Fs zaokraglone do najblizszej l. calk.</param>
        /// <returns>Tablica wartosci "Widma" w typie double</returns>
        internal double[] WidmoAmplitudoweFft(Complex[] input, int n) {
            var dziedzina = n / 2 - 1;
            var widmo = new double[dziedzina];
            for (var i = 0; i < dziedzina; i++) {
                widmo[i] = Math.Sqrt(Math.Pow(input[i].Real, 2) + Math.Pow(input[i].Imaginary, 2));
            }

            return widmo;
        }

        /// <summary>
        /// Funkcja obliczajaca Skale Decybelowa
        /// </summary>
        /// <param name="input">Tablica wejsciowa</param>
        /// <param name="n">Dlugosc sygnalu, w tym wypadku rozmiar tablicy. Tc*Fs zaokraglone do najblizszej l. calk.</param>
        /// <returns>Tablica wartosci w "Skali decybelowej"</returns>
        internal double[] SkalaDecybelowa(double[] input, int n) {
            var dziedzina = n / 2 - 1;
            var skala = new double[dziedzina];
            for (var i = 0; i < dziedzina; i++) {
                skala[i] = 10 * Math.Log10(input[i]);
            }

            return skala;
        }

        /// <summary>
        ///  Funkcja obliczajaca Skale Czestotliwosci
        /// </summary>
        /// <param name="fs">Czestotliwosc probkowania (Hz)</param>
        /// <param name="n">Dlugosc sygnalu</param>
        /// <returns>Tablica wartosci skali</returns>
        internal double[] SkalaCzestotliwosci(double fs, int n) {
            var dziedzina = n / 2 - 1;
            var skala = new double[dziedzina];
            for (var i = 0; i < dziedzina; i++) {
                skala[i] = i * fs / n;
            }

            return skala;
        }
    }
}