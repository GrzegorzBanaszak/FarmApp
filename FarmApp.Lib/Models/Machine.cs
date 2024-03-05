
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmApp.Lib.Models
{
    public class Machine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public required string Mark { get; set; }
        public required string Seria { get; set; }
        public decimal Milage { get; set; }
    }
}
