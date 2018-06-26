using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VoxelCloud.Models.Tables
{
    public class CustomerDevice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        // Establishing a foreign key relationship
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        // Establishing a foreign key relationship
        [ForeignKey("Device")]
        public int DeviceId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Device Device { get; set; }
    }
}