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
    public partial class I_NuevoTutor : I_Plantilla, iModulo
    {
        public DelegadoP2 DelP2;
        int ID=-1;
        int Forma;
        int Accion;
        public I_NuevoTutor(int ID, int Forma,int Accion )
        {
            InitializeComponent();
            this.ID = ID;
            this.Forma = Forma;
            this.Accion=Accion;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
