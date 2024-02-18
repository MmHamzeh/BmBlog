namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostTag : IDbTable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }


}
