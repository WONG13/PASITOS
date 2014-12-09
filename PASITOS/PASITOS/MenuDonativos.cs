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
    public partial class MenuDonativos : UserControl, iModulo
    {
        public DelegadoP1 DelP1;
        public DelegadoP2 DelP2;
        public MenuDonativos()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal_P1 MP = new MenuPrincipal_P1();
            MP.DelP1 = DelP1;
            MP.DelP2 = DelP2;
            DelP1(MP);
        }

        private void BtnDonativo_Click(object sender, EventArgs e)
        {
            I_NuevoDonativo ND = new I_NuevoDonativo();
            DelP2(ND);
        }

        private void BtnConsultaDonativo_Click(object sender, EventArgs e)
        {
            I_Catalogo CD = new I_Catalogo();
            DelP2(CD);
        }

    }
}
