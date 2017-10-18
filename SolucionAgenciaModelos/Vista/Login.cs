using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Clases;

namespace Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreUser = txtUsuario.Text;
            string contra = txtPassword.Text;
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario user = usuarioDAO.login(nombreUser, contra);
            if (user != null)
            {
                LoginInfo.username = nombreUser;
                LoginInfo.pass = contra;
                LoginInfo.Tipo = user.tipoUsuario;
                switch (LoginInfo.Tipo)
                {
                    case 1:
                        LoginInfo.descripcion = "Administrador";
                        AdministracionModelos administracionModelos = new AdministracionModelos();
                        administracionModelos.Show();
                        this.Hide();
                        break;
                    case 2:
                        AdministracionCitas administracionCitas = new AdministracionCitas();
                        administracionCitas.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario no definido", "Uppps", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        break;
                }
            }
            else
            {
                MessageBox.Show("esta nulo", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
