using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace seventh
{
    public class SmsMessageSender: IMessageSender
    {
        private string text;
                public SmsMessageSender(HttpContext context)
                {
                    text = context.Request.Cookies["text"];
                    if (text == null)
                    {
                        context.Response.Cookies.Append("text", "HELLOOOOO");
                    }
                }
        
                public string Send()
                {
                    if (text == null)
                    {
                        return "text empty";
                    }
                    return text;
                }
    }
}