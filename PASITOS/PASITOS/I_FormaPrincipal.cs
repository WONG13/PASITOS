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
    public delegate void Delegado();
    public delegate void Delegado2(int x);

    public partial class I_FormaPrincipal : Form
    {



        public  void CambioInterfazDonante()
        {


            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "I_NuevoDonante_Contacto")
                {
                    f.Activate();
                    return;
                }
            }

            I_NuevoDonante_Contacto formHijo = new I_NuevoDonante_Contacto();
            formHijo.CargarDelegado(this);
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
            
        }

        public void CambioInterfazContacto(int x)
        {


            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "I_NuevoContacto")
                {
                    f.Activate();
                    return;
                }
            }

            I_NuevoContacto formHijo = new I_NuevoContacto(2);
            
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();

        }


        public I_FormaPrincipal()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "I_MenuPrincipal")
                {
                    f.Activate();
                    return;
                }
            }

            I_MenuPrincipal formHijo = new I_MenuPrincipal();
            formHijo.CargarDelegado(this);
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();

        }

      

    }
}
