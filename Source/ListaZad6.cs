using System;
using System.Linq;
using System.Windows.Forms;
using Lab2_win_forms.Assets;
using Lab2_win_forms.KodyDoZadan;

namespace Lab2_win_forms {
    public partial class ListaZad6 : Form {
        private readonly ListaKod6 _lista6 = new ListaKod6();

        #region Syf
        
        public ListaZad6() {
            InitializeComponent();
        }

        private void ChooseZad_Click(object sender, EventArgs e) {
            Hide();
            var wyborZadania = new WybierzZad();
            wyborZadania.Closed += (s, args) => this.Close();
            wyborZadania.Show();
        }

        private void clearButton_Click(object sender, EventArgs e) {
            Hamming74DecoderButton.Enabled = false;
            decodeResultBox.Text = "";
            outputBox74.Text = "";
            inputBox74.Text = "";
            randomBitLabel.Text = @"N/A";
        }

        private void ClearButton_2_Click(object sender, EventArgs e) {
            Hamming1511DecoderButton.Enabled = false;
            decodeResultBox_2.Text = "";
            outputBox1511.Text = "";
            inputBox1511.Text = "";
            matrixBox.Text = "";
            randomBitLabel.Text = @"N/A";
        }

        private void DefaultValues_Click(object sender, EventArgs e) {
            inputBox74.Text = @"1001";
            inputBox1511.Text = @"11010100101";
            randomBitLabel.Text = @"N/A";
        }

        #endregion


        #region Hamming 7,4

        private void Hamm74CoderButton_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length != 4) {
                MessageBox.Show(@"Musisz wpisac 4 bity!");
            } else {
                var input = HelperFuncs.ConvertToBits(inputBox74.Text, 4);
                
                Lb3.Text = input[0].ToString();
                Lb5.Text = input[1].ToString();
                Lb6.Text = input[2].ToString();
                Lb7.Text = input[3].ToString();
                
                var hammRes = _lista6.Hamming74(input);

                var enumerable = hammRes as int[] ?? hammRes.ToArray();
                Lb1.Text = enumerable[0].ToString();
                Lb2.Text = enumerable[1].ToString();
                Lb4.Text = enumerable[3].ToString();

                var str = enumerable.Aggregate(@"", (current, x) => current + x);

                outputBox74.Text = str;
                Hamming74DecoderButton.Enabled = true;
            }
        }

        private void Hamm74CoderButton_2_Click(object sender, EventArgs e) {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox74.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox74.Text.Length != 4) {
                MessageBox.Show(@"Musisz wpisac 4 bity!");
            } else {
                var input = HelperFuncs.ConvertToBits(inputBox74.Text, 4);

                Lb3.Text = input[0].ToString();
                Lb5.Text = input[1].ToString();
                Lb6.Text = input[2].ToString();
                Lb7.Text = input[3].ToString();

                var hammRes = _lista6.Hamming74(input);
                var enumerable = hammRes as int[] ?? hammRes.ToArray();

                var randomBit = new Random().Next(0, 6);
                randomBitLabel.Text = randomBit.ToString();
                if (enumerable[randomBit] == 0) {
                    enumerable[randomBit] = 1;
                } else {
                    enumerable[randomBit] = 0;
                }
                
                Lb1.Text = enumerable[0].ToString();
                Lb2.Text = enumerable[1].ToString();
                Lb4.Text = enumerable[3].ToString();

                var str = enumerable.Aggregate(@"", (current, x) => current + x);

                outputBox74.Text = str;
                Hamming74DecoderButton.Enabled = true;
            }
        }

        private void Hamming74DecoderButton_Click(object sender, EventArgs e) {
            // Zwykly dekoder bez zmiany bitu
            var input = HelperFuncs.ConvertToBits(outputBox74.Text, 7);
            var hammDecRes = _lista6.Hamming74Decoder(input);
            var str = hammDecRes.Aggregate("", (current, x) => current + x);

            decodeResultBox.Text = str;
        }



        #endregion

        #region Hamming 15,11

        private void Hamm1511CoderButton_Click(object sender, EventArgs e) {
            // Zwykly koder bez zmiany bitu
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox1511.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox1511.Text.Length != 11) {
                MessageBox.Show(@"Musisz wpisac 11 bitow!");
            } else {
                matrixBox.Text = "";
                var input = HelperFuncs.ConvertToBits(inputBox1511.Text, 11);

                var hammRes = _lista6.Hamming1511(input);

                var enumerable = hammRes as int[] ?? hammRes.ToArray();
                var str = enumerable.Aggregate(@"", (current, x) => current + x);
                outputBox1511.Text = str;

                Hamming1511DecoderButton.Enabled = true;
            }
        }

        private void Hamm1511CoderButton_2_Click(object sender, EventArgs e) {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputBox1511.Text, "[^0-1]")) {
                MessageBox.Show(@"Wprowadzone moga zostac tylko liczyb {0, 1}");
            } else if (inputBox1511.Text.Length != 11) {
                MessageBox.Show(@"Musisz wpisac 11 bitow!");
            } else {
                matrixBox.Text = "";
                var input = HelperFuncs.ConvertToBits(inputBox1511.Text, 11);

                var hammRes = _lista6.Hamming1511(input);

                var enumerable = hammRes as int[] ?? hammRes.ToArray();

                var randomBit = new Random().Next(0, 14);
                randomBitLabel.Text = randomBit.ToString();
                if (enumerable[randomBit] == 0) {
                    enumerable[randomBit] = 1;
                } else {
                    enumerable[randomBit] = 0;
                }


                var str = enumerable.Aggregate(@"", (current, x) => current + x);
                outputBox1511.Text = str;

                Hamming1511DecoderButton.Enabled = true;
            }
        }

        private void Hamming1511DecoderButton_Click(object sender, EventArgs e) {
            // Zwykly dekoder bez zmiany bitu
            var input = HelperFuncs.ConvertToBits(outputBox1511.Text, 15);
            var hammDecRes = _lista6.Hamming1511Decoder(input);
            var str = hammDecRes.Aggregate("", (current, x) => current + x);

            decodeResultBox_2.Text = str;
        }

        #endregion

    }
}