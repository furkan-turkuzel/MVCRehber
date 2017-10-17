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
    public class AdreslerMapping : EntityTypeConfiguration<Adresler>
    {
        public AdreslerMapping()
        {
            HasKey(x => x.ID);
            Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Kisiler).WithMany(x => x.Adresler).HasForeignKey(x => x.KisiID).WillCascadeOnDelete();

            Property(x => x.AdresTanim).IsRequired();
        }
    }
}
