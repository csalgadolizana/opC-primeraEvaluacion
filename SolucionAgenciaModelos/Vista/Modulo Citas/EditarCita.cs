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
    public partial class EditarCita : Form
    {
        public EditarCita()
        {
            InitializeComponent();
            btnEliminar.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cita cita = new cita();
            CitaDAO citaDAO = new CitaDAO();
            cita = citaDAO.buscarCita(int.Parse(txtNumeroCita.Text));
            if (cita != null)
            {
                txtNumeroCita.Text = cita.numero_cita.ToString();
                txtCliente.Text = cita.cliente;
                cboModelos.SelectedIndex = 0;
                dtmFechaEvento.Value = cita.fecha;
                txtNombreEvento.Text =cita.nombre_evento;
                txtValorPorDia.Text = cita.valor_dia_modelo.ToString();
                MessageBox.Show("Encontró :)", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                txtNumeroCita.ReadOnly = true;
                btnEliminar.Show();
                btnBuscar.Hide();
            }
            else
            {
                MessageBox.Show("No Encontró", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cita cita = new cita();
            CitaDAO citaDAO = new CitaDAO();
            if (citaDAO.cancelarEvento(int.Parse(txtNumeroCita.Text)))
            {
                btnEliminar.Hide();
                btnGuardar.Hide();
                MessageBox.Show("Se Cancelo la cita :)", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No Se pudo dar de baja", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cita cita = new cita();
            cita.numero_cita = int.Parse(txtNumeroCita.Text);
            cita.cliente = txtCliente.Text;
            cita.modelo = 12;
            ModeloDAO modeloDAO = new ModeloDAO();
            //cita.modelo1 = modeloDAO.buscarModelo(12);
            cita.fecha = DateTime.Parse(dtmFechaEvento.Value.ToShortDateString());
            cita.nombre_evento = txtNombreEvento.Text;
            cita.valor_dia_modelo = int.Parse(txtValorPorDia.Text);

            CitaDAO citaDAO = new CitaDAO();
            if (citaDAO.modificarCita(cita))
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
            AdministracionCitas administracionCitas = new AdministracionCitas();
            administracionCitas.Show();
            this.Dispose();
        }
    }
}
