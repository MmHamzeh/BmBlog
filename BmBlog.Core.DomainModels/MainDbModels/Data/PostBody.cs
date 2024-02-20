namespace BmBlog.Core.DomainModels.MainDbModels.Data;

public class PostBody : IDbTable, IAuditable
{
    #region IDbTable

    public int Id { get; set; }
    public Guid PublicId { get; set; }

    #endregion

    public string Body { get; set; }

    #region Relations

    public int PostHeaderId { get; set; }
    public PostHeader PostHeader { get; set; }

    #endregion

    #region IAuditable

    public int CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedTime { get; set; }

    #endregion
}
