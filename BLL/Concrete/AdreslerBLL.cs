using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using DAL.Abstract;
using DAL.Concrete.DALManagement;

namespace BLL.Concrete
{
    public class AdreslerBLL : IAdreslerService
    {
        private readonly IAdreslerDAL _AdreslerDAL;

        public AdreslerBLL(IAdreslerDAL AdreslerDAL)
        {
            _AdreslerDAL = AdreslerDAL;
        }

        public void Add(Adresler entity)
        {
            _AdreslerDAL.Add(entity);
        }

        public void Delete(Adresler entity)
        {
            _AdreslerDAL.Delete(entity);
        }

        public Adresler Get(int? ID)
        {
            return _AdreslerDAL.Get(x => x.ID == ID);
        }

        public ICollection<Adresler> GetAll()
        {
            return _AdreslerDAL.GetAll();
        }

        public void Update(Adresler entity)
        {
            _AdreslerDAL.Update(entity);
        }

    }
}
