using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            txtContraseña.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxtUsuario.Text == "Usuario" && txtContraseña.Text == "Clave")
            {
                FrmInicio frmInicio = new FrmInicio();
                this.Hide();
                frmInicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos");
                TxtUsuario.Clear();
                txtContraseña.Clear();
            }
        }
    }
}
