using Primer_Parcial_Aplicada_1.BLL;
using Primer_Parcial_Aplicada_1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial_Aplicada_1.IU.Formulario
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private Grupos LlenaClase()
        {
            Grupos Grupo = new Grupos();

            Grupo.GrupoId = Convert.ToInt32(IdnumericUpDown.Value);
            Grupo.Descripcion = DescripciontextBox.Text;
            Grupo.Fecha = FechaDateTimePicker.Value;
            Grupo.Cantidad = CantidadnumericUpDown.Value;
            Grupo.Cantidad_Grupos = Cantidad_GruposnumericUpDown.Value;
            Grupo.Integrantes = IntegrantestextBox.Text;

            return Grupo;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            Cantidad_GruposnumericUpDown.Value = 0;
            IntegrantestextBox.Text = string.Empty;
            ErrorProvider.Clear();
        }

        private void ActivarError()
        {
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
                ErrorProvider.SetError(DescripciontextBox, "Debe Escribir Una Descripcion");
            if (CantidadnumericUpDown.Value == 0)
                ErrorProvider.SetError(CantidadnumericUpDown, "La Cantidad Debe Ser Mayor Que Cero");
        }

        private bool GetValidacion()
        {
            if (!string.IsNullOrWhiteSpace(DescripciontextBox.Text) &&
                CantidadnumericUpDown.Value != 0)
                return true;
            else
                return false;
        }


        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Grupos Grupo = GruposBLL.Buscar((int)IdnumericUpDown.Value);

            if (Grupo != null)
            {
                IdnumericUpDown.Value = Grupo.GrupoId;
                FechaDateTimePicker.Value = (DateTime)Grupo.Fecha;
                DescripciontextBox.Text = Grupo.Descripcion;
                CantidadnumericUpDown.Value = (Decimal)Grupo.Cantidad;
                CantidadnumericUpDown.Value = Grupo.Cantidad_Grupos;
                IntegrantestextBox.Text = Grupo.Integrantes.ToString();
            }
            else
            {
                MessageBox.Show("Este Grupo No Existe");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Grupos Grupo =  GruposBLL.Buscar((int)IdnumericUpDown.Value);

            if (GetValidacion())
            {
                if (Grupo == null)
                {
                    if (GruposBLL.Guardar(LlenaClase()))
                        MessageBox.Show("Guardado Con Exito");
                    else
                        MessageBox.Show("El Grupo No Se Guardo");
                }
                else
                {
                    if (GruposBLL.Modificar(LlenaClase()))
                        MessageBox.Show("Modificado Con Exito");
                    else
                        MessageBox.Show("El Grupo No Se Modifico");
                }
            }
            else
                ActivarError();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Hay Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
