namespace PASITOS
{
    partial class I_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I_MenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDonaciones = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnDonaciones
            // 
            this.BtnDonaciones.Location = new System.Drawing.Point(473, 228);
            this.BtnDonaciones.Name = "BtnDonaciones";
            this.BtnDonaciones.Size = new System.Drawing.Size(75, 23);
            this.BtnDonaciones.TabIndex = 1;
            this.BtnDonaciones.Text = "Donaciones";
            this.BtnDonaciones.UseVisualStyleBackColor = true;
            this.BtnDonaciones.Click += new System.EventHandler(this.BtnDonaciones_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(473, 257);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // I_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(579, 333);
            this.ControlBox = false;
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.BtnDonaciones);
            this.Controls.Add(this.pictureBox1);
            this.Name = "I_MenuPrincipal";
            this.Load += new System.EventHandler(this.I_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDonaciones;
        private System.Windows.Forms.Button btnReportes;
    }
}