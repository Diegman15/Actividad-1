namespace holimundo
{
    partial class Holi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Holi));
            this.lbPresentacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPresentacion
            // 
            this.lbPresentacion.AutoSize = true;
            this.lbPresentacion.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresentacion.ForeColor = System.Drawing.Color.Blue;
            this.lbPresentacion.Location = new System.Drawing.Point(174, 35);
            this.lbPresentacion.Name = "lbPresentacion";
            this.lbPresentacion.Size = new System.Drawing.Size(256, 30);
            this.lbPresentacion.TabIndex = 0;
            this.lbPresentacion.Text = "Bienvenidos a mi app";
            this.lbPresentacion.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce tu nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 2;
            // 
            // bb
            // 
            this.bb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bb.Location = new System.Drawing.Point(143, 190);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(354, 93);
            this.bb.TabIndex = 3;
            this.bb.Text = "&Puchale";
            this.bb.UseVisualStyleBackColor = true;
            this.bb.Click += new System.EventHandler(this.Bb_Click);
            // 
            // Holi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPresentacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Holi";
            this.Text = "Capi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bb;
    }
}

