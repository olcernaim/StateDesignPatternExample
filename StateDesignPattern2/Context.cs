using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern2
{
    public class Context
    {
        private LampState lampState;

        public Context()
        {
            SetLampState(new LampCloseState());
        }

        public void onOpen()
        {
            lampState.OnOpen();

            if (lampState is LampCloseState)
            {
                SetLampState(new LampOpenState());
                Console.WriteLine("Durum : " + lampState);
            }
        }

        public void onClose()
        {
            lampState.OnClose();

            if (lampState is LampOpenState)
            {
                SetLampState(new LampOpenState());
                Console.WriteLine("Durum : " + lampState);
            }
        }

        public void SetLampState(LampState lampState)
        {
            this.lampState = lampState;
        }

        public LampState GetLampState()
        {
            return lampState;
        }
    }
}
