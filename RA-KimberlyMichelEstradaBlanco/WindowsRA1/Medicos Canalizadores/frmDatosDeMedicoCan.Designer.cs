﻿namespace WindowsRA1.Medicos_Canalizadores
{
    partial class frmDatosDeMedicoCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosDeMedicoCan));
            this.dgvMedicosCan = new System.Windows.Forms.DataGridView();
            this.btnVisMedCan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMedCanBuscar = new System.Windows.Forms.TextBox();
            this.btnVerEstudios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosCan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicosCan
            // 
            this.dgvMedicosCan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicosCan.Location = new System.Drawing.Point(12, 67);
            this.dgvMedicosCan.Name = "dgvMedicosCan";
            this.dgvMedicosCan.Size = new System.Drawing.Size(461, 182);
            this.dgvMedicosCan.TabIndex = 0;
            // 
            // btnVisMedCan
            // 
            this.btnVisMedCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisMedCan.Location = new System.Drawing.Point(12, 29);
            this.btnVisMedCan.Name = "btnVisMedCan";
            this.btnVisMedCan.Size = new System.Drawing.Size(200, 23);
            this.btnVisMedCan.TabIndex = 1;
            this.btnVisMedCan.Text = "Visualizar Médicos canalizadores";
            this.btnVisMedCan.UseVisualStyleBackColor = true;
            this.btnVisMedCan.Click += new System.EventHandler(this.btnVisMedCan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Médico";
            // 
            // txtIDMedCanBuscar
            // 
            this.txtIDMedCanBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMedCanBuscar.Location = new System.Drawing.Point(258, 31);
            this.txtIDMedCanBuscar.Name = "txtIDMedCanBuscar";
            this.txtIDMedCanBuscar.Size = new System.Drawing.Size(56, 21);
            this.txtIDMedCanBuscar.TabIndex = 3;
            // 
            // btnVerEstudios
            // 
            this.btnVerEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstudios.Location = new System.Drawing.Point(320, 29);
            this.btnVerEstudios.Name = "btnVerEstudios";
            this.btnVerEstudios.Size = new System.Drawing.Size(153, 23);
            this.btnVerEstudios.TabIndex = 4;
            this.btnVerEstudios.Text = "Ver estudios solicitados";
            this.btnVerEstudios.UseVisualStyleBackColor = true;
            this.btnVerEstudios.Click += new System.EventHandler(this.btnVerEstudios_Click);
            // 
            // frmDatosDeMedicoCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(485, 261);
            this.Controls.Add(this.btnVerEstudios);
            this.Controls.Add(this.txtIDMedCanBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisMedCan);
            this.Controls.Add(this.dgvMedicosCan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosDeMedicoCan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médicos Canalizadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicosCan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicosCan;
        private System.Windows.Forms.Button btnVisMedCan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMedCanBuscar;
        private System.Windows.Forms.Button btnVerEstudios;
    }
}