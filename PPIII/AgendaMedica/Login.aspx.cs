using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            logar(usuario);
        }
        else
        {
            // alerta o erro
        }
    }

    public void logar(Usuario usuario)
    {
        switch (usuario.Tipo){
            case TipoUsuario.MEDICO:
                Session["USUARIO"] = MedicoDao.UsuarioToMedico(usuario);
                break;
            case TipoUsuario.SECRETARIA:
                Session["USUARIO"] = SecretariaDao.UsuarioToSecretaria(usuario);
                break;
            case TipoUsuario.PACIENTE:
                Session["USUARIO"] = PacienteDao.UsuarioToPaciente(usuario);
                break;
            default:
                Session["USUARIO"] = usuario;
                break;
        }

        Response.Redirect("./Default.aspx");
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        if(txtNome.Text.Trim()==""|| txtDataNasc.Text.Trim()==""||
           txtCelular.Text.Trim()=="" || txtEndereco.Text.Trim()==""||
           txtEmailCadastro.Text.Trim()==""|| txtSenhaCadastro.Text.Trim()==""||
           txtConfSenha.Text.Trim()=="")
           {
            //alerta erro
            return;
           }
        if(txtSenhaCadastro!=txtConfSenha) 
        {
            //alerta erro
            return;
        }

        Paciente novoPac= new Paciente();
        novoPac.Nome = txtNome.Text;
        novoPac.DataNascimento = DateTime.Parse(txtNome.Text);
        novoPac.Celular = txtCelular.Text;
        novoPac.Endereco = txtEndereco.Text;
        novoPac.Email = txtEmailCadastro.Text;
        novoPac.Senha = txtSenhaCadastro.Text;

            PacienteDao.CadastrarPaciente(novoPac);
    }
}