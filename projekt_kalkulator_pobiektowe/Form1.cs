using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_kalkulator_pobiektowe
{
    public partial class Form1 : Form
    {
        double liczba;
        string operacja;
        double liczba2;
        double wynik;
        bool przecinekUsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string btnText = button.Text;

            if (lblWynik.Text == "0")
            {
                lblWynik.Text = btnText;
            }
            else
            {
                lblWynik.Text = lblWynik.Text + btnText;
            }
        }

        private void btnDodawanie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(lblWynik.Text);
            lblWynik.Text = "0";
            operacja = "+";
        }

        private void btnOdejmowanie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(lblWynik.Text);
            lblWynik.Text = "0";
            operacja = "-";
        }

        private void btnMnozenie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(lblWynik.Text);
            lblWynik.Text = "0";
            operacja = "*";
        }

        private void btnDzielenie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(lblWynik.Text);
            lblWynik.Text = "0";
            operacja = "/";
        }

        private void btnPrzecinek_Click(object sender, EventArgs e)
        {
            if (!przecinekUsed)
            {
                lblWynik.Text = lblWynik.Text + ",";
                przecinekUsed = true;
            }
        }

        private void btnWynik_Click(object sender, EventArgs e)
        {

            liczba2 = double.Parse(lblWynik.Text);

            if (operacja == "+")
            {
                lblHistoria.Text = $"{liczba} + {liczba2} =";
                wynik = (liczba + liczba2);
                lblWynik.Text = Convert.ToString(wynik);
            }
            if (operacja == "-")
            {
                lblHistoria.Text = $"{liczba} - {liczba2} =";
                wynik = (liczba - liczba2);
                lblWynik.Text = Convert.ToString(wynik);
            }
            if (operacja == "*")
            {
                lblHistoria.Text = $"{liczba} * {liczba2} =";
                wynik = (liczba * liczba2);
                lblWynik.Text = Convert.ToString(wynik);
            }
            if (operacja == "/")
            {
                if (liczba2 == 0)
                {
                    MessageBox.Show("Nie można dzielić przez 0", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wynik = 0;
                    liczba = 0;
                    liczba2 = 0;
                    lblWynik.Text = "0";
                    przecinekUsed = false;
                }
                else
                {
                    lblHistoria.Text = $"{liczba} / {liczba2} =";
                    wynik = (liczba / liczba2);
                    lblWynik.Text = Convert.ToString(wynik);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            wynik = 0;
            liczba = 0;
            liczba2 = 0;
            lblWynik.Text = "0";
            lblHistoria.Text = "";
            przecinekUsed = false;
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (lblWynik.Text.StartsWith("-"))
            {
                lblWynik.Text = lblWynik.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(lblWynik.Text) && lblWynik.Text != "0")
            {
                lblWynik.Text = "-" + lblWynik.Text;
            }
        }
    }
}
