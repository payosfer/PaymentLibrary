using Newtonsoft.Json;
using PaymentService.Dto;
using PaymentService.Dto.Request;
using PaymentService.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService
{
    public class RestHttpClient
    {
        private static readonly HttpClient HttpClient;

        static RestHttpClient()
        {
            HttpClient = new HttpClient();
        }

        public static RestHttpClient Create() => new RestHttpClient();

        public T Get<T>(string url, Dictionary<string, string> headers)
        {
            return SendRequest<T>(HttpMethod.Get, url, headers);
        }

        public T Post<T>(string url, Dictionary<string, string> headers, object request)
        {
            return SendRequest<T>(HttpMethod.Post, url, headers, request);
        }

        public T Put<T>(string url, Dictionary<string, string> headers, object request)
        {
            return SendRequest<T>(HttpMethod.Put, url, headers, request);
        }

        public T Delete<T>(string url, Dictionary<string, string> headers)
        {
            return SendRequest<T>(HttpMethod.Delete, url, headers);
        }

        private T SendRequest<T>(HttpMethod method, string url, Dictionary<string, string> headers, object request = null)
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(url)
            };

            if (request != null)
            {
                httpRequest.Content = JsonBuilder.ToJsonString(request);
            }

            foreach (var header in headers)
            {
                httpRequest.Headers.Add(header.Key, header.Value);
            }

            var response = HttpClient.SendAsync(httpRequest).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
