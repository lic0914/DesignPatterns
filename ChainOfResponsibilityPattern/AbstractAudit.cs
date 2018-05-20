using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class AbstractAudit
    {
        public string Name { get; set; }
        private AbstractAudit _NextAudit = null;
        public void SetNextAudit(AbstractAudit audit)
        {
            _NextAudit = audit;
            
        }
        public abstract void Audit(ApplyContext context);
        
        protected void AuditNext(ApplyContext context)
        {
            if (_NextAudit != null)
            {
                this._NextAudit.Audit(context);
            }
        }
    }
}
