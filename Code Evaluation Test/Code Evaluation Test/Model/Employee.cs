﻿using System.ComponentModel.DataAnnotations;

namespace Code_Evaluation_Test.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
    }
}
