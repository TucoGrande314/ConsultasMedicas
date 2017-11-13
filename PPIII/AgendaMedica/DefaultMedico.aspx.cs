using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultMedico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        formatar();
        selecionarConsulta();
    }

    private void formatar()
    {
        for (int i = 0; i < gvConsultas.Rows.Count; i++)
        {
            try
            {
                // formatar data
                gvConsultas.Rows[i].Cells[3].Text = gvConsultas.Rows[0].Cells[3].Text.Split(' ')[0];
                // fortatar inicio
                gvConsultas.Rows[i].Cells[4].Text = gvConsultas.Rows[0].Cells[4].Text.Substring(0, 5);
            }
            catch
            {

            }

        }
    }

    protected bool haConsulta()
    {
        return gvConsultas.Rows.Count > 0;
    }


    protected void selecionarConsulta()
    {
        if (haConsulta())
        {
            if (gvConsultas.SelectedRow != null)
            {
                // nome do paciente
                lbPaciente.Text = gvConsultas.SelectedRow.Cells[1].Text;
                // data da consulta
                lbData.Text = gvConsultas.SelectedRow.Cells[3].Text;
                // data da consulta
                lbHorario.Text = gvConsultas.SelectedRow.Cells[4].Text;

                pnlConsultaSelecionada.Visible = true;
            }
        }

    }

    protected void gvConsultas_SelectedIndexChanged(object sender, EventArgs e)
    {
        selecionarConsulta();
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {

    }
}