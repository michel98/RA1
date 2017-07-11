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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiosRF01));
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
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblEstudio
            // 
            resources.ApplyResources(this.lblEstudio, "lblEstudio");
            this.lblEstudio.Name = "lblEstudio";
            // 
            // dgvEstudios
            // 
            resources.ApplyResources(this.dgvEstudios, "dgvEstudios");
            this.dgvEstudios.AllowUserToAddRows = false;
            this.dgvEstudios.AllowUserToDeleteRows = false;
            this.dgvEstudios.AllowUserToOrderColumns = true;
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtIdEstudio
            // 
            resources.ApplyResources(this.txtIdEstudio, "txtIdEstudio");
            this.txtIdEstudio.Name = "txtIdEstudio";
            // 
            // btnVisualizarEstudios
            // 
            resources.ApplyResources(this.btnVisualizarEstudios, "btnVisualizarEstudios");
            this.btnVisualizarEstudios.Name = "btnVisualizarEstudios";
            this.btnVisualizarEstudios.UseVisualStyleBackColor = true;
            this.btnVisualizarEstudios.Click += new System.EventHandler(this.btnVisualizarEstudios_Click);
            // 
            // frmEstudiosRF01
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.btnVisualizarEstudios);
            this.Controls.Add(this.txtIdEstudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstudios);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmEstudiosRF01";
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