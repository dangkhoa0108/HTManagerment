using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HTManagerment.Data.Common.Interfaces;

namespace HTManagerment.Data.Model
{
    [Table("Units")]
    public class UnitModel: IDateTracking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UnitId { get; set; }

        public string Value { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public int Version { get; set; }
    }
}
