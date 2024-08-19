﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qinshift.DataAccess.Domain
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("UserFullName")]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Adress { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
