namespace Domain.Entities
{
    public class BaseClass
    {
        public int Id { get; set; }
        public string CreationUserId { get; set; }
        public DateTime CreactionDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
