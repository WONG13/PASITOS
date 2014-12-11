using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PASITOS
{
    public delegate void DelegadoP1(UserControl UC1);
    public delegate void DelegadoP2(UserControl UC2);

    

    public partial class I_FormaPrincipal : Form
    {
        private iModulo ModuloActualP1 { get; set; }
        private iModulo ModuloActualP2 { get; set; }

        public I_FormaPrincipal()
        {
            InitializeComponent();

            
        }
        
        private void I_FormaPrincipal_Load(object sender, EventArgs e)
        {
            AccionesPanel2();        
            AccionesPanel1();           
        }

        private void AccionesPanel1()
        {
            MenuPrincipal_P1 MenuPrincipalP1 = new MenuPrincipal_P1();
            MenuPrincipalP1.DelP1 = new DelegadoP1(MostrarModuloP1);
            MenuPrincipalP1.DelP2 = new DelegadoP2(MostrarModuloP2);
            MostrarModuloP1(MenuPrincipalP1);
        }
        I_MenuPrincipal MenuP2;
        private void AccionesPanel2()
        {
            MenuP2 = new I_MenuPrincipal();
            MenuP2.DelP2 = new DelegadoP2(MostrarModuloP2);
            MostrarModuloP2(MenuP2);
        }
                              
        public void MostrarModuloP1(UserControl NuevoModulo)
        {
            if (ModuloActualP1 != null)
            {
                ((IDisposable)ModuloActualP1).Dispose();
            }
            ModuloActualP1 = (iModulo)NuevoModulo;      
            NuevoModulo.Dock = DockStyle.Fill;
            NuevoModulo.Parent = SC1.Panel1;     
        }

        public void MostrarModuloP2(UserControl NuevoModulo)
        {
            if (ModuloActualP2 != null)
            {
                ((IDisposable)ModuloActualP2).Dispose();
            }
            ModuloActualP2 = (iModulo)NuevoModulo;
            NuevoModulo.Dock = DockStyle.Fill;
            NuevoModulo.Parent = SC1.Panel2;
        }

       

    }
}
