using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace JwtAuthDemo.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        [JsonIgnore]
        public virtual IdentityRole Role { get; set; }

    }
}
