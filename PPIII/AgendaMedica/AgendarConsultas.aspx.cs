using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AgendarConsultas : System.Web.UI.Page
{
    List<Medico> medicos;
    protected void Page_Load(object sender, EventArgs e)
    {
        medicos = MedicoDao.getMedicos();
        for(int i = 0; i<medicos.Count; i++)
        {
            lbxMedicos.Items.Add(medicos[i].Nome);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime data = cldDatas.SelectedDate;
        data.AddDays(1);
        if (data.CompareTo(DateTime.Now) <= 0)
        {
            lblErro.Text = "Uma consulta só pode ser marcada com mais de um dia de antecedência";
            return;
        }
        if (lbxMedicos.SelectedIndex < 0)
        {
            lblErro.Text = "Selecione um médico para consulta-lo";
            return;
        }

    }
}