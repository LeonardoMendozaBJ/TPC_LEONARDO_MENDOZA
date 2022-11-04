using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPcuatrimestral_Leonardo_Mendoza
{
    public partial class Depositos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ListaDeposito"] == null)
            {
                DepositoNegocio negocio = new DepositoNegocio();
                Session.Add("ListaDeposito", negocio.listar());

            }


            dgvDepositos.DataSource = Session["ListaDeposito"];
            dgvDepositos.DataBind();

            List<Deposito> listaSession = new List<Deposito>();
            listaSession = (List<Deposito>)Session["ListaDeposito"];
            

        }
    }
    
}