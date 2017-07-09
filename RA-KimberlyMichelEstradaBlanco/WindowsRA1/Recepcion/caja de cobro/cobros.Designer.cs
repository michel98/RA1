namespace WindowsRA1.Recepcion.caja_de_cobro
{
    partial class frmCobros
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
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDServPagar = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Location = new System.Drawing.Point(12, 63);
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.Size = new System.Drawing.Size(521, 157);
            this.dgvDeudas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicios aún no pagados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID del servicio:";
            // 
            // txtIDServPagar
            // 
            this.txtIDServPagar.Location = new System.Drawing.Point(391, 23);
            this.txtIDServPagar.Name = "txtIDServPagar";
            this.txtIDServPagar.Size = new System.Drawing.Size(81, 20);
            this.txtIDServPagar.TabIndex = 3;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(478, 21);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(55, 23);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // frmCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 240);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.txtIDServPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDeudas);
            this.Name = "frmCobros";
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.frmCobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeudas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDServPagar;
        private System.Windows.Forms.Button btnCobrar;
    }
}