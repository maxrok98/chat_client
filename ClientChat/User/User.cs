using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat.User
{
    public partial class User : Form, IUser
    {
        public event Action MyChatSelected;
        public event Action NotMyChatSelected;
        public event Action UpdateU;
        public event Action CreateNewChat;

        public User()
        {
            InitializeComponent();
            this.listBox1.SelectedIndex = -1;
            this.listBox2.SelectedIndex = -1;
            BindComponent();
        }
        public void BindComponent()
        {
            this.listBox1.DisplayMember = "Name";
            this.listBox2.DisplayMember = "Name";

            this.listBox1.SelectedIndexChanged += OnListBox1SelectedIndexChanged;
            this.listBox2.SelectedIndexChanged += OnListBox2SelectedIndexChanged;

        }

        

        public List<Chat> MyChats
        {
            get { return this.listBox1.DataSource as List<Chat>; }
        }
        public List<Chat> NotMyChats
        {
            get { return this.listBox2.DataSource as List<Chat>; }
        }
        public Chat SelectedMyChat
        {
            get { return this.listBox1.SelectedItem as Chat; }
        }
        public Chat SelectedNotMyChat
        {
            get { return this.listBox2.SelectedItem as Chat; }
        }

        public void LoadMyChats(List<Chat> mychats)
        {
            this.listBox1.DataSource = mychats;
            this.listBox1.ClearSelected();
        }
        public void LoadNotMyChats(List<Chat> notmychats)
        {
            this.listBox2.DataSource = notmychats;
            this.listBox2.ClearSelected();

        }
        public void OpenChat(Chat chat)
        {
            MessageBox.Show($"Open chat {chat.Name}");
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void OnListBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyChatSelected != null)
            {
                MyChatSelected();
            }
        }
        private void OnListBox2SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotMyChatSelected != null)
            {
                NotMyChatSelected();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UpdateU != null)
            {
                UpdateU();
            }
        }
        public string[] LoadNewChat()
        {
            string[] chat = new string[2];
            chat[0] = textBox1.Text;
            chat[1] = textBox2.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            return chat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(CreateNewChat != null)
            {
                CreateNewChat();
            }
        }
    }
}
