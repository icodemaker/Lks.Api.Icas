// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// BookRecord
    /// </summary>
    public class BookRecordMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BookRecord>
    {
        public BookRecordMap()
            : this("study")
        {
        }

        public BookRecordMap(string schema)
        {
            ToTable("BookRecord", schema);
            HasKey(x => new { x.ArrangeCourseId, x.StudentId });

            Property(x => x.ArrangeCourseId).HasColumnName(@"ArrangeCourseId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StudentId).HasColumnName(@"StudentId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PassStatusType).HasColumnName(@"PassStatusType").HasColumnType("bigint").IsRequired();
            Property(x => x.IsUnBook).HasColumnName(@"IsUnBook").HasColumnType("bit").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bigint").IsRequired();
            Property(x => x.IsOwner).HasColumnName(@"IsOwner").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.ArrangeCourse).WithMany(b => b.BookRecords).HasForeignKey(c => c.ArrangeCourseId); // FK_BookRecord_ArrangeCourse
        }
    }

}
// </auto-generated>