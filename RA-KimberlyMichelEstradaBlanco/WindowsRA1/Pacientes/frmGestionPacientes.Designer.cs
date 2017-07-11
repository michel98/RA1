namespace WindowsRA1.Pacientes
{
    partial class frmGestionPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPacientes));
            this.dgvpacientes = new System.Windows.Forms.DataGridView();
            this.btnvisualizar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtVerEstudios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbresid = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbestudios = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpacientes
            // 
            this.dgvpacientes.AllowUserToAddRows = false;
            this.dgvpacientes.AllowUserToDeleteRows = false;
            this.dgvpacientes.AllowUserToOrderColumns = true;
            this.dgvpacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpacientes.Location = new System.Drawing.Point(25, 123);
            this.dgvpacientes.Name = "dgvpacientes";
            this.dgvpacientes.ReadOnly = true;
            this.dgvpacientes.Size = new System.Drawing.Size(490, 185);
            this.dgvpacientes.TabIndex = 0;
            // 
            // btnvisualizar
            // 
            this.btnvisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisualizar.Location = new System.Drawing.Point(48, 26);
            this.btnvisualizar.Name = "btnvisualizar";
            this.btnvisualizar.Size = new System.Drawing.Size(131, 23);
            this.btnvisualizar.TabIndex = 1;
            this.btnvisualizar.Text = "Visualizar Pacientes";
            this.btnvisualizar.UseVisualStyleBackColor = true;
            this.btnvisualizar.Click += new System.EventHandler(this.btnvisualizar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(329, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(174, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Ver estudios del paciente";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtVerEstudios
            // 
            this.txtVerEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerEstudios.Location = new System.Drawing.Point(282, 28);
            this.txtVerEstudios.Name = "txtVerEstudios";
            this.txtVerEstudios.Size = new System.Drawing.Size(41, 20);
            this.txtVerEstudios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el ID del paciente";
            // 
            // rdbresid
            // 
            this.rdbresid.AutoSize = true;
            this.rdbresid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbresid.Location = new System.Drawing.Point(178, 66);
            this.rdbresid.Name = "rdbresid";
            this.rdbresid.Size = new System.Drawing.Size(137, 17);
            this.rdbresid.TabIndex = 5;
            this.rdbresid.TabStop = true;
            this.rdbresid.Text = "Lugar de residencia";
            this.rdbresid.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por:";
            // 
            // rdbestudios
            // 
            this.rdbestudios.AutoSize = true;
            this.rdbestudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbestudios.Location = new System.Drawing.Point(178, 89);
            this.rdbestudios.Name = "rdbestudios";
            this.rdbestudios.Size = new System.Drawing.Size(188, 17);
            this.rdbestudios.TabIndex = 7;
            this.rdbestudios.TabStop = true;
            this.rdbestudios.Text = "Fecha de ultimo(s) estudio(s)";
            this.rdbestudios.UseVisualStyleBackColor = true;
            // 
            // frmGestionPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(538, 349);
            this.Controls.Add(this.rdbestudios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbresid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVerEstudios);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnvisualizar);
            this.Controls.Add(this.dgvpacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de pacientes";
            this.Load += new System.EventHandler(this.frmGestionPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpacientes;
        private System.Windows.Forms.Button btnvisualizar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtVerEstudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbresid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbestudios;
    }
}