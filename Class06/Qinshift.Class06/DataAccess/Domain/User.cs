using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qinshift.DataAccess.Domain
{
    public partial class User
    {
        public User()
        {
            Notes = new List<Note>();
            Meals = new List<Meal>();
            Contacts = new List<Contact>();
        }

        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Note> Notes { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }
}