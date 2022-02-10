using BuisenessObjects;
using BuisenessObjects.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLibrary.Interace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLibrary
{
    public class MailRepository : IMailRepository
    {
        private ApplicationContext _applicationContext;
        public MailRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<IEnumerable<Mail>> Get()
        {
            return await _applicationContext.Mails.ToListAsync();
        }

        public async Task<bool> Post(Mail mail)
        {
            try
            {
                _applicationContext.Mails.Add(mail);
                await _applicationContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
