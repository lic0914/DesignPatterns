using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class EMei:AbstractUnited
    {
        public EMei(AbstractWulinAlliance wulinAlliance)
            :base(wulinAlliance)
        {
            
        }
        public void sendAlliance(String message)
        {
            wulinAlliance.notice(message, this);
        }
        public void getNotice(String message)
        {
            Console.WriteLine("峨眉收到消息：" + message);
        }

    }
}
