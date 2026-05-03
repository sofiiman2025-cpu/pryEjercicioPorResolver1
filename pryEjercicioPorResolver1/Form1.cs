using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjercicioPorResolver1
{
    
    public partial class frmLogin : Form
    {
        int intentos = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           string u = txtUsuario.Text;
           string c = txtContraseña.Text;
           string m = cmbModulo.Text;

          //Adm
          if (u == "Admin" && c == "@1a")
            {
                if (m == "ADM" || m == "COM" || m == "VTA")
                {
                    entrar();
                    return;
                }
            }

          //John
            if (u == "John" && c == "@2b")
            {
                if (m == "COM" || m == "VTA")
                {
                    entrar();
                    return;
                }
            }

            //Ceci
            if (u == "Ceci" && c == "@3c")
            {
                if (m == "VTA")
                {
                    entrar();
                    return;
                }
            }
            //God (acceso total)
            if (u == "God" && c == "@#4d")
            {
                entrar();
                return;
            }

            // si falla
            intentos++;
            MessageBox.Show("Usuario, contraseña o módulo incorrecto. Intente nuevamente.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (intentos == 2)
                this.Close();
        }
        private void entrar()
        {
            frmBienvenido frmBienvenido = new frmBienvenido();
            this.Hide();
            frmBienvenido.ShowDialog();
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
