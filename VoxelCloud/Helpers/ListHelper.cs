using System;
using System.Collections.Generic;
using VoxelCloud.Models.Tables;

namespace VoxelCloud.Helpers
{
    public class ListHelper
    {
        private string Url = "https://voxelcloud-demo-python.herokuapp.com";

        public List<Location> LocationList()
        {
            var result = new List<Location>();

            var location_1 = new Location();
            location_1.Id = 1;
            location_1.Name = "Location 1";
            result.Add(location_1);

            var location_2 = new Location();
            location_2.Id = 2;
            location_2.Name = "Location 2";
            result.Add(location_2);

            var location_3 = new Location();
            location_3.Id = 3;
            location_3.Name = "Location 3";
            result.Add(location_3);

            return result;
        }


        public List<Product> ProductList()
        {
            var result = new List<Product>();

            var product_1 = new Product();
            product_1.Id = 1;
            product_1.Name = "Product 1";
            product_1.Ip_Address = "10.0.0.4";
            product_1.Mac_Address = "001122334455";
            product_1.Serial_Number = "1";
            product_1.Compressor_status = 1;
            product_1.Fan_status = 0;
            product_1.Temperature_alert = 0;
            product_1.Temperature = 75;
            product_1.Installation_Date = DateTime.Now.ToString("M/d/yyyy");
            product_1.Communication_Frequency = 24;
            product_1.Reporting_Url = Url;
            product_1.Write_Frequency = 10;
            product_1.Write_Time = 20;

            result.Add(product_1);

            return result;
        }

        public List<Customer> CustomerList()
        {
            var result = new List<Customer>();

            var customer_1 = new Customer();
            customer_1.Id = 1;
            customer_1.Customer_Number = "AA12CA";
            customer_1.Active = true;
            result.Add(customer_1);

            return result;
        }

        public List<CustomerLocation> CustomerLocationList()
        {
            var result = new List<CustomerLocation>();

            var CustomerLocation_1 = new CustomerLocation();
            CustomerLocation_1.Id = 1;
            CustomerLocation_1.CustomerId= 1;
            CustomerLocation_1.LocationId = 1;
            result.Add(CustomerLocation_1);

            return result;
        }

        public List<CustomerProduct> CustomerProductList()
        {
            var result = new List<CustomerProduct>();

            var CustomerProduct_1 = new CustomerProduct();
            CustomerProduct_1.Id = 1;
            CustomerProduct_1.CustomerId = 1;
            CustomerProduct_1.ProductId = 1;
            result.Add(CustomerProduct_1);

            return result;
        }
    }
}