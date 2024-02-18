namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostSeen : IDbTable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }


}
