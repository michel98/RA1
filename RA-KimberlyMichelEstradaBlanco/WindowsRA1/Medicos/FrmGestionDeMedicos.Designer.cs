﻿namespace WindowsRA1.Medicos
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
            this.dgvMedicosEstudios = new System.Windows.Forms.DataGridView();
            this.btnVisualizarMed = new System.Windows.Forms.Button();
            this.btnRegistrarMed = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicosEstudios
            // 
            this.dgvMedicosEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosEstudios.Location = new System.Drawing.Point(10, 78);
            this.dgvMedicosEstudios.Name = "dgvMedicosEstudios";
            this.dgvMedicosEstudios.Size = new System.Drawing.Size(386, 159);
            this.dgvMedicosEstudios.TabIndex = 0;
            // 
            // btnVisualizarMed
            // 
            this.btnVisualizarMed.Location = new System.Drawing.Point(12, 31);
            this.btnVisualizarMed.Name = "btnVisualizarMed";
            this.btnVisualizarMed.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarMed.TabIndex = 1;
            this.btnVisualizarMed.Text = "Visualizar";
            this.btnVisualizarMed.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMed
            // 
            this.btnRegistrarMed.Location = new System.Drawing.Point(125, 31);
            this.btnRegistrarMed.Name = "btnRegistrarMed";
            this.btnRegistrarMed.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarMed.TabIndex = 2;
            this.btnRegistrarMed.Text = "Registrar";
            this.btnRegistrarMed.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(321, 33);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtIdMod
            // 
            this.txtIdMod.Location = new System.Drawing.Point(259, 35);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(46, 20);
            this.txtIdMod.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(256, 18);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(72, 13);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID del medico";
            // 
            // FrmGestionDeMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 258);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtIdMod);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrarMed);
            this.Controls.Add(this.btnVisualizarMed);
            this.Controls.Add(this.dgvMedicosEstudios);
            this.Name = "FrmGestionDeMedicos";
            this.Text = "Gestión de Médicos del centro de estudios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicosEstudios;
        private System.Windows.Forms.Button btnVisualizarMed;
        private System.Windows.Forms.Button btnRegistrarMed;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.Label ID;
    }
}