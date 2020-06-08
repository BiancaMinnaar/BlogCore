using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    [Table("User", Schema = "BlogKata")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
