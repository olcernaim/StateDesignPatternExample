using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern2
{
    public class LampCloseState : LampState
    {
        public void OnClose()
        {
            Console.WriteLine("Lamba zaten kapalı");
        }

        public void OnOpen()
        {
            Console.WriteLine("Lamba açılıyor");
        }
    }
}
