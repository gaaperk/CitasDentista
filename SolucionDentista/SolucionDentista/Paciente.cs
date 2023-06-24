using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SolucionDentista
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("TextChanged");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtanuncio.ForeColor = Color.Black;
            txtanuncio.Text = "";
            string a,b,c, d;
            a = TxtNom.Texts;
            b=txtAp.Texts;
            c=TxtAm.Texts;
            d=TxtTel.Texts;

            if (a != "" && b != "" && c != "" )
            {
                txtanuncio.Text = "";
                txtanuncio.ForeColor = Color.Black;
                string query = "INSERT INTO catpac (`Nombre`, `Ap1`, `Ap2`, `Cel`, `Estado`) VALUES  (" + "'" + a + "'," + "'" + b + "','" + c + "','" + d + "','A');";
                Inicio.Insert(query);
                TxtNom.Texts = "";
                txtAp.Texts = "";
                TxtAm.Texts = "";
                TxtTel.Texts = "";
                txtanuncio.ForeColor = Color.Black;
                txtanuncio.Text = "Paciente registrado";
            }
            else
            {
                txtanuncio.ForeColor = Color.Red;
                txtanuncio.Text = "Todos los campos con * son obligatorios";
            }
                
            

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            TxtNom.Texts = "";
            txtAp.Texts = "";
            TxtAm.Texts = "";
            TxtTel.Texts = "";
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
      if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TxtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TxtAm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
