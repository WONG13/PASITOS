namespace PASITOS
{
    partial class I_NuevoBeneficiario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.txtNecesidades = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Genero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(424, 23);
            this.label1.Text = "Capturar Datos de Beneficiario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CB_Genero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNecesidades);
            this.groupBox1.Controls.Add(this.txtPadecimiento);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Size = new System.Drawing.Size(424, 239);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(280, 280);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(361, 280);
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Necesidades:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Location = new System.Drawing.Point(134, 100);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(229, 20);
            this.txtPadecimiento.TabIndex = 6;
            // 
            // txtNecesidades
            // 
            this.txtNecesidades.Location = new System.Drawing.Point(134, 123);
            this.txtNecesidades.Multiline = true;
            this.txtNecesidades.Name = "txtNecesidades";
            this.txtNecesidades.Size = new System.Drawing.Size(229, 98);
            this.txtNecesidades.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Genero:";
            // 
            // CB_Genero
            // 
            this.CB_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Genero.FormattingEnabled = true;
            this.CB_Genero.Location = new System.Drawing.Point(134, 76);
            this.CB_Genero.Name = "CB_Genero";
            this.CB_Genero.Size = new System.Drawing.Size(229, 21);
            this.CB_Genero.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Padecimiento:";
            // 
            // ErrorDatos
            // 
            this.ErrorDatos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorDatos.ContainerControl = this;
            // 
            // I_NuevoBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(448, 315);
            this.Name = "I_NuevoBeneficiario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNecesidades;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_Genero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider ErrorDatos;
    }
}
