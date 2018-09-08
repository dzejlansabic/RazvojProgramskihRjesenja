namespace Zadaca1
{
    partial class FormaSlika
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.slika = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dodajSliku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // slika
            // 
            this.slika.Location = new System.Drawing.Point(3, 3);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(143, 138);
            this.slika.TabIndex = 0;
            this.slika.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dodajSliku
            // 
            this.dodajSliku.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajSliku.Location = new System.Drawing.Point(0, 162);
            this.dodajSliku.Name = "dodajSliku";
            this.dodajSliku.Size = new System.Drawing.Size(146, 23);
            this.dodajSliku.TabIndex = 2;
            this.dodajSliku.Text = "Promijeni";
            this.dodajSliku.UseVisualStyleBackColor = true;
            this.dodajSliku.Click += new System.EventHandler(this.dodajSliku_Click);
            // 
            // FormaSlika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dodajSliku);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.slika);
            this.Name = "FormaSlika";
            this.Size = new System.Drawing.Size(149, 188);
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dodajSliku;
    }
}
