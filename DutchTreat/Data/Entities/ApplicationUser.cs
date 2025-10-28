using Microsoft.AspNetCore.Identity;

namespace DutchTreat.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string? JobTitle { get; set; }
    }
}
