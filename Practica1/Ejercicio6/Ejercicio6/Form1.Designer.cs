namespace Ejercicio6
{
    partial class Frm_inicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.Combox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Txt_numero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresee Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // btn_Generar
            // 
            this.btn_Generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar.Location = new System.Drawing.Point(453, 96);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(97, 30);
            this.btn_Generar.TabIndex = 3;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // Combox
            // 
            this.Combox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combox.FormattingEnabled = true;
            this.Combox.Items.AddRange(new object[] {
            "Primos",
            "Perfectos",
            "Fibonacci"});
            this.Combox.Location = new System.Drawing.Point(297, 96);
            this.Combox.Name = "Combox";
            this.Combox.Size = new System.Drawing.Size(121, 30);
            this.Combox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(171, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 180);
            this.listBox1.TabIndex = 5;
            // 
            // Txt_numero
            // 
            this.Txt_numero.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numero.Location = new System.Drawing.Point(171, 96);
            this.Txt_numero.Name = "Txt_numero";
            this.Txt_numero.Size = new System.Drawing.Size(100, 29);
            this.Txt_numero.TabIndex = 6;
            // 
            // Frm_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 432);
            this.Controls.Add(this.Txt_numero);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Combox);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_inicial";
            this.Text = "Aplicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.ComboBox Combox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Txt_numero;
        public System.Windows.Forms.Label label1;
    }
}

