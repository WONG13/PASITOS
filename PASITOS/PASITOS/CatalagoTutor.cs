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
    public partial class CatalagoTutor : I_Plantilla, iModulo
    {
        public DelegadoP2 DelP2;
        DelegadoCon DelCon;
        AccesoDatos ObjAD = new AccesoDatos();
        public O_Donante donante;
        public int Forma = 0;
        int ID = -1;

        public CatalagoTutor()
        {
            InitializeComponent();
        }

        public void Cargar(int ID)
        {
            dataGridView1.DataSource = ObjAD.ConsultarContatoPorDonanteID(ID);
        }

    }
}
