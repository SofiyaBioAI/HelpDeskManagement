using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Mvc.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        public string? Priority { get; set; }

        // Status is assigned automatically in the controller
        public string? Status { get; set; }

        [Required(ErrorMessage = "Raised By is required")]
        public string? RaisedBy { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}