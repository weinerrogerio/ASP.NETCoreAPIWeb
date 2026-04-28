namespace ASP.NETCoreAPI.Models
{
    public class UpdateTodoItemDto
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? IsDone { get; set; }
    }
}
