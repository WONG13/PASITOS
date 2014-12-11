namespace PASITOS
{
    partial class I_Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(I_Agenda));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Donativos = new System.Windows.Forms.CheckBox();
            this.Eventos = new System.Windows.Forms.CheckBox();
            this.Cumpleaños = new System.Windows.Forms.CheckBox();
            this.Informacion = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(21, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(681, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnCrear
            // 
            this.btnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrear.BackgroundImage")));
            this.btnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrear.Location = new System.Drawing.Point(262, 31);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(48, 41);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(262, 78);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(48, 40);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminar.BackgroundImage")));
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.Location = new System.Drawing.Point(262, 124);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(48, 38);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Donativos
            // 
            this.Donativos.AutoSize = true;
            this.Donativos.Location = new System.Drawing.Point(236, 187);
            this.Donativos.Name = "Donativos";
            this.Donativos.Size = new System.Drawing.Size(74, 17);
            this.Donativos.TabIndex = 4;
            this.Donativos.Text = "Donativos";
            this.Donativos.UseVisualStyleBackColor = true;
            // 
            // Eventos
            // 
            this.Eventos.AutoSize = true;
            this.Eventos.Location = new System.Drawing.Point(331, 187);
            this.Eventos.Name = "Eventos";
            this.Eventos.Size = new System.Drawing.Size(65, 17);
            this.Eventos.TabIndex = 5;
            this.Eventos.Text = "Eventos";
            this.Eventos.UseVisualStyleBackColor = true;
            // 
            // Cumpleaños
            // 
            this.Cumpleaños.AutoSize = true;
            this.Cumpleaños.Location = new System.Drawing.Point(417, 187);
            this.Cumpleaños.Name = "Cumpleaños";
            this.Cumpleaños.Size = new System.Drawing.Size(84, 17);
            this.Cumpleaños.TabIndex = 6;
            this.Cumpleaños.Text = "Cumpleaños";
            this.Cumpleaños.UseVisualStyleBackColor = true;
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.dataGridView2);
            this.Informacion.Location = new System.Drawing.Point(340, 31);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(351, 150);
            this.Informacion.TabIndex = 7;
            this.Informacion.TabStop = false;
            this.Informacion.Text = "Donativos del mes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(339, 125);
            this.dataGridView2.TabIndex = 0;
            // 
            // I_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.Cumpleaños);
            this.Controls.Add(this.Eventos);
            this.Controls.Add(this.Donativos);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "I_Agenda";
            this.Size = new System.Drawing.Size(723, 462);
            this.Load += new System.EventHandler(this.I_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Informacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.CheckBox Donativos;
        private System.Windows.Forms.CheckBox Eventos;
        private System.Windows.Forms.CheckBox Cumpleaños;
        private System.Windows.Forms.GroupBox Informacion;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
