using System;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
// ReSharper disable InlineTemporaryVariable
// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable InvertIf
// ReSharper disable ReturnTypeCanBeEnumerable.Global
// ReSharper disable RedundantBoolCompare
// ReSharper disable InconsistentNaming

namespace Lab2_win_forms.Assets {
    internal static class HelperFuncs {

        public static PlotModel GenerateChartDft(double[] x, double[] y, int size, string titleLeft,
            string titleBottom) {
            var n = size / 2 - 1; //Zakomentuj dzielenie zeby rysowac caly wykres
            var model = new PlotModel();
            var xAxe = new LinearAxis{
                Position = AxisPosition.Bottom, 
                Title = titleBottom
            };
            var yAxe = new LinearAxis{
                Position = AxisPosition.Left,
                Title = titleLeft
            };
            var pointSet = new OxyPlot.Series.LineSeries();

            for (var i = 0; i < n; i++) {
                pointSet.Points.Add(new DataPoint(x[i], y[i]));
            }

            model.Axes.Add(xAxe);
            model.Axes.Add(yAxe);
            model.Series.Add(pointSet);
            return model;
        }

        public static PlotModel GenerateChartFft(Complex[] input, int size) {
            var n = size / 2 - 1; //Zakomentuj dzielenie zeby rysowac caly wykres
            var model = new PlotModel();
            var xAxe = new LinearAxis{Position = AxisPosition.Bottom};
            var yAxe = new LinearAxis{Position = AxisPosition.Left};
            var pointSet = new OxyPlot.Series.LineSeries();

            for (var i = 0; i < n; i++) {
                pointSet.Points.Add(new DataPoint(input[i].Real, input[i].Imaginary));
            }

            model.Axes.Add(xAxe);
            model.Axes.Add(yAxe);
            model.Series.Add(pointSet);
            return model;
        }

        public static double[] GenerateWhiteNoise(double st, double en, double alfa, int n) {
            var result = new double[n];
            var rand = new Random(); //reuse this if you are generating many

            for (var i = 0; i < n; i++) {
                var u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
                var u2 = 1.0 - rand.NextDouble();
                var randStdNormal =
                    Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
                var randNormal = (st + en * randStdNormal) * alfa; //random normal(mean,stdDev^2)
                result[i] = randNormal;
            }

            return result;
        }

        public static int[] ConvertText(string input, int streamLength) {
            if (input.Any(str => str < 32 || str > 127)) {
                MessageBox.Show(@"Niepoprawny znak");
                throw new Exception(
                    "Char value out of provided range"); //Wyjatek po oczach, brutalnie ale skutecznie.
            }

            var output = new int[streamLength * input.Length];
            for (var i = 0; i < input.Length; i++) {
                int index = input[i];
                for (var k = streamLength - 1; k >= 0; k--) {
                    output[i * streamLength + k] = Convert.ToInt32(index % 2);
                    index = index / 2;
                }
            }

            return output;
        }

        public static double[] GenT(int n, double ts) {
            var result = new double[n];
            var tmp = 0.0;
            for (var i = 0; i < n; i++) {
                result[i] = tmp;
                tmp += ts;
            }

            return result;
        }

        public static int[] ConvertToBits(string str, int size) {
            var result = new int[size];
            for (var i = 0; i < str.Length; i++) {
                result[i] = (int)char.GetNumericValue(str[i]);
            }
            return result;
        }

        public static int[][] DivideAndConvertToBits(string str, double divideLenght) {
            var arrNmber = Math.Ceiling(str.Length / divideLenght);
            var result = new int[(int)arrNmber][]; 
            var curr = 0; // String counter

            for (var i = 0; i < arrNmber; i++) {
                result[i] = new int[(int)divideLenght];
                for (var j = 0; j < 4; j++) {
                    result[i][j] = 0; // Initalize with 0 to prevent errors

                    if (curr >= str.Length) {
                        curr--;
                    }  // If we are out of bounds, go back to the last character

                    result[i][j] = (int)char.GetNumericValue(str[curr]);
                    curr++;
                }
            }

            return result;
        }

        public static int[] ConvertBackToHammCodedArr(double[] input, double tb, double tc, int n, double ts) {
            var result = new int[Convert.ToInt32(tc / tb)];
            var tb2 = tb;
            var j = 0;
            var x = HelperFuncs.GenT(n, ts);
            var val = false;
            for (var i = 0; i < n; i++) {
                if (input[i] == 1) {
                    val = true;
                }

                if (tb2 < x[i]) {
                    if (val == true) {
                        result[j] = 1;
                    } else {
                        result[j] = 0;
                    }

                    tb2 += tb;
                    j++;
                    val = false;
                }
            }

            if (val == true) {
                result[j] = 1;
            } else {
                result[j] = 0;
            }

            return result;
        }

        public static int[][] DivideArray(int[] input, int divideLength) {
            var result = new int[input.Length / divideLength][];
            var cnter = 0;
            for (var i = 0; i < result.Length; i++) {
                result[i] = new int[divideLength];
                for (var j = 0; j < divideLength; j++) {
                    result[i][j] = input[cnter];
                    cnter++;
                }
            }

            return result;
        }
    }
}
