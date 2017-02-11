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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }


        private void UsuarioForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new UsuariosEntidades();

            conn.Nombre = nombreTextBox.Text;
            conn.Clave = claveTextBox.Text;
            if (conn != null)
            {
                PatronRepositoio.BLL.RegistroBLL.Guardar(conn);
                MessageBox.Show("Correcto");
            }
        }
    }
}
