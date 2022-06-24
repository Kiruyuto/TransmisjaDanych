using System;
using System.Collections.Generic;
using System.Windows.Forms;
// ReSharper disable LocalizableElement
// ReSharper disable MemberCanBeMadeStatic.Global

namespace Lab2_win_forms.KodyDoZadan {
    internal class ListaKod6 {

        #region Hamming (7, 4)

        /// <summary>
        /// Koder 7,4
        /// </summary>
        /// <param name="input">4 elementowa wejsciowa tablica bitow</param>
        /// <returns>7 elementowa zakodowana tablica bitow</returns>
        internal IEnumerable<int> Hamming74(int[] input) {
            // 4bitowe slowo zapisuje sie na 3, 5, 6 i 7 bicie
            var result = new int[7];
            result[2] = input[0]; // x3 = 3 bit
            result[4] = input[1]; // x5 = 5 bit
            result[5] = input[2]; // x6 = 6 bit
            result[6] = input[3]; // x7 = 7 bit
            // Kodowanie
            var x1 = result[2] ^ result[4] ^ result[6];
            var x2 = result[2] ^ result[5] ^ result[6];
            var x4 = result[4] ^ result[5] ^ result[6];
            // Przypisanie do tablicy wynikowej
            result[0] = x1; // x1 = 1 bit
            result[1] = x2; // x2 = 2 bit
            result[3] = x4; // x4 = 4 bit

            return result;
        }

        /// <summary>
        /// Dekoder 7,4
        /// </summary>
        /// <param name="input">7 elementowa wejsciowa tablica bitow</param>
        /// <param name="displayBox">Whether or not display warning box</param>
        /// <returns>4 elementowa odkodowana tablica bitow</returns>
        internal IEnumerable<int> Hamming74Decoder(int[] input, bool displayBox = true) {
            var result = new int[4];
            // Wyliczanie prim
            var x1P = input[2] ^ input[4] ^ input[6];
            var x2P = input[2] ^ input[5] ^ input[6];
            var x4P = input[4] ^ input[5] ^ input[6];
            // Wyliczanie kresek
            var x1Kreska = input[0] ^ x1P;
            var x2Kreska = input[1] ^ x2P;
            var x4Kreska = input[3] ^ x4P;
            // Suma
            var s = x1Kreska * Math.Pow(2, 0) + x2Kreska * Math.Pow(2, 1) + x4Kreska * Math.Pow(2, 2);
            // Zamien przeklamany bit
            if (s != 0) {
                if (displayBox) {
                    MessageBox.Show("S != 0\nSwiadczy to o mozliwie przeklamanym bicie!");
                }
                if (input[(int)s - 1] == 0) {
                    input[(int)s - 1] = 1;
                    Hamming74Decoder(input);
                } else {
                    input[(int)s - 1] = 0;
                    Hamming74Decoder(input);
                }
            }

            // Przypisz do tablicy wynikowej i zwroc
            result[0] = input[2]; // x3 = 3 bit
            result[1] = input[4]; // x5 = 5 bit
            result[2] = input[5]; // x6 = 6 bit
            result[3] = input[6]; // x7 = 7 bit
            return result;
        }

        #endregion

        #region Hamming(15, 11)

        /// <summary>
        /// Koder 15,11
        /// </summary>
        /// <param name="input">11 elementowa wejsciowa tablica bitow</param>
        /// <returns>15 elementowa zakodowana tablica bitow</returns>
        internal IEnumerable<int> Hamming1511(int[] input) {
            var result = new int[15];
            result[2] = input[0]; // x3 = 3 bit
            result[4] = input[1]; // x5 = 5 bit
            result[5] = input[2]; // x6 = 6 bit
            result[6] = input[3]; // x7 = 7 bit
            result[8] = input[4]; // x9 = 9 bit
            result[9] = input[5]; // x10 = 10 bit
            result[10] = input[6]; // x11 = 11 bit
            result[11] = input[7]; // x12 = 12 bit
            result[12] = input[8]; // x13 = 13 bit
            result[13] = input[9]; // x14 = 14 bit
            result[14] = input[10]; // x15 = 15 bit

            var p1 = result[2] ^ result[4] ^ result[6] ^ result[8] ^ result[10] ^ result[12] ^ result[14];
            var p2 = result[2] ^ result[5] ^ result[6] ^ result[9] ^ result[10] ^ result[13] ^ result[14];
            var p4 = result[4] ^ result[5] ^ result[6] ^ result[11] ^ result[12] ^ result[13] ^ result[14];
            var p8 = result[8] ^ result[9] ^ result[10] ^ result[11] ^ result[12] ^ result[13] ^ result[14];
            result[0] = p1;
            result[1] = p2;
            result[3] = p4;
            result[7] = p8;

            return result;
        }

        /// <summary>
        /// Dekoder 15,11
        /// </summary>
        /// <param name="input">15 elementowa tablica bitow</param>
        /// <returns>11 elementowa odkodowana tablica bitow</returns>
        internal IEnumerable<int> Hamming1511Decoder(int[] input) {
            var result = new int[11];
            //Prim
            var p1P = input[2] ^ input[4] ^ input[6] ^ input[8] ^ input[10] ^ input[12] ^ input[14];
            var p2P = input[2] ^ input[5] ^ input[6] ^ input[9] ^ input[10] ^ input[13] ^ input[14];
            var p4P = input[4] ^ input[5] ^ input[6] ^ input[11] ^ input[12] ^ input[13] ^ input[14];
            var p8P = input[8] ^ input[9] ^ input[10] ^ input[11] ^ input[12] ^ input[13] ^ input[14];
            //Kres
            var x1Kreska = input[0] ^ p1P;
            var x2Kreska = input[1] ^ p2P;
            var x4Kreska = input[3] ^ p4P;
            var x8Kreska = input[7] ^ p8P;
            // Suma
            var s = x1Kreska * Math.Pow(2, 0) + x2Kreska * Math.Pow(2, 1) + x4Kreska * Math.Pow(2, 2) +
                    x8Kreska * Math.Pow(2, 3);
            // Zamien przeklamany bit
            if (s != 0) {
                MessageBox.Show("S != 0\nSwiadczy to o mozliwie przeklamanym bicie!");
                if (input[(int)s - 1] == 0) {
                    input[(int)s - 1] = 1;
                    Hamming74Decoder(input);
                } else {
                    input[(int)s - 1] = 0;
                    Hamming74Decoder(input);
                }
            }

            // Przypisz do tablicy wynikowej i zwroc
            result[0] = input[2]; // x3 = 3 bit
            result[1] = input[4]; // x5 = 5 bit
            result[2] = input[5]; // x6 = 6 bit
            result[3] = input[6]; // x7 = 7 bit
            result[4] = input[8]; // x9 = 9 bit
            result[5] = input[9]; // x10 = 10 bit
            result[6] = input[10]; // x11 = 11 bit
            result[7] = input[11]; // x12 = 12 bit
            result[8] = input[12]; // x13 = 13 bit
            result[9] = input[13]; // x14 = 14 bit
            result[10] = input[14]; // x15 = 15 bit

            return result;
        }
        #endregion
    }
}

// syfzmacierzami
//var inputToDouble = input.Select(x => (double)x).ToArray();

//var identityMatrix = Matrix<double>.Build.DenseIdentity(11);
//var twoToPower = new double[4][];

//twoToPower[0] = new double[] { 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1 };
//twoToPower[1] = new double[] { 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1 };
//twoToPower[2] = new double[] { 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
//twoToPower[3] = new double[] { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };

//var matrixP = Matrix<double>.Build.DenseOfColumns(twoToPower);
////Console.WriteLine("P " + matrixP);
//var matrixG = matrixP.Append(identityMatrix);
//Console.WriteLine("G " + matrixG);
//var v = Vector<double>.Build.DenseOfArray(inputToDouble);
//Console.WriteLine("V " + v);
//var vm = v * matrixG;
//Console.WriteLine("MV " + vm);
////foreach (var q in dd) {
////    Console.WriteLine(q);
////}