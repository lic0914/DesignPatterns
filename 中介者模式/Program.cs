using System;

namespace 中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WulinAlliance champions = new WulinAlliance();
            Wudang wudang = new Wudang(champions);
            ShaoLin shaolin = new ShaoLin(champions);
            EMei emei = new EMei(champions);
            champions.setWudang(wudang);
            champions.setShaolin(shaolin);
            champions.setEmei(emei);
            wudang.SendAlliance("武当弟子被少林大力金刚指所杀");
            emei.sendAlliance("峨眉弟子被少林大力金刚指所杀");
            shaolin.sendAlliance("少林弟子绝不会做出这种事情");
            Console.ReadKey();
        }
    }
}
