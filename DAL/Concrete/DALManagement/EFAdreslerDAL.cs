using Core.DataAccess.EntityFramework;
using DAL.Abstract;
using DAL.Concrete.DBContext;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.DALManagement
{
    public class EFAdreslerDAL : EFEntityRepositoryBase<RehberDBContext,Adresler>,IAdreslerDAL
    {

    }
}
