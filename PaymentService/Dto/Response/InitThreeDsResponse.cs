using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Dto.Response
{
    public class InitThreeDsResponse
    {
        public InitThreeDsResponse(string input, bool isIFrame) 
        {
            this.HtmlContent = input;
            this.IsIframe = isIFrame;
        }

        public bool IsIframe { get; set; }

        public string HtmlContent { get; set; }

        public string InitTransId { get; set; }
    }
}
