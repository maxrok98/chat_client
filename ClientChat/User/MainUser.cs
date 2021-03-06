﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientChat
{
    class MainUser
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public MainUser(int id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public List<Chat> mychat = new List<Chat>();
        public void AddMyChat(Chat chat)
        {
            mychat.Add(chat);
        }
        public Chat GetMyById(int id)
        {
            foreach(Chat ch in mychat)
            {
                if (ch.Id == id)
                    return ch;
            }
            return null;
        }
        public List<Chat> MyChats()
        {
            return mychat;
        }

        public List<Chat> notmychat = new List<Chat>();
        public void AddNotMyChat(Chat chat)
        {
            notmychat.Add(chat);
        }
        public Chat GetNotMyById(int id)
        {
            foreach (Chat ch in notmychat)
            {
                if (ch.Id == id)
                    return ch;
            }
            return null;
        }
        public List<Chat> NotMyChats()
        {
            return notmychat;
        }

    }
}
