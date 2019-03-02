using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HTManagerment.Data.Common.Interfaces;

namespace HTManagerment.Data.Model
{
    [Table("Settings")]
    public class SettingModel : IDateTracking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public string Address { get; set; }

        public string TimeWork { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int Version { get; set; }
    }
}
