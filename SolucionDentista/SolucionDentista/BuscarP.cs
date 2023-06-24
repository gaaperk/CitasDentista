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
    public partial class BuscarP : Form
    {
        public BuscarP()
        {
            InitializeComponent();
            ocultar();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                DGVB.Visible=false;
            }
            else
            DGVB.Visible = true;
            DataTable x;
            String query="";
            DGVB.DataSource = null;

            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
               
            }else   
           if (Char.IsControl(e.KeyChar) ||Char.IsNumber(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
                
            }

            if (RBNom.Checked)
            {
                query = "SELECT NumCarnet,concat_ws(' ',Nombre, Ap1, Ap2) as nombre FROM `catpac` where Nombre like '%" + txtBP.Texts + "%' or Ap1 like'%" + txtBP.Texts + "%' or Ap2 like '%" + txtBP.Texts + "%'";
            }
            else
            if (rbCarnet.Checked)
            {
                query = "SELECT NumCarnet,concat_ws(' ',Nombre, Ap1, Ap2) as nombre FROM `catpac` where Numcarnet like '%"+txtBP.Texts+"%';";
            }
                        
            x = Inicio.Listar(query);
            DGVB.DataSource = x;


        }

        private void txtBP__TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            ocultar();
            DGVCon.DataSource = null;            
            int n = e.RowIndex;
            DataTable x;
            string numC,query;           
            if (n != -1)
            {
                numC = DGVB.Rows[n].Cells[0].Value.ToString();
                //MessageBox.Show(""+numC);
                query = "SELECT a.NumCarnet as Carnet ,concat_ws(' ',a.Nombre, Ap1, Ap2) as Nombre, Cel as Tel , b.Nombre as Tratamiento,c.estado as Estado, Fecha_I as Inicio, Fecha_F as Fin ,progreso as Avance , FechaCita as Cita , e.Estado as Etapa FROM catpac as a, catcu as b, tratamientocuracion as c, cucitas as d , citas as e where a.Numcarnet = e.Numcarnet and e.idCitas=d.idCitas and d.idTC=c.idTC and c.idCatCu=b.idCatCu and a.NumCarnet=" + numC + " union all SELECT a.NumCarnet as Carnet ,concat_ws(' ',a.Nombre, Ap1, Ap2) as Nombre, Cel as Tel , b.Nombre as Tratamiento,c.estado as Estado, Fecha_I as Inicio, Fecha_F as Fin ,progreso as Avance , FechaCita as Cita , e.estado as Estado FROM catpac as a, catarr as b, tratamiento_arreglo as c, citas as e, trcitas as d where a.Numcarnet = e.Numcarnet and e.idCitas= d.idCitas and d.idTA=c.idTA and c.idCatArr=b.idCatArr and a.NumCarnet=" + numC + " ORDER BY Estado ASC , Cita DESC";
 
                x = Inicio.Listar(query);
                if (x.Rows.Count>0)
                {
                    DGVCon.DataSource = x;      
                    
                }
                else
                {
                    MessageBox.Show("No se encontro ningun historial para este paciente");
                    DGVCon.DataSource = null;
                }
                    
            }
        }

        private void DGVC_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DGVC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void DGVC_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            limpiar();
            int n = e.RowIndex;
            string query = "",car,Es="";
            DataTable x;
            if (n != -1)
            {
                //MessageBox.Show(n + "");
               ver();

                car = DGVCon.Rows[n].Cells[0].Value.ToString();
                // MessageBox.Show("" + numC);
                query = "SELECT NumCarnet, Nombre, Ap1, Ap2, Cel,Estado from catpac where NumCarnet="+car+";";
                try
                {
                    x=Inicio.Listar(query);
                    txtNom.Text = x.Rows[0]["Nombre"].ToString();
                    txtAp1.Text = x.Rows[0]["Ap1"].ToString() ;
                    txtAp2.Text = x.Rows[0]["Ap2"].ToString();
                    txtTel.Text = x.Rows[0]["cel"].ToString();
                    label7.Text = x.Rows[0]["NumCarnet"].ToString();
                    Es = x.Rows[0]["Estado"].ToString();
                    if (Es == "A")
                    {
                        cmbEstado.SelectedIndex = 0;
                    }else
                    {
                        cmbEstado.SelectedIndex = 1;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro al selecionar el paciente");
                }
            }
         }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (noVacio()!=true) {
                DataTable x;
                char Estado = 'A';
                if (cmbEstado.SelectedIndex == 0)
                {
                    Estado = 'A';
                }
                else
                {
                    Estado = 'D';
                }

                string query = "UPDATE catpac SET `Nombre` = '" + txtNom.Text + "', `Ap1` = '" + txtAp1.Text + "', `Ap2` = '" + txtAp2.Text + "', `Cel` = '" + txtTel.Text + "', `Estado` = '" + Estado + "' WHERE `catpac`.`NumCarnet` = " + label7.Text + ";";
                Inicio.Insert(query);
                MessageBox.Show("Datos actualizados");
                query = "SELECT a.NumCarnet as Carnet ,concat_ws(' ',a.Nombre, Ap1, Ap2) as Nombre, Cel as Tel , b.Nombre as Tratamiento, Fecha_I as Inicio, Fecha_F as Fin ,progreso as Avance , FechaCita as Cita ,c.estado as Estado FROM catpac as a, catcu as b, tratamientocuracion as c, cucitas as d , citas as e where a.Numcarnet = e.Numcarnet and e.idCitas=d.idCitas and d.idTC=c.idTC and c.idCatCu=b.idCatCu and a.NumCarnet='" + label7.Text + "';";
                x = Inicio.Listar(query);
                DGVCon.DataSource = x;
                ocultar();
                limpiar();
            }else
                MessageBox.Show("Los datos con * son obligatorios");
        }

        private void limpiar()
        {
            txtNom.Text = "";
            txtAp1.Text = "";
            txtAp2.Text = "";
            txtTel.Text = "";
            label7.Text = "";
        }

        private void ocultar()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            txtAp1.Visible = false;
            txtAp2.Visible = false;
            txtNom.Visible = false;
            txtTel.Visible = false;
            cmbEstado.Visible = false;
            btnA.Visible = false;
        }
        private void ver()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            txtAp1.Visible = true;
            txtAp2.Visible = true;
            txtNom.Visible = true;
            txtTel.Visible = true;
            cmbEstado.Visible = true;
            btnA.Visible = true;
        }

        private bool noVacio()
        {
            bool vacio = false;

            if (txtAp1.Text =="") {                
                vacio = true; 
            }else
            if (txtAp2.Text=="")
            {
                vacio = true;
            }
            else
                if (txtNom.Text == "")
            {
                vacio= true;
            }
            return vacio;
        }
    }
}
