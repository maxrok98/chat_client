using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat.Registration
{
    public partial class Registration : Form, IRegistration
    {
        public event Action OnRegistration;
        public Registration()
        {
            InitializeComponent();
        }
        public string[] LoadUser()
        {
            string[] mas = new string[2];
            mas[0] = this.textBox1.Text;
            mas[1] = this.textBox2.Text;
            return mas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(OnRegistration != null)
            {
                OnRegistration();
            }
        }
        
    }
}
