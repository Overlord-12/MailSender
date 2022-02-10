using AutoMapper;
using BuisenessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailSender
{
    public class MailSenderAutoMapper:Profile
    {
        public MailSenderAutoMapper()
        {
            CreateMap<MailDto, Mail>();
            CreateMap<Mail, MailDto>();
        }
    }
}
