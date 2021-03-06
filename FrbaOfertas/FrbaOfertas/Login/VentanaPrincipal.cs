﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.Menu;
using FrbaOfertas.gestionUsuarios;
using FrbaOfertas.Datos;


namespace FrbaOfertas
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signinbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conex = Conexiones.AbrirConexion();

            SqlCommand procedure = new SqlCommand("NUNCA_INJOIN.sp_validarUsuario", conex);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.AddWithValue("@id_ingresado", SqlDbType.NVarChar).Value = usuarioTxt.Text;
            procedure.Parameters.Add("@contra_ingresada", SqlDbType.NVarChar).Value = password.Text;
            procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            procedure.ExecuteNonQuery();
            Conexiones.CerrarConexion();

            int retorno = (int)procedure.Parameters["@retorno"].Value;

            if (retorno == 1)
            {//todo bien

                VentanaMenu menu = new VentanaMenu(this,usuarioTxt.Text);
                this.Hide();
                menu.Show();
                password.Clear();
            }
            else if (retorno == 0)
            { //hay intentos todavia
                MessageBox.Show("Contraseña incorrecta, pruebe nuevamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                password.Clear();
            }
            else if (retorno == -1)
            { //baja logica
                MessageBox.Show("Se excedió la cantidad de intentos posibles", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Clear();
            }
            else if (retorno == 3)
            { //baja logica del Rol
                MessageBox.Show("No se pudo ingresar, su rol esta inhabilitado. Contacte al administrador.", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Clear();
            }
            else
            { //no existe usuario
                MessageBox.Show("No Existe Usuario", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioTxt.Clear();
                password.Clear();

            }
        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreacionUsuario ventanaCreacion = new CreacionUsuario(this, null, InfoUsuario.rolUsuario == 1);
            ventanaCreacion.Show();
            this.Hide();
        }
        public string getUsuario()
        {
            return usuarioTxt.Text;
        }
    }
}
