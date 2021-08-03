using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVtest.MasterPages
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                iblNombrePersona.Text = ConfigurationManager.AppSettings["NombrePersona"] ?? "(Definir en Web.Config;)";
            }
        }
    }
}