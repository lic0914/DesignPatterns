using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer c = new Computer();
            using(new ComputerAdapter(c))
            {
                c.Play();
            }
        }
        
    }
    /*
     * 假如有一个Computer类有Destroy方法，但是没有实现IDisposable接口，
     * 在不改变Computer类的情况下怎么样能使用using进行资源的回收。
     * 
     * 开闭原则 对扩展开放,对修改关闭
     */
    class Computer
    {
        public void Play()
        { 
         Console.WriteLine("电脑在播放视频");
        }
        public void Destroy()
        {
            Console.WriteLine("电脑已被销毁");
        }
    }
    class ComputerAdapter : IDisposable
    {
        private Computer computer;
        public ComputerAdapter(Computer c)
        {
            computer = c;
        }
        public void Dispose()
        {
            computer.Destroy();
        }
    }
}
