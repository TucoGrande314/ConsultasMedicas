using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgendarConsultas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(ddlMedicos.SelectedValue);
        DateTime dataHora = cldDatas.SelectedDate;
        if (!ConsultaDao.horarioDisponivel(dataHora, id))
            lblErro.Text = "Horário indisponível";
    }
}