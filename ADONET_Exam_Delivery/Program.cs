using ADONET_Exam_Delivery.OrderModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADONET_Exam_Delivery.DataLayer;
using System.Data.SqlClient;
using ADONET_Exam_Delivery.Classes;
using System.Net;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Data;

namespace ADONET_Exam_Delivery
{
    internal class Program
    {
        static string connStr = ConfigurationManager.ConnectionStrings["DeliveryDB"].ConnectionString;
        static void Main(string[] args)
        {
            IEnumerable<ModelOfOrder> models = DL.Ord.GetOrdersByStatusId(4);

            foreach (var item in models)
            {
                Console.WriteLine($"{item.Id}   {item.Addrss}  {item.Descript}  {item.OrderDate.ToShortDateString()}    {item.OrderStatusId}   {item.CourierID}    {item.Price}");
            }

            //AddNewOrder("Phili Street", "Halo-Halo", DateTime.Now, 2, 3, 50);
            //AddNewOrder("Zain Street", "Apple Juice", DateTime.Now, 3, 3, 50);
            //AddNewOrder("Foo Street", "Shawarma", DateTime.Now, 1, 4, 40);
            //AddNewOrder("Bar Street", "Kebab", DateTime.Now, 1, 2, 30);
            //AddNewOrder("Noc Street", "Karak Tea", DateTime.Now, 4, 2, 30);
            //AddNewOrder("Peach Street", "Masala", DateTime.Now, 3, 1, 50);
            //AddNewOrder("Pork Street", "Curry", DateTime.Now, 3, 2, 510);
            //AddNewOrder("Pan Street", "Chili", DateTime.Now, 3, 1, 58);

            //int res = AddCourier("Mark Downey", new DateTime(1984, 5, 23), "Yes", "A");

            //GetOrdersByStatus(2);

            //Console.WriteLine(res);

            Console.ReadKey();
        }


        private static void AddNewOrder(string _address, string _description, DateTime _date, int _ordSt, int _courier, int _price)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("AddNewOrder", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Addrss", _address));
                cmd.Parameters.Add(new SqlParameter("@Descript", _description));
                cmd.Parameters.Add(new SqlParameter("@OrderDate", _date));
                cmd.Parameters.Add(new SqlParameter("@OrderStatusId", _ordSt));
                cmd.Parameters.Add(new SqlParameter("@CourierId", _courier));
                cmd.Parameters.Add(new SqlParameter("@Price", _price));

                var res = cmd.ExecuteScalar();

                Console.WriteLine(res);
            }
        }

        private static int AddCourier(string _name, DateTime _DoB, string _drivLic, string _cat)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("AddCourier", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@FullName", _name));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", _DoB));
                cmd.Parameters.Add(new SqlParameter("@DriverLicense", _drivLic));
                cmd.Parameters.Add(new SqlParameter("@CategoryDrLic", _cat));


                int res = cmd.ExecuteNonQuery();

                return res;
            }
        }


        private static void GetOrdersByStatus(int _idx)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("GetOrdersByStatus", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Orders WHERE OrderStatusId = _idx", con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);

                var res = cmd.ExecuteScalar();

                Console.WriteLine(res);
            }
        }

    }
}
