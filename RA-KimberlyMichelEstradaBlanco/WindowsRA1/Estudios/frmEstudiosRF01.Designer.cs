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
            this.cboEstudios = new System.Windows.Forms.ComboBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(76, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar nuevo estudio";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(296, 138);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboEstudios
            // 
            this.cboEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstudios.FormattingEnabled = true;
            this.cboEstudios.Location = new System.Drawing.Point(76, 51);
            this.cboEstudios.Name = "cboEstudios";
            this.cboEstudios.Size = new System.Drawing.Size(352, 21);
            this.cboEstudios.TabIndex = 2;
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
            // frmEstudiosRF01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 200);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.cboEstudios);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmEstudiosRF01";
            this.Text = "Gestión de estudios";
            this.Load += new System.EventHandler(this.frmEstudiosRF01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboEstudios;
        private System.Windows.Forms.Label lblEstudio;
    }
}