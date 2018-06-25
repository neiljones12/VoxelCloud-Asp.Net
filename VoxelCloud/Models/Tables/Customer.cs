namespace VoxelCloud.Models.Tables
{
    public class Customer : Base
    {
        public string Customer_Number { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }
    }
}