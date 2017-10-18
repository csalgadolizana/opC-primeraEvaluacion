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
    public partial class CreateCita : Form
    {
        int[] listaModelos=new int[99];

        public CreateCita()
        {
            InitializeComponent();
            ModeloDAO modeloDAO = new ModeloDAO();
            int i = 0;
            List<modelo> list = modeloDAO.listaModelos();
            cboModelos.Items.Clear();
            foreach (modelo item in list)
            {
                cboModelos.Items.Insert(i, item.nombre + " " + item.apellido_paterno);
                listaModelos[i] = item.codigo_unico;
                i++;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cita cita = new cita();
            cita.numero_cita = int.Parse(txtNumeroCita.Text);
            cita.cliente = txtCliente.Text;
            cita.modelo = 12 ;
            ModeloDAO modeloDAO = new ModeloDAO();
            //cita.modelo1 = modeloDAO.buscarModelo(12);
            cita.fecha = DateTime.Parse(dtmFechaEvento.Value.ToShortDateString());
            cita.nombre_evento = txtNombreEvento.Text;
            cita.valor_dia_modelo = int.Parse(txtValorPorDia.Text);

            CitaDAO citaDAO = new CitaDAO();
            if (citaDAO.ingresarCita(cita))
            {
                MessageBox.Show("Guardo :)", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
