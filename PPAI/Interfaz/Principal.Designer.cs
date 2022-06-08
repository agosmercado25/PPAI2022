namespace PPAI.Interfaz
{
    partial class Principal
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
            this.btnIngresarMantCorr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarMantCorr
            // 
            this.btnIngresarMantCorr.Location = new System.Drawing.Point(304, 108);
            this.btnIngresarMantCorr.Name = "btnIngresarMantCorr";
            this.btnIngresarMantCorr.Size = new System.Drawing.Size(186, 202);
            this.btnIngresarMantCorr.TabIndex = 0;
            this.btnIngresarMantCorr.Text = "Registrar ingreso de RT en mantenimiento correctivo";
            this.btnIngresarMantCorr.UseVisualStyleBackColor = true;
            this.btnIngresarMantCorr.Click += new System.EventHandler(this.btnprobar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresarMantCorr);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarMantCorr;
    }
}