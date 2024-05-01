﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern2
{
    public class LampOpenState : LampState
    {
        public void OnClose()
        {
            Console.WriteLine("Lamba kapanıyor");
        }

        public void OnOpen()
        {
            Console.WriteLine("Lamba zaten açık");
        }
    }
}
