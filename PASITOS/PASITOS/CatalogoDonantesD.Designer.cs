namespace PASITOS
{
    partial class CatalogoDonantesD
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
            this.DG_Catalog = new System.Windows.Forms.DataGridView();
            this.BtnNuevoContacto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Catalog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Size = new System.Drawing.Size(620, 20);
            this.label1.Text = "Donantes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_Catalog);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Size = new System.Drawing.Size(620, 255);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(477, 308);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(558, 308);
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DG_Catalog
            // 
            this.DG_Catalog.AllowUserToAddRows = false;
            this.DG_Catalog.AllowUserToDeleteRows = false;
            this.DG_Catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Catalog.Location = new System.Drawing.Point(6, 20);
            this.DG_Catalog.Name = "DG_Catalog";
            this.DG_Catalog.ReadOnly = true;
            this.DG_Catalog.Size = new System.Drawing.Size(600, 230);
            this.DG_Catalog.TabIndex = 1;
            this.DG_Catalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Catalog_CellContentClick);
            // 
            // BtnNuevoContacto
            // 
            this.BtnNuevoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevoContacto.Location = new System.Drawing.Point(21, 308);
            this.BtnNuevoContacto.Name = "BtnNuevoContacto";
            this.BtnNuevoContacto.Size = new System.Drawing.Size(96, 23);
            this.BtnNuevoContacto.TabIndex = 5;
            this.BtnNuevoContacto.Text = "NuevoContacto";
            this.BtnNuevoContacto.UseVisualStyleBackColor = true;
            this.BtnNuevoContacto.Click += new System.EventHandler(this.BtnNuevoContacto_Click);
            // 
            // CatalogoDonantesD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.BtnNuevoContacto);
            this.Name = "CatalogoDonantesD";
            this.Size = new System.Drawing.Size(650, 340);
            this.Load += new System.EventHandler(this.CatalogoDonantesD_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BtnNuevoContacto, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Catalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Catalog;
        private System.Windows.Forms.Button BtnNuevoContacto;
    }
}
