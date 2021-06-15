﻿using StudentProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.ViewModels
{
    public class CreateViewModel
    {

        [Required]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
