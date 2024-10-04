using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PaymentService.Dto;
using PaymentService.Dto.Enums;
using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Net.Http;

namespace PaymentService
{
    public class ApiSource
    {

        public static Dictionary<string, string> GetHttpHeaders(ResourceOptions options)
        {
            string token = GetAccessToken(options);

            return new Dictionary<string, string>
            {
                { "accept", "text/plain" },
                { "RequestVerificationToken", GenerateRequestVerificationToken() },
                { "X-Requested-With", "XMLHttpRequest" },
                { "Authorization", $"Bearer {token}" }
            };
        }

        private static string GetAccessToken(ResourceOptions options)
        {
            var url = options.AuthUrl;

            using (var client = new HttpClient())
            {
                var requestData = new Dictionary<string, string>
                {
                    { "client_id", options.ApiKey },
                    { "client_secret", options.SecretKey },
                    { "grant_type", "password" }, 
                    { "scope", options.Scobe },
                    { "username", options.Username },
                    { "password", options.Password }
                };

                var requestContent = new FormUrlEncodedContent(requestData);

                var response = client.PostAsync($"{url}/connect/token", requestContent).Result;

                if (!response.IsSuccessStatusCode)
                {
                    var errorResponse = response.Content.ReadAsStringAsync().Result;
                    throw new Exception($"Token isteği başarısız oldu: {response.StatusCode} - {errorResponse}");
                }

                var responseString = response.Content.ReadAsStringAsync().Result;

                var tokenData = JsonConvert.DeserializeObject<TokenResponse>(responseString);
                return tokenData.AccessToken;
            }
        }



        private static string GenerateRequestVerificationToken()
        {
            return Guid.NewGuid().ToString("N");
        }

        public class TokenResponse
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }
        }

        //payment için olan parametreler 
        public PaymentStatus PaymentStatus { get; set; }

        public string TransId { get; set; }

        public string OrderId { get; set; }

        public decimal Amount { get; set; }

        public int Installment { get; set; }
    }
}
