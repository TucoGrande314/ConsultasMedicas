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
        preencherHorarios();
    }
    private void preencherHorarios()
    {
        for (int i = 0; i < 24; i++)
            if (i < 10)
                ddlHora.Items.Add("0" + i);
            else
                ddlHora.Items.Add(""+i);

        for(int i =0; i<60; i++)
            if (i < 10)
                ddlMinuto.Items.Add("0" + i);
            else
                ddlMinuto.Items.Add("" + i);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(ddlMedicos.SelectedValue);

        DateTime dataHora = cldDatas.SelectedDate;
        dataHora.AddHours(Convert.ToDouble(ddlHora.SelectedValue));
        dataHora.AddMinutes(Convert.ToDouble(ddlMinuto.SelectedValue));

        if (!ConsultaDao.horarioDisponivel(dataHora, id))
        {
            lblErro.Text = "Horário indisponível";
            return;
        }
        if (dataHora.CompareTo(DateTime.Now)<0)
        {
            lblErro.Text = "Não é possível marcar uma consulta numa hora passáda";
            return;
        }
        if (dataHora.CompareTo(DateTime.Now.AddDays(1)) < 0)
        {
            lblErro.Text = "Uma consulta só pode ser marcada";
            return;
        }


    }
}