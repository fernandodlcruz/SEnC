using SEnC.Datatypes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEnC.Repository.Mapping
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            ToTable("Status");
            HasKey(x => x.Id);
            Property(x => x.Descricao).HasMaxLength(45).IsRequired();
        }
    }
}
