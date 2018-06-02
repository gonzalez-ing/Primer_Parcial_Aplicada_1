using Primer_Parcial_Aplicada_1.IU.Consultar;
using Primer_Parcial_Aplicada_1.IU.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial_Aplicada_1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Registro().Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarRegistro().Show();
        }
    }
}
