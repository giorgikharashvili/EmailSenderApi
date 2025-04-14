using EmailSenderApi.Services;
using Microsoft.AspNetCore.Mvc;



namespace EmailSenderApi.Controllers
{
    
    [ApiController]
    [Route("api/emails")]
    public class EmailsController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailsController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(string receptor, string subject, string body)
        {
            await _emailService.SendMail(receptor, subject, body);

            return Ok();
        }
    }
}
