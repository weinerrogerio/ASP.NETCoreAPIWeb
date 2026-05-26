using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCoreAPI.Models.Dto
{
    public class UpdatePersonDto
    {
        public long Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; } = string.Empty;

        public string? Address { get; set; }

        public string? Gender { get; set; }
    }
}
