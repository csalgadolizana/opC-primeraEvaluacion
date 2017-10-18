using Biblioteca_de_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class CreateModelo : Form
    {
        public CreateModelo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AdministracionModelos administracionModelos = new AdministracionModelos();
            administracionModelos.Show();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modelo modelo = new modelo();
            modelo.codigo_unico = int.Parse(txtCodigo.Text);
            modelo.nombre = txtNombre.Text;
            modelo.apellido_paterno = txtApPaterno.Text;
            modelo.apellido_materno = txtApMaterno.Text;
            modelo.sexo = cboSexo.SelectedItem.ToString();
            modelo.color_ojos = txtColorOjos.Text;
            modelo.tez = txtTez.Text;
            modelo.medidas_anatomicas = txtMedidasAnatomicas.Text;
            modelo.observaciones = txtObservaciones.Text;
            modelo.fecha_nacimiento = DateTime.Parse(dtmFechaNacimiento.Value.ToShortDateString());

            modelo.estaActivo = 1;
            modelo.foto = "/ruta de prueba";

            ModeloDAO modeloDAO = new ModeloDAO();
            if (modeloDAO.ingresoModelo(modelo))
            {
                MessageBox.Show("Guardo :)", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                //LoginInfo.username = nombreUser;
                //LoginInfo.pass = contra;
                //LoginInfo.Tipo = user.tipoUsuario;
                //switch (LoginInfo.Tipo)
                //{
                //    case 1:
                //        LoginInfo.descripcion = "Administrador";
                //        break;
                //    case 2:
                //        AdministracionModelos administracionModelos = new AdministracionModelos();
                //        administracionModelos.Show();
                //        this.Hide();
                //        break;
                //    default:
                //        MessageBox.Show("Tipo de usuario no definido", "Uppps", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                //        break;
                //}
            }
            else
            {
                MessageBox.Show("No guardo", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
