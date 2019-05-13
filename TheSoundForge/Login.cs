using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheSoundForge
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }


        private bool ValidarLogin()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexão.conectar();
            cmd.Connection.Open();
            cmd.CommandText = "select 1 as validador from tbFuncionario where usuario = @user and senha = @pass;";

            cmd.Parameters.Add("@user", SqlDbType.VarChar, 20).Value = txtUser.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 10).Value = txtPass.Text;

            bool usuarioExistente = false;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarioExistente = true;
            }
            dr.Close();
            cmd.Connection.Close();
            return usuarioExistente == true;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnter_Click(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnter_Click(sender, e);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (ValidarLogin())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
