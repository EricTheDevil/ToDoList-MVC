using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ToDoAPI.Models;

namespace ToDoAPI.Authentication
{
    public class ApplicationUser: IdentityUser
    {
        [JsonIgnore]

        public ICollection<ToDoItemModel> Items { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }
    }
}
