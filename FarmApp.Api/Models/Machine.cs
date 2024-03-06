using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmApp.Api.Models
{
    public class Machine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public required string Mark { get; set; }
        public required string Seria { get; set; }
        [Precision(18, 2)]
        public decimal Milage { get; set; }
    }
}
