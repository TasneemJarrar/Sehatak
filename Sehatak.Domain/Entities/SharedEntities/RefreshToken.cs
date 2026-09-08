using Sehatak.Domain.Enums.SharedEnums;
namespace Sehatak.Domain.Entities.SharedEntities
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public string Token { get; set; } = string.Empty;
        public TokenOwnerType OwnerType { get; set; }
        public int UserId { get; set; }

        public int? CenterId { get; set; }

        public DateTime ExpiresAt { get; set; }
        public bool IsRevoked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
