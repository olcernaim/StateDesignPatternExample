using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern2
{
    public interface LampState
    {
        public void OnOpen();
        public void OnClose();
    }
}
