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
    public partial class MenuPrincipal_P1 : UserControl,iModulo
    {
        public DelegadoP1 DelP1;
        public MenuPrincipal_P1()
        {
            InitializeComponent();
        }

        private void BtnDonante_Click(object sender, EventArgs e)
        {
            
            
            DelP1(new MenuDonantesP1());
            
            
        }

        public void CargarDelegado()
        {
            //DelP1 = new DelegadoP1();
        }


    }
}
