using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChat.Login
{
    interface ILoginForm
    {
        event Action OnLogin;

        string[] LoadUser();
        void CreateUserForm(int n);
        void Close();
    }
}
