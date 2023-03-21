using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.EF.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        [Required]
       
        public int RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        public Restaurant Restaurant { get; set; }

        
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]

        public Employee Employee { get; set; }

        public DateTime RequestDate { get; set; } = DateTime.Now;

        public DateTime ExpiredTime { get; set; }
        public string Status { get; set; } = null;
    }
}