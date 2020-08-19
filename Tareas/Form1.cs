using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txtidusuario.Text = "0";
        }

        private void Btnregistrar_Click(object sender, EventArgs e)
        {
            if (Txtcontrasena.Text == Txtconfirmar.Text)
            {
                var Domini = new Dominio(
                   // iduser:Convert.ToInt32(Txtidusuario.Text),
                    nombre: Txtnombre.Text,
                    apellido: Txtapellido.Text,
                    correo: Txtcorreo.Text,
                    contrasena: Txtcontrasena.Text);
                var insertar = Domini.Insertarusuario();
                MessageBox.Show(insertar);
            }
            else
            {
                MessageBox.Show("Las contrasenas no coinciden"); 
            }
        }
    }
}
