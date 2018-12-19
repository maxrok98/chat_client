﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat.Login
{
    public partial class LoginForm : Form, ILoginForm
    {
        public event Action OnLogin;
        Registration.Registration registration;
        Registration.Model model;
        Registration.Presenter presenter;
        User.Model usermodel;
        User.Presenter userpresenter;
        User.User user;

        public LoginForm()
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

        private void button2_Click(object sender, EventArgs e)
        {
            registration = new Registration.Registration();
            model = new Registration.Model();
            presenter = new Registration.Presenter(registration, model);
            registration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(OnLogin != null)
            {
                OnLogin();
            }
        }
        public void CreateUserForm(int n)
        {
            user = new User.User();
            usermodel = new User.Model(n);
            userpresenter = new User.Presenter(user, usermodel);
            user.Show();
        }
    }
}
