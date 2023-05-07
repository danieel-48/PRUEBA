using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_WEB
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlSexo.Items.Insert(0, new ListItem("Seleccionar", ""));
                Calendar1.SelectedDate = DateTime.Today;
            }
        }
        private void Registrar(string nombre, DateTime fecha, string sexo)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            service.Registrar(nombre, fecha, sexo);
        }
        protected void btn_Registrar_Mod_Click(object sender, EventArgs e)
        {
            if (ddlSexo.SelectedIndex == 0)
            {
                string script = "alert('Por favor seleccione un sexo');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", script, true);
            }

            if (ddlSexo.SelectedValue != "" && txtNombre_Mod.Text != "" && ddlSexo.SelectedIndex != 0)
            {
                string nombre = txtNombre_Mod.Text;
                DateTime fecha = Calendar1.SelectedDate;
                string sexo = ddlSexo.SelectedItem.Text;
                Registrar(nombre, fecha, sexo);
                string script = "alert('Registrado Correctamente');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", script, true);
                txtNombre_Mod.Text = "";
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date > DateTime.Now.Date)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}