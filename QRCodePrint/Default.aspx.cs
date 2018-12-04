using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QRCodePrint
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.Browser.Browser.Contains("Firefox"))
            {
                Response.Redirect("~/Tools/error.html");
            }
            else
            {           

                bool auth =User.Identity.IsAuthenticated;
            if (!auth)
            {
                HttpCookie valid = new HttpCookie("Valid")
                {
                    Value = "true",

                };

                Response.SetCookie(valid);

               
            }
            else
            {
                Response.Cookies["Valid"].Expires = DateTime.Now.AddMinutes(-5);
            }


                //     Session["name"] = "yuchengren";

            }
        }
    }
}