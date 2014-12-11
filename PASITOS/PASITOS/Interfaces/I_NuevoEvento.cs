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
    public partial class I_NuevoEvento : I_Plantilla, iModulo
    {
        AccesoDatos Obj_AD = new AccesoDatos();
        DataTable tabla;
        public I_NuevoEvento()
        {
            InitializeComponent();
        }

        public void Cargar(int ID_Evento)
        {
            tabla = Obj_AD.ConsultarEvento(ID_Evento);
            DataRow fila=tabla.Rows[0];
            txtNombre.Text = fila.Field<string>("Nombre_Evento");
            txtDireccion.Text = fila.Field<string>("Direccion");
            cbboxTipo.Text= fila.Field<string>("Tipo_Evento");
            txtInfo.Text = fila.Field<string>("Info_Evento");
            dtpFecha.Value= fila.Field<DateTime>("Fecha_Evento");
            cbboxEstado.Text = fila.Field<string>("Estado_Evento");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                O_Evento E = new O_Evento();
                E.Nombre_Evento = txtNombre.Text;
                E.Tipo_Evento = cbboxTipo.Text;
                E.Info_Evento = txtInfo.Text;
                E.Fecha_Evento = dtpFecha.Value;
                E.Direccion = txtDireccion.Text;
                E.Estado_Evento = cbboxEstado.Text;
                if (tabla == null)
                {
                    if (Obj_AD.NuevoEvento(E))
                        MessageBox.Show("Evento Guardado Exitosamente");
                }
                else
                {
                    E.ID_Evento = tabla.Rows[0].Field<int>("ID_Evento");
                    if (Obj_AD.UpdateEvento(E))
                        MessageBox.Show("Evento Guardado Exitosamente");
                }
            }
        }

        public bool validar()
        {
             //Hacer cosas aqui 
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
        }
        
    }
}
