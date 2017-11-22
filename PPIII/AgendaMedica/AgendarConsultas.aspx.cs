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

        for (int i = 0; i < 60; i++)
            if (i < 10)
                ddlMinuto.Items.Add("0" + i);
            else
                ddlMinuto.Items.Add("" + i);

        ddlDuracaoCons.Items.Add("30 min");
        ddlDuracaoCons.Items[0].Value = "30";
        ddlDuracaoCons.Items.Add("45 min");
        ddlDuracaoCons.Items[1].Value = "45";
        ddlDuracaoCons.Items.Add("1 hora");
        ddlDuracaoCons.Items[2].Value = "60";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(ddlMedicos.SelectedValue);

        int duracao = Convert.ToInt32(ddlDuracaoCons.SelectedValue);
        DateTime dataHora = cldDatas.SelectedDate;
        dataHora.AddHours(Convert.ToDouble(ddlHora.SelectedValue));
        dataHora.AddMinutes(Convert.ToDouble(ddlMinuto.SelectedValue));
        if (dataHora.CompareTo(DateTime.Now)<0)
        {
            lblErro.Text = "Não é possível marcar uma consulta numa hora passada";
            return;
        }
        if (dataHora.CompareTo(DateTime.Now.AddDays(1)) < 0)
        {
            lblErro.Text = "Uma consulta só pode ser marcada com mais de um dia de antecedência";
            return;
        }
        if (!ConsultaDao.horarioDisponivel(dataHora, duracao, id))
        {
            lblErro.Text = "Horário indisponível";
            return;
        }


        Consulta novaCons = new Consulta();
        novaCons.Paciente = (Paciente)Session["USUARIO"];
        novaCons.Medico = new Medico();
        novaCons.Medico.IdMedico = id;
        novaCons.DataConsulta = dataHora;
        novaCons.InicioConsulta = dataHora;
        novaCons.Duracao = duracao;

        if(ConsultaDao.inserirConsulta(novaCons))
            lblErro.Text = "Consulta agendada com sucesso";
        else
            lblErro.Text = "Houve um erro durante o agendamento, por favor tente novamente";
    }
}