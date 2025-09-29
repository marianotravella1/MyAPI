using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserRole Role { get; set; } 
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

    }

    public enum UserRole
    {
        Guest,
        User,
        Admin
    }
}
