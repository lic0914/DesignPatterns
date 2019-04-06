using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class ShaoLin:AbstractUnited
    {
        public ShaoLin(AbstractWulinAlliance wulinAlliance)
            :base(wulinAlliance)
        {

        }
        public void sendAlliance(String message)
        {
            wulinAlliance.notice(message, this);
        }
        public void getNotice(String message)
        {
            Console.WriteLine("少林收到消息：" + message);
        }
        
    }
}
