using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DTO.Request
{
    public class RemoveStudentRequest
    {
        [Required]
        public string IndexNumber { get; set; }
    }
}
