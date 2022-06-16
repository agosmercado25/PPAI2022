namespace PPAI.Interfaz
{
    partial class RegistrarIngresoRTMantenimientoCorrectivo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grillaRTDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaFinPrevista = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxFin = new System.Windows.Forms.GroupBox();
            this.btnFechaRazon = new System.Windows.Forms.Button();
            this.NumeroRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRTDisponibles)).BeginInit();
            this.groupBoxFin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.grillaRTDisponibles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 275);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos Tecnológicos";
            // 
            // grillaRTDisponibles
            // 
            this.grillaRTDisponibles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grillaRTDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRTDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroRT,
            this.FechaAlta,
            this.Imagenes,
            this.Periodicidad,
            this.Fraccion,
            this.Duracion,
            this.TipoRecurso,
            this.Modelo});
            this.grillaRTDisponibles.Location = new System.Drawing.Point(12, 82);
            this.grillaRTDisponibles.Name = "grillaRTDisponibles";
            this.grillaRTDisponibles.Size = new System.Drawing.Size(774, 178);
            this.grillaRTDisponibles.TabIndex = 2;
            this.grillaRTDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaRTDisponibles_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recursos disponibles:";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(225, 64);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(561, 30);
            this.txtRazon.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Razón de mantenimiento";
            // 
            // txtFechaFinPrevista
            // 
            this.txtFechaFinPrevista.Location = new System.Drawing.Point(168, 19);
            this.txtFechaFinPrevista.Mask = "00/00/0000";
            this.txtFechaFinPrevista.Name = "txtFechaFinPrevista";
            this.txtFechaFinPrevista.Size = new System.Drawing.Size(116, 30);
            this.txtFechaFinPrevista.TabIndex = 18;
            this.txtFechaFinPrevista.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha fin prevista";
            this.label2.UseMnemonic = false;
            // 
            // groupBoxFin
            // 
            this.groupBoxFin.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxFin.Controls.Add(this.btnFechaRazon);
            this.groupBoxFin.Controls.Add(this.txtRazon);
            this.groupBoxFin.Controls.Add(this.label2);
            this.groupBoxFin.Controls.Add(this.label3);
            this.groupBoxFin.Controls.Add(this.txtFechaFinPrevista);
            this.groupBoxFin.Enabled = false;
            this.groupBoxFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFin.Location = new System.Drawing.Point(12, 293);
            this.groupBoxFin.Name = "groupBoxFin";
            this.groupBoxFin.Size = new System.Drawing.Size(804, 156);
            this.groupBoxFin.TabIndex = 21;
            this.groupBoxFin.TabStop = false;
            // 
            // btnFechaRazon
            // 
            this.btnFechaRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaRazon.Location = new System.Drawing.Point(666, 118);
            this.btnFechaRazon.Name = "btnFechaRazon";
            this.btnFechaRazon.Size = new System.Drawing.Size(120, 32);
            this.btnFechaRazon.TabIndex = 21;
            this.btnFechaRazon.Text = "Ingresar Datos";
            this.btnFechaRazon.UseVisualStyleBackColor = true;
            this.btnFechaRazon.Click += new System.EventHandler(this.btnFechaRazon_Click);
            // 
            // NumeroRT
            // 
            this.NumeroRT.DataPropertyName = "NumeroRT";
            this.NumeroRT.HeaderText = "NumeroRT";
            this.NumeroRT.Name = "NumeroRT";
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "FechaAlta";
            this.FechaAlta.HeaderText = "FechaAlta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.Visible = false;
            // 
            // Imagenes
            // 
            this.Imagenes.DataPropertyName = "Imagenes";
            this.Imagenes.HeaderText = "Imagenes";
            this.Imagenes.Name = "Imagenes";
            this.Imagenes.Visible = false;
            // 
            // Periodicidad
            // 
            this.Periodicidad.DataPropertyName = "Periodicidad";
            this.Periodicidad.HeaderText = "Periodicidad";
            this.Periodicidad.Name = "Periodicidad";
            this.Periodicidad.Visible = false;
            // 
            // Fraccion
            // 
            this.Fraccion.DataPropertyName = "FraccionHorarioTurno";
            this.Fraccion.HeaderText = "Fraccion";
            this.Fraccion.Name = "Fraccion";
            this.Fraccion.Visible = false;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "Duracion";
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.Visible = false;
            // 
            // TipoRecurso
            // 
            this.TipoRecurso.DataPropertyName = "TipoRecurso";
            this.TipoRecurso.HeaderText = "Tipo Recurso";
            this.TipoRecurso.Name = "TipoRecurso";
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // RegistrarIngresoRTMantenimientoCorrectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(832, 464);
            this.Controls.Add(this.groupBoxFin);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarIngresoRTMantenimientoCorrectivo";
            this.Text = "Ingreso a Mantenimiento Correctivo";
            this.Load += new System.EventHandler(this.RegistrarIngresoRTMantenimientoCorrectivo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRTDisponibles)).EndInit();
            this.groupBoxFin.ResumeLayout(false);
            this.groupBoxFin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaRTDisponibles;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtFechaFinPrevista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxFin;
        private System.Windows.Forms.Button btnFechaRazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
    }
}