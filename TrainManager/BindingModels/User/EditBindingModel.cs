﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainManager.BindingModels.User
{
    public class EditBindingModel
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter Valid SSN!")]
        public string SSN { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
    }
}
