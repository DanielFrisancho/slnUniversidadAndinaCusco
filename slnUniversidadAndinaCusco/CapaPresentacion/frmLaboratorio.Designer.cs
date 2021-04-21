
namespace CapaPresentacion
{
    partial class frmLaboratorio
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtRequerimientos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnExperimentar = new System.Windows.Forms.Button();
            this.btnEnsamblar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(111, 56);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(179, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(111, 116);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(179, 20);
            this.txtUbicacion.TabIndex = 1;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(111, 180);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(179, 20);
            this.txtCreditos.TabIndex = 2;
            // 
            // txtRequerimientos
            // 
            this.txtRequerimientos.Location = new System.Drawing.Point(111, 247);
            this.txtRequerimientos.Name = "txtRequerimientos";
            this.txtRequerimientos.Size = new System.Drawing.Size(179, 20);
            this.txtRequerimientos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombres:";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(468, 56);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(468, 116);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnExperimentar
            // 
            this.btnExperimentar.Location = new System.Drawing.Point(111, 346);
            this.btnExperimentar.Name = "btnExperimentar";
            this.btnExperimentar.Size = new System.Drawing.Size(80, 23);
            this.btnExperimentar.TabIndex = 7;
            this.btnExperimentar.Text = "Experimentar";
            this.btnExperimentar.UseVisualStyleBackColor = true;
            this.btnExperimentar.Click += new System.EventHandler(this.btnExperimentar_Click);
            // 
            // btnEnsamblar
            // 
            this.btnEnsamblar.Location = new System.Drawing.Point(241, 346);
            this.btnEnsamblar.Name = "btnEnsamblar";
            this.btnEnsamblar.Size = new System.Drawing.Size(75, 23);
            this.btnEnsamblar.TabIndex = 8;
            this.btnEnsamblar.Text = "Ensamblar";
            this.btnEnsamblar.UseVisualStyleBackColor = true;
            this.btnEnsamblar.Click += new System.EventHandler(this.btnEnsamblar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(372, 346);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(75, 23);
            this.btnCortar.TabIndex = 9;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ubicacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Creditos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Requerimientos";
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.btnEnsamblar);
            this.Controls.Add(this.btnExperimentar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequerimientos);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNombres);
            this.Name = "frmLaboratorio";
            this.Text = "Trabajar con la Clase Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtRequerimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnExperimentar;
        private System.Windows.Forms.Button btnEnsamblar;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}