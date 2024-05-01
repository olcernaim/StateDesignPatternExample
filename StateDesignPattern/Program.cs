using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();

            startState.doAction(context);

            Console.WriteLine(context.GetState().ToString());


            StopState stopState = new StopState();

            stopState.doAction(context);

            Console.WriteLine(context.GetState().ToString());
        }
    }
}
