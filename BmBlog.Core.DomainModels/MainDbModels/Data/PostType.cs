namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostType : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public string TypeTitle { get; set; }
    public string TypeTitleEn { get; set; }
    public string Slug { get; set; }

    #region Relations

    public ICollection<PostHeader> PostHeaders { get; set; }

    #endregion

}
