namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class Tag : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public string TagTitle { get; set; }
    public string TagTitleEn { get; set; }
    public string Slug { get; set; }

    #region Relations

    public ICollection<PostTag> PostTags { get; set; }

    #endregion

}
