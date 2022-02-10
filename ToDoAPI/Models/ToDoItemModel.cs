using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Authentication;

namespace ToDoAPI.Models
{
    public class ToDoItemModel
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "ItemName is required")]
  
        public string ItemName { get; set; }

        [Required(ErrorMessage = "ItemDescription is required")]

        public string ItemDescription { get; set; }

        public string ItemStatus { get; set; }

        public string ItemCreated { get; set; }

        public string ItemUpdated { get; set; }


        [JsonIgnore]
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }



    }
}
