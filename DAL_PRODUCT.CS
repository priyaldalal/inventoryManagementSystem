sing System;
using INMS.BAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace INMS.DAL
{
    public class DAL_PRODUCT : Conection
    {
        string str = "";
        public string product(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", "INSERT");
                cmd.Parameters.AddWithValue("USERID", objBal.USERID);
                cmd.Parameters.AddWithValue("PNAME", objBal.PNAME);
                cmd.Parameters.AddWithValue("PDISCRIPTION", objBal.DISCRIPTION);
                cmd.Parameters.AddWithValue("CATEGORY", objBal.CATEGORY);
                cmd.Parameters.AddWithValue("BRAND", objBal.BRAND);
                cmd.Parameters.AddWithValue("QUNTITY", objBal.QUNTITY);
                cmd.Parameters.AddWithValue("IOENT", objBal.IOENT);
                cmd.Parameters.AddWithValue("COST", objBal.COST);
                cmd.Parameters.AddWithValue("DATE", objBal.DATE);


                cmd.Parameters.Add("MSG", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                str = cmd.Parameters["MSG"].Value.ToString();
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            finally
            {
                disconnect();
            }
            return str;
        }

        public DataTable GetALl(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", "SELALL");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            finally
            {
                disconnect();
            }
            return dt;
        }

        public DataTable GETDETAIL(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", "SEL");
                cmd.Parameters.AddWithValue("PID", objBal.PID);
                da.Fill(dt);
            }
            catch (Exception)
            {
            }
            finally
            {
                disconnect();
            }
            return dt;
        }

        //public string Delete(BAL_PRODUCT objBal)
        //{
        //    str = "";
        //    try
        //    {
        //        Connect();
        //        cmd.Connection = con;
        //        cmd.CommandText = "dbo.SP_PRODUCT";
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("ACTION", "DELETE");
        //        cmd.Parameters.AddWithValue("PID", objBal.PID);

        //        cmd.Parameters.Add("MSG", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
        //        cmd.ExecuteNonQuery();
        //        str = cmd.Parameters["MSG"].Value.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        str = ex.Message;
        //    }
        //    finally
        //    {
        //        disconnect();
        //    }
        //    return str;
        //}


        public string UPDATE(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", "UPDATE");
                cmd.Parameters.AddWithValue("PID", objBal.PID);
                cmd.Parameters.AddWithValue("PNAME", objBal.PNAME);
                cmd.Parameters.AddWithValue("PDISCRIPTION", objBal.DISCRIPTION);
                cmd.Parameters.AddWithValue("CATEGORY", objBal.CATEGORY);
                cmd.Parameters.AddWithValue("BRAND", objBal.BRAND);
                cmd.Parameters.AddWithValue("COST", objBal.COST);
                cmd.Parameters.AddWithValue("DATE", objBal.DATE);
                cmd.Parameters.AddWithValue("IOENT", objBal.IOENT);
                cmd.Parameters.AddWithValue("QUNTITY", objBal.QUNTITY);


                cmd.Parameters.Add("MSG", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                str = cmd.Parameters["MSG"].Value.ToString();
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            finally
            {
                disconnect();
            }
            return str;
        }


       

        public DataTable Getcategory(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", objBal.ACTION);
                //cmd.Parameters.AddWithValue("PRODUCT", objBal.PRODUCT);
                cmd.Parameters.AddWithValue("CID", objBal.CID);
                cmd.Parameters.AddWithValue("PDISCRIPTION", objBal.DISCRIPTION);
                cmd.Parameters.AddWithValue("CNAME", objBal.CNAME);
               
               
                da.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                disconnect();
            }
            return dt;
        }
        public DataTable GetPRODUCT(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", objBal.ACTION);
                cmd.Parameters.AddWithValue("PID", objBal.PID);
                
                cmd.Parameters.AddWithValue("PNAME", objBal.PNAME);


                da.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                disconnect();
            }
            return dt;
        }

        public DataTable GetBRAND(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", objBal.ACTION);
                cmd.Parameters.AddWithValue("CATEGORY", objBal.CATEGORY);
                cmd.Parameters.AddWithValue("BID", objBal.BID);
                cmd.Parameters.AddWithValue("BNAME", objBal.BNAME);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                disconnect();
            }
            return dt;
        }

        public string Delete(BAL_PRODUCT objBal)
        {
            str = "";
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", "DELETE");
                cmd.Parameters.AddWithValue("PID", objBal.PID);

                cmd.Parameters.Add("MSG", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                str = cmd.Parameters["MSG"].Value.ToString();
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            finally
            {
                disconnect();
            }
            return str;
        }

        public DataTable Getproduct(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", objBal.ACTION);
                cmd.Parameters.AddWithValue("CID", objBal.PID);
                cmd.Parameters.AddWithValue("PRICE", objBal.COST);
                cmd.Parameters.AddWithValue("CNAME", objBal.PNAME);


                da.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                disconnect();
            }
            return dt;
        }

        public DataTable PRODUCTQTY(BAL_PRODUCT objBal)
        {
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "dbo.SP_PRODUCT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ACTION", "SELALL1");
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            finally
            {
                disconnect();
            }
            return dt;
        }

        

    }
}
