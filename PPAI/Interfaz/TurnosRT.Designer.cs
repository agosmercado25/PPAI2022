namespace PPAI.Interfaz
{
    partial class TurnosRT
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
            this.grupoTurnos = new System.Windows.Forms.GroupBox();
            this.grillaTurnos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grupoTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoTurnos
            // 
            this.grupoTurnos.BackColor = System.Drawing.SystemColors.Control;
            this.grupoTurnos.Controls.Add(this.btnConfirmar);
            this.grupoTurnos.Controls.Add(this.grillaTurnos);
            this.grupoTurnos.Controls.Add(this.label4);
            this.grupoTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoTurnos.Location = new System.Drawing.Point(12, 12);
            this.grupoTurnos.Name = "grupoTurnos";
            this.grupoTurnos.Size = new System.Drawing.Size(408, 336);
            this.grupoTurnos.TabIndex = 23;
            this.grupoTurnos.TabStop = false;
            this.grupoTurnos.Text = "Turnos";
            // 
            // grillaTurnos
            // 
            this.grillaTurnos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grillaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTurnos.Location = new System.Drawing.Point(12, 82);
            this.grillaTurnos.Name = "grillaTurnos";
            this.grillaTurnos.Size = new System.Drawing.Size(368, 178);
            this.grillaTurnos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Turnos RT";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(260, 289);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 32);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TurnosRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 372);
            this.Controls.Add(this.grupoTurnos);
            this.Name = "TurnosRT";
            this.Text = "TurnosRT";
            this.Load += new System.EventHandler(this.TurnosRT_Load);
            this.grupoTurnos.ResumeLayout(false);
            this.grupoTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoTurnos;
        private System.Windows.Forms.DataGridView grillaTurnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
    }
}