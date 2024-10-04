using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace AngularAppAzure.Server.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Publisher { get; set; }
        public bool? BestSellerList { get; set; }

    }
}
