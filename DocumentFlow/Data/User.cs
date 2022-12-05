using MongoDB.Bson.Serialization.Attributes;

namespace DocumentFlow.Data
{
    [BsonIgnoreExtraElements]
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }

        // Developer
        public string? OGRN { get; set; }
        public string? INN { get; set; }
        public string? KPP { get; set; }
        public string ?Address { get; set; }
        public string ?Director { get; set; }

        // Designer
        public string ?GIP { get; set; }
    }
}
