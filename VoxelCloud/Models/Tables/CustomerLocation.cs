using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VoxelCloud.Models.Tables
{
    public class CustomerLocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        // Establishing a foreign key relationship
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        // Establishing a foreign key relationship
        [ForeignKey("Location")]
        public int LocationId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Location Location { get; set; }
    }
}