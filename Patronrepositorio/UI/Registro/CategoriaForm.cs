using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Patronrepositorio.Entidades;

namespace Patronrepositorio.UI.Registro
{
    public partial class CategoriaForm : Form
    {
        public CategoriaForm()
        {
            InitializeComponent();
        }
       

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new Categoria();
            con.Descripcion = descripcionTextBox.Text;

            if(con!=null)
            {
                PatronRepositoio.BLL.RegistroBLL.Guardar(con);
                MessageBox.Show("Correcto");
            }

        }
    }
}
