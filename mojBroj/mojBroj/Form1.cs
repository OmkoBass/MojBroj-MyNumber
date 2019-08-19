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
using org.mariuszgromada.math.mxparser;
using System.Timers;

namespace mojBroj
{

    public partial class Form1 : Form
    {
        int s = 0;
        public Form1()
        {
            InitializeComponent();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; //intercal = 1 sec
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;

            MaximizeBox = false;
            MinimizeBox = false;
            input.ReadOnly = true;
            ok.Enabled = false;
            plus.Enabled = false;
            minus.Enabled = false;
            puta.Enabled = false;
            podeljeno.Enabled = false;
            nazad.Enabled = false;
            levaZagrada.Enabled = false;
            desnaZagrada.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(s == 60) { s = 0; MessageBox.Show("Nema vise vremena."); this.Close(); }
            else { progress.Value = s; s += 1; }
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
                nazad.Enabled = true;
                levaZagrada.Enabled = true;
                desnaZagrada.Enabled = true;
            }
            brojac++;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                Expression ex = new Expression(input.Text);
                string ss = ex.calculate().ToString();
                int x = Int16.Parse(ss);
                int y = Int16.Parse(brojPogadjas.Text);
                if (x == y) { s = 0; MessageBox.Show("Tacno!"); this.Close(); }
                else { s = 0; MessageBox.Show($"Netacno! Tvoj broj je {x}"); this.Close(); }
            }
            catch { s = 0; MessageBox.Show("Los unos! / Bad input!"); this.Close(); }
        }

        private void Prvi_Click_1(object sender, EventArgs e)
        {
            input.AppendText(prvi.Text);
            prvi.BackColor = Color.White;
            enableOperations();
            disableNumbers();
        }

        private void Drugi_Click_1(object sender, EventArgs e)
        {
            input.AppendText(drugi.Text);
            drugi.BackColor = Color.White;
            enableOperations();
            disableNumbers();
        }

        private void Treci_Click_1(object sender, EventArgs e)
        {
            input.AppendText(treci.Text);
            treci.BackColor = Color.White;
            enableOperations();
            disableNumbers();
        }

        private void Cetvrti_Click_1(object sender, EventArgs e)
        {
            input.AppendText(cetvrti.Text);
            cetvrti.BackColor = Color.White;
            enableOperations();
            disableNumbers();
        }

        private void Peti_Click_1(object sender, EventArgs e)
        {
            input.AppendText(peti.Text);
            peti.BackColor = Color.White;
            enableOperations();
            disableNumbers();
        }

        private void Sesti_Click_1(object sender, EventArgs e)
        {
            input.AppendText(sesti.Text);
            sesti.BackColor = Color.White;
            enableOperations();
            disableNumbers();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            input.AppendText("+");
            disableOperations();
            enableNumbers();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            input.AppendText("-");
            disableOperations();
            enableNumbers();
        }

        private void Puta_Click(object sender, EventArgs e)
        {
            input.AppendText("*");
            disableOperations();
            enableNumbers();
        }

        private void Podeljeno_Click(object sender, EventArgs e)
        {
            input.AppendText("/");
            disableOperations();
            enableNumbers();
        }
        private void LevaZagrada_Click_1(object sender, EventArgs e)
        {
            input.AppendText("(");
            enableNumbers();
        }
        private void DesnaZagrada_Click(object sender, EventArgs e)
        {
            input.AppendText(")");
            enableNumbers();
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
                Expression ex = new Expression(input.Text);
                string s = ex.calculate().ToString();
                trenutniBroj.Text = s;
                if(s.Equals(brojPogadjas.Text)) { trenutniBroj.BackColor = Color.Green; }
            }
            catch { }
        }

        public void enableOperations()
        {
            plus.Enabled = true;
            minus.Enabled = true;
            puta.Enabled = true;
            podeljeno.Enabled = true;
        }

        public void disableOperations()
        {
            plus.Enabled = false;
            minus.Enabled = false;
            puta.Enabled = false;
            podeljeno.Enabled = false;
        }

        public void enableNumbers()
        {
            prvi.Enabled = true;
            drugi.Enabled = true;
            treci.Enabled = true;
            cetvrti.Enabled = true;
            peti.Enabled = true;
            sesti.Enabled = true;
        }

        public void disableNumbers()
        {
            prvi.Enabled = false;
            drugi.Enabled = false;
            treci.Enabled = false;
            cetvrti.Enabled = false;
            peti.Enabled = false;
            sesti.Enabled = false;
        }
    }
}
