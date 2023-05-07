using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicio_WCF;

namespace Proyecto_WEB
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Consultar();
                ddlSexo.Items.Insert(0, new ListItem("Seleccionar", ""));
                Calendar1.SelectedDate = DateTime.Today;
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
        protected void Btn_Consultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            using (ServiceReference1.Service1Client service = new ServiceReference1.Service1Client())
            {
                GridView1.DataSource = service.Consultar();
                GridView1.DataBind();
            }
        }
        private void Actualizar(int codpersona, string nombre, DateTime fecha, string Sexo)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            service.Actualizar(codpersona, nombre, fecha, Sexo);
        }
        private void Eliminar(int codpersona)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            service.Eliminar(codpersona);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                string cod = row.Cells[0].Text;

                Eliminar(Convert.ToInt32(cod));
                Consultar();
            }
            if (e.CommandName == "Modificar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                string cod = row.Cells[0].Text;
                string nombre = row.Cells[1].Text;
                string fecha = row.Cells[2].Text;
                string sexo = row.Cells[3].Text;

                txtCod_Mod.Text = cod;
                txtNombre_Mod.Text = nombre;
                Calendar1.SelectedDate = Convert.ToDateTime(fecha);
                ddlSexo.Text = sexo;

            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtCod_Mod.Visible = true;
            txtNombre_Mod.Visible = true;
            Calendar1.Visible = true;
            ddlSexo.Visible = true;

            lblCod.Visible = true;  
            lblNombre.Visible = true;
            lblFecha.Visible = true;
            lblSexo.Visible = true;
            btn_Aceptar_Mod.Visible = true;
        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCod_Mod.Text);
            string nombre = txtNombre_Mod.Text;
            DateTime fecha = Calendar1.SelectedDate;
            string sexo = ddlSexo.SelectedItem.Text;
            if (ddlSexo.SelectedIndex == 0)
            {
                string script = "alert('Por favor seleccione un sexo');";
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", script, true);
            }

            if(txtCod_Mod.Text != null && txtNombre_Mod.Text != "" && ddlSexo.SelectedIndex != 0)
            {
                Actualizar(cod, nombre, fecha, sexo);

                Consultar();

                txtCod_Mod.Visible = false;
                txtNombre_Mod.Visible = false;
                Calendar1.Visible = false;
                ddlSexo.Visible = false;
                lblCod.Visible = false;
                lblNombre.Visible = false;
                lblFecha.Visible = false;
                lblSexo.Visible = false;
                btn_Aceptar_Mod.Visible = false;
            }
        }
    }
}