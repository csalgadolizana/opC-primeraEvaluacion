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
    public partial class AdministracionCitas : Form
    {
        public AdministracionCitas()
        {
            InitializeComponent();
        }

        private void goToCreateCita_Click(object sender, EventArgs e)
        {
            CreateCita create = new CreateCita();
            create.Show();
            this.Dispose();
        }

        private void goToSearchCita_Click(object sender, EventArgs e)
        {
            EditarCita editarCita = new EditarCita();
            editarCita.Show();
            this.Dispose();
        }
    }
}
