﻿// This file is part of SmsIrRestful.
// Copyright © 2017 Younos Baghaee Moghaddam.
// 
// SmsIrRestful is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3
// of the License, or any later version.
// 
// SmsIrRestful is distributed in the hope that it will be useful
// for sms.ir customers, but WITHOUT ANY WARRANTY; without even the
// implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with SmsIrRestful. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsIrRestful
{

    public class ReceiveMessageRequestObject
    {
        public string Shamsi_FromDate { get; set; }
        public string Shamsi_ToDate { get; set; }
        public int RequestedPageNumber { get; set; }
        public int RowsPerPage { get; set; }
    }

    public class ReceivedMessages
    {
        public long ID { get; set; }
        public string LineNumber { get; set; }
        public string SMSMessageBody { get; set; }
        public string MobileNo { get; set; }
        public string ReceiveDateTime { get; set; }
        public string LatinReceiveDateTime { get; set; }
        public string TypeOfMessage { get; set; }
    }

    public class ReceivedMessageResponseByDate : BaseResponseApiModel
    {
        public int CountOfAll { get; set; }
        public ReceivedMessages[] Messages { get; set; }
    }


    public class ReceiveMessageResponseById : BaseResponseApiModel
    {
        public ReceivedMessages[] Messages { get; set; }
        public int CountOfAll { get; set; }
    }














}
