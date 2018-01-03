using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;

namespace PicoBrewPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginAddress = "https://picobrew.com/account/loginAjax.cshtml";
            var loginData = new NameValueCollection
            {
              { "username", "" },
              { "password", "" }
             };

            var client = new CookieAwareWebClient();
            client.Login(loginAddress, loginData);

            string getAllSessionsForUser = "https://picobrew.com/JSONAPI/Pico/PicoSession.cshtml";
            string myParameters = "option=getAllSessionsForUser";

            client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string json = client.UploadString(getAllSessionsForUser, myParameters);

            var picoSessions = JsonConvert.DeserializeObject<GetAllSessionsForUserResponse>(json);

            Console.ReadLine();
        }
    }
}
