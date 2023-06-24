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
    public partial class ConsultarC : Form
    {
        string SC="";
        string CT="";
        public ConsultarC()
        {
            InitializeComponent();
            CitasHoy();
            NV();
            DGVB.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        public void CitasHoy()
        {
            DGVC.DataSource = null;
            DataTable x;
            string query = "SELECT idCitas as '# Cita', FechaCita as Fecha ,NumCarnet as '# Carnet' , HoraCita as Hora, Estado FROM `citas` where FechaCita=CURDATE() and Estado ='A'";
            x = Inicio.Listar(query);
            DGVC.DataSource=x;  
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DGVC.DataSource = null;
            string fechaI, fechaF,query;
            DataTable x;
            fechaI = MC.SelectionStart.ToShortDateString();
            fechaF = MC.SelectionEnd.ToShortDateString();
            //MessageBox.Show(fechaI + fechaF);
            if (fechaI.Equals(fechaF))
            {
                DateTime fecha = DateTime.Parse(fechaI);
                string FF = fecha.ToString("yyyy-MM-dd");
                query = "SELECT idCitas as '# Cita', FechaCita as Fecha ,NumCarnet as '# Carnet' , HoraCita as Hora, Estado FROM `citas` where FechaCita='" + FF+ "'order by Estado";
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
                query = "SELECT idCitas as '# Cita', FechaCita as Fecha ,NumCarnet as '# Carnet' , HoraCita as Hora, Estado FROM `citas` where FechaCita between '" + FF1+"' and '"+FF2+"' order by Estado";
                x = Inicio.Listar(query);
                DGVC.DataSource = x;
            }
            //MessageBox.Show(fechaI + fechaF);
            //txtFecha.Texts = fechaI+fechaF;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            CitasHoy();
            txtBP.Texts = "";
            txtAnuncio.Text = "";
        }

        private void DGVB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = e.RowIndex;
            DataTable x;
            if (n != -1)
            {
                string carnet= DGVB.Rows[n].Cells[0].Value.ToString();
                string query = "SELECT idCitas as '# Cita', FechaCita as Fecha ,NumCarnet as '# Carnet' , HoraCita as Hora, Estado FROM `citas` where NumCarnet = '" + carnet+ "' order by Estado";
                x=Inicio.Listar(query);
                DGVC.DataSource= x;
                DGVB.DataSource = null;
                DGVB.Visible = false;
            }
            else
            {
                txtAnuncio.Text = "Error al seleccionar paciente";
            }
           

            DGVB.Visible = false;
        }

        private void DGVC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vacio();
            txtAnuncio.Text = "";
            int n = e.RowIndex;
            string Es="",fechaC,horas,hora="",min="";
            try
            {
                if (n != -1)
                {
                    //MessageBox.Show(n + "");
                    Es = DGVC.Rows[n].Cells[4].Value.ToString();
                    if (Es.Equals("A"))
                    {
                        SV();
                        
                        cmbE.SelectedIndex = 1;
                        CT = DGVC.Rows[n].Cells[0].Value.ToString(); ;
                        fechaC = DGVC.Rows[n].Cells[1].Value.ToString().Remove(10);
                        DateTime time = DateTime.Parse(fechaC);
                        DTP.Value = time;
                        SC = DGVC.Rows[n].Cells[2].Value.ToString();
                        horas = DGVC.Rows[n].Cells[3].Value.ToString();
                        // MessageBox.Show(horas);

                        hora = horas.Substring(0, 2);
                        min = horas.Substring(2, 3).Remove(0, 1);
                        //MessageBox.Show(hora+min);
                        for (int i = 0; i < 24; i++)
                        {
                            if (hora.Equals(cmbH.Items[i].ToString()))
                            {
                                cmbH.SelectedIndex = i;
                                break;
                            }
                        }
                        for (int i = 0; i < 60; i++)
                        {
                            if (min.Equals(cmbM.Items[i].ToString()))
                            {
                                cmbM.SelectedIndex = i;
                                break;
                            }
                        }
                        cmbE.SelectedIndex = 0;

                    }
                    else
                    {
                        txtAnuncio.Text = "Solo se pueden modificar citas activas";
                        NV();
                    }
                }
                else
                    txtAnuncio.Text = "Fecha";
            }catch (Exception ex)
            {
                txtAnuncio.Text = "Error al recuperar cita";
            }
        }

        private void NV()
        {
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            DTP.Visible = false;   
            cmbH.Visible = false;
            cmbM.Visible = false;
            cmbE.Visible = false;   
            btnA.Visible = false;
           
        }
        private void SV()
        {
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            DTP.Visible = true;
            cmbH.Visible = true;
            cmbM.Visible = true;
            cmbE.Visible = true;
            btnA.Visible = true;
        }
        private void vacio()
        {
            //txtFecha.Texts = "";
            SC = "";
            CT = "";
            cmbH.Text = "Horas";
            cmbM.Text = "Minutos";
        }

        private void cmbE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtAnuncio.Text = "";
            string fechas =DTP.Value.ToShortDateString();
            DateTime fecha = DateTime.Parse(fechas);
            string f = fecha.ToString("yyyy-MM-dd");
            char Estado = 'A';
            string query="";
            int ch = cmbH.SelectedIndex;
            int cm = cmbM.SelectedIndex;            
            if (ch != -1 && cm != -1)
            {
                switch (cmbE.SelectedIndex)
                {
                   case 0: Estado = 'A';   break;
                    case 1: Estado = 'F'; break;
                    case 2: Estado = 'C'; break;
                }
                try
                {
                    query = "UPDATE citas SET `FechaCita` = '" + f + "', HoraCita = '" + cmbH.Items[ch].ToString() + ":" + cmbM.Items[cm].ToString() + "', `Estado` = '" + Estado + "' WHERE idCitas = '" + CT + "' and NumCarnet = '"+SC+"' ;";
                   //txtBP.Texts = query;
                    //MessageBox.Show(query);  
                    Inicio.Insert(query);
                    vacio();
                    NV();
                    CitasHoy();
                    txtAnuncio.Text = "Cita actualizada";
                }
                catch (Exception ex)
                {
                    txtAnuncio.Text = "Error al actualizar cita";
                }
                
            }
            else
            {
                txtAnuncio.Text = "Seleccione una hora";
            }  
            
               
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* private string cvlc(string query)
         {
             txtAnuncio.Text = "";
             DataTable x;
             try
             {
                x= Inicio.Listar(query);
                string clv = x.Rows[0][0].ToString();
                 return clv;
             }
             catch (Exception ex)
             {
                 txtAnuncio.Text = "Error el recuperar clave";
                 return "";
             }

         }*/
    }
}
