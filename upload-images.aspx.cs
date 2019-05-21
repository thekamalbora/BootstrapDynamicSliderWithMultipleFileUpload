using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace BootstrapDynamicSlider
{
    public partial class upload_images : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                if (img01.HasFile)
                {
                    // Getting the image path.
                    string SavePath = Server.MapPath("~/Images/");

                    // Getting image name.
                    string fileName = Path.GetFileNameWithoutExtension(img01.PostedFile.FileName);

                    // Getting image extension
                    string extension = Path.GetExtension(img01.PostedFile.FileName);

                    //Saving images into folder.
                    img01.SaveAs(SavePath + fileName + extension);

                    SqlCommand cmd1 = new SqlCommand("INSERT INTO tblImages VALUES ('" + fileName + "','" + extension + "')", con);
                    cmd1.ExecuteNonQuery();

                }
                if (img02.HasFile)
                {
                    // Getting the image path.
                    string SavePath = Server.MapPath("~/Images/");

                    // Getting image name.
                    string fileName = Path.GetFileNameWithoutExtension(img02.PostedFile.FileName);

                    // Getting image extension
                    string extension = Path.GetExtension(img02.PostedFile.FileName);

                    //Saving images into folder.
                    img02.SaveAs(SavePath + fileName + extension);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO tblImages VALUES ('" + fileName + "','" + extension + "')", con);
                    cmd2.ExecuteNonQuery();

                }
                if (img03.HasFile)
                {
                    // Getting the image path.
                    string SavePath = Server.MapPath("~/Images/");

                    // Getting image name.
                    string fileName = Path.GetFileNameWithoutExtension(img03.PostedFile.FileName);

                    // Getting image extension
                    string extension = Path.GetExtension(img02.PostedFile.FileName);

                    //Saving images into folder.
                    img03.SaveAs(SavePath + fileName + extension);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO tblImages VALUES ('" + fileName + "','" + extension + "')", con);
                    cmd3.ExecuteNonQuery();

                }
                if (img04.HasFile)
                {
                    // Getting the image path.
                    string SavePath = Server.MapPath("~/Images/");

                    // Getting image name.
                    string fileName = Path.GetFileNameWithoutExtension(img04.PostedFile.FileName);

                    // Getting image extension
                    string extension = Path.GetExtension(img04.PostedFile.FileName);

                    //Saving images into folder.
                    img04.SaveAs(SavePath + fileName + extension);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO tblImages VALUES ('" + fileName + "','" + extension + "')", con);
                    cmd4.ExecuteNonQuery();

                }
                if (img05.HasFile)
                {
                    // Getting the image path.
                    string SavePath = Server.MapPath("~/Images/");

                    // Getting image name.
                    string fileName = Path.GetFileNameWithoutExtension(img05.PostedFile.FileName);

                    // Getting image extension
                    string extension = Path.GetExtension(img05.PostedFile.FileName);

                    //Saving images into folder.
                    img05.SaveAs(SavePath + fileName + extension);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO tblImages VALUES ('" + fileName + "','" + extension + "')", con);
                    cmd5.ExecuteNonQuery();

                }
                lblMessage.Text = "Saved successfully.";
            }
        }
    }
}