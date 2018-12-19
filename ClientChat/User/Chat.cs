using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChat
{
    public class Chat
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Chat(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
