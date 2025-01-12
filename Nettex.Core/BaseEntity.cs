using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nettex.Core
{
    [Serializable]
    public abstract class BaseEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
    }
}