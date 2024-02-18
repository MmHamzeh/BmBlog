namespace BmBlog.Core.DomainModels.Common.Interfaces;

public interface IDbTable
{
    public int Id { get; set; }
    public Guid PublicId { get; set; }
}