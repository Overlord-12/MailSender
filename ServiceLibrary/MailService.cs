using BuisenessObjects.Models;
using RepositoryLibrary.Interace;
using ServiceLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class MailService : IMailService
    {
        private IMailRepository _mailRepository;
        public MailService(IMailRepository mailRepository)
        {
            _mailRepository = mailRepository;
        }

        public Task<IEnumerable<Mail>> Get()
        {
            return _mailRepository.Get();
        }

        public Task<bool> Post(Mail mail)
        {
            return _mailRepository.Post(mail);
        }
    }
}
