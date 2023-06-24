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
    public partial class RegP : Form
    {
        int index=-1;
        public RegP()
        {
            InitializeComponent();
            DGVB.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox6_KeyPress(object sender, KeyPressEventArgs e)
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
                }catch (Exception ex)
                {
                    txtanuncio.Text = "Error al buscar paciente";
                }
            }
        }

        private void DGVB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DGVB = null;
            nuevo();
            int n = e.RowIndex;
            string carnet = "";
            if (n != -1)
            {
                carnet = DGVB.Rows[n].Cells[0].Value.ToString(); 
                txtCarnet.Texts = carnet;
                txtNombre.Texts = DGVB.Rows[n].Cells[1].Value.ToString();
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
            DGVB.DataSource=null;
            string query= "SELECT b.NumCarnet as '#Carnet',concat_ws(' ',a.Nombre, Ap1, Ap2) as nombre, b.idTC as ID, e.Nombre as Tratamiento, Fecha_I, Fecha_F, b.Estado, IFNULL(diferencia,e.precio)as pendiente from tratamientocuracion as b left join catpac as a on b.NumCarnet=a.NumCarnet left join catcu as e on b.idCatCu=e.idCatCu left join pagostc as c on b.idTC=c.idTC left join detallespagos as d on c.idPagos = d.idPagos where IFNULL(diferencia,e.precio) and b.NumCarnet = '"+Carnet+"' union SELECT b.NumCarnet as '#Carnet',concat_ws(' ', a.Nombre, Ap1, Ap2) as nombre, b.idTA as ID, e.Nombre as Tratamiento, Fecha_I, Fecha_F, b.Estado, IFNULL(diferencia,e.precio)as pendiente from tratamiento_arreglo as b left join catpac as a on b.NumCarnet = a.NumCarnet left join catarr as e on b.idCatArr = e.idCatArr left join pagosta as c on b.idTA = c.idTA left join detallespagos as d on c.idPagos = d.idPagos where IFNULL(diferencia,e.precio) and b.NumCarnet = '"+Carnet+"'";
            DataTable x;
            x = Inicio.Listar(query);
            DGVC.DataSource = x;
        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            nuevo();          
            string query = "";
            DataTable x;
            try
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                {

                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        e.Handled = false;
                        query = "SELECT NumCarnet,concat_ws(' ',Nombre, Ap1, Ap2) as nombre FROM `catpac` where Numcarnet = '" + txtCarnet.Texts + "';";
                        x = Inicio.Listar(query);
                        //txtCarnet.Texts= x.Rows[0]["NumCarnet"].ToString();
                        txtNombre.Texts = x.Rows[0]["nombre"].ToString();
                        ConP(txtCarnet.Texts);
                    }
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
               
            }
            catch (Exception ex)
            {
                txtanuncio.Text = "No se encontro ningun paciente";
            }
        }

        private void nuevo()
        {
            
            txtCarnet.Texts = "";
            txtNombre.Texts = "";          
            txtBP.Texts = "";
            txtanuncio.Text = "";
            txtTr.Texts = "";
            txtDesc.Texts = "";
            txtMon.Texts = "";
            index = -1;
        }

        private void DGVC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             index = e.RowIndex;
            if (index != -1)
            {
                txtTr.Texts = DGVC.Rows[index].Cells[3].Value.ToString();               
            }
            else
            {
                txtanuncio.Text = "Error al seleccionar paciente";
            }
            

        }

        private void txtMon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string query;
            txtanuncio.Text = "";
            if (txtCarnet.Texts != "" && txtMon.Texts != "" && txtTr.Texts != "")
            {
                if (index != -1)
                {
                    try
                    {
                        float pen, mon = float.Parse(txtMon.Texts);
                        char Estado = 'P';
                        string campo="";
                        //MessageBox.Show(DGVC.Rows[index].Cells["Pendiente"].Value.ToString());
                        pen = float.Parse(DGVC.Rows[index].Cells[7].Value.ToString());                        
                        if (pen==mon)
                        {
                            Estado = 'C';
                        }
                        if (mon <= pen)
                        {
                            query = "INSERT INTO detallespagos (`idPagos`, `Fecha`, `Hora`, `Cantidad`, `Descripcion`, `Estado`) VALUES (NULL, curdate(), DATE_FORMAT(NOW( ), \"%H:%i:%S\" ), '" + txtMon.Texts + "', '" + txtDesc.Texts + "', '" + Estado + "');";
                           // txtDesc.Texts = query;

                            Inicio.Insert(query);
                            string cvp = LogClv("SELECT idPagos FROM `detallespagos` ORDER BY `detallespagos`.`idPagos` DESC");
                            string tipo = tabla("SELECT count(*) FROM `catcu` WHERE nombre = '" + DGVC.Rows[index].Cells[3].Value.ToString() + "'");
                            string carnet = DGVC.Rows[index].Cells[0].Value.ToString();
                            if (tipo.Equals("pagostc"))
                            {
                                campo = "idtc";
                            }
                            else
                            {
                                campo = "idta";
                            }
                            query = "update " + tipo + " set diferencia = '" + (pen - mon) + "' where " + campo + " = '" + DGVC.Rows[index].Cells[2].Value.ToString() + "'";
                            //MessageBox.Show(query);
                            Inicio.Insert(query);
                            query = "INSERT INTO " + tipo + " VALUES ('" + cvp + "', '" + DGVC.Rows[index].Cells[2].Value.ToString() + "','"+(pen-mon)+"');";
                            Inicio.Insert(query);
                            ConP(carnet);
                            txtMon.Texts = "";
                            index = -1;
                            txtanuncio.Text = "Pago Registrado";
                        }
                        else
                        {
                            txtanuncio.Text = "El pago no puede exceder al monto pendiente del tratamiento elegido";
                        }

                        //nuevo();
                    }
                    catch (Exception ex)
                    {
                        txtanuncio.Text = "Erro al registrar pago";
                        MessageBox.Show(""+ex);
                    }

                    
                }else
                    txtanuncio.Text = "Seleccione un tratamiento a pagar";
            }
            else
                txtanuncio.Text = "Todos los campos con * son obligatorios";
            
        }

        private string LogClv(string query)
        {
            string resul;
            try
            {
                DataTable x;
                x = Inicio.Listar(query);
                resul = x.Rows[0][0].ToString();
                return resul;
                //idCitas citas
            }
            catch (Exception ex)
            {
                txtanuncio.Text = "Error al obtener clave";
                return "";
            }
        }

        private string tabla(string query)
        {
            //SELECT count(*) FROM `catcu` WHERE nombre = 'hola'
            string resul;
            int c;
            try
            {
                DataTable x;
                x = Inicio.Listar(query);
               c = int.Parse( x.Rows[0][0].ToString());
                if (c>0)
                {
                    return "pagostc";
                }else
                {
                    return "pagosta";
                }                                
            }
            catch (Exception ex)
            {
                txtanuncio.Text = "Error al de consulta";
                return "";
            }
        }

        

        private void iconButton2_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
