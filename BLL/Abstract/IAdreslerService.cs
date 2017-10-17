using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IAdreslerService
    {
        void Add(Adresler entity);
        void Update(Adresler entity);
        void Delete(Adresler entity);
        Adresler Get(int? ID);
        ICollection<Adresler> GetAll();
    }
}
