namespace WindowsRA1.Medicos
{
    partial class FrmGestionDeMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionDeMedicos));
            this.dgvMedicosEstudios = new System.Windows.Forms.DataGridView();
            this.btnVisualizarMed = new System.Windows.Forms.Button();
            this.btnRegistrarMed = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicosEstudios
            // 
            this.dgvMedicosEstudios.AllowUserToAddRows = false;
            this.dgvMedicosEstudios.AllowUserToDeleteRows = false;
            this.dgvMedicosEstudios.AllowUserToOrderColumns = true;
            this.dgvMedicosEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosEstudios.Location = new System.Drawing.Point(10, 120);
            this.dgvMedicosEstudios.Name = "dgvMedicosEstudios";
            this.dgvMedicosEstudios.ReadOnly = true;
            this.dgvMedicosEstudios.Size = new System.Drawing.Size(386, 159);
            this.dgvMedicosEstudios.TabIndex = 0;
            // 
            // btnVisualizarMed
            // 
            this.btnVisualizarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarMed.Location = new System.Drawing.Point(12, 46);
            this.btnVisualizarMed.Name = "btnVisualizarMed";
            this.btnVisualizarMed.Size = new System.Drawing.Size(169, 23);
            this.btnVisualizarMed.TabIndex = 1;
            this.btnVisualizarMed.Text = "Visualizar/Actualizar lista";
            this.btnVisualizarMed.UseVisualStyleBackColor = true;
            this.btnVisualizarMed.Click += new System.EventHandler(this.btnVisualizarMed_Click);
            // 
            // btnRegistrarMed
            // 
            this.btnRegistrarMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMed.Location = new System.Drawing.Point(12, 75);
            this.btnRegistrarMed.Name = "btnRegistrarMed";
            this.btnRegistrarMed.Size = new System.Drawing.Size(169, 23);
            this.btnRegistrarMed.TabIndex = 2;
            this.btnRegistrarMed.Text = "Registrar médico";
            this.btnRegistrarMed.UseVisualStyleBackColor = true;
            this.btnRegistrarMed.Click += new System.EventHandler(this.btnRegistrarMed_Click);
            // 
            // ID
            // 
            this.ID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(215, 22);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(183, 15);
            this.ID.TabIndex = 5;
            this.ID.Text = "Inserte Id de datos a editar:";
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBuscar.Location = new System.Drawing.Point(259, 49);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(137, 20);
            this.txtIdBuscar.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(259, 75);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.Editar_click);
            // 
            // FrmGestionDeMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(410, 291);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtIdBuscar);
            this.Controls.Add(this.btnRegistrarMed);
            this.Controls.Add(this.btnVisualizarMed);
            this.Controls.Add(this.dgvMedicosEstudios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionDeMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Médicos del centro de estudios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicosEstudios;
        private System.Windows.Forms.Button btnVisualizarMed;
        private System.Windows.Forms.Button btnRegistrarMed;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.Button btnEditar;
    }
}