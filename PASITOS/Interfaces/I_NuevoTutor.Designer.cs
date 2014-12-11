namespace PASITOS
{
    partial class I_NuevoTutor
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombretut = new System.Windows.Forms.TextBox();
            this.txtDirecciontut = new System.Windows.Forms.TextBox();
            this.txtTelefonotut = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_Parentesco = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.Text = "Capturar datos de Tutor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Parentesco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtTelefonotut);
            this.groupBox1.Controls.Add(this.txtDirecciontut);
            this.groupBox1.Controls.Add(this.txtNombretut);
            this.groupBox1.Location = new System.Drawing.Point(10, 26);
            this.groupBox1.Size = new System.Drawing.Size(254, 182);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(216, 214);
            this.btnAceptar.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(162, 214);
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtNombretut
            // 
            this.txtNombretut.Location = new System.Drawing.Point(88, 22);
            this.txtNombretut.Name = "txtNombretut";
            this.txtNombretut.Size = new System.Drawing.Size(132, 20);
            this.txtNombretut.TabIndex = 0;
            // 
            // txtDirecciontut
            // 
            this.txtDirecciontut.Location = new System.Drawing.Point(88, 48);
            this.txtDirecciontut.Name = "txtDirecciontut";
            this.txtDirecciontut.Size = new System.Drawing.Size(132, 20);
            this.txtDirecciontut.TabIndex = 0;
            // 
            // txtTelefonotut
            // 
            this.txtTelefonotut.Location = new System.Drawing.Point(88, 74);
            this.txtTelefonotut.Name = "txtTelefonotut";
            this.txtTelefonotut.Size = new System.Drawing.Size(132, 20);
            this.txtTelefonotut.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(89, 142);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(131, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de\r\nNacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parentesco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefono";
            // 
            // CB_Parentesco
            // 
            this.CB_Parentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Parentesco.FormattingEnabled = true;
            this.CB_Parentesco.Items.AddRange(new object[] {
            "Padre",
            "Madre",
            "Tio",
            "Tia",
            "Abuelo",
            "Abuela",
            "Hermano",
            "Hermana",
            "Primo",
            "Prima"});
            this.CB_Parentesco.Location = new System.Drawing.Point(89, 100);
            this.CB_Parentesco.Name = "CB_Parentesco";
            this.CB_Parentesco.Size = new System.Drawing.Size(131, 21);
            this.CB_Parentesco.TabIndex = 3;
            // 
            // I_NuevoTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "I_NuevoTutor";
            this.Size = new System.Drawing.Size(276, 293);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDirecciontut;
        public System.Windows.Forms.TextBox txtNombretut;
        public System.Windows.Forms.TextBox txtTelefonotut;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox CB_Parentesco;
    }
}
