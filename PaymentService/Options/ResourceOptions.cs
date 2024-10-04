using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Options
{
    public class ResourceOptions
    {
        public string ApiKey { get; set; } //client_id

        public string SecretKey { get; set; }  //client_secret

        public string BaseUrl { get; set; }      // https://localhost:7004/api/app/

        public string AuthUrl { get; set; }      //https://localhost:7600

        public string Scobe { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
