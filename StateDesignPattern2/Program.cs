using System;

namespace StateDesignPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            Console.WriteLine("First state is : " + context.GetLampState());


            context.onClose();
            context.onOpen();

            Console.WriteLine("-------");
            Console.WriteLine("state is : " + context.GetLampState());

            context.onOpen();
            context.onClose();
            Console.WriteLine("state is : " + context.GetLampState());

            //Console.WriteLine("Hello World!");
        }
    }
}
