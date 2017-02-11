using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Patronrepositorio.UI.Registro;

namespace Patronrepositorio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioForm u = new UsuarioForm();
            u.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaForm c = new CategoriaForm();
            c.Show();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula();
            p.Show();
        }
    }
}
