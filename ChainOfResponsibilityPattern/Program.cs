using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplyContext context = new ApplyContext
            {
                Name = "小亮亮",
                Hours = 25
            };
            //创建对象可以使用简单工厂 +反射+配置文件 做可配置的
            AbstractAudit pm = new PM
            {
                Name = "悠悠吾心"
            };
            AbstractAudit zhuguan  = new ZhuGuan
            {
                Name = "康师傅"
            };
            AbstractAudit chain = new Chain
            {
                Name = "喜得龙"
            };
            pm.SetNextAudit(zhuguan);
            zhuguan.SetNextAudit(chain);
            pm.Audit(context);
            Console.ReadKey();
        }
    }
}
