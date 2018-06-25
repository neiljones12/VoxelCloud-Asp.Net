using System;

namespace VoxelCloud.Models.Tables
{
    public class Device : Base
    {
        public string Name { get; set; }

        public int Compressor_status { get; set; }

        public int Fan_status { get; set; }

        public int Temperature_alert { get; set; }

        public int Temperature { get; set; }

        public string Ip_Address { get; set; }

        public string Serial_Number { get; set; }

        public string Mac_Address { get; set; }

        public int Communication_Frequency { get; set; }

        public string Installation_Date { get; set; }

        public int Write_Frequency { get; set; }

        public int Write_Time { get; set; }

        public string Reporting_Url { get; set; }

        public string Timestamp { get; set; }

    }
}