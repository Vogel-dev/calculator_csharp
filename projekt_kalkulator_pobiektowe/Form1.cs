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
            this.KeyPreview = true;  // Włączenie obsługi zdarzeń klawiatury
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
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
            lblHistoria.Text = $"{liczba} + ";
            operacja = "+";
        }

        private void btnOdejmowanie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(lblWynik.Text);
            lblWynik.Text = "0";
            lblHistoria.Text = $"{liczba} - ";
            operacja = "-";
        }

        private void btnMnozenie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(lblWynik.Text);
            lblWynik.Text = "0";
            lblHistoria.Text = $"{liczba} * ";
            operacja = "*";
        }

        private void btnDzielenie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(lblWynik.Text);
            lblWynik.Text = "0";
            lblHistoria.Text = $"{liczba} / ";
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
                    lblHistoria.Text = "";
                    lblWynik.Text = "0";
                    MessageBox.Show("Nie można dzielić przez 0", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    wynik = 0;
                    liczba = 0;
                    liczba2 = 0;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btnNumber_Click(btn0, EventArgs.Empty);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btnNumber_Click(btn1, EventArgs.Empty);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btnNumber_Click(btn2, EventArgs.Empty);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btnNumber_Click(btn3, EventArgs.Empty);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btnNumber_Click(btn4, EventArgs.Empty);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btnNumber_Click(btn5, EventArgs.Empty);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btnNumber_Click(btn6, EventArgs.Empty);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btnNumber_Click(btn7, EventArgs.Empty);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btnNumber_Click(btn8, EventArgs.Empty);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btnNumber_Click(btn9, EventArgs.Empty);
                    break;
                case Keys.Add:
                    btnDodawanie_Click(btnDodawanie, EventArgs.Empty);
                    break;
                case Keys.Subtract:
                    btnOdejmowanie_Click(btnOdejmowanie, EventArgs.Empty);
                    break;
                case Keys.Multiply:
                    btnMnozenie_Click(btnMnozenie, EventArgs.Empty);
                    break;
                case Keys.Divide:
                    btnDzielenie_Click(btnDzielenie, EventArgs.Empty);
                    break;
                case Keys.Oemcomma:
                    btnPrzecinek_Click(btnPrzecinek, EventArgs.Empty);
                    break;
                case Keys.OemPeriod:
                    btnPrzecinek_Click(btnPrzecinek, EventArgs.Empty);
                    break;
                case Keys.Escape:
                    btnClear_Click(btnClear, EventArgs.Empty);
                    break;
                case Keys.Back:
                    btnBackspace_Click(btnBackspace, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblWynik.Text.Length > 0)
            {
                lblWynik.Text = lblWynik.Text.Substring(0, lblWynik.Text.Length - 1);
            }
        }
    }
}
