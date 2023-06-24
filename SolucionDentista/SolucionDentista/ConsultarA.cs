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
    public partial class ConsultarA : Form
    {
        public ConsultarA()
        {
            InitializeComponent();
            ConTabla();
            NV();
            
            }

        private void txtBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable x;
            String query = "";

            DGVA.DataSource = null;
            if (txtBP.Texts != "")
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
          if (Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }

                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;

                }
                query = "SELECT idCatArr as Codigo,Nombre as 'Arreglo Denatal',Precio as 'Precio $',Estado,Descripcion FROM catarr where Nombre like '%" + txtBP.Texts + "%' ORDER BY Nombre asc, Estado ASC";
              // MessageBox.Show(query);
                x = Inicio.Listar(query);
                DGVA.DataSource = x;

            }
            else
            {
                ConTabla();
            }

           

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtanuncio.Text = "";
            string a, b, c;
            a = TxtNom.Text;
            b = txtCosto.Text;            
            if (a != "" && b != "")
            {
                DataTable x;
                char Estado = 'A';
                if (cmbE.SelectedIndex == 0)
                {
                    Estado = 'A';
                }
                else
                {
                    Estado = 'D';
                }
                string query = "UPDATE catarr SET `Nombre` = '" + TxtNom.Text + " ', `Descripcion` = '" + txtDesc.Text + " ', `precio` = '" + txtCosto.Text + "', `Estado` = '"+Estado+"' WHERE `catarr`.`idCatArr` = "+label7.Text+";";
                Inicio.Insert(query);
                txtanuncio.Text = "Datos actualizados ";
                NV();
                vacio();
                ConTabla();
            }
            txtanuncio.Text = "Todos los campos con * son obligatorios";

        }

        private void ConTabla()
        {
            DGVA.DataSource = null;
            string query = "SELECT idCatArr as Codigo,Nombre as 'Arreglo Denatal',Precio as 'Precio $',Estado,Descripcion FROM catarr  ORDER BY Nombre asc, Estado ASC";
            DataTable x;
            x = Inicio.Listar(query);
            DGVA.DataSource = x;

        }

        private void NV()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            TxtNom.Visible = false;
            txtCosto.Visible = false;
            txtDesc.Visible = false;
            cmbE.Visible = false;
            btnA.Visible = false;
        }
        private void SV()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            TxtNom.Visible = true;
            txtCosto.Visible= true;
            txtDesc.Visible=true;
            cmbE.Visible = true;
            btnA.Visible = true;
        }
        private void vacio()
        {
            TxtNom.Text = "";
            txtCosto.Text = "";
            txtDesc.Text = "";
            label7.Text = "";

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DGVA_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVA_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtanuncio.Text = "";
            int n = e.RowIndex;
            string Es;
            if (n != -1)
            {
                //MessageBox.Show(n + "");
                SV();
                vacio();
                cmbE.SelectedIndex = 1;
                label7.Text = DGVA.Rows[n].Cells[0].Value.ToString();
                TxtNom.Text=DGVA.Rows[n].Cells[1].Value.ToString();
                txtCosto.Text = DGVA.Rows[n].Cells[2].Value.ToString();
                txtDesc.Text=DGVA.Rows[n].Cells[4].Value.ToString();
                Es = DGVA.Rows[n].Cells[3].Value.ToString();
                if (Es == "A")
                    {
                        cmbE.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbE.SelectedIndex = 1;
                    }
            }else
            txtanuncio.Text = "Erro al seleccionar el Arreglo dental";
        }

        private void txtCosto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
