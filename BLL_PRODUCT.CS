using INMS.BAL;
using INMS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace INMS.BLL
{
    public class BLL_PRODUCT
    {
        public DataTable Getcategory(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.Getcategory(objBal);
        }
        public DataTable GetBRAND(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.GetBRAND(objBal);
        }
        public string product(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.product(objBal);
        }
        public DataTable GetALl(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.GetALl(objBal);
        }
        public DataTable GETDETAIL(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.GETDETAIL(objBal);
        }

        public string Delete(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.Delete(objBal);
        }
        public string UPDATE(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.UPDATE(objBal);
        }
       
        public DataTable Getproduct(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.Getproduct(objBal);
        }
        public DataTable GetPRODUCT(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.GetPRODUCT(objBal);
        }
        public DataTable PRODUCTQTY(BAL_PRODUCT objBal)
        {
            DAL_PRODUCT ObjDal = new DAL_PRODUCT();
            return ObjDal.PRODUCTQTY(objBal);
        }
      
    }
}
