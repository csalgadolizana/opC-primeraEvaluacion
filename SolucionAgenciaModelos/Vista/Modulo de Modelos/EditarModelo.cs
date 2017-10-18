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
    public partial class EditarModelo : Form
    {
        public EditarModelo()
        {
            InitializeComponent();
            btnDarDeBaja.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
            if (modeloDAO.editarModelo(modelo))
            {
                MessageBox.Show("Modificó :)", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No guardo", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AdministracionModelos administracionModelos = new AdministracionModelos();
            administracionModelos.Show();
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            modelo modelo = new modelo();
            ModeloDAO modeloDAO = new ModeloDAO();
            modelo = modeloDAO.buscarModelo(int.Parse(txtCodigo.Text));
            if (modelo != null && modelo.estaActivo == 1)
            {
                txtCodigo.Text = modelo.codigo_unico.ToString();
                txtNombre.Text = modelo.nombre;
                txtApPaterno.Text = modelo.apellido_paterno;
                txtApMaterno.Text = modelo.apellido_materno;
                cboSexo.SelectedIndex = (modelo.sexo == "Hombre") ? 0 : 1;
                //cboSexo.SelectedIndex = 0 ;
                txtColorOjos.Text = modelo.color_ojos;
                txtTez.Text = modelo.tez;
                txtMedidasAnatomicas.Text = modelo.medidas_anatomicas;
                txtObservaciones.Text = modelo.observaciones;
                dtmFechaNacimiento.Value = modelo.fecha_nacimiento;
                MessageBox.Show("Encontró :)", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                txtCodigo.ReadOnly = true;
                btnDarDeBaja.Show();
                btnBuscar.Hide();
            }
            else
            {
                MessageBox.Show("No Encontró", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            modelo modelo = new modelo();
            ModeloDAO modeloDAO = new ModeloDAO();
            if (modeloDAO.darDeBajaModelo(int.Parse(txtCodigo.Text)))
            {
                btnEditar.Hide();
                btnDarDeBaja.Hide();
                MessageBox.Show("Se dio de baja correctamente:)", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No Se pudo dar de baja", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
    }
}
