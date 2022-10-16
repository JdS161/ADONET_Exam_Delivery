using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADONET_Exam_Delivery;

namespace ADONET_Exam_Delivery.Classes
{
    internal class DeliveryContext:DbContext
    {
        public DeliveryContext() : base("DeliveryDB") 
        {
            Database.SetInitializer<DeliveryContext>(new CreateDatabaseIfNotExists<DeliveryContext>());

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CourierCl> Couriers { get; set; }
        public DbSet<OrderStatus> Statuses { get; set; }
              
    }
}
