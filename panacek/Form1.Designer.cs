namespace panacek
{
    partial class oknoProgramu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.kresliciPlocha = new System.Windows.Forms.Panel();
            this.tlacitkoNahoru = new System.Windows.Forms.Button();
            this.tlacitkoDoprava = new System.Windows.Forms.Button();
            this.tlacitkoLeva = new System.Windows.Forms.Button();
            this.tlacitkoDolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kresliciPlocha
            // 
            this.kresliciPlocha.BackColor = System.Drawing.Color.Azure;
            this.kresliciPlocha.Location = new System.Drawing.Point(12, 12);
            this.kresliciPlocha.Name = "kresliciPlocha";
            this.kresliciPlocha.Size = new System.Drawing.Size(397, 384);
            this.kresliciPlocha.TabIndex = 0;
            this.kresliciPlocha.Paint += new System.Windows.Forms.PaintEventHandler(this.kresliciPlocha_Paint);
            // 
            // tlacitkoNahoru
            // 
            this.tlacitkoNahoru.BackColor = System.Drawing.Color.Azure;
            this.tlacitkoNahoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlacitkoNahoru.Location = new System.Drawing.Point(164, 420);
            this.tlacitkoNahoru.Name = "tlacitkoNahoru";
            this.tlacitkoNahoru.Size = new System.Drawing.Size(75, 23);
            this.tlacitkoNahoru.TabIndex = 1;
            this.tlacitkoNahoru.Text = "Nahoru";
            this.tlacitkoNahoru.UseVisualStyleBackColor = false;
            this.tlacitkoNahoru.Click += new System.EventHandler(this.tlacitkoNahoru_Click);
            // 
            // tlacitkoDoprava
            // 
            this.tlacitkoDoprava.BackColor = System.Drawing.Color.Azure;
            this.tlacitkoDoprava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlacitkoDoprava.Location = new System.Drawing.Point(252, 462);
            this.tlacitkoDoprava.Name = "tlacitkoDoprava";
            this.tlacitkoDoprava.Size = new System.Drawing.Size(75, 23);
            this.tlacitkoDoprava.TabIndex = 2;
            this.tlacitkoDoprava.Text = "Doprava";
            this.tlacitkoDoprava.UseVisualStyleBackColor = false;
            this.tlacitkoDoprava.Click += new System.EventHandler(this.tlacitkoDoprava_Click);
            // 
            // tlacitkoLeva
            // 
            this.tlacitkoLeva.BackColor = System.Drawing.Color.Azure;
            this.tlacitkoLeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlacitkoLeva.Location = new System.Drawing.Point(76, 462);
            this.tlacitkoLeva.Name = "tlacitkoLeva";
            this.tlacitkoLeva.Size = new System.Drawing.Size(75, 23);
            this.tlacitkoLeva.TabIndex = 3;
            this.tlacitkoLeva.Text = "doleva";
            this.tlacitkoLeva.UseVisualStyleBackColor = false;
            this.tlacitkoLeva.Click += new System.EventHandler(this.tlacitkoLeva_Click);
            // 
            // tlacitkoDolu
            // 
            this.tlacitkoDolu.BackColor = System.Drawing.Color.Azure;
            this.tlacitkoDolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlacitkoDolu.Location = new System.Drawing.Point(164, 500);
            this.tlacitkoDolu.Name = "tlacitkoDolu";
            this.tlacitkoDolu.Size = new System.Drawing.Size(75, 23);
            this.tlacitkoDolu.TabIndex = 4;
            this.tlacitkoDolu.Text = "Dolu";
            this.tlacitkoDolu.UseVisualStyleBackColor = false;
            this.tlacitkoDolu.Click += new System.EventHandler(this.tlacitkoDolu_Click);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(421, 580);
            this.Controls.Add(this.tlacitkoDolu);
            this.Controls.Add(this.tlacitkoLeva);
            this.Controls.Add(this.tlacitkoDoprava);
            this.Controls.Add(this.tlacitkoNahoru);
            this.Controls.Add(this.kresliciPlocha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oknoProgramu";
            this.Text = "Mnauka";
            this.Load += new System.EventHandler(this.oknoProgramu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kresliciPlocha;
        private System.Windows.Forms.Button tlacitkoNahoru;
        private System.Windows.Forms.Button tlacitkoDoprava;
        private System.Windows.Forms.Button tlacitkoLeva;
        private System.Windows.Forms.Button tlacitkoDolu;
    }
}

