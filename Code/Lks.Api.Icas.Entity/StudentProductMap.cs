// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// StudentProduct
    /// </summary>
    public class StudentProductMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<StudentProduct>
    {
        public StudentProductMap()
            : this("stu")
        {
        }

        public StudentProductMap(string schema)
        {
            ToTable("StudentProduct", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StudentId).HasColumnName(@"StudentId").HasColumnType("int").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired();
            Property(x => x.IsPackageSerial).HasColumnName(@"IsPackageSerial").HasColumnType("bit").IsRequired();
            Property(x => x.IsComplete).HasColumnName(@"IsComplete").HasColumnType("bit").IsRequired();
            Property(x => x.OrderNum).HasColumnName(@"OrderNum").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bigint").IsRequired();
        }
    }

}
// </auto-generated>
