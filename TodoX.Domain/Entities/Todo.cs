using TodoX.Domain.Common;

namespace TodoX.Domain.Entities
{
    public class Todo : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
