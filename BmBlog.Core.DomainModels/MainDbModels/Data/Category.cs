namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class Category : IDbTable, IAuditable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public string Title { get; set; }
    public string TitleEn { get; set; }
    public string Slug { get; set; }
    public string Icon { get; set; }

    #region Relations
    
    public int? ParentId { get; set; }
    public Category? Parent { get; set; }

    public ICollection<Category> Children { get; set; }
    public ICollection<PostHeader> PostHeaders { get; set; }
    public ICollection<CategoryMetaTag> MataTags { get; set; }

    #endregion

    #region IAuditable

    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }

    #endregion
}
