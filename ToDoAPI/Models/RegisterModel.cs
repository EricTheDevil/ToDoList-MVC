﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.Models
{
    public class RegisterModel
    {

        public string Username { get; set; }

 
        public string Email { get; set; }

        public string Password { get; set; }
        public string CreatedTime { get; set; }

    }
}
