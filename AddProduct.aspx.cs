using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using System.Data.SqlClient;

namespace SVARD_Shopping
{
    public partial class AddProduct : System.Web.UI.Page
    {

        static String imagelink;
        protected void Page_Load(object sender, EventArgs e)
        {


            getproductid();
            /* if (!IsPostBack)
             {
                 getproductid();
             }
        */


        }

        protected void Button1_Click(object sender, EventArgs e)
        {


                /*
            if (uploadimage() == true)
            {

                String query = "insert into rohit_Product(productid,productname,price,productimage,productsearch,category) values(" + Convert.ToInt16(Label4.Text) + ",'" + TextBox1.Text + "','" + Convert.ToInt32(TextBox2.Text) + "','" +  + "','" + TextBox3.Text + "','" + DropDownList1.SelectedItem.Value + "')";
                String mycon = "Data Source = ndamssql\\sqlilearn; Initial Catalog = Training_19Sep18_Pune; User ID = sqluser; Password = sqluser";
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Label3.Text = "Product Has Been Successfully Saved";

                TextBox1.Text = "";
                TextBox2.Text = "";
            }

            */


        }
        /*
        private Boolean uploadimage()
        {
            /*Boolean imagesaved = false;
            if (FileUpload1.HasFile == true)
            {

                String contenttype = FileUpload1.PostedFile.ContentType;

                if (contenttype == "image/jpeg")
                {

                    FileUpload1.SaveAs(Server.MapPath("~/images/") + Label3.Text + ".jpg");
                    imagelink = "images/" + Label3.Text + ".jpg";
                    imagesaved = true;
                }
                else
                {
                    Label3.Text = "Kindly Upload JPEG Format Image Only";
                }

            }

            else
            {
                Label3.Text = "You have not selected any file - Browse and Select File First";
            }

            return imagesaved;
            
        }
        */
       public void getproductid()
          {
              String mycon = "Data Source = ndamssql\\sqlilearn; Initial Catalog = Training_19Sep18_Pune; User ID = sqluser; Password = sqluser";
              SqlConnection scon = new SqlConnection(mycon);
              String myquery = "select productid from rohit_Product";
              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = myquery;
              cmd.Connection = scon;
              SqlDataAdapter da = new SqlDataAdapter();
              da.SelectCommand = cmd;
              DataSet ds = new DataSet();
              da.Fill(ds);
              scon.Close();
              if (ds.Tables[0].Rows.Count < 1)
              {
                  Label4.Text = "1001";
              }
              else
              {
                  String mycon1 = "Data Source = ndamssql\\sqlilearn; Initial Catalog = Training_19Sep18_Pune; User ID = sqluser; Password = sqluser";
                  SqlConnection scon1 = new SqlConnection(mycon1);
                  String myquery1 = "select max(productid) from rohit_Product";
                  SqlCommand cmd1 = new SqlCommand();
                  cmd1.CommandText = myquery1;
                  cmd1.Connection = scon1;
                  SqlDataAdapter da1 = new SqlDataAdapter();
                  da1.SelectCommand = cmd1;
                  DataSet ds1 = new DataSet();
                  da1.Fill(ds1);
                  Label4.Text = ds1.Tables[0].Rows[0][0].ToString();
                  int a;
                  a = Convert.ToInt16(Label4.Text);
                  a = a + 1;
                  Label4.Text = a.ToString();
                  scon1.Close();
              }
          }
        




    }
}