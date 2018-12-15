using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace myBlog.Entity
{
    [Table("t_user")]
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CD { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime UserRegistered { get; set; }
        public int Status { get; set; } = 0;
    }
}
