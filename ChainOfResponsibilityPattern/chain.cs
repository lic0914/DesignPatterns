using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Chain : AbstractAudit
    {
       
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine("总监:{0} 审批中。。。。", this.Name);
            if (context.Hours<30)
            {
                Console.WriteLine("总监:{0} 批准了",this.Name);
            }else
            {
                base.AuditNext(context);
            }
        }
    }
}
