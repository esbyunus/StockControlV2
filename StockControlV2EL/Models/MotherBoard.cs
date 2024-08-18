using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlV2EL.Models
{
    public class MotherBoard : IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        [Required]
        [MaxLength(10)]
        public string Socket { get; set; }

        [Required]
        [MaxLength(10)]
        public string FormFactor { get; set; }
        public string BrandType { get; set; }
    }
}
