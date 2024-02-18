namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class Comment : IDbTable, IAuditable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }


    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }
}
