using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Exam_Delivery.Classes
{
    [Table (name: "Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Addrss { get; set; }
        [MaxLength (50)]
        [Required]
        public string Descript { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public int OrderStatusID { get; set; }
        public int CourierID { get; set; }
        [Required]
        public int Price { get; set; }

        public virtual OrderStatus OrdStatus { get; set; }
        public virtual CourierCl Courier { get; set; }
    }
}
