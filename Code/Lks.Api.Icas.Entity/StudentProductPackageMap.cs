// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// StudentProductPackage
    /// </summary>
    public class StudentProductPackageMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<StudentProductPackage>
    {
        public StudentProductPackageMap()
            : this("stu")
        {
        }

        public StudentProductPackageMap(string schema)
        {
            ToTable("StudentProductPackage", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StudentProductId).HasColumnName(@"StudentProductId").HasColumnType("int").IsRequired();
            Property(x => x.ClassType).HasColumnName(@"ClassType").HasColumnType("bigint").IsRequired();
            Property(x => x.IsComplete).HasColumnName(@"IsComplete").HasColumnType("bit").IsRequired();
            Property(x => x.IsSerial).HasColumnName(@"IsSerial").HasColumnType("bit").IsRequired();
            Property(x => x.OrderNum).HasColumnName(@"OrderNum").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bigint").IsRequired();

            // Foreign keys
            HasRequired(a => a.StudentProduct).WithMany(b => b.StudentProductPackages).HasForeignKey(c => c.StudentProductId); // FK_StudentProductPackage_StudentProduct
        }
    }

}
// </auto-generated>
