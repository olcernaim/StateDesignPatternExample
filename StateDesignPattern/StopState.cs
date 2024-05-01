using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class StopState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player in stop state");
            context.SetState(this);
        }
        public string toString()
        {
            return "Stop State";
        }
    }
}
