using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    public abstract class AbstractWulinAlliance
    {
        public abstract void notice(String message, AbstractUnited united);
    }
}
