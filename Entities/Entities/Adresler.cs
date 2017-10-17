using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Adresler : IEntity
    {
        public int ID { get; set; }

        public int KisiID { get; set; }

        public string AdresTanim { get; set; }

        public virtual Kisiler Kisiler { get; set; }
    }
}
