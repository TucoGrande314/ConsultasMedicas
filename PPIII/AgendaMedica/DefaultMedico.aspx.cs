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
        selecionarConsulta();
    }

    protected bool haConsulta()
    {
        return gvConsultas.Rows.Count > 0;
    }


    protected void selecionarConsulta()
    {
        if(haConsulta())
        {
            if (gvConsultas.SelectedRow != null)
            {
                
                lbPaciente.Text = gvConsultas.SelectedRow.Cells[1].Text;
                lbData.Text = gvConsultas.SelectedRow.Cells[3].Text;
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