using BuisenessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLibrary.Interace
{
    public interface IMailRepository
    {
        public Task<IEnumerable<Mail>> Get();
        public Task<bool> Post(Mail mail);

    }
}
