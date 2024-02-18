namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostRating : IDbTable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }


}
