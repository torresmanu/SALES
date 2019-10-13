﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Clases;
using FrbaOfertas.gestionUsuarios;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.Datos;

namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.texto(txtNom,errorNombre);
        }

        private void txtApe_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.texto(txtApe, errorApe);
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.numerico(txtDni,errorDni);
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            ValidadorCampos.numerico(txtTel, errorTel);
        }

        private void txtCodP_Leave(object sender, EventArgs e)
        {
            errorCodP.Clear();
            if (txtCodP.Text.Length > 8)
                errorCodP.SetError(txtCodP, "Máximo 8 caracteres");
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            using (CreacionUsuario ventanaCreacion = new CreacionUsuario(this, "3", InfoUsuario.rolUsuario == 1))
            {
                if (ventanaCreacion.ShowDialog() == DialogResult.OK)
                {
                    textIdUsuario.Text = ventanaCreacion.nombreIngresado;
                    textIdUsuario.ReadOnly = true;
                    btnNuevoUser.Hide();
                    txtNoTieneUser.Hide();
                }
            }
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            
            SqlConnection conex = Conexiones.AbrirConexion();
            try
            {
                if (camposValidos())
                {
                    SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].altaCliente", conex);
                    procedure.CommandType = CommandType.StoredProcedure;
                    procedure.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = textIdUsuario.Text;
                    procedure.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = txtNom.Text;
                    procedure.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = txtApe.Text;
                    procedure.Parameters.Add("@dni", SqlDbType.Int).Value = txtDni.Text;
                    procedure.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txtMail.Text;
                    procedure.Parameters.Add("@telefono", SqlDbType.Int).Value = txtTel.Text;
                    procedure.Parameters.Add("@domicilio", SqlDbType.NVarChar).Value = txtDom.Text;
                    procedure.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = txtLocalidad.Text;
                    procedure.Parameters.Add("@codigo_postal", SqlDbType.NVarChar).Value = txtCodP.Text;
                    procedure.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = fechaNac.Text;

                    procedure.ExecuteNonQuery();
                    Conexiones.CerrarConexion();
                    MessageBox.Show("Cliente creado correctamente", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Complete todos los campos para seguir", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique el formato de los campos completados", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private bool camposValidos()
        {
            return noTienenError() && estanCompletos();
        }
        
        private bool noTienenError()
        {
            return errorNombre.GetError(txtNom)+errorApe.GetError(txtApe)+errorDni.GetError(txtDni)+
                    errorTel.GetError(txtTel) + errorCodP.GetError(txtCodP)+errorUserId.GetError(textIdUsuario) == "";
        }

        private bool estanCompletos()
        {
            return txtNom.Text != "" && txtApe.Text != "" && txtDni.Text != "" && txtTel.Text != ""
                && txtMail.Text != "" && fechaNac.Text != "" && textIdUsuario.Text != "" && 
                txtLocalidad.Text != "" && txtCodP.Text != "" && txtDom.Text != "" ;
        }

        private void textIdUsuario_Leave(object sender, EventArgs e)
        {
            errorUserId.Clear();
            try
            {
                SqlConnection conex = Conexiones.AbrirConexion();
                SqlCommand procedure = new SqlCommand("[NUNCA_INJOIN].esUsuarioExistente", conex);
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = textIdUsuario.Text;
                procedure.Parameters.Add("@rol_id", SqlDbType.Int).Value = "3";
                procedure.ExecuteNonQuery();
                Conexiones.CerrarConexion();
            }
            catch (Exception ex)
            {
                errorUserId.SetError(textIdUsuario, ex.Message);
            }
        }
    }
}
