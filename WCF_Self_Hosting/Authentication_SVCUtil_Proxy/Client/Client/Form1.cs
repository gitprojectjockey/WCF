﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            using (UserInformationService.UserInformationServiceClient client = new UserInformationService.UserInformationServiceClient())
            {
                UserInformationService.User user = client.GetUserInformation();
                txtUser.Text = string.Format("User Name: {0}\r\nAuthenticated: {1}\r\nAuthentication Type: {2}", user.Name, user.IsAuthentic, user.AuthenticationType);
            }
        }
    }
}
