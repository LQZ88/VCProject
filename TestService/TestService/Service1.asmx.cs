using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace TestService
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(){
            return "Hello World";
        }
        [WebMethod]
        public String searchPatent(String patentNo) { 
            return "[{\"sqh\":\"201410274530.5\",\"zlmc\":\"一种能够避免堵塞的绝缘子快速清洗结构\",\"zlqr\":\"国网四川省电力公司成都市新都供电分公司\",\"fmsjr\":\"杨璞、杨庆、喻华\",\"zllx\":\"发明\",\"zlzt\":\"授权\"},"+
            "{\"sqh\":\"201417894530.5\",\"zlmc\":\"一种能够避免堵塞的绝结构\",\"zlqr\":\"国网四川省成都市新都供电分公司\",\"fmsjr\":\"徐卫，赵宇\",\"zllx\":\"发明\",\"zlzt\":\"授权\"}" +
            "]";
        }
        [WebMethod]
        public String searchPaper(String patentNo)
        {
            return "[{\"lwmc\":\"很多事覅说快速清洗结构\",\"zzxm\":\"国网四川省电力公司\",\"kwmc\":\"有限公司刊物\",\"kwjb\":\"二级\",\"kh\":\"三号\",\"kq\":\"三期\"},"+
            "{\"lwmc\":\"很多事覅说快速清洗结构\",\"zzxm\":\"国网四川省电力公司\",\"kwmc\":\"有限公司刊物\",\"kwjb\":\"三级\",\"kh\":\"四号\",\"kq\":\"四期\"}]";
        }
        [WebMethod]
        public String searchWrite(String patentNo)
        {
            return "[{\"lzmc\":\"很到位论著\",\"zyzz\":\"成都市新都供电分公司\",\"zzdw\":\"小米公司\",\"sh\":\"一丝号\",\"cbs\":\"小米有限出版社\",\"cbrq\":\"2017-02-12\"}," +
                "{\"lzmc\":\"很到位论著\",\"zyzz\":\"成都市新都供电分公司\",\"zzdw\":\"小米公司\",\"sh\":\"2号\",\"cbs\":\"哈喽有限出版社\",\"cbrq\":\"2017-01-12\"}]";
        }
        [WebMethod]
        public String searchRight(String patentNo)
        {
            return "[{\"zzqmc\":\"快速清洗结构软件著作权\",\"djh\":\"三号\",\"sqr\":\"杨庆\",\"zzqr\":\"发明人\"},"+
                "{\"zzqmc\":\"快速清洗结构软件著作权\",\"djh\":\"四号\",\"sqr\":\"杨璞、喻华\",\"zzqr\":\"有限人\"}]";
        }
        [WebMethod]
        public String bindProject(String patentNo)
        {
            return "{\"success\":\"true\",\"message\":\"false\"}";
        }
    }
}
