namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class DefaultMetaTag : IDbTable, IAuditable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    //TODO: Properties

    #region Relations

    public ICollection<CategoryMetaTag> CategoryMetaTags { get; set; }
    public ICollection<PostMetaTag> PostMetaTags { get; set; }

    #endregion

    #region IAuditable

    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }

    #endregion
}
