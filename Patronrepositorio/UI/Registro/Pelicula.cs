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
    public partial class Pelicula : Form
    {
        public Pelicula()
        {
            InitializeComponent();
        }

       

        private void Pelicula_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new Categoria();
            conn.Descripcion = descripcionTextBox.Text;
            conn.CategoriaId = categoriaIdTextBox.Text;
            
            if(conn!= null)
            {
                PatronRepositoio.BLL.RegistroBLL.Guardar(conn);
                MessageBox.Show("Correcto");
            }
            
           
        }
    }
}
