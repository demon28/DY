using DY注册机.XieYi.MashangModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY注册机.XieYi
{
   public class MaShang
    {
        //http://api.myzjxl.com:8080/Login/?username=用户名&password=密码   登录


           public string Msg { get; set; }

        public bool Login(string username,string pwd,ref LoginModel model)
        {
            try
            {

          
            string value=   HttpHelper.HttpGet("http://api.myzjxl.com:8080/Login/", "username="+username+"&password="+pwd);

             model = new LoginModel();
            model.issuccess = value.Split('|')[0].ToString() == "1" ? true : false;
            model.token = value.Split('|')[1].ToString();
            model.amount = value.Split('|')[2].ToString();
            model.blance = value.Split('|')[3].ToString();
                Msg = value;
            return true;

            }
            catch (Exception e)
            {
                Msg = e.ToString();
                return false;
            }


        }



    }
}
