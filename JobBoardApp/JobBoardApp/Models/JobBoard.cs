using System;
using System.ComponentModel.DataAnnotations;

namespace JobBoardApp.Models
{
    public class JobBoard
    {
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Job { get; set; }
        
        [Required]

        [StringLength(50)]
        public string JobTitle { get; set; }

        [Required]

        [StringLength(250)]
        public string Description { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime ExpiresAt { get; set; }
    }
}