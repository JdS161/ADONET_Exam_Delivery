﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADONET_Exam_Delivery
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DeliveryDBEntities : DbContext
    {
        public DeliveryDBEntities()
            : base("name=DeliveryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Courier> Couriers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
    
        public virtual int AddCourier(string fullName, Nullable<System.DateTime> dateofBitrh, string driverLicense, string categoryDrLic)
        {
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var dateofBitrhParameter = dateofBitrh.HasValue ?
                new ObjectParameter("DateofBitrh", dateofBitrh) :
                new ObjectParameter("DateofBitrh", typeof(System.DateTime));
    
            var driverLicenseParameter = driverLicense != null ?
                new ObjectParameter("DriverLicense", driverLicense) :
                new ObjectParameter("DriverLicense", typeof(string));
    
            var categoryDrLicParameter = categoryDrLic != null ?
                new ObjectParameter("CategoryDrLic", categoryDrLic) :
                new ObjectParameter("CategoryDrLic", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCourier", fullNameParameter, dateofBitrhParameter, driverLicenseParameter, categoryDrLicParameter);
        }
    
        public virtual int AddNewOrder(string address, string description, Nullable<System.DateTime> dateofOrder, Nullable<int> orderStatusId, Nullable<int> courierId, Nullable<int> price)
        {
            var addressParameter = address != null ?
                new ObjectParameter("Addrss", address) :
                new ObjectParameter("Addrss", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Descript", description) :
                new ObjectParameter("Descript", typeof(string));
    
            var dateofOrderParameter = dateofOrder.HasValue ?
                new ObjectParameter("DateofOrder", dateofOrder) :
                new ObjectParameter("DateofOrder", typeof(System.DateTime));
    
            var orderStatusIdParameter = orderStatusId.HasValue ?
                new ObjectParameter("OrderStatusId", orderStatusId) :
                new ObjectParameter("OrderStatusId", typeof(int));
    
            var courierIdParameter = courierId.HasValue ?
                new ObjectParameter("CourierId", courierId) :
                new ObjectParameter("CourierId", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNewOrder", addressParameter, descriptionParameter, dateofOrderParameter, orderStatusIdParameter, courierIdParameter, priceParameter);
        }
    
        public virtual ObjectResult<GetOrdersByStatus_Result> GetOrdersByStatus(Nullable<int> statusId)
        {
            var statusIdParameter = statusId.HasValue ?
                new ObjectParameter("statusId", statusId) :
                new ObjectParameter("statusId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOrdersByStatus_Result>("GetOrdersByStatus", statusIdParameter);
        }
    }
}