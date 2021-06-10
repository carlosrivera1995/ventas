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
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inicioDeSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formalogin = new formlogin();
            formalogin.ShowDialog();
          
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproducto = new formproductos();
            formproducto.MdiParent = this;
            formproducto.Show();

        }
    }
}
