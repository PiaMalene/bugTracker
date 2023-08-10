using System.ComponentModel.DataAnnotations;

namespace bTracker.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string? Category { get; set; }
        public decimal Severity { get; set; }
    }
}

