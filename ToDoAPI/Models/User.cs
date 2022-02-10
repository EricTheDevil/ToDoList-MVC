using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Authentication;

namespace ToDoAPI.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
 
        public virtual ICollection<ToDoItemModel> Items { get; set; }
    }
}
