using System;

namespace Project_Lab_4_API.Domain.Catalog
{
    public class Rating
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Stars { get; set; } // Example: 1 to 5
        public string ReviewerName { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
