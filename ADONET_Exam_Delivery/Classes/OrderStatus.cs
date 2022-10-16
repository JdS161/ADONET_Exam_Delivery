using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Exam_Delivery.Classes
{
    [Table (name: "Statuses")]
    public class OrderStatus
    {
        [Key]
        public int OrderID { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public OrderStatus()
        {
            Orders = new List<Order>();
        }
    }
}
