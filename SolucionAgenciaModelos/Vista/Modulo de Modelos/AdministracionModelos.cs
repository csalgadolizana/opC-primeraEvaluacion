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
    public partial class AdministracionModelos : Form
    {
        public AdministracionModelos()
        {
            InitializeComponent();
        }

        private void goToCreateModelo_Click(object sender, EventArgs e)
        {
            CreateModelo create = new CreateModelo();
            create.Show();
            this.Dispose();
        }

        private void goToSearchModelo_Click(object sender, EventArgs e)
        {
            EditarModelo editarModelo = new EditarModelo();
            editarModelo.Show();
            this.Dispose();
        }
    }
}
