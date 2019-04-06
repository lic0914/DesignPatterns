using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    public abstract class AbstractUnited
    {
        protected AbstractWulinAlliance wulinAlliance;
        public AbstractUnited(AbstractWulinAlliance wulinAlliance)
        {
            this.wulinAlliance = wulinAlliance;
        }
    }

}
