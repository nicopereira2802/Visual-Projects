namespace proyectoBase
{
    partial class LlamadasCEncuesta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescripcionO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncuestaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionO,
            this.DetalleAccion,
            this.EncuestaE,
            this.Duracion,
            this.Observacion});
            this.dataGridView1.Location = new System.Drawing.Point(52, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(687, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // DescripcionO
            // 
            this.DescripcionO.HeaderText = "DescripcionO";
            this.DescripcionO.MinimumWidth = 6;
            this.DescripcionO.Name = "DescripcionO";
            this.DescripcionO.Width = 125;
            // 
            // DetalleAccion
            // 
            this.DetalleAccion.HeaderText = "DetalleAccion";
            this.DetalleAccion.MinimumWidth = 6;
            this.DetalleAccion.Name = "DetalleAccion";
            this.DetalleAccion.Width = 125;
            // 
            // EncuestaE
            // 
            this.EncuestaE.HeaderText = "EncuestaE";
            this.EncuestaE.MinimumWidth = 6;
            this.EncuestaE.Name = "EncuestaE";
            this.EncuestaE.Width = 125;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            this.Duracion.Width = 125;
            // 
            // Observacion
            // 
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DescripcionO;
        private DataGridViewTextBoxColumn DetalleAccion;
        private DataGridViewTextBoxColumn EncuestaE;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Observacion;
    }
}