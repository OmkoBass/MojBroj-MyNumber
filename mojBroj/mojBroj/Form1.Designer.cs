namespace mojBroj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stop = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.puta = new System.Windows.Forms.Button();
            this.podeljeno = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.tr = new System.Windows.Forms.Label();
            this.levaZagrada = new System.Windows.Forms.Button();
            this.desnaZagrada = new System.Windows.Forms.Button();
            this.prvi = new System.Windows.Forms.Button();
            this.drugi = new System.Windows.Forms.Button();
            this.treci = new System.Windows.Forms.Button();
            this.cetvrti = new System.Windows.Forms.Button();
            this.peti = new System.Windows.Forms.Button();
            this.sesti = new System.Windows.Forms.Button();
            this.trenutniBroj = new System.Windows.Forms.Button();
            this.brojPogadjas = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(170, 112);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(56, 31);
            this.stop.TabIndex = 7;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(14, 167);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(374, 38);
            this.input.TabIndex = 8;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(170, 211);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(56, 31);
            this.ok.TabIndex = 9;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(472, 8);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(43, 33);
            this.plus.TabIndex = 10;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(472, 47);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(43, 33);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // puta
            // 
            this.puta.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puta.Location = new System.Drawing.Point(472, 87);
            this.puta.Name = "puta";
            this.puta.Size = new System.Drawing.Size(43, 33);
            this.puta.TabIndex = 12;
            this.puta.Text = "*";
            this.puta.UseVisualStyleBackColor = true;
            this.puta.Click += new System.EventHandler(this.Puta_Click);
            // 
            // podeljeno
            // 
            this.podeljeno.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podeljeno.Location = new System.Drawing.Point(472, 125);
            this.podeljeno.Name = "podeljeno";
            this.podeljeno.Size = new System.Drawing.Size(43, 33);
            this.podeljeno.TabIndex = 13;
            this.podeljeno.Text = "÷";
            this.podeljeno.UseVisualStyleBackColor = true;
            this.podeljeno.Click += new System.EventHandler(this.Podeljeno_Click);
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazad.Location = new System.Drawing.Point(394, 167);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(72, 38);
            this.nazad.TabIndex = 16;
            this.nazad.Text = "<---";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // tr
            // 
            this.tr.AutoSize = true;
            this.tr.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tr.Location = new System.Drawing.Point(298, 20);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(82, 21);
            this.tr.TabIndex = 18;
            this.tr.Text = "TREUNTNO:";
            // 
            // levaZagrada
            // 
            this.levaZagrada.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levaZagrada.Location = new System.Drawing.Point(472, 164);
            this.levaZagrada.Name = "levaZagrada";
            this.levaZagrada.Size = new System.Drawing.Size(43, 33);
            this.levaZagrada.TabIndex = 19;
            this.levaZagrada.Text = "(";
            this.levaZagrada.UseVisualStyleBackColor = true;
            this.levaZagrada.Click += new System.EventHandler(this.LevaZagrada_Click_1);
            // 
            // desnaZagrada
            // 
            this.desnaZagrada.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desnaZagrada.Location = new System.Drawing.Point(472, 203);
            this.desnaZagrada.Name = "desnaZagrada";
            this.desnaZagrada.Size = new System.Drawing.Size(43, 33);
            this.desnaZagrada.TabIndex = 20;
            this.desnaZagrada.Text = ")";
            this.desnaZagrada.UseVisualStyleBackColor = true;
            this.desnaZagrada.Click += new System.EventHandler(this.DesnaZagrada_Click);
            // 
            // prvi
            // 
            this.prvi.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prvi.Location = new System.Drawing.Point(14, 68);
            this.prvi.Name = "prvi";
            this.prvi.Size = new System.Drawing.Size(38, 38);
            this.prvi.TabIndex = 21;
            this.prvi.UseVisualStyleBackColor = true;
            this.prvi.Click += new System.EventHandler(this.Prvi_Click_1);
            // 
            // drugi
            // 
            this.drugi.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugi.Location = new System.Drawing.Point(58, 68);
            this.drugi.Name = "drugi";
            this.drugi.Size = new System.Drawing.Size(38, 38);
            this.drugi.TabIndex = 22;
            this.drugi.UseVisualStyleBackColor = true;
            this.drugi.Click += new System.EventHandler(this.Drugi_Click_1);
            // 
            // treci
            // 
            this.treci.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treci.Location = new System.Drawing.Point(102, 68);
            this.treci.Name = "treci";
            this.treci.Size = new System.Drawing.Size(38, 38);
            this.treci.TabIndex = 23;
            this.treci.UseVisualStyleBackColor = true;
            this.treci.Click += new System.EventHandler(this.Treci_Click_1);
            // 
            // cetvrti
            // 
            this.cetvrti.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetvrti.Location = new System.Drawing.Point(146, 68);
            this.cetvrti.Name = "cetvrti";
            this.cetvrti.Size = new System.Drawing.Size(38, 38);
            this.cetvrti.TabIndex = 24;
            this.cetvrti.UseVisualStyleBackColor = true;
            this.cetvrti.Click += new System.EventHandler(this.Cetvrti_Click_1);
            // 
            // peti
            // 
            this.peti.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peti.Location = new System.Drawing.Point(216, 68);
            this.peti.Name = "peti";
            this.peti.Size = new System.Drawing.Size(79, 38);
            this.peti.TabIndex = 25;
            this.peti.UseVisualStyleBackColor = true;
            this.peti.Click += new System.EventHandler(this.Peti_Click_1);
            // 
            // sesti
            // 
            this.sesti.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesti.Location = new System.Drawing.Point(301, 68);
            this.sesti.Name = "sesti";
            this.sesti.Size = new System.Drawing.Size(79, 38);
            this.sesti.TabIndex = 26;
            this.sesti.UseVisualStyleBackColor = true;
            this.sesti.Click += new System.EventHandler(this.Sesti_Click_1);
            // 
            // trenutniBroj
            // 
            this.trenutniBroj.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trenutniBroj.Location = new System.Drawing.Point(387, 8);
            this.trenutniBroj.Name = "trenutniBroj";
            this.trenutniBroj.Size = new System.Drawing.Size(79, 43);
            this.trenutniBroj.TabIndex = 27;
            this.trenutniBroj.UseVisualStyleBackColor = true;
            // 
            // brojPogadjas
            // 
            this.brojPogadjas.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojPogadjas.Location = new System.Drawing.Point(147, 10);
            this.brojPogadjas.Name = "brojPogadjas";
            this.brojPogadjas.Size = new System.Drawing.Size(104, 43);
            this.brojPogadjas.TabIndex = 28;
            this.brojPogadjas.UseVisualStyleBackColor = true;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(10, 266);
            this.progress.MarqueeAnimationSpeed = 1000;
            this.progress.Maximum = 75;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(503, 23);
            this.progress.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(525, 301);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.brojPogadjas);
            this.Controls.Add(this.trenutniBroj);
            this.Controls.Add(this.sesti);
            this.Controls.Add(this.peti);
            this.Controls.Add(this.cetvrti);
            this.Controls.Add(this.treci);
            this.Controls.Add(this.drugi);
            this.Controls.Add(this.prvi);
            this.Controls.Add(this.desnaZagrada);
            this.Controls.Add(this.levaZagrada);
            this.Controls.Add(this.tr);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.podeljeno);
            this.Controls.Add(this.puta);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.input);
            this.Controls.Add(this.stop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(541, 340);
            this.Name = "Form1";
            this.Text = "Moj broj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button puta;
        private System.Windows.Forms.Button podeljeno;
        private System.Windows.Forms.Label tr;
        internal System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button levaZagrada;
        private System.Windows.Forms.Button desnaZagrada;
        private System.Windows.Forms.Button prvi;
        private System.Windows.Forms.Button drugi;
        private System.Windows.Forms.Button treci;
        private System.Windows.Forms.Button cetvrti;
        private System.Windows.Forms.Button peti;
        private System.Windows.Forms.Button sesti;
        private System.Windows.Forms.Button trenutniBroj;
        private System.Windows.Forms.Button brojPogadjas;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Timer timer1;
    }
}

