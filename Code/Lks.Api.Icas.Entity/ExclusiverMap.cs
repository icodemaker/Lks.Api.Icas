// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// Exclusiver
    /// </summary>
    public class ExclusiverMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Exclusiver>
    {
        public ExclusiverMap()
            : this("user")
        {
        }

        public ExclusiverMap(string schema)
        {
            ToTable("Exclusiver", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired();
            Property(x => x.UserType).HasColumnName(@"UserType").HasColumnType("bigint").IsRequired();
            Property(x => x.ExclusiveBy).HasColumnName(@"ExclusiveBy").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bigint").IsRequired();
            Property(x => x.ProductType).HasColumnName(@"ProductType").HasColumnType("bigint").IsOptional();
        }
    }

}
// </auto-generated>