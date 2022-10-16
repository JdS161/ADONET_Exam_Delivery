using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Exam_Delivery.OrderModel
{
    public class ModelOfOrder
    {
        public int Id { get; set; }
        public string Addrss { get; set; }
        public string Descript { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatusId { get; set; }
        public int CourierID { get; set; }
        public int Price { get; set; }
    }
}
