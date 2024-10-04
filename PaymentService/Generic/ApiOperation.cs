using PaymentService.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Generic
{

    public class ApiOperation<T> where T : class
    {
        protected readonly ResourceOptions _options;
        protected readonly RestHttpClient _client;

        public ApiOperation(ResourceOptions options)
        {
            _options = options;
            _client = RestHttpClient.Create();
        }

        protected T Create(string endpoint, object request)
        {
            return _client.Post<T>(_options.BaseUrl + endpoint, ApiSource.GetHttpHeaders(_options), request);
        }

        protected T Get(string endpoint)
        {
            return _client.Get<T>(_options.BaseUrl + endpoint, ApiSource.GetHttpHeaders(_options));
        }

        protected T Update(string endpoint, object request)
        {
            return _client.Put<T>(_options.BaseUrl + endpoint, ApiSource.GetHttpHeaders(_options), request);
        }

        protected T Delete(string endpoint)
        {
            return _client.Delete<T>(_options.BaseUrl + endpoint, ApiSource.GetHttpHeaders(_options));
        }
    }
}
