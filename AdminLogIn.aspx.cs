using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SVARD_Shopping
{
    public partial class AdminLogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (Session["Admin"] != null)
            {


                if (Session["Admin"].ToString() == "admin")
                {


                    Response.Redirect("Index.aspx");
                }

            }
            HttpCookie c1 = Request.Cookies["MyData"];


            */



        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(TextBox2.Text=="admin" && TextBox3.Text=="admin")
            {
                //Response.Redirect("AddProduct.aspx");
              
              /* HttpCookie c1 = new HttpCookie("MyData");
                c1["Id"] = "admin";
                c1["pass"] = "admin";
               
                Response.Cookies.Add(c1);

                Session["Admin"] = c1["Id"];
                Session.Timeout = 1;
                */
                Response.Redirect("AddProduct.aspx");


            }



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}