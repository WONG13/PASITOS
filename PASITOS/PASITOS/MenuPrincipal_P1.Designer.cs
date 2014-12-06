namespace PASITOS
{
    partial class MenuPrincipal_P1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.BtnNinos = new System.Windows.Forms.Button();
            this.BtnDonante = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgenda);
            this.groupBox1.Controls.Add(this.BtnNinos);
            this.groupBox1.Controls.Add(this.BtnDonante);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnAgenda
            // 
            this.btnAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgenda.Location = new System.Drawing.Point(24, 209);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(114, 48);
            this.btnAgenda.TabIndex = 2;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            // 
            // BtnNinos
            // 
            this.BtnNinos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNinos.Location = new System.Drawing.Point(24, 155);
            this.BtnNinos.Name = "BtnNinos";
            this.BtnNinos.Size = new System.Drawing.Size(114, 48);
            this.BtnNinos.TabIndex = 1;
            this.BtnNinos.Text = "Niños";
            this.BtnNinos.UseVisualStyleBackColor = true;
            // 
            // BtnDonante
            // 
            this.BtnDonante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDonante.Location = new System.Drawing.Point(24, 101);
            this.BtnDonante.Name = "BtnDonante";
            this.BtnDonante.Size = new System.Drawing.Size(114, 48);
            this.BtnDonante.TabIndex = 0;
            this.BtnDonante.Text = "Donantes";
            this.BtnDonante.UseVisualStyleBackColor = true;
            this.BtnDonante.Click += new System.EventHandler(this.BtnDonante_Click);
            // 
            // MenuPrincipal_P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuPrincipal_P1";
            this.Size = new System.Drawing.Size(189, 324);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button BtnNinos;
        private System.Windows.Forms.Button BtnDonante;
    }
}
