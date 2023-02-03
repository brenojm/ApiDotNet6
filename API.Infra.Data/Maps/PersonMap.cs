using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infra.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("IdPessoa").UseIdentityColumn();

            builder.Property(x => x.Document).HasColumnName("Documento");

            builder.Property(x => x.Name).HasColumnName("Nome");

            builder.Property(x => x.Phone).HasColumnName("Celular");

            builder.HasMany(c => c.Purchases).WithOne(p => p.Person).HasForeignKey(c => c.PersonId);

        }
    }
}
