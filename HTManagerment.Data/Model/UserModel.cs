using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HTManagerment.Data.Common.Interfaces;

namespace HTManagerment.Data.Model
{
    [Table("Users")]
    public class UserModel : IDateTracking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public int Version { get; set; }
    }
}
