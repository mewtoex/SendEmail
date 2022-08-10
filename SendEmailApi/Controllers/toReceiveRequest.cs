using Microsoft.AspNetCore.Mvc;
using SendEmailApi.Util;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SendEmailApi.Controllers
{
    [Route("api/Recevi")]
    [ApiController]
    public class toReceiveRequest : ControllerBase
    {

        [HttpPost]
        public bool Post(string emailSend)
        {
            util reseller = new util();
            return reseller.sendEmailForApi(emailSend);

        }


    }
}
