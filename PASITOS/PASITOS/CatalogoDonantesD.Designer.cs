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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoDonantesD));
            this.DG_Catalog = new System.Windows.Forms.DataGridView();
            this.BtnNuevoContacto = new System.Windows.Forms.Button();
            this.catalagoContacto1 = new PASITOS.CatalagoContacto();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Catalog)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Size = new System.Drawing.Size(652, 20);
            this.label1.Text = "Donantes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.catalagoContacto1);
            this.groupBox1.Controls.Add(this.DG_Catalog);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Size = new System.Drawing.Size(652, 364);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(438, 490);
            this.btnAceptar.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.Location = new System.Drawing.Point(619, 441);
            this.BtnCancelar.Size = new System.Drawing.Size(48, 41);
            this.BtnCancelar.Text = "";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DG_Catalog
            // 
            this.DG_Catalog.AllowUserToAddRows = false;
            this.DG_Catalog.AllowUserToDeleteRows = false;
            this.DG_Catalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Catalog.Location = new System.Drawing.Point(24, 20);
            this.DG_Catalog.Name = "DG_Catalog";
            this.DG_Catalog.ReadOnly = true;
            this.DG_Catalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Catalog.Size = new System.Drawing.Size(607, 185);
            this.DG_Catalog.TabIndex = 1;
            this.DG_Catalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Catalog_CellClick);
            this.DG_Catalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Catalog_CellContentClick);
            // 
            // BtnNuevoContacto
            // 
            this.BtnNuevoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevoContacto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevoContacto.BackgroundImage")));
            this.BtnNuevoContacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevoContacto.Location = new System.Drawing.Point(21, 25);
            this.BtnNuevoContacto.Name = "BtnNuevoContacto";
            this.BtnNuevoContacto.Size = new System.Drawing.Size(48, 41);
            this.BtnNuevoContacto.TabIndex = 5;
            this.BtnNuevoContacto.UseVisualStyleBackColor = true;
            this.BtnNuevoContacto.Click += new System.EventHandler(this.BtnNuevoContacto_Click);
            // 
            // catalagoContacto1
            // 
            this.catalagoContacto1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.catalagoContacto1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.catalagoContacto1.Location = new System.Drawing.Point(6, 211);
            this.catalagoContacto1.Name = "catalagoContacto1";
            this.catalagoContacto1.Size = new System.Drawing.Size(641, 147);
            this.catalagoContacto1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.BtnEliminar);
            this.groupBox2.Controls.Add(this.BtnActualizar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 76);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donante";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Location = new System.Drawing.Point(64, 25);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(48, 41);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.BackgroundImage")));
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnActualizar.Location = new System.Drawing.Point(10, 25);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(48, 41);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.BtnNuevoContacto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(145, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 76);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(129, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 41);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(75, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 41);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatalogoDonantesD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "CatalogoDonantesD";
            this.Size = new System.Drawing.Size(682, 551);
            this.Load += new System.EventHandler(this.CatalogoDonantesD_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Catalog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Catalog;
        private System.Windows.Forms.Button BtnNuevoContacto;
        private CatalagoContacto catalagoContacto1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
