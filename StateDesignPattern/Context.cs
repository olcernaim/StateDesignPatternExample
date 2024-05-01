using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class Context
    {
        private State _state;

        public Context()
        {
            _state = null;
        }

        public void SetState(State state)
        {
            _state = state;
        }
        public State GetState()
        {
            return _state;
        }
    }
}
