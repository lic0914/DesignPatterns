using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
     class PM:AbstractAudit
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine("经理:{0} 审批中。。。。", this.Name);
            if (context.Hours < 8)
            {
                Console.WriteLine("经理:{0} 批准了",this.Name);
            }
            else
            {
                base.AuditNext(context);
            }
        }
    }
}
