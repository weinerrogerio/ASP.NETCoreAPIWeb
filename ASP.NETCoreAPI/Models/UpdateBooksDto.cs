namespace ASP.NETCoreAPI.Models
{
    public class UpdateBooksDto
    {        
        public long Id { get; set; }        
        public string? Title { get; set; }
        public string? Author { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Launch_date { get; set; }

    }
}
