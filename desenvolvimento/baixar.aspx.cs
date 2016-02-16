using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VhsAsp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //{ 
            //  Dim objConexao As MySqlConnection = New MySqlConnection(ConfigurationManager.AppSettings("strConexao"))
            //Dim command As MySqlCommand = New MySqlCommand(sql, objConexao)
            
            //}

            string sqlQuery = "SELECT * FROM tipo_cfop  ";

            //MySqlConnection objConexao = new MySqlConnection(ConfigurationManager.AppSettings["MYconn"]);
            //MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            //objAdapter.SelectCommand = new MySqlCommand(sqlQuery, objConexao);
            //objConexao.Open();
            //DataSet ds = new DataSet();
            //objAdapter.Fill(ds);
            //GridView1.DataSource = ds;
            //GridView1.DataBind();

           


            if (!IsPostBack)
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Server.MapPath("~/arquivos/"));
                System.IO.FileInfo[] fi = di.GetFiles();

                foreach (System.IO.FileInfo arquivo in fi)
                    ListBox1.Items.Add(arquivo.Name);
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            System.IO.FileInfo arquivo = new System.IO.FileInfo(Server.MapPath("~/arquivos/")+ ListBox1.SelectedValue);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + arquivo.Name);
            Response.AddHeader("Content-Length", arquivo.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(arquivo.FullName);
            Response.End();
        }

        
    }
}