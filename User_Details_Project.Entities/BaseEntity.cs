using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Details_Project.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow.AddMinutes(330);

        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; } = "SYS";

        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow.AddMinutes(330);

        [StringLength(50)]
        public string? ModifiedBy { get; set; } = "SYS";

        [Required]
        public bool IsActive { get; set; } = true;
    }
}
