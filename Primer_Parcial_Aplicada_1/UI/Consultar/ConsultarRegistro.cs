using Primer_Parcial_Aplicada_1.BLL;
using Primer_Parcial_Aplicada_1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial_Aplicada_1.IU.Consultar
{
    public partial class ConsultarRegistro : Form
    {
        public ConsultarRegistro()
        {
            InitializeComponent();
        }

        private void BuscarFiltrobutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> filtral = x => 1 == 1;
            int Id;
            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0://GrupoId
                    Id = Convert.ToInt32(FiltrartextBox.Text);
                    filtral = x => x.GrupoId == Id
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;

                case 1://Descripcion
                    filtral = x => x.Descripcion.Contains(FiltrartextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;

                case 2://Cantidad
                    Decimal Cantidad = Decimal.Parse(FiltrartextBox.Text);
                    filtral = x => x.Cantidad >= Cantidad
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;

                case 3://Grupos
                    Decimal Cantidad_Grupos = Decimal.Parse(FiltrartextBox.Text);
                    filtral = x => x.Cantidad_Grupos >= Cantidad_Grupos
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
            }

            ConsultadataGridView.DataSource = GruposBLL.GetList(filtral);
        }

        private void ConsultarRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
