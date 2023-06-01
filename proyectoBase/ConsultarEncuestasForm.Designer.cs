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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGenerarCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtmFechaInicio
            // 
            this.dtmFechaInicio.Location = new System.Drawing.Point(85, 131);
            this.dtmFechaInicio.Name = "dtmFechaInicio";
            this.dtmFechaInicio.Size = new System.Drawing.Size(301, 27);
            this.dtmFechaInicio.TabIndex = 1;
            // 
            // dtmFechaFin
            // 
            this.dtmFechaFin.Location = new System.Drawing.Point(85, 232);
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
            this.label2.Location = new System.Drawing.Point(85, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de fin";
            // 
            // btnBuscarLlamadasPeriodo
            // 
            this.btnBuscarLlamadasPeriodo.Location = new System.Drawing.Point(158, 301);
            this.btnBuscarLlamadasPeriodo.Name = "btnBuscarLlamadasPeriodo";
            this.btnBuscarLlamadasPeriodo.Size = new System.Drawing.Size(156, 62);
            this.btnBuscarLlamadasPeriodo.TabIndex = 5;
            this.btnBuscarLlamadasPeriodo.Text = "Buscar Llamadas de Periodo";
            this.btnBuscarLlamadasPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscarLlamadasPeriodo.Click += new System.EventHandler(this.btnBuscarLlamadasPeriodo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(158, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 62);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(464, 24);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(438, 206);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente});
            this.dataGridView3.Location = new System.Drawing.Point(899, 24);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(266, 206);
            this.dataGridView3.TabIndex = 10;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 125;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(464, 250);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(710, 244);
            this.listBox1.TabIndex = 11;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(882, 526);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 50);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGenerarCsv
            // 
            this.btnGenerarCsv.Location = new System.Drawing.Point(684, 526);
            this.btnGenerarCsv.Name = "btnGenerarCsv";
            this.btnGenerarCsv.Size = new System.Drawing.Size(128, 50);
            this.btnGenerarCsv.TabIndex = 13;
            this.btnGenerarCsv.Text = "Generar CSV";
            this.btnGenerarCsv.UseVisualStyleBackColor = true;
            this.btnGenerarCsv.Click += new System.EventHandler(this.btnGenerarCsv_Click);
            // 
            // ConsultarEncuestasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 630);
            this.Controls.Add(this.btnGenerarCsv);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView3);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Cliente;
        private ListBox listBox1;
        private Button btnImprimir;
        private Button btnGenerarCsv;
    }
}