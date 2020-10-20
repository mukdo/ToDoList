using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Web.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string Discription { get; set; }
        public DateTime Time { get; set; }

        public void DateRemaining()
        {
            
        }

    }
}
