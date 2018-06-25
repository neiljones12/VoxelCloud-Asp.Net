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


        public List<Device> DeviceList()
        {
            var result = new List<Device>();

            var Device_1 = new Device();
            Device_1.Id = 1;
            Device_1.Name = "Device 1";
            Device_1.Ip_Address = "10.0.0.4";
            Device_1.Mac_Address = "001122334455";
            Device_1.Serial_Number = "1";
            Device_1.Compressor_status = 1;
            Device_1.Fan_status = 0;
            Device_1.Temperature_alert = 0;
            Device_1.Temperature = 75;
            Device_1.Installation_Date = DateTime.Now.ToString("M/d/yyyy");
            Device_1.Timestamp = DateTime.Now.ToString("M/d/yyyy");
            Device_1.Communication_Frequency = 24;
            Device_1.Reporting_Url = Url;
            Device_1.Write_Frequency = 10;
            Device_1.Write_Time = 20;
            result.Add(Device_1);

            var Device_2 = new Device();
            Device_2.Id = 2;
            Device_2.Name = "Device 2";
            Device_2.Ip_Address = "10.0.0.6";
            Device_2.Mac_Address = "001122334466";
            Device_2.Serial_Number = "2";
            Device_2.Compressor_status = 1;
            Device_2.Fan_status = 0;
            Device_2.Temperature_alert = 0;
            Device_2.Temperature = 50;
            Device_2.Installation_Date = DateTime.Now.ToString("M/d/yyyy");
            Device_2.Timestamp = DateTime.Now.ToString("M/d/yyyy");
            Device_2.Communication_Frequency = 24;
            Device_2.Reporting_Url = Url;
            Device_2.Write_Frequency = 10;
            Device_2.Write_Time = 20;
            result.Add(Device_2);

            return result;
        }

        public List<Customer> CustomerList()
        {
            var result = new List<Customer>();

            var customer_1 = new Customer();
            customer_1.Id = 1;
            customer_1.Customer_Number = "AA1122";
            customer_1.Password = "password";
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

        public List<CustomerDevice> CustomerDeviceList()
        {
            var result = new List<CustomerDevice>();

            var CustomerDevice_1 = new CustomerDevice();
            CustomerDevice_1.Id = 1;
            CustomerDevice_1.CustomerId = 1;
            CustomerDevice_1.DeviceId = 1;
            result.Add(CustomerDevice_1);

            var CustomerDevice_2 = new CustomerDevice();
            CustomerDevice_2.Id = 2;
            CustomerDevice_2.CustomerId = 1;
            CustomerDevice_2.DeviceId = 2;
            result.Add(CustomerDevice_2);

            return result;
        }
    }
}