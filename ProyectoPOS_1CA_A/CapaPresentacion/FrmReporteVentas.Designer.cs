namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    partial class FrmReporteVentas
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
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTES";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(487, 181);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFin.TabIndex = 1;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(137, 181);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 26);
            this.dtpInicio.TabIndex = 2;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(37, 181);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(93, 20);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Fecha inicio";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(387, 181);
            this.lblFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(75, 20);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Fecha fin";
            this.lblFin.Click += new System.EventHandler(this.lblFin_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(205, 312);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(185, 35);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "GENERAR PDF";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(452, 312);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(257, 35);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 443);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReporteVentas";
            this.Text = "FrmReporteVentas";
            this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}