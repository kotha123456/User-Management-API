﻿using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeFirstAPI.Model
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
       
    }
}
