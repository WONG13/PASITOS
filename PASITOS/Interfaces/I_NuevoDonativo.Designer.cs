namespace PASITOS
{
    partial class I_NuevoDonativo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_Donante = new System.Windows.Forms.ComboBox();
            this.CB_TipoDon = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPerio = new System.Windows.Forms.TextBox();
            this.txtCantDon = new System.Windows.Forms.TextBox();
            this.txtFormPag = new System.Windows.Forms.TextBox();
            this.txtUsoDon = new System.Windows.Forms.TextBox();
            this.txtEstadoDon = new System.Windows.Forms.TextBox();
            this.CB_Beneficiario = new System.Windows.Forms.ComboBox();
            this.ErrorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(582, 23);
            this.label1.Text = "Datos de Donativo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_Beneficiario);
            this.groupBox1.Controls.Add(this.txtEstadoDon);
            this.groupBox1.Controls.Add(this.txtUsoDon);
            this.groupBox1.Controls.Add(this.txtFormPag);
            this.groupBox1.Controls.Add(this.txtCantDon);
            this.groupBox1.Controls.Add(this.txtPerio);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CB_TipoDon);
            this.groupBox1.Controls.Add(this.CB_Donante);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Size = new System.Drawing.Size(582, 335);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(438, 376);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(519, 376);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del Donante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Donativo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(17, 104);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(68, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Periodicidad:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(17, 127);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(113, 26);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Cantidad de Donacion\r\n(Si es Monetario)";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 156);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Forma de Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Beneficiario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Uso del Donativo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Estado:";
            // 
            // CB_Donante
            // 
            this.CB_Donante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Donante.FormattingEnabled = true;
            this.CB_Donante.Location = new System.Drawing.Point(147, 22);
            this.CB_Donante.Name = "CB_Donante";
            this.CB_Donante.Size = new System.Drawing.Size(182, 21);
            this.CB_Donante.TabIndex = 9;
            // 
            // CB_TipoDon
            // 
            this.CB_TipoDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoDon.FormattingEnabled = true;
            this.CB_TipoDon.Location = new System.Drawing.Point(147, 49);
            this.CB_TipoDon.Name = "CB_TipoDon";
            this.CB_TipoDon.Size = new System.Drawing.Size(182, 21);
            this.CB_TipoDon.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtPerio
            // 
            this.txtPerio.Location = new System.Drawing.Point(147, 101);
            this.txtPerio.Name = "txtPerio";
            this.txtPerio.Size = new System.Drawing.Size(182, 20);
            this.txtPerio.TabIndex = 12;
            // 
            // txtCantDon
            // 
            this.txtCantDon.Location = new System.Drawing.Point(147, 127);
            this.txtCantDon.Name = "txtCantDon";
            this.txtCantDon.Size = new System.Drawing.Size(182, 20);
            this.txtCantDon.TabIndex = 13;
            // 
            // txtFormPag
            // 
            this.txtFormPag.Location = new System.Drawing.Point(147, 153);
            this.txtFormPag.Name = "txtFormPag";
            this.txtFormPag.Size = new System.Drawing.Size(182, 20);
            this.txtFormPag.TabIndex = 14;
            // 
            // txtUsoDon
            // 
            this.txtUsoDon.Location = new System.Drawing.Point(147, 231);
            this.txtUsoDon.Multiline = true;
            this.txtUsoDon.Name = "txtUsoDon";
            this.txtUsoDon.Size = new System.Drawing.Size(182, 71);
            this.txtUsoDon.TabIndex = 16;
            // 
            // txtEstadoDon
            // 
            this.txtEstadoDon.Location = new System.Drawing.Point(147, 205);
            this.txtEstadoDon.Name = "txtEstadoDon";
            this.txtEstadoDon.Size = new System.Drawing.Size(182, 20);
            this.txtEstadoDon.TabIndex = 17;
            // 
            // CB_Beneficiario
            // 
            this.CB_Beneficiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Beneficiario.FormattingEnabled = true;
            this.CB_Beneficiario.Location = new System.Drawing.Point(147, 178);
            this.CB_Beneficiario.Name = "CB_Beneficiario";
            this.CB_Beneficiario.Size = new System.Drawing.Size(182, 21);
            this.CB_Beneficiario.TabIndex = 18;
            // 
            // ErrorDatos
            // 
            this.ErrorDatos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorDatos.ContainerControl = this;
            // 
            // I_NuevoDonativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(606, 411);
            this.Name = "I_NuevoDonativo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CB_TipoDon;
        private System.Windows.Forms.ComboBox CB_Donante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstadoDon;
        private System.Windows.Forms.TextBox txtUsoDon;
        private System.Windows.Forms.TextBox txtFormPag;
        private System.Windows.Forms.TextBox txtCantDon;
        private System.Windows.Forms.TextBox txtPerio;
        private System.Windows.Forms.ComboBox CB_Beneficiario;
        private System.Windows.Forms.ErrorProvider ErrorDatos;
    }
}
