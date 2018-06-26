using System;
using System.Collections.Generic;
using VoxelCloud.Models.Tables;

namespace VoxelCloud.Helpers
{
    public class ListHelper
    {
        // This method is used to populate the tables with values
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
            Device_1.Serial_Number = "1001";
            Device_1.Compressor_status = 1;
            Device_1.Fan_status = 0;
            Device_1.Temperature_alert = 0;
            Device_1.Temperature = 75;
            Device_1.Installation_Date = "2/25/2017 01:02:03";
            Device_1.Timestamp = "2/25/2018 01:02:03";
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
            Device_2.Serial_Number = "1002";
            Device_2.Compressor_status = 1;
            Device_2.Fan_status = 0;
            Device_2.Temperature_alert = 0;
            Device_2.Temperature = 50;
            Device_2.Installation_Date = "6/13/2017 01:02:03";
            Device_2.Timestamp = "6/13/2018 01:02:03";
            Device_2.Communication_Frequency = 24;
            Device_2.Reporting_Url = Url;
            Device_2.Write_Frequency = 10;
            Device_2.Write_Time = 20;
            result.Add(Device_2);

            var Device_3 = new Device();
            Device_3.Id = 3;
            Device_3.Name = "Device 3";
            Device_3.Ip_Address = "10.11.0.1";
            Device_3.Mac_Address = "001122334466";
            Device_3.Serial_Number = "1003";
            Device_3.Compressor_status = 1;
            Device_3.Fan_status = 1;
            Device_3.Temperature_alert = 1;
            Device_3.Temperature = 90;
            Device_3.Installation_Date = "6/25/2017 01:02:03";
            Device_3.Timestamp = "6/25/2018 01:02:03";
            Device_3.Communication_Frequency = 48;
            Device_3.Reporting_Url = Url;
            Device_3.Write_Frequency = 10;
            Device_3.Write_Time = 20;
            result.Add(Device_3);

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

            var customer_2 = new Customer();
            customer_2.Id = 2;
            customer_2.Customer_Number = "ABCD12";
            customer_2.Password = "password";
            customer_2.Active = true;
            result.Add(customer_2);

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

            var CustomerLocation_2 = new CustomerLocation();
            CustomerLocation_2.Id = 2;
            CustomerLocation_2.CustomerId = 2;
            CustomerLocation_2.LocationId = 2;
            result.Add(CustomerLocation_2);

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

            var CustomerDevice_3 = new CustomerDevice();
            CustomerDevice_3.Id = 3;
            CustomerDevice_3.CustomerId = 2;
            CustomerDevice_3.DeviceId = 3;
            result.Add(CustomerDevice_3);

            return result;
        }

        public List<DeviceEvent> DeviceEventList()
        {
            var result = new List<DeviceEvent>();

            var log_1 = new DeviceEvent();
            log_1.Id = 1;
            log_1.DeviceId = 1;
            log_1.Status_At_Event_Compressor = 0;
            log_1.Status_At_Event_Compressor = 1;
            log_1.Status_At_Event_Fan = 0;
            log_1.Status_After_Event_Fan = 1;
            log_1.Restart_Check_Compressor = 0;
            log_1.Restart_Check_Fan = 0;
            log_1.Timestamp = "2/25/2017 01:02:03";
            log_1.Temperature = 75;
            result.Add(log_1);

            var log_2 = new DeviceEvent();
            log_2.Id = 2;
            log_2.DeviceId = 1;
            log_2.Status_At_Event_Compressor = 1;
            log_2.Status_At_Event_Compressor = 0;
            log_2.Status_At_Event_Fan = 1;
            log_2.Status_After_Event_Fan = 0;
            log_2.Restart_Check_Compressor = 0;
            log_2.Restart_Check_Fan = 0;
            log_2.Timestamp = "2/27/2017 11:02:03";
            log_2.Temperature = 80;
            result.Add(log_2);

            var log_3 = new DeviceEvent();
            log_3.Id = 3;
            log_3.DeviceId = 1;
            log_3.Status_At_Event_Compressor = 0;
            log_3.Status_At_Event_Compressor = 1;
            log_3.Status_At_Event_Fan = 0;
            log_3.Status_After_Event_Fan = 1;
            log_3.Restart_Check_Compressor = 1;
            log_3.Restart_Check_Fan = 0;
            log_3.Timestamp = "3/2/2017 10:22:03";
            log_3.Temperature = 50;
            result.Add(log_3);

            var log_4 = new DeviceEvent();
            log_4.Id = 4;
            log_4.DeviceId = 1;
            log_4.Status_At_Event_Compressor = 1;
            log_4.Status_At_Event_Compressor = 0;
            log_4.Status_At_Event_Fan = 0;
            log_4.Status_After_Event_Fan = 1;
            log_4.Restart_Check_Compressor = 0;
            log_4.Restart_Check_Fan = 0;
            log_4.Timestamp = "10/5/2017 10:22:03";
            log_4.Temperature = 60;
            result.Add(log_4);

            var log_5 = new DeviceEvent();
            log_5.Id = 5;
            log_5.DeviceId = 1;
            log_5.Status_At_Event_Compressor = 0;
            log_5.Status_At_Event_Compressor = 1;
            log_5.Status_At_Event_Fan = 1;
            log_5.Status_After_Event_Fan = 0;
            log_5.Restart_Check_Compressor = 0;
            log_5.Restart_Check_Fan = 0;
            log_5.Timestamp = "12/10/2017 12:22:03";
            log_5.Temperature = 90;
            result.Add(log_5);

            var log_6 = new DeviceEvent();
            log_6.Id = 6;
            log_6.DeviceId = 1;
            log_6.Status_At_Event_Compressor = 1;
            log_6.Status_At_Event_Compressor = 0;
            log_6.Status_At_Event_Fan = 0;
            log_6.Status_After_Event_Fan = 1;
            log_6.Restart_Check_Compressor = 0;
            log_6.Restart_Check_Fan = 0;
            log_6.Timestamp = "1/16/2018 01:22:03";
            log_6.Temperature = 80;
            result.Add(log_6);

            var log_7 = new DeviceEvent();
            log_7.Id = 7;
            log_7.DeviceId = 1;
            log_7.Status_At_Event_Compressor = 0;
            log_7.Status_At_Event_Compressor = 1;
            log_7.Status_At_Event_Fan = 1;
            log_7.Status_After_Event_Fan = 0;
            log_7.Restart_Check_Compressor = 0;
            log_7.Restart_Check_Fan = 1;
            log_7.Timestamp = "3/26/2018 21:22:03";
            log_7.Temperature = 90;
            result.Add(log_7);

            var log_8 = new DeviceEvent();
            log_8.Id = 8;
            log_8.DeviceId = 1;
            log_8.Status_At_Event_Compressor = 1;
            log_8.Status_At_Event_Compressor = 0;
            log_8.Status_At_Event_Fan = 0;
            log_8.Status_After_Event_Fan = 1;
            log_8.Restart_Check_Compressor = 1;
            log_8.Restart_Check_Fan = 1;
            log_8.Timestamp = "5/15/2018 11:22:03";
            log_8.Temperature = 80;
            result.Add(log_8);

            var log_9 = new DeviceEvent();
            log_9.Id = 9;
            log_9.DeviceId = 1;
            log_9.Status_At_Event_Compressor = 0;
            log_9.Status_At_Event_Compressor = 1;
            log_9.Status_At_Event_Fan = 1;
            log_9.Status_After_Event_Fan = 0;
            log_9.Restart_Check_Compressor = 0;
            log_9.Restart_Check_Fan = 0;
            log_9.Timestamp = "6/11/2018 01:22:03";
            log_9.Temperature = 60;
            result.Add(log_9);

            var log_10 = new DeviceEvent();
            log_10.Id = 10;
            log_10.DeviceId = 1;
            log_10.Status_At_Event_Compressor = 1;
            log_10.Status_At_Event_Compressor = 0;
            log_10.Status_At_Event_Fan = 0;
            log_10.Status_After_Event_Fan = 1;
            log_10.Restart_Check_Compressor = 0;
            log_10.Restart_Check_Fan = 0;
            log_10.Timestamp = "6/25/2018 01:22:03";
            log_10.Temperature = 60;
            result.Add(log_10);


            var log_11 = new DeviceEvent();
            log_11.Id = 11;
            log_11.DeviceId = 2;
            log_11.Status_At_Event_Compressor = 0;
            log_11.Status_At_Event_Compressor = 1;
            log_11.Status_At_Event_Fan = 0;
            log_11.Status_After_Event_Fan = 1;
            log_11.Restart_Check_Compressor = 0;
            log_11.Restart_Check_Fan = 0;
            log_11.Timestamp = "2/25/2018 01:02:03";
            log_11.Temperature = 75;
            result.Add(log_11);

            var log_12 = new DeviceEvent();
            log_12.Id = 12;
            log_12.DeviceId = 2;
            log_12.Status_At_Event_Compressor = 1;
            log_12.Status_At_Event_Compressor = 0;
            log_12.Status_At_Event_Fan = 1;
            log_12.Status_After_Event_Fan = 0;
            log_12.Restart_Check_Compressor = 0;
            log_12.Restart_Check_Fan = 0;
            log_12.Timestamp = "3/27/2018 11:02:03";
            log_12.Temperature = 80;
            result.Add(log_12);

            var log_13 = new DeviceEvent();
            log_13.Id = 13;
            log_13.DeviceId = 2;
            log_13.Status_At_Event_Compressor = 0;
            log_13.Status_At_Event_Compressor = 1;
            log_13.Status_At_Event_Fan = 0;
            log_13.Status_After_Event_Fan = 1;
            log_13.Restart_Check_Compressor = 1;
            log_13.Restart_Check_Fan = 0;
            log_13.Timestamp = "4/2/2018 10:22:03";
            log_13.Temperature = 50;
            result.Add(log_13);

            var log_14 = new DeviceEvent();
            log_14.Id = 14;
            log_14.DeviceId = 2;
            log_14.Status_At_Event_Compressor = 1;
            log_14.Status_At_Event_Compressor = 0;
            log_14.Status_At_Event_Fan = 0;
            log_14.Status_After_Event_Fan = 1;
            log_14.Restart_Check_Compressor = 0;
            log_14.Restart_Check_Fan = 0;
            log_14.Timestamp = "5/5/2018 10:22:03";
            log_14.Temperature = 60;
            result.Add(log_14);

            var log_15 = new DeviceEvent();
            log_15.Id = 15;
            log_15.DeviceId = 2;
            log_15.Status_At_Event_Compressor = 0;
            log_15.Status_At_Event_Compressor = 1;
            log_15.Status_At_Event_Fan = 1;
            log_15.Status_After_Event_Fan = 0;
            log_15.Restart_Check_Compressor = 0;
            log_15.Restart_Check_Fan = 0;
            log_15.Timestamp = "6/13/2018 12:22:03";
            log_15.Temperature = 90;
            result.Add(log_15);

            var log_16 = new DeviceEvent();
            log_16.Id = 16;
            log_16.DeviceId = 3;
            log_16.Status_At_Event_Compressor = 1;
            log_16.Status_At_Event_Compressor = 0;
            log_16.Status_At_Event_Fan = 0;
            log_16.Status_After_Event_Fan = 1;
            log_16.Restart_Check_Compressor = 0;
            log_16.Restart_Check_Fan = 0;
            log_16.Timestamp = "12/16/2017 01:22:03";
            log_16.Temperature = 80;
            result.Add(log_16);

            var log_17 = new DeviceEvent();
            log_17.Id = 17;
            log_17.DeviceId = 3;
            log_17.Status_At_Event_Compressor = 0;
            log_17.Status_At_Event_Compressor = 1;
            log_17.Status_At_Event_Fan = 1;
            log_17.Status_After_Event_Fan = 0;
            log_17.Restart_Check_Compressor = 0;
            log_17.Restart_Check_Fan = 1;
            log_17.Timestamp = "2/20/2018 21:22:03";
            log_17.Temperature = 90;
            result.Add(log_17);

            var log_18 = new DeviceEvent();
            log_18.Id = 18;
            log_18.DeviceId = 3;
            log_18.Status_At_Event_Compressor = 1;
            log_18.Status_At_Event_Compressor = 0;
            log_18.Status_At_Event_Fan = 0;
            log_18.Status_After_Event_Fan = 1;
            log_18.Restart_Check_Compressor = 1;
            log_18.Restart_Check_Fan = 1;
            log_18.Timestamp = "3/15/2018 11:22:03";
            log_18.Temperature = 80;
            result.Add(log_18);

            var log_19 = new DeviceEvent();
            log_19.Id = 19;
            log_19.DeviceId = 3;
            log_19.Status_At_Event_Compressor = 0;
            log_19.Status_At_Event_Compressor = 1;
            log_19.Status_At_Event_Fan = 1;
            log_19.Status_After_Event_Fan = 0;
            log_19.Restart_Check_Compressor = 0;
            log_19.Restart_Check_Fan = 0;
            log_19.Timestamp = "6/21/2018 01:22:03";
            log_19.Temperature = 60;
            result.Add(log_19);

            var log_20 = new DeviceEvent();
            log_20.Id = 20;
            log_20.DeviceId = 3;
            log_20.Status_At_Event_Compressor = 1;
            log_20.Status_At_Event_Compressor = 0;
            log_20.Status_At_Event_Fan = 0;
            log_20.Status_After_Event_Fan = 1;
            log_20.Restart_Check_Compressor = 0;
            log_20.Restart_Check_Fan = 0;
            log_20.Timestamp = "6/25/2018 01:22:03";
            log_20.Temperature = 60;
            result.Add(log_20);

            return result;
        }
    }
}