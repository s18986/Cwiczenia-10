﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DTO.Request
{
    public class EnrollStudentRequest
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IndexNumber { get; set; }
        [Required]
        public DateTime birthDate { get; set; }
        [Required]
        public string Studies { get; set; }
    }
}
