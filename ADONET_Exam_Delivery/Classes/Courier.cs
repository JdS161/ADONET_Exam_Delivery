using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Exam_Delivery.Classes
{
    [Table (name: "Couriers")]
    public class CourierCl
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        [Required]
        public string FullName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [MaxLength (20)]
        [Required]
        public string DriverLicense { get; set; }
        public string CategoryDrLic { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }

        public CourierCl()
        {
            Orders = new List<Order>();
        }
               
    }
}
