﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace ToothPickService
{
    public class CustomValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                throw new FaultException(string.Format("Wrong username ({0}) or password ", userName));
            }

            if (!(userName == "eric" && password == "eric") && !(userName == "dave" && password == "dave"))
            {
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
    }
}
