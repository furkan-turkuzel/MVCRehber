using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Kisiler : IEntity
    {

        public int ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int Yas { get; set; }

        public virtual List<Adresler> Adresler { get; set; }
    }
}
