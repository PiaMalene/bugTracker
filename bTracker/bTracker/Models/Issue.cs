using System.ComponentModel.DataAnnotations;


//setup for the database of "issues"
//NB! might want to change to more correct fields later. Make new branch before attempting any changes
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

