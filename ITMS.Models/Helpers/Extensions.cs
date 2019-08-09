using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMS.Extensions
{

    public static class Serialize 
    {
        public static string ToJson<T>(this List<T> self) => JsonConvert.SerializeObject(self, ITMS.Helper.Converter.Settings);
    }
}
