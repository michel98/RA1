namespace WindowsRA1.Recepcion
{
    partial class frmVisualizarServiciosMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarServiciosMedico));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServiciosMedico = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdServicioBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnImprimirDiagnostico = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios asignados";
            // 
            // dgvServiciosMedico
            // 
            this.dgvServiciosMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiciosMedico.Location = new System.Drawing.Point(12, 51);
            this.dgvServiciosMedico.Name = "dgvServiciosMedico";
            this.dgvServiciosMedico.Size = new System.Drawing.Size(551, 104);
            this.dgvServiciosMedico.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id de servicio:";
            // 
            // txtIdServicioBuscar
            // 
            this.txtIdServicioBuscar.Location = new System.Drawing.Point(106, 170);
            this.txtIdServicioBuscar.Name = "txtIdServicioBuscar";
            this.txtIdServicioBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtIdServicioBuscar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diagnostico:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(305, 170);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(258, 85);
            this.txtDiagnostico.TabIndex = 5;
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.Location = new System.Drawing.Point(106, 196);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarServicio.TabIndex = 6;
            this.btnBuscarServicio.Text = "Buscar servicio";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            // 
            // btnImprimirDiagnostico
            // 
            this.btnImprimirDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirDiagnostico.Location = new System.Drawing.Point(436, 261);
            this.btnImprimirDiagnostico.Name = "btnImprimirDiagnostico";
            this.btnImprimirDiagnostico.Size = new System.Drawing.Size(127, 23);
            this.btnImprimirDiagnostico.TabIndex = 7;
            this.btnImprimirDiagnostico.Text = "Imprimir diagnostico";
            this.btnImprimirDiagnostico.UseVisualStyleBackColor = true;
            this.btnImprimirDiagnostico.Click += new System.EventHandler(this.btnImprimirDiagnostico_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 271);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Atendido";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(305, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmVisualizarServiciosMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(575, 296);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnImprimirDiagnostico);
            this.Controls.Add(this.btnBuscarServicio);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdServicioBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvServiciosMedico);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizarServiciosMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios de medico";
            this.Load += new System.EventHandler(this.frmVisualizarServiciosMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServiciosMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdServicioBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Button btnImprimirDiagnostico;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnGuardar;
    }
}