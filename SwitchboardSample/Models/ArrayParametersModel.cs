using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwitchboardSample.Models
{
    public class ArrayParametersModel
    {
        [Required]
        [Range(1, 30, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public int Rows { get; set; }

        [Required]
        [Range(1,30, ErrorMessage ="Value for {0} must be between {1} and {2}")]
        public int Cols { get; set; }

    }
}
