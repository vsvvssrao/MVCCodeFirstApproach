﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSpaDemo.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Class is Required")]
        public string Class { get; set; }
    }
}