using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class KisilerMapping:EntityTypeConfiguration<Kisiler>
    {
        public KisilerMapping()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Ad).HasMaxLength(20).IsRequired();
            Property(x => x.Soyad).HasMaxLength(30).IsRequired();
            Property(x => x.Yas).IsRequired();
        }
    }
}
