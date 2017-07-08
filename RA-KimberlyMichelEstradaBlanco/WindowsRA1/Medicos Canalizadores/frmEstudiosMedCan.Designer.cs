namespace WindowsRA1.Pacientes
{
    partial class frmdatosmedicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreMedCan = new System.Windows.Forms.TextBox();
            this.txtApellidosMedCan = new System.Windows.Forms.TextBox();
            this.dgvEstudiosMedico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiosMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudios solicitados por el médico:";
            // 
            // txtNombreMedCan
            // 
            this.txtNombreMedCan.Location = new System.Drawing.Point(12, 37);
            this.txtNombreMedCan.Name = "txtNombreMedCan";
            this.txtNombreMedCan.Size = new System.Drawing.Size(341, 20);
            this.txtNombreMedCan.TabIndex = 1;
            // 
            // txtApellidosMedCan
            // 
            this.txtApellidosMedCan.Location = new System.Drawing.Point(12, 63);
            this.txtApellidosMedCan.Name = "txtApellidosMedCan";
            this.txtApellidosMedCan.Size = new System.Drawing.Size(341, 20);
            this.txtApellidosMedCan.TabIndex = 2;
            // 
            // dgvEstudiosMedico
            // 
            this.dgvEstudiosMedico.AllowUserToAddRows = false;
            this.dgvEstudiosMedico.AllowUserToDeleteRows = false;
            this.dgvEstudiosMedico.AllowUserToOrderColumns = true;
            this.dgvEstudiosMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiosMedico.Location = new System.Drawing.Point(12, 102);
            this.dgvEstudiosMedico.Name = "dgvEstudiosMedico";
            this.dgvEstudiosMedico.ReadOnly = true;
            this.dgvEstudiosMedico.Size = new System.Drawing.Size(341, 150);
            this.dgvEstudiosMedico.TabIndex = 3;
            // 
            // frmdatosmedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 264);
            this.Controls.Add(this.dgvEstudiosMedico);
            this.Controls.Add(this.txtApellidosMedCan);
            this.Controls.Add(this.txtNombreMedCan);
            this.Controls.Add(this.label1);
            this.Name = "frmdatosmedicos";
            this.Text = "frmdatosmedicos";
            this.Load += new System.EventHandler(this.frmdatosmedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiosMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMedCan;
        private System.Windows.Forms.TextBox txtApellidosMedCan;
        private System.Windows.Forms.DataGridView dgvEstudiosMedico;
    }
}