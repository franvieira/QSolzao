using System;
using System.Collections.Generic;
using System.Text;
using QSolzao.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSolzao.Infra.Data.Mapping
{
    public class CambistaMapping : IEntityTypeConfiguration<Cambista>
    {
        public void Configure(EntityTypeBuilder<Cambista> builder)
        {
            builder.ToTable("Tb_cambista");
            builder.HasKey(p => p.CambistaId);
            builder.Property(p => p.Nome);

        }
    }
}
