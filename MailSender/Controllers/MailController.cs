using AutoMapper;
using BuisenessObjects;
using BuisenessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Interface;
using Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailSender.Controllers
{
    [ApiController]
    public class MailController : ControllerBase
    {
        private IMailService _mailService;
        private IMapper _mapper;

        public MailController(IMailService mailService, IMapper mapper)
        {
            _mapper = mapper;
            _mailService = mailService;
        }

        [Route("api/mails")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MailDto mailDto)
        {
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(mailDto.Recipients,mailDto.Subject,mailDto.Body);
            var result = await _mailService.Post(_mapper.Map<Mail>(mailDto));

            return Ok(result);
        }

        [Route("api/mails")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mail>>> Get()
        {
            return Ok(await _mailService.Get());
        }
    }
}
