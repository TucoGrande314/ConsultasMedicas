using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        if (txtEmailLogin.Text.Trim() == "")
        {
            // alerta erro 
            return;
        }
        if (txtSenhaLogin.Text.Trim() == "")
        {
            // alerta erro 
            return;
        }

        Usuario usuario = new Usuario();        
        usuario.Email = txtEmailLogin.Text;
        usuario.Senha = txtSenhaLogin.Text;

        usuario = UsuarioDao.LoginValido(usuario);

        if (usuario != null)
        {
            // manda pra tela inicial de usuario
            switch (usuario.Tipo)
            {
                case TipoUsuario.MEDICO:
                    LogarMedico(usuario);
                    break;
                case TipoUsuario.PACIENTE:
                    LogarPaciente(usuario);
                    break;
                case TipoUsuario.SECRETARIA:
                    LogarSecretaria(usuario);
                    break;
            }
        }
        else
        {
            // alerta o erro
        }
    }

    public void LogarMedico(Usuario usuario)
    {

    }

    public void LogarPaciente(Usuario usuario)
    {

    }

    public void LogarSecretaria(Usuario usuario)
    {

    }
}