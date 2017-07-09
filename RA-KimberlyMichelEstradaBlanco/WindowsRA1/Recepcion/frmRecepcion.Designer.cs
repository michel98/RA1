namespace WindowsRA1.Recepcion
{
    partial class frmRecepcion
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
            this.btnEstudios = new System.Windows.Forms.Button();
            this.btnMedEst = new System.Windows.Forms.Button();
            this.btnCobro = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnMedCan = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnServiciosAt = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstudios
            // 
            this.btnEstudios.Location = new System.Drawing.Point(12, 46);
            this.btnEstudios.Name = "btnEstudios";
            this.btnEstudios.Size = new System.Drawing.Size(94, 56);
            this.btnEstudios.TabIndex = 0;
            this.btnEstudios.Text = "Gestión de estudios";
            this.btnEstudios.UseVisualStyleBackColor = true;
            this.btnEstudios.Click += new System.EventHandler(this.btnEstudios_Click);
            // 
            // btnMedEst
            // 
            this.btnMedEst.Location = new System.Drawing.Point(261, 46);
            this.btnMedEst.Name = "btnMedEst";
            this.btnMedEst.Size = new System.Drawing.Size(94, 56);
            this.btnMedEst.TabIndex = 1;
            this.btnMedEst.Text = "Gestión de Medicos de estudios";
            this.btnMedEst.UseVisualStyleBackColor = true;
            this.btnMedEst.Click += new System.EventHandler(this.btnMedEst_Click);
            // 
            // btnCobro
            // 
            this.btnCobro.Location = new System.Drawing.Point(261, 138);
            this.btnCobro.Name = "btnCobro";
            this.btnCobro.Size = new System.Drawing.Size(94, 56);
            this.btnCobro.TabIndex = 2;
            this.btnCobro.Text = "Caja de cobro";
            this.btnCobro.UseVisualStyleBackColor = true;
            this.btnCobro.Click += new System.EventHandler(this.btnCobro_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(494, 138);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(94, 56);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Gestión de usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(12, 138);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(94, 56);
            this.btnPacientes.TabIndex = 4;
            this.btnPacientes.Text = "Gestión de pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnMedCan
            // 
            this.btnMedCan.Location = new System.Drawing.Point(494, 46);
            this.btnMedCan.Name = "btnMedCan";
            this.btnMedCan.Size = new System.Drawing.Size(94, 56);
            this.btnMedCan.TabIndex = 5;
            this.btnMedCan.Text = "Medicos canalizadores";
            this.btnMedCan.UseVisualStyleBackColor = true;
            this.btnMedCan.Click += new System.EventHandler(this.btnMedCan_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Location = new System.Drawing.Point(12, 242);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(94, 56);
            this.btnServicios.TabIndex = 6;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnServiciosAt
            // 
            this.btnServiciosAt.Location = new System.Drawing.Point(261, 242);
            this.btnServiciosAt.Name = "btnServiciosAt";
            this.btnServiciosAt.Size = new System.Drawing.Size(94, 56);
            this.btnServiciosAt.TabIndex = 7;
            this.btnServiciosAt.Text = "Servicios atendidos";
            this.btnServiciosAt.UseVisualStyleBackColor = true;
            this.btnServiciosAt.Click += new System.EventHandler(this.btnServiciosAt_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(494, 242);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 56);
            this.button9.TabIndex = 8;
            this.button9.Text = "Servicios por medico";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnServiciosAt);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.btnMedCan);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCobro);
            this.Controls.Add(this.btnMedEst);
            this.Controls.Add(this.btnEstudios);
            this.Name = "frmRecepcion";
            this.Text = "Recepción";
            this.Load += new System.EventHandler(this.frmRecepcion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstudios;
        private System.Windows.Forms.Button btnMedEst;
        private System.Windows.Forms.Button btnCobro;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnMedCan;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnServiciosAt;
        private System.Windows.Forms.Button button9;
    }
}