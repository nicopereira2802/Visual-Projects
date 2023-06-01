namespace proyectoBase
{
    partial class ConsultarEncuestasForm
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
            this.dtmFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtmFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarLlamadasPeriodo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmFechaInicio
            // 
            this.dtmFechaInicio.Location = new System.Drawing.Point(85, 108);
            this.dtmFechaInicio.Name = "dtmFechaInicio";
            this.dtmFechaInicio.Size = new System.Drawing.Size(301, 27);
            this.dtmFechaInicio.TabIndex = 1;
            // 
            // dtmFechaFin
            // 
            this.dtmFechaFin.Location = new System.Drawing.Point(85, 198);
            this.dtmFechaFin.Name = "dtmFechaFin";
            this.dtmFechaFin.Size = new System.Drawing.Size(301, 27);
            this.dtmFechaFin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese las fechas del periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de fin";
            // 
            // btnBuscarLlamadasPeriodo
            // 
            this.btnBuscarLlamadasPeriodo.Location = new System.Drawing.Point(158, 277);
            this.btnBuscarLlamadasPeriodo.Name = "btnBuscarLlamadasPeriodo";
            this.btnBuscarLlamadasPeriodo.Size = new System.Drawing.Size(156, 62);
            this.btnBuscarLlamadasPeriodo.TabIndex = 5;
            this.btnBuscarLlamadasPeriodo.Text = "Buscar Llamadas de Periodo";
            this.btnBuscarLlamadasPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscarLlamadasPeriodo.Click += new System.EventHandler(this.btnBuscarLlamadasPeriodo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(158, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 62);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(413, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(333, 409);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(786, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(389, 407);
            this.dataGridView1.TabIndex = 9;
            // 
            // ConsultarEncuestasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarLlamadasPeriodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmFechaFin);
            this.Controls.Add(this.dtmFechaInicio);
            this.Name = "ConsultarEncuestasForm";
            this.Text = "PantallaConsultarEncuesta";
            this.Load += new System.EventHandler(this.ConsultarEncuestasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtmFechaInicio;
        private DateTimePicker dtmFechaFin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBuscarLlamadasPeriodo;
        private Button btnCancelar;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}