using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChat.User
{
    interface IUser
    {
        event Action MyChatSelected;
        event Action NotMyChatSelected;
        event Action UpdateU;
        event Action CreateNewChat;


        List<Chat> MyChats { get; }
        List<Chat> NotMyChats { get; }

        Chat SelectedMyChat { get; }
        Chat SelectedNotMyChat { get; }

        void LoadMyChats(List<Chat> mychats);
        void LoadNotMyChats(List<Chat> notmychats);
        void OpenChat(Chat chat);
        string[] LoadNewChat();
        void Close();
    }
}
