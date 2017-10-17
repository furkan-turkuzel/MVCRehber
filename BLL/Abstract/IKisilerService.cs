using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IKisilerService
    {
        void Add(Kisiler entity);
        void Update(Kisiler entity);
        void Delete(Kisiler entity);
        Kisiler Get(int? ID);
        ICollection<Kisiler> GetAll();
    }
}
