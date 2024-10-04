using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentService.Dto;
using PaymentService.Dto.Request;

namespace PaymentService.Payment
{
    public class JsonBuilder
    {
        public static string SerializeToJsonString(object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                Formatting = Formatting.None,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        public static StringContent ToJsonString(object obj)
        {
            return new StringContent(SerializeToJsonString(obj), Encoding.UTF8, "application/json");
        }
    }
}
