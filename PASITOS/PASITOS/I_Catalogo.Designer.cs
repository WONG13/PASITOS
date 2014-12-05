namespace PASITOS
{
    partial class I_Catalogo
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
            this.CB_Categoria = new System.Windows.Forms.ComboBox();
            this.DG_Catalog = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Catalog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(657, 23);
            this.label1.Text = "Datos de donativos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_Catalog);
            this.groupBox1.Controls.Add(this.CB_Categoria);
            this.groupBox1.Size = new System.Drawing.Size(657, 341);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(513, 382);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(594, 382);
            // 
            // CB_Categoria
            // 
            this.CB_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Categoria.FormattingEnabled = true;
            this.CB_Categoria.Items.AddRange(new object[] {
            "Beneficiarios",
            "Donantes",
            "Contactos",
            "Donativos\t"});
            this.CB_Categoria.Location = new System.Drawing.Point(27, 19);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(121, 21);
            this.CB_Categoria.TabIndex = 0;
            this.CB_Categoria.SelectedIndexChanged += new System.EventHandler(this.CB_Categoria_SelectedIndexChanged);
            // 
            // DG_Catalog
            // 
            this.DG_Catalog.AllowUserToAddRows = false;
            this.DG_Catalog.AllowUserToDeleteRows = false;
            this.DG_Catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Catalog.Location = new System.Drawing.Point(27, 46);
            this.DG_Catalog.Name = "DG_Catalog";
            this.DG_Catalog.Size = new System.Drawing.Size(599, 225);
            this.DG_Catalog.TabIndex = 1;
            // 
            // I_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 417);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "I_Catalogo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Catalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Categoria;
        private System.Windows.Forms.DataGridView DG_Catalog;
    }
}
