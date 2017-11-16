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
    }

    private void formatar()
    {
        for (int i = 0; i < gvConsultas.Rows.Count; i++)
        {
            try
            {
                // formatar data
                gvConsultas.Rows[i].Cells[3].Text = gvConsultas.Rows[i].Cells[3].Text.Split(' ')[0];
                // fortatar inicio
                gvConsultas.Rows[i].Cells[4].Text = gvConsultas.Rows[i].Cells[4].Text.Substring(0, 5);

             /*   if (gvConsultas.SelectedRow.Cells[6].Text == "AGENDADA")
                {
                    gvConsultas.SelectedRow.Cells[6].BackColor = System.Drawing.Color.Yellow;

                }
                else if (gvConsultas.SelectedRow.Cells[6].Text == "OCORRIDA")
                {
                    gvConsultas.SelectedRow.Cells[6].BackColor = System.Drawing.Color.DarkGreen;
                }
                else if (gvConsultas.SelectedRow.Cells[6].Text == "CANCELADA")
                {
                    gvConsultas.SelectedRow.Cells[6].BackColor = System.Drawing.Color.DarkRed;
                }*/
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
                // hora da consulta
                lbHorario.Text = gvConsultas.SelectedRow.Cells[4].Text;
                // status da consulta
                rbStatus.SelectedValue = gvConsultas.SelectedRow.Cells[6].Text;

                var consulta = new Consulta();
                consulta.Id = Convert.ToInt32(gvConsultas.SelectedRow.Cells[7].Text);
                Anotacoes anotacoes = AnotacoesDao.getAnotacao(consulta);

                if (anotacoes != null)
                {
                    txtDiagnostico.Text = anotacoes.Diagnostico;
                    txtMedicamentos.Text = anotacoes.Medicacao;
                }
                else
                {
                    txtMedicamentos.Text = "";
                    txtDiagnostico.Text = "";
                }
                
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
        var consulta = new Consulta();
        consulta.Id = Convert.ToInt32(gvConsultas.SelectedRow.Cells[7].Text);
        consulta.Stat = rbStatus.SelectedValue;

        var anotacoes = new Anotacoes();
        anotacoes.Diagnostico = txtDiagnostico.Text;
        anotacoes.Medicacao = txtMedicamentos.Text;
        anotacoes.Consulta = consulta;
        anotacoes.Resultado = "";

        var anotacoesBanco = AnotacoesDao.getAnotacao(consulta);

        if (anotacoesBanco == null)
        {
            if (AnotacoesDao.cadastrarAnotacoes(anotacoes))
            {
                if (ConsultaDao.cadastrarConsulta(consulta))
                {
                    dsConsultas.DataBind();
                }
            }
        }
        else
        {
            anotacoes.Id = anotacoesBanco.Id;

            if (AnotacoesDao.atualizarAnotacao(anotacoes))
            {
                if (ConsultaDao.cadastrarConsulta(consulta))
                {
                    dsConsultas.DataBind();
                    gvConsultas.DataBind();
                }
            }
        }
    }
}