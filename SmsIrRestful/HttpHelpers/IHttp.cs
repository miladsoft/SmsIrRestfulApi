﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsIrRestful
{
    internal interface IHttp
    {
        string Execute(HttpObject http);

    }
}