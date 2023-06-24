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
    public partial class Inicio : Form
    {
        string servidor = "";
        string BD = "";
        string usuario = "";
        string password = "";
        static MySqlConnection conexion;

        public Inicio()
        {
            InitializeComponent();
            servidor = "sql10.freesqldatabase.com";
            BD = "sql10458777";
            usuario = "sql10458777";
            password = "yQNUhnaAkQ";
            string connectionString;
            connectionString = "SERVER=" + servidor + ";" + "DATABASE=" + BD + ";" + "UID=" + usuario + ";" + "PASSWORD=" + password + ";";
            try
            {
                conexion = new MySqlConnection(connectionString);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo problemas en la conexion \n" + ex);
            }
            submenu();
            
    }



    private void submenu()
        {
            SubMenuPa.Visible = false;
            SubmenuCitas.Visible = false;
            SubmenuArreglos.Visible = false;
            SubmenuCuraciones.Visible = false;
            SubmenuPagos.Visible = false;
        }

        private void HideSubmenu()
        {
            if (SubMenuPa.Visible == true)
            {
               SubMenuPa.Visible=false;
            }
            if (SubmenuCitas.Visible == true)
            {
                SubmenuCitas.Visible = false;
            }
            if (SubmenuArreglos.Visible == true)
            {
                SubmenuArreglos.Visible = false;
            }
            if (SubmenuCuraciones.Visible == true)
            {
                SubmenuCuraciones.Visible = false;
            }
            if (SubmenuPagos.Visible == true)
            {
                SubmenuPagos.Visible = false;
            }

        }
        private void ShowSubmenu(Panel SubMenu){

            if (SubMenu.Visible == false)
            {
                HideSubmenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }

        }
        private Form activeform = null;
        private void openform(Form Sform)
        {
            if(activeform != null)
            {
                activeform.Close();             
            }
            activeform = Sform;
            Sform.TopLevel = false;
            Sform.FormBorderStyle = FormBorderStyle.None;
            Sform.Dock = DockStyle.Fill;
            PanelView.Controls.Add(Sform);
            PanelView.Tag = Sform;
            Sform.BringToFront();
            Sform.Show();  

        }

        public static bool OpenConnection()
        {
            try{
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se establecio una conexion . Contacte al administrador");
                        break;
                    case 1045:

                        MessageBox.Show("username/password no validos , por favor verifique datos");
                        break;
                }
                return false;
            }
        }
        public static bool CloseConnection()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

                return false;
            }
        }
        public static void Insert(String query)
        {
            try
            {
                if (OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("se realizo la consulta con exito", "Consulta");
                    CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public static DataTable Listar(string query)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable dtspaquete = new DataTable();
            try
            {
                if (Inicio.OpenConnection() == true)
                {
                    dtspaquete.Clear();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    adaptador.SelectCommand = cmd;
                    adaptador.Fill(dtspaquete);
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            return dtspaquete;
        }

    

        private void OpenFrom()
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubMenuPa);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            openform(new Paciente());

        }

        private void btnBsucar_Click(object sender, EventArgs e)
        {

            HideSubmenu();
            openform(new BuscarP());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            openform(new Cita());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HideSubmenu();          
            openform(new ConsultarC());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            openform(new RegP());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            openform(new ConsultarPag());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            HideSubmenu();
            openform(new AgregarA());
        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            openform(new ConsultarA());
            HideSubmenu();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            openform(new AgregarC());
        }

        private void btnConsultar3_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            openform(new ConsultarCu());
        }

        private void bntCitas_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuCitas);
        }

        private void bntPagos_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuPagos);

        }

        private void btnArreglos_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuArreglos);
        }

        private void btnCuraciones_Click(object sender, EventArgs e)
        {
            ShowSubmenu(SubmenuCuraciones);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
