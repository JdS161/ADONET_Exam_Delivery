using ADONET_Exam_Delivery.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADONET_Exam_Delivery.Classes;
using ADONET_Exam_Delivery;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ADONET_Exam_Delivery.DataLayer
{
    public class DL
    {
        public static class Ord
        {
            public static IEnumerable<ModelOfOrder> GetOrdersByStatusId(int idx)
            {                
                using (DeliveryDBEntities delDB = new DeliveryDBEntities())
                {
                    List<ModelOfOrder> orders = new List<ModelOfOrder>();
                    var temp = delDB.GetOrdersByStatus(idx).ToList();
                    

                    foreach (var item in temp)
                    {
                        ModelOfOrder order = new ModelOfOrder();
                        order.Id = item.Id;
                        order.Addrss = item.Addrss;
                        order.Descript = item.Descript;
                        order.OrderDate = item.OrderDate;
                        order.OrderStatusId = item.OrderStatusID;
                        order.CourierID = item.CourierID;
                        order.Price = item.Price;

                        orders.Add(order);
                    }
                    return orders;
                }
            }
        }
    }
}
