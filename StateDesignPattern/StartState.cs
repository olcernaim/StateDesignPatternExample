using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class StartState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player in start state");
            context.SetState(this);
        }
        public string toString()
        {
            return "Start State";
        }
    }
}
