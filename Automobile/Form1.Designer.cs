namespace Automobile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accensione = new System.Windows.Forms.Button();
            this.Acceleratore = new System.Windows.Forms.Button();
            this.Freno = new System.Windows.Forms.Button();
            this.Tacchimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accensione
            // 
            this.accensione.Location = new System.Drawing.Point(440, 406);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(58, 56);
            this.accensione.TabIndex = 0;
            this.accensione.Text = "On/off";
            this.accensione.UseVisualStyleBackColor = true;
            this.accensione.Click += new System.EventHandler(this.accensione_Click);
            // 
            // Acceleratore
            // 
            this.Acceleratore.Location = new System.Drawing.Point(315, 369);
            this.Acceleratore.Name = "Acceleratore";
            this.Acceleratore.Size = new System.Drawing.Size(75, 93);
            this.Acceleratore.TabIndex = 1;
            this.Acceleratore.Text = "Acceleratore";
            this.Acceleratore.UseVisualStyleBackColor = true;
            // 
            // Freno
            // 
            this.Freno.Location = new System.Drawing.Point(176, 369);
            this.Freno.Name = "Freno";
            this.Freno.Size = new System.Drawing.Size(75, 93);
            this.Freno.TabIndex = 2;
            this.Freno.Text = "Freno";
            this.Freno.UseVisualStyleBackColor = true;
            // 
            // Tacchimetro
            // 
            this.Tacchimetro.AutoSize = true;
            this.Tacchimetro.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tacchimetro.Location = new System.Drawing.Point(236, 218);
            this.Tacchimetro.Name = "Tacchimetro";
            this.Tacchimetro.Size = new System.Drawing.Size(106, 65);
            this.Tacchimetro.TabIndex = 3;
            this.Tacchimetro.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 515);
            this.Controls.Add(this.Tacchimetro);
            this.Controls.Add(this.Freno);
            this.Controls.Add(this.Acceleratore);
            this.Controls.Add(this.accensione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button accensione;
        private Button Acceleratore;
        private Button Freno;
        private Label Tacchimetro;
    }
}