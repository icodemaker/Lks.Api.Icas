// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// StuReq
    /// </summary>
    public class StuReqMap : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<StuReq>
    {
        public StuReqMap()
            : this("dbo")
        {
        }

        public StuReqMap(string schema)
        {
            ToTable("StuReq", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StudentId).HasColumnName(@"StudentId").HasColumnType("int").IsRequired();
            Property(x => x.LevelType).HasColumnName(@"LevelType").HasColumnType("bigint").IsRequired();
            Property(x => x.ClassType).HasColumnName(@"ClassType").HasColumnType("bigint").IsRequired();
            Property(x => x.BeginTime).HasColumnName(@"BeginTime").HasColumnType("datetime").IsRequired();
            Property(x => x.EndTime).HasColumnName(@"EndTime").HasColumnType("datetime").IsRequired();
            Property(x => x.OpenTime).HasColumnName(@"OpenTime").HasColumnType("datetime").IsOptional();
            Property(x => x.CrowdType).HasColumnName(@"CrowdType").HasColumnType("bigint").IsOptional();
            Property(x => x.CustomTeacherId).HasColumnName(@"CustomTeacherId").HasColumnType("int").IsOptional();
            Property(x => x.CustomPackageId).HasColumnName(@"CustomPackageId").HasColumnType("int").IsOptional();
            Property(x => x.CustomCourseId).HasColumnName(@"CustomCourseId").HasColumnType("int").IsOptional();
            Property(x => x.CustomCourseSubjectId).HasColumnName(@"CustomCourseSubjectId").HasColumnType("int").IsOptional();
            Property(x => x.PlatformType).HasColumnName(@"PlatformType").HasColumnType("bigint").IsRequired();
            Property(x => x.MathingId).HasColumnName(@"MathingId").HasColumnType("int").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("bigint").IsRequired();
            Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType("int").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.CreateBy).HasColumnName(@"CreateBy").HasColumnType("int").IsRequired();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsRequired();
            Property(x => x.Remark).HasColumnName(@"Remark").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);

            // Foreign keys
            HasOptional(a => a.Matching).WithMany(b => b.StuReqs).HasForeignKey(c => c.MathingId); // FK_StuReq_Matching
        }
    }

}
// </auto-generated>