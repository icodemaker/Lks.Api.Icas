// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// ClassTypePool
    /// </summary>
    [Serializable]
    public class ClassTypePool
    {

        ///<summary>
        /// 编号
        ///</summary>
        public int Id { get; set; } // Id (Primary key)

        ///<summary>
        /// 学员编号
        ///</summary>
        public int StudentId { get; set; } // StudentId

        ///<summary>
        /// 课堂类型（系统枚举）
        ///</summary>
        public ClassType ClassType { get; set; } // ClassType

        ///<summary>
        /// 个性产品包（来源）
        ///</summary>
        public int? StudentProductPackageId { get; set; } // StudentProductPackageId

        ///<summary>
        /// 是否限制预订（即预订时扣除课节）
        ///</summary>
        public bool IsLimit { get; set; } // IsLimit

        ///<summary>
        /// 已完成课节量
        ///</summary>
        public int Completed { get; set; } // Completed

        ///<summary>
        /// 课节总量
        ///</summary>
        public int Total { get; set; } // Total

        ///<summary>
        /// 合同状态（系统枚举）；默认：执行
        ///</summary>
        public ContractStatusType ContractStatusType { get; set; } // ContractStatusType

        ///<summary>
        /// 开始日期
        ///</summary>
        public DateTime BeginDate { get; set; } // BeginDate

        ///<summary>
        /// 截止日期
        ///</summary>
        public DateTime EndDate { get; set; } // EndDate

        ///<summary>
        /// 合同类型编号（对应LksForSetting库ContractType表）
        ///</summary>
        public int? ContractTypeId { get; set; } // ContractTypeId

        ///<summary>
        /// 状态（系统枚举）
        ///</summary>
        public Status Status { get; set; } // Status
    }

}
// </auto-generated>
