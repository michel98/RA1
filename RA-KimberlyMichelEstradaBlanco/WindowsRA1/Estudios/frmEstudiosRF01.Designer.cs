namespace WindowsRA1
{
    partial class frmEstudiosRF01
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.dgvEstudios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEstudio = new System.Windows.Forms.TextBox();
            this.btnVisualizarEstudios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(76, 192);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar nuevo estudio";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(277, 237);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Location = new System.Drawing.Point(73, 35);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(45, 13);
            this.lblEstudio.TabIndex = 3;
            this.lblEstudio.Text = "Estudio:";
            // 
            // dgvEstudios
            // 
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudios.Location = new System.Drawing.Point(77, 77);
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.Size = new System.Drawing.Size(352, 109);
            this.dgvEstudios.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Estudio";
            // 
            // txtIdEstudio
            // 
            this.txtIdEstudio.Location = new System.Drawing.Point(334, 211);
            this.txtIdEstudio.Name = "txtIdEstudio";
            this.txtIdEstudio.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstudio.TabIndex = 6;
            // 
            // btnVisualizarEstudios
            // 
            this.btnVisualizarEstudios.Location = new System.Drawing.Point(76, 51);
            this.btnVisualizarEstudios.Name = "btnVisualizarEstudios";
            this.btnVisualizarEstudios.Size = new System.Drawing.Size(107, 23);
            this.btnVisualizarEstudios.TabIndex = 7;
            this.btnVisualizarEstudios.Text = "Visualizar estudios";
            this.btnVisualizarEstudios.UseVisualStyleBackColor = true;
            this.btnVisualizarEstudios.Click += new System.EventHandler(this.btnVisualizarEstudios_Click);
            // 
            // frmEstudiosRF01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 272);
            this.Controls.Add(this.btnVisualizarEstudios);
            this.Controls.Add(this.txtIdEstudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstudios);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmEstudiosRF01";
            this.Text = "Gestión de estudios";
            this.Load += new System.EventHandler(this.frmEstudiosRF01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEstudio;
        public System.Windows.Forms.DataGridView dgvEstudios;
        private System.Windows.Forms.Button btnVisualizarEstudios;
    }
}