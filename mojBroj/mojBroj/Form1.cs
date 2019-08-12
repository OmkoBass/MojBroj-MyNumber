using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace mojBroj
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();



            input.ReadOnly = true;
            ok.Enabled = false;
            plus.Enabled = false;
            minus.Enabled = false;
            puta.Enabled = false;
            podeljeno.Enabled = false;
            nazad.Enabled = false;
        }

        int brojac = 0;

        private void Stop_Click(object sender, EventArgs e)
        {
            //Simulira stop, (maybe stupid)
            int[] brojevi = { 10, 15, 25 };
            int[] drugiBrojevi = { 50, 75, 100 };
            Random r = new Random();

            if (brojac == 0) { brojPogadjas.Text = r.Next(1, 1000).ToString(); }
            else if (brojac == 1) { prvi.Text = r.Next(1, 10).ToString(); }
            else if (brojac == 2) { drugi.Text = r.Next(1, 10).ToString(); }
            else if (brojac == 3) { treci.Text = r.Next(1, 10).ToString(); }
            else if (brojac == 4) { cetvrti.Text = r.Next(1, 10).ToString(); }
            else if (brojac == 5) { peti.Text = brojevi[r.Next(brojevi.Length)].ToString(); }
            else if (brojac == 6)
            {
                //Setamo zadnji broj i postavljamo da mozemo da radimo sa dugmicima
                sesti.Text = drugiBrojevi[r.Next(drugiBrojevi.Length)].ToString();
                ok.Enabled = true;
                prvi.BackColor = Color.DarkRed;
                drugi.BackColor = Color.DarkRed;
                treci.BackColor = Color.DarkRed;
                cetvrti.BackColor = Color.DarkRed;
                peti.BackColor = Color.DarkRed;
                sesti.BackColor = Color.DarkRed;
                plus.Enabled = true;
                minus.Enabled = true;
                puta.Enabled = true;
                podeljeno.Enabled = true;
                nazad.Enabled = true;
            }
            brojac++;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input.Text) == false)
            {
                string s = MathParser.EvalExpression(input.Text.ToCharArray()).ToString();
                int x = Int16.Parse(s);
                int y = Int16.Parse(brojPogadjas.Text);

                if (x == y) { MessageBox.Show("Tacno!"); this.Close(); }
                else { MessageBox.Show($"Netacno! Tvoj broj je {x}"); this.Close(); }
            }
            else
            {
                MessageBox.Show("Los unos!"); this.Close();
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            input.AppendText("+");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            input.AppendText("-");
        }

        private void Puta_Click(object sender, EventArgs e)
        {
            input.AppendText("*");
        }

        private void Podeljeno_Click(object sender, EventArgs e)
        {
            input.AppendText("÷");
        }

        private void Prvi_Click(object sender, EventArgs e)
        {
            input.AppendText(prvi.Text);
            prvi.BackColor = Color.White;
            prvi.Enabled = false;
        }

        private void Drugi_Click(object sender, EventArgs e)
        {
            input.AppendText(drugi.Text);
            drugi.BackColor = Color.White;
            drugi.Enabled = false;
        }

        private void Treci_Click(object sender, EventArgs e)
        {
            input.AppendText(treci.Text);
            treci.BackColor = Color.White;
            treci.Enabled = false;
        }

        private void Cetvrti_Click(object sender, EventArgs e)
        {
            input.AppendText(cetvrti.Text);
            cetvrti.BackColor = Color.White;
            cetvrti.Enabled = false;
        }

        private void Peti_Click(object sender, EventArgs e)
        {
            input.AppendText(peti.Text);
            peti.BackColor = Color.White;
            peti.Enabled = false;
        }

        private void Sesti_Click(object sender, EventArgs e)
        {
            input.AppendText(sesti.Text);
            sesti.BackColor = Color.White;
            sesti.Enabled = false;
        }

        private void LevaZagrada_Click(object sender, EventArgs e)
        {
            input.AppendText("(");
        }

        private void DesnaZagrada_Click(object sender, EventArgs e)
        {
            input.AppendText(")");
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            trenutniBroj.Text = "";
            input.Text = "";
            prvi.BackColor = Color.DarkRed;
            drugi.BackColor = Color.DarkRed;
            treci.BackColor = Color.DarkRed;
            cetvrti.BackColor = Color.DarkRed;
            peti.BackColor = Color.DarkRed;
            sesti.BackColor = Color.DarkRed;
            prvi.Enabled = true;
            drugi.Enabled = true;
            treci.Enabled = true;
            cetvrti.Enabled = true;
            peti.Enabled = true;
            sesti.Enabled = true;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = MathParser.EvalExpression(input.Text.ToCharArray()).ToString();
                trenutniBroj.Text = s;
            }
            catch { }
        }
    }
}
