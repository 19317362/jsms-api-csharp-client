﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using jsms.common;
using jsms.util;

namespace jsms.sms
{
    public class SMSPayload
    {
        public string mobile;
        public Int16 temp_id;
        public Dictionary<string,string> temp_para;

        public SMSPayload(string mobile, Int16 temp_id)
        {
            this.mobile = mobile;
            this.temp_id = temp_id;
        }

        public SMSPayload(string mobile, Int16 temp_id,  Dictionary<string, string> temp_para)
        {
            this.mobile = mobile;
            this.temp_id = temp_id;
            this.temp_para = temp_para;
        }


        public string ToJson(SMSPayload sms)
        {
            return JsonConvert.SerializeObject(sms,
                            Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
        }
        public SMSPayload Check()
        {
            return this;
        }
    }
}
