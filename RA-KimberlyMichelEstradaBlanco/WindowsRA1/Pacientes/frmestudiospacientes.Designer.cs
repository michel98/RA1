namespace WindowsRA1.Pacientes
{
    partial class frmestudiospacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmestudiospacientes));
            this.dgvEstudiosDepac = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDelPac = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiosDepac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiosDepac
            // 
            this.dgvEstudiosDepac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiosDepac.Location = new System.Drawing.Point(12, 51);
            this.dgvEstudiosDepac.Name = "dgvEstudiosDepac";
            this.dgvEstudiosDepac.Size = new System.Drawing.Size(379, 150);
            this.dgvEstudiosDepac.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreDelPac
            // 
            this.txtNombreDelPac.Enabled = false;
            this.txtNombreDelPac.Location = new System.Drawing.Point(65, 21);
            this.txtNombreDelPac.Name = "txtNombreDelPac";
            this.txtNombreDelPac.Size = new System.Drawing.Size(88, 20);
            this.txtNombreDelPac.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(265, 21);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(126, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos:";
            // 
            // frmestudiospacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(403, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombreDelPac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstudiosDepac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmestudiospacientes";
            this.Text = "Estudios de los pacientes";
            this.Load += new System.EventHandler(this.frmestudiospacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiosDepac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiosDepac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDelPac;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
    }
}