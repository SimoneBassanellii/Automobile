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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accensione
            // 
            this.accensione.Location = new System.Drawing.Point(440, 406);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(58, 56);
            this.accensione.TabIndex = 0;
            this.accensione.Text = "Start";
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(189, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 150);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Freno);
            this.Controls.Add(this.Acceleratore);
            this.Controls.Add(this.accensione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button accensione;
        private Button Acceleratore;
        private Button Freno;
        private ListView listView1;
        private Button button1;
    }
}