namespace practicavideo1
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
            this.btnMostraDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnAgregarPersona2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostraDatos
            // 
            this.btnMostraDatos.Location = new System.Drawing.Point(623, 66);
            this.btnMostraDatos.Name = "btnMostraDatos";
            this.btnMostraDatos.Size = new System.Drawing.Size(144, 58);
            this.btnMostraDatos.TabIndex = 0;
            this.btnMostraDatos.Text = "MostrarDatos";
            this.btnMostraDatos.UseVisualStyleBackColor = true;
            this.btnMostraDatos.Click += new System.EventHandler(this.btnMostraDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(163, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(296, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(163, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido :";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(296, 129);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(276, 27);
            this.txtApellido.TabIndex = 4;
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.ItemHeight = 20;
            this.lstPersonas.Location = new System.Drawing.Point(236, 310);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(356, 124);
            this.lstPersonas.TabIndex = 5;
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(184, 183);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(186, 60);
            this.btnAgregarPersona.TabIndex = 6;
            this.btnAgregarPersona.Text = "Agregar Persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarPersona2
            // 
            this.btnAgregarPersona2.Location = new System.Drawing.Point(437, 183);
            this.btnAgregarPersona2.Name = "btnAgregarPersona2";
            this.btnAgregarPersona2.Size = new System.Drawing.Size(186, 60);
            this.btnAgregarPersona2.TabIndex = 7;
            this.btnAgregarPersona2.Text = "Agregar Persona 2";
            this.btnAgregarPersona2.UseVisualStyleBackColor = true;
            this.btnAgregarPersona2.Click += new System.EventHandler(this.btnAgregarPersona2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 565);
            this.Controls.Add(this.btnAgregarPersona2);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.lstPersonas);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostraDatos);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMostraDatos;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private ListBox lstPersonas;
        private Button btnAgregarPersona;
        private Button btnAgregarPersona2;
    }
}