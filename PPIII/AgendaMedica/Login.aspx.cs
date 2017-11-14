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
                Response.Redirect("./DefaultMedico.aspx");
                break;
            case TipoUsuario.SECRETARIA:
                Session["USUARIO"] = SecretariaDao.UsuarioToSecretaria(usuario);
                break;
            case TipoUsuario.PACIENTE:
                Session["USUARIO"] = PacienteDao.UsuarioToPaciente(usuario);
                Response.Redirect("./DefaultPaciente.aspx");
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
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Preencha todos os campos para relizar o cadastro')", true);
            return;
           }
        if(txtSenhaCadastro.Text!=txtConfSenha.Text) 
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('A senhas não batem')", true);
            return;
        }

        Paciente novoPac= new Paciente();
        novoPac.Nome = txtNome.Text;
        novoPac.DataNascimento = DateTime.Parse(txtDataNasc.Text);
        novoPac.Celular = txtCelular.Text;
        novoPac.Endereco = txtEndereco.Text;
        novoPac.Email = txtEmailCadastro.Text;
        novoPac.Senha = txtSenhaCadastro.Text;
        novoPac.Tipo = TipoUsuario.PACIENTE;
        try
        {
            PacienteDao.CadastrarPaciente(novoPac);
        }
        catch(InsertPacientException er)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('"+er.ToString()+"')", true);
        }
        catch (InsertUsuarioException er)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + er.ToString() + "')", true);
        }
        catch (UsuarioNotFoundException er)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + er.ToString() + "')", true);
        }

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Usuário cadastrado com sucesso, faça seu login')", true);
    }
}