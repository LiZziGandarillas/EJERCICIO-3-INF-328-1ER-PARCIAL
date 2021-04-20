using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string nombres, apellidos, phpT;
        nombres = Request.QueryString["nombres"];
        apellidos = Request.QueryString["apellidos"];
        phpT = Request.QueryString["phptime"];
        Response.Write("<title>Ejercicio 3 NET</title>");
        Response.Write("<h1>Bienvenid@ a NET:</h1>");
        Response.Write("<h3>" + nombres + " " + apellidos + "</h3>");
        Response.Write("<br> PHP: " + phpT);
        String timeNet = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToLongTimeString();
        Response.Write("<br>Net: " + timeNet);
        if(nombres!=null && apellidos != null && phpT != null && timeNet != null)
        {
            nombres = nombres.Replace(" ", "-");
            apellidos = apellidos.Replace(" ", "-");
            phpT = phpT.Replace(" ", "-");
            timeNet = timeNet.Replace(" ", "-");
        }
        Response.Write("<form method='GET' action='http://localhost:8080/mavenproject1/NewServlet'><input type = 'hidden' name = 'nombresNet' value = "+nombres+ "><input type = 'hidden' name = 'apellidosNet' value = "+apellidos+"><input type = 'hidden' name = 'phptimeNet' value = "+phpT+"><input type = 'hidden' name = 'nettime' value = "+timeNet+ "><br/> <br/><input type = 'submit' name = 'Enviar'/></form> <br><br>" + timeNet.Replace("-", " "));

    }
}