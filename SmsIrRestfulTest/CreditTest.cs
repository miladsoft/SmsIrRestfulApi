﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmsIrRestful;
using System.Collections.Generic;

namespace SmsIrRestfulTest
{
    [TestClass]
    public class UnitTest1
    {

        public string GetToken()
        {
            string userApikey = TokenInformation.UserApikey;
            string secretKey = TokenInformation.SecretKey;


            return new Token().GetToken(userApikey, secretKey);
        }



        [TestMethod]
        public void GetCredit()
        {
            var token = GetToken();

            if (!string.IsNullOrWhiteSpace(token))
                throw new Exception($@"{nameof(token) } is null");


            CreditResponse credit = new Credit().GetCredit(token);

            if (credit == null)
                throw new Exception($@"{nameof(credit) } is null");

            if (credit.IsSuccessful)
            {


            }
            else
            {

            }
        }
    }
}
