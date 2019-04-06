using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    /// <summary>
    /// 具体同事类（武当）
    /// </summary>
    public class Wudang : AbstractUnited
    {
        public Wudang(AbstractWulinAlliance wulinAlliance)
            :base(wulinAlliance)
        {
           
        }
        public void SendAlliance(String message)
        {
            wulinAlliance.notice(message, this);
        }
        public void getNotice(String message)
        {
            Console.WriteLine("武当收到消息：" + message);
        }
    }
}
