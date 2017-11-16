using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Relatorios_RelatorioConsultasMes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void dlMedicos_SelectedIndexChanged(object sender, EventArgs e)
    {
        dsConsultasMes.DataBind();
        chart.DataBind();
    }
}