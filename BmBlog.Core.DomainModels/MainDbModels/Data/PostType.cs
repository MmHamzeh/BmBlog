namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostType : IDbTable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }


}
