namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class Tag : IDbTable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }


}
