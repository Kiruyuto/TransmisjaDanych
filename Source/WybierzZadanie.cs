using System;
using System.Windows.Forms;
// ReSharper disable InconsistentNaming

namespace Lab2_win_forms {
    public partial class WybierzZad : Form {
        public WybierzZad() {
            InitializeComponent();
        }

        private void Lista1_Click(object sender, EventArgs e) {
            Hide();
            var lista1 = new Lista1();
            lista1.Closed += (s, args) => Close();
            lista1.Show();
        }

        private void Lista2_Click(object sender, EventArgs e) {
            Hide();
            var lista2 = new Lista2();
            lista2.Closed += (s, args) => Close();
            lista2.Show();
        }

        private void Lista3_Click(object sender, EventArgs e) {
            Hide();
            var lista3 = new Lista3();
            lista3.Closed += (s, args) => Close();
            lista3.Show();
        }

        private void Lista4_Click(object sender, EventArgs e) {
            Hide();
            var lista4 = new Lista4();
            lista4.Closed += (s, args) => Close();
            lista4.Show();
        }

        private void Lista6_Click(object sender, EventArgs e) {
            Hide();
            var lista6 = new ListaZad6();
            lista6.Closed += (s, args) => Close();
            lista6.Show();
        }

        private void Lista7_Click(object sender, EventArgs e) {
            Hide();
            var lista7 = new ListaZad7();
            lista7.Closed += (s, args) => Close();
            lista7.Show();
        }
    }
}
