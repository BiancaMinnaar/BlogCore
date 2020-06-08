using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    [Table("BlogEntry", Schema = "BlogKata")]
    public class BlogEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public Guid ID { get; set; }
        public Guid BlogID { get; set; }
        public string HeadingText { get; set; }
        public string EntryText { get; set; }
        public Guid UserID { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
