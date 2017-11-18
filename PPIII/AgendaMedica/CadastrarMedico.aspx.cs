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
        // validar se está em branco

        Medico medico = new Medico();

        if (txtSenha.Text == txtConfirmacaoSenha.Text)
        {
            medico.Senha = txtSenha.Text;
            // alerta erro
            return;
        }

        medico.Email = txtEmail.Text;
        medico.Nome = txtNome.Text;
        medico.Especializacao = new Especializacao();
        medico.Especializacao.IdEspecializacao = Convert.ToInt32(ddEspecialidade.SelectedValue);
        medico.Celular = txtCelular.Text;
        medico.Tipo = TipoUsuario.MEDICO;

        MedicoDao.CadastrarMedico(medico);
        
    }
}