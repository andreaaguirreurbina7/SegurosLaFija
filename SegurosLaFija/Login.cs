using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurosLaFija
{
    public partial class Login : Form
    {
        int intentos = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (intentos > 1) 
            {
                string user = txtUser.Text;
                string pass = txtPass.Text;

                if (user == "Juan" && pass == "123456") 
                {
                    MessageBox.Show("Se logueo con éxito, Bienvenido");
                }
                else 
                {
                    intentos--;
                    MessageBox.Show("Credenciales no validas\n le quedan " + intentos + " intentos");
                }

            }
            else 
            {
                MessageBox.Show("La cantidad de intentos se acabo");
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Esta seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
                this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
