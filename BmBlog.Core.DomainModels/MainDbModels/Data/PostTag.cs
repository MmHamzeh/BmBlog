namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostTag : IDbTable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public int Order { get; set; }

    #region Relations

    public int PostHeaderId { get; set; }
    public PostHeader PostHeader { get; set; }

    public int TagId { get; set; }
    public Tag Tag { get; set; }

    #endregion

}
