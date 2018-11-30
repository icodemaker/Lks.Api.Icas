// <auto-generated>
using Lks.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Lks.Api.Icas.Entity
{

    /// <summary>
    /// Log
    /// </summary>
    [Serializable]
    public class Log
    {
        public int Id { get; set; } // Id (Primary key)
        public DateTime Date { get; set; } // Date
        public string Thread { get; set; } // Thread (length: 255)
        public string Level { get; set; } // Level (length: 50)
        public string Logger { get; set; } // Logger (length: 255)
        public string Message { get; set; } // Message (length: 4000)
        public string Exception { get; set; } // Exception (length: 4000)
    }

}
// </auto-generated>
