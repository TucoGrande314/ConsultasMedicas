using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CadastrarMedico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        if (validarCampos())
        {
            Medico medico = new Medico();

            medico.Email = txtEmail.Text;
            medico.Senha = txtSenha.Text;

            if (!UsuarioDao.existeUsuario(medico.Email))
            {
                medico.Nome = txtNome.Text;
                medico.Especializacao = new Especializacao();
                medico.Especializacao.IdEspecializacao = Convert.ToInt32(ddEspecialidade.SelectedValue);
                medico.Celular = txtCelular.Text;
                medico.Tipo = TipoUsuario.MEDICO;

                cadastrarMedico(medico);
            }
            else
            {
                alertarErro("Esse email já existe está cadastrado no sistema");
            }
        }
    }

    protected bool validarCampos()
    {
        // validar se está em branco
        if (txtEmail.Text.Trim() == "")
        {
            alertarErro("Preencha o campo 'email'.");
            return false;
        }
        if (txtSenha.Text.Trim() == "")
        {
            alertarErro("Preencha o campo 'senha'.");
            return false;
        }
        if (txtConfirmacaoSenha.Text.Trim() == "")
        {
            alertarErro("Preencha o campo 'confirmação de senha'.");
            return false;
        }
        if (txtNome.Text.Trim() == "")
        {
            alertarErro("Preencha o campo 'nome'.");
            return false;
        }
        if (txtCelular.Text.Trim() == "")
        {
            alertarErro("Preencha o campo 'celular'.");
            return false;
        }
        if (txtSenha.Text != txtConfirmacaoSenha.Text)
        {
            return false;
        }

        return true;
    }

    protected void cadastrarMedico(Medico medico)
    {
        if (MedicoDao.CadastrarMedico(medico))
        {
            alertarSucesso("Médico cadastrado com sucesso!");
        }
        else
        {
            alertarErro("Não foi possível cadastrar o médico");
        }
    }

    protected void alertarErro(String mensagem)
    {
        this.lbErro.Text = mensagem;
        this.lbErro.Visible = true;
        this.lbSucesso.Visible = false;
    }

    protected void alertarSucesso(String mensagem)
    {
        this.lbSucesso.Text = mensagem;
        this.lbErro.Visible = false;
        this.lbSucesso.Visible = true;
    }
}