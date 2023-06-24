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
    public partial class Cita : Form
    {

        private string fechaS="";
        public Cita()
        {
            InitializeComponent();
            DGVB.Visible = false;
            catalogos();
            ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
 
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DGVB.DataSource = null;
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

                query = "SELECT NumCarnet,concat_ws(' ',Nombre, Ap1, Ap2) as nombre FROM `catpac` where (Nombre like '%" + txtBP.Texts + "%' or Ap1 like'%" + txtBP.Texts + "%' or Ap2 like '%" + txtBP.Texts + "%')and Estado='A';";
                x = Inicio.Listar(query);
                DGVB.DataSource = x;
            }
        }

        private void DGVB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int n = e.RowIndex;
            if (n != -1)
            {
                txtCarnet.Texts = DGVB.Rows[n].Cells[0].Value.ToString();
                txtNombre.Texts = DGVB.Rows[n].Cells[1].Value.ToString();
                DGVB.DataSource = null;
                DGVB.Visible = false;
            }
            else
            {
                txtanuncio.Text = "Error al seleccionar paciente";
            }
            if (rdbC.Checked)
            {
                LogTratamiento();
            }
            
            DGVB.Visible = false;

        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtanuncio.Text = "";
            txtNombre.Texts = "";
            string query = "";
            DataTable x;
            try
            {               
                    if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) )
                    {

                    if ((int)e.KeyChar == (int)Keys.Enter)
                    {
                        e.Handled = false;
                        query = "SELECT NumCarnet,concat_ws(' ',Nombre, Ap1, Ap2) as nombre FROM `catpac` where Numcarnet = '" + txtCarnet.Texts + "';";
                        x = Inicio.Listar(query);
                        //txtCarnet.Texts= x.Rows[0]["NumCarnet"].ToString();
                        txtNombre.Texts = x.Rows[0]["nombre"].ToString();
                    }
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }

                if (rdbC.Checked)
                {
                    LogTratamiento();
                }

            }
            catch (Exception ex)
            {
                txtanuncio.Text = "No se encontro ningun paciente";
            }
        }

        private void catalogos()
        {
            DataTable x;
            string query;
            query = "select Nombre from catcu where Estado='A' order by Nombre";
            x=Inicio.Listar(query);
            DataRow fila = x.NewRow();
            fila["Nombre"] = "Curaciones Dentales";
            x.Rows.InsertAt(fila,0);
            cmbCu.DataSource = x;
            cmbCu.ValueMember = "Nombre";
            cmbCu.DisplayMember = "Nombre";
            /////
            query = "select Nombre from catarr where Estado='A' order by Nombre";
            x = Inicio.Listar(query);
            DataRow fila2 = x.NewRow();
            fila2["Nombre"] = "Arreglos Dentales";
            x.Rows.InsertAt(fila2, 0);
            cmbAr.DataSource = x;
            cmbAr.ValueMember = "Nombre";
            cmbAr.DisplayMember = "Nombre";
        }
        private void LogTratamiento()
        {
            string query;
            DataTable x;
            query = "SELECT b.Nombre FROM tratamientocuracion as a join catcu as b on a.idCatCu = b.idCatCu where NumCarnet='" + txtCarnet.Texts + "' and a.Estado='A'";
            x = Inicio.Listar(query);
            DataRow fila = x.NewRow();
            fila["Nombre"] = "Curaciones Dentales";
            x.Rows.InsertAt(fila, 0);
            cmbCu.DataSource = x;
            cmbCu.ValueMember = "Nombre";
            cmbCu.DisplayMember = "Nombre";
            ///////
            query = "SELECT b.Nombre FROM tratamiento_arreglo as a join catarr as b on a.idCatArr=b.idCatArr where NumCarnet='" + txtCarnet.Texts + "' and a.Estado='A'";
            x = Inicio.Listar(query);
            DataRow fila2 = x.NewRow();
            fila2["Nombre"] = "Arreglos Dentales";
            x.Rows.InsertAt(fila2, 0);
            cmbAr.DataSource = x;
            cmbAr.ValueMember = "Nombre";
            cmbAr.DisplayMember = "Nombre";
        }

        private void cmbAr_MouseClick(object sender, MouseEventArgs e)
        {
              
        }

        private void monthCalendar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
            
        

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            txtanuncio.Text = "";
            if (fechaS != "" && txtNombre.Texts != "")
            {
                //MessageBox.Show(fechaS);
                if (cmbAr.SelectedIndex > 0 || cmbCu.SelectedIndex > 0)
                {
                    int ch=cmbH.SelectedIndex;
                    int cm=cmbM.SelectedIndex;
                    if (ch!=-1&&cm!=-1)
                    {                        
                            try
                            {
                            string f, query, tratamiento = "",tabla1="",tabla2="",campo="";
                            string res="";
                            DataTable x;
                            int n = cmbAr.SelectedIndex;
                            int m = cmbCu.SelectedIndex;
                            int numero=-1;

                            DateTime fecha = DateTime.Parse(fechaS);
                            f = fecha.ToString("yyyy-MM-dd");
                            //MessageBox.Show(f);
                            if (rdbN.Checked)
                            {
                                if (n > 0)
                                {
                                    tratamiento = cmbAr.SelectedValue.ToString();
                                    tabla1 = "trcitas";
                                    tabla2 = "tratamiento_arreglo";
                                    campo = "idTA";
                                    GenTa(tratamiento, txtCarnet.Texts, f);                                 
                                }
                                else
                                    if (m > 0)
                                {
                                    tratamiento = cmbCu.SelectedValue.ToString();
                                    tabla1 = "cucitas";
                                    tabla2 = "tratamientocuracion";
                                    campo = "idTC";
                                    //MessageBox.Show(tratamiento);
                                    GenCu(tratamiento, txtCarnet.Texts, f);                                
                                }                                  
                                query = "INSERT INTO citas VALUES (NULL, '" + f + "', '" + cmbH.Items[ch].ToString()+ ":" + cmbM.Items[cm].ToString()+ ":00', 'A', '" + txtCarnet.Texts +"');";
                                //MessageBox.Show(query);
                                Inicio.Insert(query);
                                query = "INSERT INTO "+tabla1+" VALUES ('" + ultima("idCitas", " citas") + "', '" + ultima(campo, tabla2) + "', '"+txtAvance.Texts+"', '1');";
                                Inicio.Insert(query);
                                //MessageBox.Show(query);

                            }else

                                if (rdbC.Checked)
                            {                                                               
                                if (n > 0)
                                {
                                    tratamiento = cmbAr.SelectedValue.ToString();
                                    tabla1 = "trcitas";
                                    tabla2 = "tratamiento_arreglo";
                                    campo = "idTA";
                                    res = LogClv("SELECT idTA FROM tratamiento_arreglo where NumCarnet ='" + txtCarnet.Texts + "' and Estado='A'");
                                     numero = int.Parse(LogClv("SELECT NumCita FROM trcitas where idTA='" + res + "'"));
                                    numero++;
                                }
                                else
                                if (m > 0)
                                {
                                    tratamiento = cmbCu.SelectedValue.ToString();
                                    tabla1 = "cucitas";
                                    tabla2 = "tratamientocuracion";
                                    campo = "idTC";
                                    res = LogClv("SELECT idTC FROM tratamientocuracion where NumCarnet ='" + txtCarnet.Texts + "' and Estado='A'");
                                    numero = int.Parse(LogClv("SELECT NumCita FROM cucitas where idTC='" + res + "'"));
                                    numero++;
                                }
                              
                                query = "UPDATE citas SET Estado = 'F' WHERE NumCarnet = '" + txtCarnet.Texts+"' and idCitas in (select idCitas from "+tabla1+" as a where a."+campo+" = '"+res+"' )";
                               // MessageBox.Show(query);
                                Inicio.Insert(query);
                               query = "INSERT INTO citas VALUES (NULL, '" + f + "', '" + cmbH.Items[ch].ToString() + ":" + cmbM.Items[cm].ToString() + ":00', 'A', '" + txtCarnet.Texts + "');";
                                //MessageBox.Show(query);
                                Inicio.Insert(query);                                                                                               
                               query = "INSERT INTO " + tabla1 + " VALUES ('" + ultima("idCitas", " citas") + "', '" + res + "', '" + txtAvance.Texts + "', '"+numero+"');";
                                Inicio.Insert(query);
                            }
                            nuevo();

                        }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                                          

                    }else
                        txtanuncio.Text = "No se selecciono una hora y/o un minuto para la cita";
                }               
                else
                    txtanuncio.Text = "Debe seleccionar una curacion  o un arreglo";
            }
            else
                txtanuncio.Text = "No se selcciono una fecha o un paciente para realizar la cita";
             
            rdbC.Checked= false;    
            rdbN.Checked = true;
        }

        private void cmbCu_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbCu_MouseCaptureChanged(object sender, EventArgs e)
        {
            int n = cmbCu.SelectedIndex;
            if (n > 0)
            {
                cmbAr.SelectedIndex = 0;
            }
        }

        private void cmbAr_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbAr_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbAr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = cmbAr.SelectedIndex;
            if (n > 0)
            {
                cmbCu.SelectedIndex = 0;
            }
        }

        private void cmbCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = cmbCu.SelectedIndex;
            if (n > 0)
            {
                cmbAr.SelectedIndex = 0;
            }
        }

        private void Calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void nuevo()
        {
            fechaS = "";
            txtCarnet.Texts = "";
            txtNombre.Texts = "";
;           cmbAr.SelectedIndex = 0;    
            cmbCu.SelectedIndex = 0;
            cmbH.SelectedIndex=-1;
            cmbM.SelectedIndex = -1;
            txtBP.Texts = "";
            txtAvance.Texts = "";
            catalogos();
        }
        private void GenCu(string index,string carnet, string fecha)
        {
            string sql;
            try
            {
                sql = "update citas set Estado = 'F' where Numcarnet = '"+carnet+"' and idCitas in (SELECT idCitas FROM `cucitas` as a join tratamientocuracion as b on a.idTC = b.idTC where NumCarnet = '"+carnet+"' and b.Estado='A')";
                Inicio.Insert(sql);
                sql = "UPDATE tratamientocuracion SET `Fecha_F` = '"+fecha+"', `Estado` = 'F' WHERE NumCarnet="+carnet+" and Estado = 'A'";
                //MessageBox.Show(sql);
                Inicio.Insert(sql);
                sql = "INSERT INTO tratamientocuracion VALUES (NULL, '" + carnet + "', '"+ ids(index, "catcu") + "', '"+fecha+"', NULL, 'A');";
                //MessageBox.Show(sql);
                Inicio.Insert(sql);

            }catch (Exception ex)
            {
                txtanuncio.Text = "Error al generar la cita";
            }

        }

        private void GenTa(string index, string carnet, string fecha)
        {
            string sql;
            try
            {
                sql = "update citas set Estado = 'F' where Numcarnet = '"+carnet+"' and idCitas in (SELECT idCitas FROM trcitas as a join tratamiento_arreglo as b on a.idTA = b.idTA where NumCarnet = '"+carnet+"' and b.Estado='A')";
                Inicio.Insert(sql);
                sql = "UPDATE tratamiento_arreglo SET `Fecha_F` = '" + fecha + "', `Estado` = 'F' WHERE NumCarnet=" + carnet + " and Estado = 'A'";
                Inicio.Insert(sql);
                sql = "INSERT INTO tratamiento_arreglo VALUES (NULL, '" + ids(index, "catarr") + "', '" + carnet + "', '" + fecha + "', NULL, 'A');";
                Inicio.Insert(sql);

            }
            catch (Exception ex)
            {
                txtanuncio.Text = "Error al generar la cita";
            }

        }


        public int ids(string nom,string tabla)
        {
            try
            {
                DataTable x;
                string query = "SELECT * FROM "+tabla+" WHERE Nombre='"+nom+"'";
                x = Inicio.Listar(query);
                string clv = x.Rows[0][0].ToString();
                return int.Parse(clv);
            }
            catch (Exception ex)
            {
                txtanuncio.Text = "Error al generar cita";
                return -1;
            }
        }
        public string ultima(string campo, string tabla)
        {
            string resul;
            string sql = "SELECT "+campo+" FROM "+tabla+" ORDER BY "+campo+" desc";
            DataTable x;
            x= Inicio.Listar(sql);  
            resul= x.Rows[0][0].ToString();
            return resul;
            //idCitas citas
        }


    

        private void rdbC_MouseCaptureChanged(object sender, EventArgs e)
        {
            LogTratamiento();
        }

        private void rdbN_MouseCaptureChanged(object sender, EventArgs e)
        {
            catalogos();
        }

        public string LogClv(string query)
        {
            string resul;
            try
            {              
                DataTable x;
                x = Inicio.Listar(query);
                resul = x.Rows[0][0].ToString();
                return resul;
                //idCitas citas
            }catch (Exception ex)
            {
                txtanuncio.Text = "Error al continuar tratamiento";
                return "";
            }
        }

        private void Calendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaS = Calendar1.SelectionRange.Start.ToShortDateString().ToString();
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
