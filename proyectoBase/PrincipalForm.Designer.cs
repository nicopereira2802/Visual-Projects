namespace proyectoBase
{
    partial class PrincipalForm
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultarEncuesta = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Swis721 Hv BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(165, 49);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(125, 48);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Hola!";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenida.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(541, 254);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 66);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEncuesta
            // 
            this.btnConsultarEncuesta.Location = new System.Drawing.Point(311, 254);
            this.btnConsultarEncuesta.Name = "btnConsultarEncuesta";
            this.btnConsultarEncuesta.Size = new System.Drawing.Size(147, 66);
            this.btnConsultarEncuesta.TabIndex = 3;
            this.btnConsultarEncuesta.Text = "Consultar Encuesta";
            this.btnConsultarEncuesta.UseVisualStyleBackColor = true;
            this.btnConsultarEncuesta.Click += new System.EventHandler(this.btnConsultarEncuesta_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(74, 254);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 66);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(74, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Por favor seleccione una opcion";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnConsultarEncuesta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBienvenida;
        private Button btnSalir;
        private Button btnConsultarEncuesta;
        private Button btnRegistrar;
        private Label label1;
    }
}