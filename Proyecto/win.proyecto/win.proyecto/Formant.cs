using BL.proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win.proyecto
{
    public partial class Formant : Form
    {
        mantenimientoBL _mantenimient;
        public Formant()
        {
            InitializeComponent();

            _mantenimient = new mantenimientoBL();
            mantenimientoBL_manteniBindingSource.DataSource = _mantenimient.obtenermantenimientos();
        }




        private void mantenimientoBL_manteniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            mantenimientoBL_manteniBindingSource.EndEdit();
            var mantenimiento = (manteni)mantenimientoBL_manteniBindingSource.Current;

            var resultado = _mantenimient.Guardarmantenimiento(mantenimiento);

            if (resultado == true)
            {
                mantenimientoBL_manteniBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error guardando el mantenimiento");
            }
        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _mantenimient.Agregarmantenimiento();
            mantenimientoBL_manteniBindingSource.MoveLast();
        }




       

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(idTextBox.Text);
            var Resultado = _mantenimient.Eliminarmantenimiento(Id);

            if (Resultado == true)
            {
                mantenimientoBL_manteniBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }
    }
}
