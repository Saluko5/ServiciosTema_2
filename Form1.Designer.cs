namespace Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtcadena = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblerrores = new System.Windows.Forms.Label();
            this.txtExtensiones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoincidencias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(67, 121);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(100, 20);
            this.txtdir.TabIndex = 0;
            // 
            // txtcadena
            // 
            this.txtcadena.Location = new System.Drawing.Point(184, 121);
            this.txtcadena.Name = "txtcadena";
            this.txtcadena.Size = new System.Drawing.Size(100, 20);
            this.txtcadena.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(236, 252);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(236, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Detec Mayus";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Coincidencias";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(247, 198);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 8;
            // 
            // lblerrores
            // 
            this.lblerrores.AutoSize = true;
            this.lblerrores.Location = new System.Drawing.Point(247, 198);
            this.lblerrores.Name = "lblerrores";
            this.lblerrores.Size = new System.Drawing.Size(0, 13);
            this.lblerrores.TabIndex = 9;
            // 
            // txtExtensiones
            // 
            this.txtExtensiones.Location = new System.Drawing.Point(111, 281);
            this.txtExtensiones.Name = "txtExtensiones";
            this.txtExtensiones.Size = new System.Drawing.Size(119, 20);
            this.txtExtensiones.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Extensiones:";
            // 
            // txtCoincidencias
            // 
            this.txtCoincidencias.FormattingEnabled = true;
            this.txtCoincidencias.Location = new System.Drawing.Point(67, 160);
            this.txtCoincidencias.Name = "txtCoincidencias";
            this.txtCoincidencias.Size = new System.Drawing.Size(148, 95);
            this.txtCoincidencias.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 425);
            this.Controls.Add(this.txtCoincidencias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExtensiones);
            this.Controls.Add(this.lblerrores);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtcadena);
            this.Controls.Add(this.txtdir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtcadena;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblerrores;
        private System.Windows.Forms.TextBox txtExtensiones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox txtCoincidencias;
    }
}

