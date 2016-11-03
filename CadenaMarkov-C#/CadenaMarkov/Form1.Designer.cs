namespace CadenaMarkov
{
    partial class Form1
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
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.palabrasEn = new System.Windows.Forms.ListBox();
            this.PalabrasCon = new System.Windows.Forms.ListBox();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_Oracion = new System.Windows.Forms.Button();
            this.txt_oracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(12, 12);
            this.txt_texto.Multiline = true;
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(501, 304);
            this.txt_texto.TabIndex = 0;
            // 
            // palabrasEn
            // 
            this.palabrasEn.FormattingEnabled = true;
            this.palabrasEn.Location = new System.Drawing.Point(522, 25);
            this.palabrasEn.Name = "palabrasEn";
            this.palabrasEn.Size = new System.Drawing.Size(120, 329);
            this.palabrasEn.TabIndex = 1;
            // 
            // PalabrasCon
            // 
            this.PalabrasCon.FormattingEnabled = true;
            this.PalabrasCon.Location = new System.Drawing.Point(648, 25);
            this.PalabrasCon.Name = "PalabrasCon";
            this.PalabrasCon.Size = new System.Drawing.Size(120, 329);
            this.PalabrasCon.TabIndex = 2;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(12, 322);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(128, 23);
            this.btn_cargar.TabIndex = 3;
            this.btn_cargar.Text = "Cargar Cadena";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(146, 322);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(107, 23);
            this.btn_list.TabIndex = 4;
            this.btn_list.Text = "Cargar Palabras";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_Oracion
            // 
            this.btn_Oracion.Location = new System.Drawing.Point(259, 322);
            this.btn_Oracion.Name = "btn_Oracion";
            this.btn_Oracion.Size = new System.Drawing.Size(75, 23);
            this.btn_Oracion.TabIndex = 5;
            this.btn_Oracion.Text = "Crear Oracion";
            this.btn_Oracion.UseVisualStyleBackColor = true;
            this.btn_Oracion.Click += new System.EventHandler(this.btn_Oracion_Click);
            // 
            // txt_oracion
            // 
            this.txt_oracion.Enabled = false;
            this.txt_oracion.Location = new System.Drawing.Point(12, 364);
            this.txt_oracion.Name = "txt_oracion";
            this.txt_oracion.Size = new System.Drawing.Size(756, 20);
            this.txt_oracion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Palabras Encontradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "% palabra Continua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Oracion Creada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_oracion);
            this.Controls.Add(this.btn_Oracion);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.PalabrasCon);
            this.Controls.Add(this.palabrasEn);
            this.Controls.Add(this.txt_texto);
            this.Name = "Form1";
            this.Text = "Cadena Marvok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.ListBox palabrasEn;
        private System.Windows.Forms.ListBox PalabrasCon;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_Oracion;
        private System.Windows.Forms.TextBox txt_oracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

