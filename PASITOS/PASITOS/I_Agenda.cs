using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PASITOS
{
    public partial class I_Agenda : UserControl, iModulo
    {
        AccesoDatos Obj_AD = new AccesoDatos();
        int ID_Evento;
        DateTime start, end;
        public I_Agenda()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataGridView1.DataSource = Obj_AD.ConsultarEventos(e.Start, e.End);
            start = e.Start; end = e.End;
        }

        private void I_Agenda_Load(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Today;
            dataGridView1.DataSource = Obj_AD.ConsultarEventos(d1,d1.AddDays(1));            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            I_NuevoEvento NV=new I_NuevoEvento();
            Form F = new Form();
            F.Controls.Add(NV);
            F.Size = NV.Size;
            F.ShowDialog();
            dataGridView1.DataSource = Obj_AD.ConsultarEventos(start, end);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ID_Evento > 0)
            {
                I_NuevoEvento NV = new I_NuevoEvento();
                NV.Cargar(ID_Evento);
                Form F = new Form();
                F.Controls.Add(NV);
                F.Size = NV.Size;
                F.ShowDialog();
                dataGridView1.DataSource = Obj_AD.ConsultarEventos(start, end);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ID_Evento=((DataTable)dataGridView1.DataSource).Rows[e.RowIndex].Field<int>("ID_Evento");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Obj_AD.DeleteEvento(ID_Evento))
            {
                MessageBox.Show("Evento Eleminado");
            }
            dataGridView1.DataSource = Obj_AD.ConsultarEventos(start, end);
        }
    }
}
