namespace PASITOS
{
    partial class I_NuevoDonante_Contacto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I_NuevoDonante_Contacto));
            this.label9 = new System.Windows.Forms.Label();
            this.CB_Estatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_TipoDon = new System.Windows.Forms.ComboBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.ErrorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Size = new System.Drawing.Size(530, 25);
            this.label1.Text = "Capturar Datos de Aspirante a Donante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Controls.Add(this.CB_TipoDon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CB_Estatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Size = new System.Drawing.Size(530, 261);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.Location = new System.Drawing.Point(497, 324);
            this.btnAceptar.Size = new System.Drawing.Size(48, 42);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.Location = new System.Drawing.Point(445, 324);
            this.BtnCancelar.Size = new System.Drawing.Size(46, 42);
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "RFC:";
            // 
            // CB_Estatus
            // 
            this.CB_Estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Estatus.FormattingEnabled = true;
            this.CB_Estatus.Location = new System.Drawing.Point(128, 118);
            this.CB_Estatus.Name = "CB_Estatus";
            this.CB_Estatus.Size = new System.Drawing.Size(229, 21);
            this.CB_Estatus.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tipo de Donante:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(128, 145);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(229, 98);
            this.txtInfo.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(128, 66);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Informacion del donante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre del Donante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estatus:";
            // 
            // CB_TipoDon
            // 
            this.CB_TipoDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoDon.FormattingEnabled = true;
            this.CB_TipoDon.Location = new System.Drawing.Point(128, 39);
            this.CB_TipoDon.Name = "CB_TipoDon";
            this.CB_TipoDon.Size = new System.Drawing.Size(229, 21);
            this.CB_TipoDon.TabIndex = 1;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(128, 92);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(229, 20);
            this.txtRFC.TabIndex = 3;
            // 
            // ErrorDatos
            // 
            this.ErrorDatos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorDatos.ContainerControl = this;
            // 
            // I_NuevoDonante_Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "I_NuevoDonante_Contacto";
            this.Size = new System.Drawing.Size(560, 395);
            this.Load += new System.EventHandler(this.I_NuevoDonante_Contacto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.ComboBox CB_TipoDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_Estatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErrorDatos;
    }
}
