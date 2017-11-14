using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultPacient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Paciente pac = (Paciente)Session["USUARIO"];
        lblNome.Text = pac.Nome.ToUpper();
        lblEmail.Text = pac.Email.ToUpper();
        lblEndereco.Text = pac.Endereco.ToUpper();
        lblDataNasc.Text = pac.DataNascimento.ToString();
        lblCelular.Text = pac.Celular;
        if (pac.Celular == null)
            imgProfilePic.ImageUrl = "./Images/PROFILE_PIC_NULL.jpg";
        else
        {
            //imgProfilePic.i = pac.Foto;
        }
    }
}