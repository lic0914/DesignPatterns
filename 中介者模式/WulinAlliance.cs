using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class WulinAlliance:AbstractWulinAlliance
    {
        private Wudang wudang;
        private ShaoLin shaolin;
        private EMei emei;
        public void setWudang(Wudang wudang)
        {
            this.wudang = wudang;
        }
        public void setEmei(EMei emei)
        {
            this.emei = emei;
        }
        public void setShaolin(ShaoLin shaolin)
        {
            this.shaolin = shaolin;
        }
        public override void notice(string message, AbstractUnited united)
        {
            if (united == wudang)
            {
                shaolin.getNotice(message);
            }
            else if (united == emei)
            {
                shaolin.getNotice(message);
            }
            else if (united == shaolin)
            {
                wudang.getNotice(message);
                emei.getNotice(message);
            }

        }
    }
}
