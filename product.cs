sing System;
using INMS.BAL;
using INMS.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace INMS
{
    public partial class PRODUCT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static string Save(int USERID, string PNAME, string DISCRIPTION, string CATEGORY, string BRAND, int COST, DateTime DATE, string IOENT, int QUNTITY)
        {
            string str = "";
            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();

            objBal.USERID = USERID;
            objBal.PNAME = PNAME;
            objBal.DISCRIPTION = DISCRIPTION;
            objBal.CATEGORY = CATEGORY;
            objBal.IOENT = IOENT;
            objBal.BRAND = BRAND;
            objBal.QUNTITY = QUNTITY;
            objBal.COST = COST;
            objBal.DATE = DATE;

            str = objBll.product(objBal);

            return str;
        }

        [System.Web.Services.WebMethod]
        public static string GetAll()
        {
            string str = "";
            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();

            DataTable dt = objBll.GetALl(objBal);

            dt.TableName = "tblData";
            using (StringWriter sw = new StringWriter())
            {
                dt.WriteXml(sw);
                str = sw.ToString();
            }
            return str;
        }
        [System.Web.Services.WebMethod]
        public static string GETDETAIL(int PID)
        {
            string str = "";
            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();
            objBal.PID = PID;

            DataTable dt = objBll.GETDETAIL(objBal);

            dt.TableName = "tblData";
            using (StringWriter sw = new StringWriter())
            {
                dt.WriteXml(sw);
                str = sw.ToString();
            }
            return str;
        }
        [WebMethod]
        public static string GetPRODUCT()
        {
            string str = "";

            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();
            objBal.ACTION = "BINDPRODUCT1";
            DataTable dt = objBll.GetPRODUCT(objBal);
            dt.TableName = "tblData";
            using (StringWriter sw = new StringWriter())
            {
                dt.WriteXml(sw);
                str = sw.ToString();
            }
            return str;

        }
        [WebMethod]
        public static string Getcategory()
        {
            string str = "";

            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();
            objBal.ACTION = "BINDCATEGORY";
            DataTable dt = objBll.Getcategory(objBal);
            dt.TableName = "tblData";
            using (StringWriter sw = new StringWriter())
            {
                dt.WriteXml(sw);
                str = sw.ToString();
            }
            return str;

        }

        [WebMethod]
        public static string GetBRAND(string CATEGORY)
        {
            string str = "";

            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();
            objBal.ACTION = "BINDBRAND1";
            objBal.CATEGORY = CATEGORY;
            DataTable dt = objBll.GetBRAND(objBal);
            dt.TableName = "tblData";
            using (StringWriter sw = new StringWriter())
            {
                dt.WriteXml(sw);
                str = sw.ToString();
            }
            return str;

        }


        [System.Web.Services.WebMethod]
        public static string UPDATE(int USERID, int PID, string PNAME, string DISCRIPTION, string CATEGORY, string BRAND, int COST, DateTime DATE, string IOENT, int QUNTITY)
        {
            string str = "";
            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();
            objBal.USERID = USERID;
            objBal.PID = PID;
            objBal.PNAME = PNAME;
            objBal.DISCRIPTION = DISCRIPTION;
            objBal.CATEGORY = CATEGORY;
            objBal.BRAND = BRAND;
            objBal.COST = COST;
            objBal.DATE = DATE;
            objBal.IOENT = IOENT;
           
            objBal.QUNTITY = QUNTITY;

            str = objBll.UPDATE(objBal);


            return str;
        }

        [System.Web.Services.WebMethod]
        public static string DELETE(int PID)
        {
            string str = "";
            BAL_PRODUCT objBal = new BAL_PRODUCT();
            BLL_PRODUCT objBll = new BLL_PRODUCT();
            objBal.PID = PID;

            str = objBll.Delete(objBal);

            return str;
        }
    }
}
