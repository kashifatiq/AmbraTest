using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace AmraLibrary
{
    public static class Helpers
    {
        public static string ConvertObjectToJsonString(object obj)
        {
            var dd = JsonConvert.SerializeObject(obj);
            return dd;
        }
    }
}
