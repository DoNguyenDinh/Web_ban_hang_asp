using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ecommerces_asp.net.Helpers
{
    public static class SessionHelper
    {
        public static void SetOjectAsJson(this ISession session,string key,object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetOjectFromJson<T>(this ISession session,string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
