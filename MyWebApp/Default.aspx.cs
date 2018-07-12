using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace MyWebApp
{
    public partial class _Default : Page
    {
        public static string textDataSource = @"Server=IH-CHIPC227;Database=MyDBSB_Test;Trusted_Connection=true";

        protected void Page_Load(object sender, EventArgs e)
        {
            //@"Data Source = (localhost)\IH-CHIPC227; Integrated Security = True; Initial Catalog = MyDBSB_Test"
            //SqlConnection sqlCon = new SqlConnection(@"Data Source = localhost\IH - CHIPC227; Integrated Security = SSPI; Initial Catalog = MyDBSB_Test;");
            //SqlDataAdapter da = new SqlDataAdapter("Select * from PetStore", sqlCon);
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = SQL;
            //da.SelectCommand = cmd;
            //DataSet ds = new DataSet();

            //conn.Open();
            //da.Fill(ds);
            //conn.Close();



            SqlConnection cnn;
                SqlDataAdapter dad;
                DataSet dts = new DataSet();
                cnn = new SqlConnection(textDataSource);
                dad = new SqlDataAdapter("Select * from PetStore", cnn);
               
                cnn.Open();
                dad.Fill(dts);
            GridView1.DataSource = dts;
            GridView1.DataBind();
           
            cnn.Close();


            using (SqlConnection connection = new SqlConnection(textDataSource))
            {
                var petStore = connection.Query<PetStore>("Select * from PetStore").ToList();
                foreach (PetStore ps in petStore)
                {
                    Label1.Text += ps.Item + "<br />";
                }
            }
           






        }
    }
}