using System.ComponentModel.DataAnnotations;

namespace Coding_Challenge_Backend.Models
{
    public class Book
    {
        [Key]
        public int BookId {  get; set; }
        public string Title {  get; set; }
        public string Author {  get; set; }
        public string ISBN {  get; set; }
        public string Genre {  get; set; }
        public int Publication_Year {  get; set; }
        public string Publisher {  get; set; }
        public int Total_Copies {  get; set; }
    }
}
