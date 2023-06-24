using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionDentista
{
    public partial class AgregarA : Form
    {
        public AgregarA()
        {
            InitializeComponent();
            ConTabla();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = TxtNom.Texts;
            b = txtCosto.Texts;
            c = txtDesc.Texts;
            

            if (a != "" && b != "" )
            {
                txtanuncio.Text = "";
                txtanuncio.ForeColor = Color.Black;
                string query = "INSERT INTO catarr VALUES (null, '"+TxtNom.Texts+"', '"+txtDesc.Texts+"', '"+txtCosto.Texts+"', 'A');";
                Inicio.Insert(query);
                TxtNom.Texts = "";
                txtCosto.Texts = "";
                txtDesc.Texts = "";                
                txtanuncio.ForeColor = Color.Black;
                txtanuncio.Text = "Arreglo registrado";
                ConTabla();
            }
            else
            {
                txtanuncio.ForeColor = Color.Red;
                txtanuncio.Text = "Todos los campos con * son obligatorios";
            }
                

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            TxtNom.Texts = "";
            txtCosto.Texts = "";
            txtDesc.Texts = "";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                txtanuncio.Text = "Este campo solo admite entradas de numeros y un punto decimal";
            }
            else
            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
                txtanuncio.Text = "Este campo solo admite entradas de numeros y un punto decimal";
            }
            else
                txtanuncio.Text = "";
        }

        private void ConTabla()
        {
            dgvL.DataSource = null;
            string query = "SELECT Nombre as 'Arreglo Denatal',Precio as 'Precio $'FROM `catarr` WHERE Estado='A'";
            DataTable x;
            x = Inicio.Listar(query);
            dgvL.DataSource = x;
            
        }
    }
}
