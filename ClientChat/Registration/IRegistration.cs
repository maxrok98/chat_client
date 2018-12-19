using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChat.Registration
{
    interface IRegistration
    {
        event Action OnRegistration;

        string[] LoadUser();
        void Close();
    }
}
