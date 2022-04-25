using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace INMS.DAL
{
   

        public class Conection
        {
            public SqlCommand cmd;
            public SqlConnection con;
            public SqlConnection conSL;
            public SqlDataAdapter da;
            public SqlDataAdapter dr1;
            public DataSet ds;
            public DataTable dt;
            public double max;
            public string msg = "";

            public void Connect()
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConMain"].ConnectionString);
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandTimeout = 0;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                dt = new DataTable();

            }
            public void disconnect()
            {
                con.Close();
            }
            public void disconnectSoundLife()
            {
                conSL.Close();
            }
        }
       
}
