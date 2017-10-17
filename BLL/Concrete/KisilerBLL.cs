using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using System.Linq.Expressions;
using DAL.Abstract;
using DAL.Concrete.DALManagement;

namespace BLL.Concrete
{
    public class KisilerBLL : IKisilerService
    {
        private readonly IKisilerDAL _KisilerDAL;

        public KisilerBLL(IKisilerDAL KisilerDAL)
        {
            _KisilerDAL = KisilerDAL;
        }

        public void Add(Kisiler entity)
        {
            _KisilerDAL.Add(entity);
        }

        public void Delete(Kisiler entity)
        {
            _KisilerDAL.Delete(entity);
        }

        public Kisiler Get(int? ID)
        {
            return _KisilerDAL.Get(x=>x.ID == ID);
        }

        public ICollection<Kisiler> GetAll()
        {
            return _KisilerDAL.GetAll();
        }

        public void Update(Kisiler entity)
        {
            _KisilerDAL.Update(entity);
        }
    }
}
