using System.Threading;
using System.Windows.Forms;

namespace ZIO.etcs
{
    internal class Funkce
    {
        public static void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }
    }
}
