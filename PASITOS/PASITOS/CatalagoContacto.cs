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
    public partial class CatalagoContacto : PASITOS.I_Plantilla, iModulo
    {
        AccesoDatos ObjAD = new AccesoDatos();
        public O_Donante donante;
        public CatalagoContacto()
        {
            InitializeComponent();
        }

        public void Cargar(int ID)
        {
            dataGridView1.DataSource=ObjAD.ConsultarContatoPorDonanteID(ID);
        }
    }
}
