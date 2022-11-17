using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_SACA
{
    public partial class _Default : Page
    {
        
        private Int32 numero;

        public int Numero { get => numero; set => numero = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                numero = Convert.ToInt32(txt_numero.Text);
                if (numero >= 0 && numero <= 500)
                {
                    string resultado = string.Empty;

                    for(int i = 0; i <= numero; i++)
                    {
                        if (i % 2 == 0) {
                           
                            resultado += i + " ,";
                        }
                    } 
                    lbl_resultado.Text = resultado;
                }
                //throw new Exception("Se ha producido un error no controlado.");
            }
            catch (Exception ex)
            {
                string script = @"<script type='text/javascript'>
                            alert('{0}');
                        </script>";

                script = string.Format(script, ex.Message);

                ScriptManager.RegisterStartupScript(this, typeof(Page), "Alerta", script, false);

            }
        }
    }
}