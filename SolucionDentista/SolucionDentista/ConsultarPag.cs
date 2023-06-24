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
    public partial class ConsultarPag : Form
    {
        public ConsultarPag()
        {
            InitializeComponent();
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DGVB.DataSource = null;
            DGVB.Visible = true;
            if (txtBP.Texts == "")
            {
                DGVB.Visible = false;
            }
            else
            {
                DGVB.Visible = true;
                DataTable x;
                String query = "";
                DGVB.DataSource = null;

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
                try
                {


                    query = "SELECT NumCarnet,concat_ws(' ',Nombre, Ap1, Ap2) as nombre FROM `catpac` where (Nombre like '%" + txtBP.Texts + "%' or Ap1 like'%" + txtBP.Texts + "%' or Ap2 like '%" + txtBP.Texts + "%')and Estado='A';";
                    x = Inicio.Listar(query);
                    DGVB.DataSource = x;
                }
                catch (Exception ex)
                {
                    txtanuncio.Text = "Error al buscar paciente";
                }
            }
        }

        private void DGVB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = e.RowIndex;
            string carnet = "";
            if (n != -1)
            {
                carnet = DGVB.Rows[n].Cells[0].Value.ToString();
                DGVB.DataSource = null;
                DGVB.Visible = false;
                ConP(carnet);
            }
            else
            {
                txtanuncio.Text = "Error al seleccionar paciente";
            }

            DGVB.Visible = false;
        }

        private void ConP(string Carnet)
        {
            DGVB.DataSource = null;
            string query = "SELECT b.NumCarnet as '#Carnet',concat_ws(' ',a.Nombre, Ap1, Ap2) as nombre, b.idTA as ID, e.Nombre as Tratamiento,e.precio, IFNULL(d.Fecha,'sin pago')as Fecha, IFNULL(d.Hora,'sin pago') as Hora,IFNULL(d.cantidad,'sin pago')as Pago,IFNULL(diferencia,e.precio)as pendiente, d.Descripcion from tratamiento_arreglo as b left join catpac as a on b.NumCarnet=a.NumCarnet left join catarr as e on b.idCatArr=e.idCatArr left join pagosta as c on b.idTA=c.idTA left join detallespagos as d on c.idPagos = d.idPagos where b.NumCarnet ='" + Carnet+ "'union SELECT b.NumCarnet as '#Carnet',concat_ws(' ', a.Nombre, Ap1, Ap2) as nombre, b.idTC as ID, e.Nombre as Tratamiento,e.precio, IFNULL(d.Fecha, 'sin pago') as Fecha, IFNULL(d.Hora, 'sin pago') as Hora,IFNULL(d.cantidad, 'sin pago') as Pago,IFNULL(diferencia, e.precio) as pendiente, d.Descripcion from tratamientocuracion as b left join catpac as a on b.NumCarnet = a.NumCarnet left join catcu as e on b.idCatCu = e.idCatCu left join pagostc as c on b.idTC = c.idTC left join detallespagos as d on c.idPagos = d.idPagos where b.NumCarnet = '" + Carnet+"'";
            DataTable x;
            x = Inicio.Listar(query);
            DGVC.DataSource = x;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DGVC.DataSource = null;
            string fechaI, fechaF, query;
            DataTable x;
            fechaI = MC.SelectionStart.ToShortDateString();
            fechaF = MC.SelectionEnd.ToShortDateString();
            //MessageBox.Show(fechaI + fechaF);
            if (fechaI.Equals(fechaF))
            {
                DateTime fecha = DateTime.Parse(fechaI);
                string FF = fecha.ToString("yyyy-MM-dd");
                query = "SELECT idPagos as ID, Fecha, Hora cantidad, descripcion FROM `detallespagos` where fecha= '"+FF+"'";
                x = Inicio.Listar(query);
                DGVC.DataSource = x;
            }
            else
            {
                string FF1, FF2;
                DateTime fecha = DateTime.Parse(fechaI);
                FF1 = fecha.ToString("yyyy-MM-dd");
                fecha = DateTime.Parse(fechaF);
                FF2 = fecha.ToString("yyyy-MM-dd");
                //MessageBox.Show(FF1 +";"+FF2);
                query = "SELECT idPagos as ID, Fecha, Hora cantidad, descripcion FROM `detallespagos` where fecha between '"+FF1+"' and '"+FF2+"' ORDER BY `detallespagos`.`Fecha` DESC";
                x = Inicio.Listar(query);
                DGVC.DataSource = x;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DGVB.DataSource = null;
            txtBP.Texts = "";
            DGVC.DataSource = null;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
