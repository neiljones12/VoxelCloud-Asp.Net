using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VoxelCloud.Models.Tables
{
    public class DeviceEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Device")]
        public int DeviceId { get; set; }

        public int? Status_At_Event_Compressor { get; set; }

        public int? Status_At_Event_Fan { get; set; }

        public int? Status_After_Event_Compressor { get; set; }

        public int? Status_After_Event_Fan { get; set; }

        public bool? Restart_Check_Compressor { get; set; }

        public bool? Restart_Check_Fan { get; set; }

        public string Timestamp { get; set; }

        public virtual Device Device { get; set; }
    }
}