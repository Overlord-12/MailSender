using BuisenessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Interface
{
    public interface IMailService
    {
        public Task<IEnumerable<Mail>> Get();
        public Task<bool> Post(Mail mail);

    }
}
